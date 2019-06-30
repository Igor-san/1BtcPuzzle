using Kaos.Combinatorics;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneBTCPuzzle
{
    public partial class FormMain : Form
    {

        private bool BatchWork = false; //выполнение долгой операции
        private string BatchWorkTip = ""; //описание текущей долгой операции

        Control DisabledControl;
        DataGridView DisabledGrid;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ErrorMessage(string p)
        {
            try
            {
              if (textBoxLog!=null)  textBoxLog.AppendText("Error: " + p + Environment.NewLine);
            }
            catch { }
        }

        private void StatusMessage(string p)
        {
            try
            {
            if (textBoxLog != null) textBoxLog.AppendText("Info: " + p + Environment.NewLine);
                        }
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="control"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        private bool StartQuery(out DateTime startTime, string workTip = "", Control control = null, DataGridView grid = null)
        {
            startTime = DateTime.Now;

            string msg = "";
            if (BatchWorkTip != "") msg = " (" + BatchWorkTip + ")";

            if (BatchWork)
            {
                ErrorMessage("Выполняется другое длительное задание:" + msg);
                return false;
            }

            BatchWorkTip = workTip;
            BatchWork = true;

            DisabledControl = control;
            DisabledGrid = grid;

            if (DisabledControl != null)
                DisabledControl.Enabled = false;
            if (DisabledGrid != null)
                DisabledGrid.SuspendLayout();

            buttonStop.Focus();
            buttonStop.Select();
           
            return true;
        }

        /// <summary>
        /// Окончание и запроса и работы, разблокировка контролов
        /// </summary>
        /// <param name="dtStart"></param>
        private void FinallyQueryWork(DateTime dtStart)
        {

            BatchWork = false;
            BatchWorkTip = "";

            if (DisabledControl != null)
                DisabledControl.Enabled = true;
            if (DisabledGrid != null)
                DisabledGrid.ResumeLayout();

            DateTime dtEnd = DateTime.Now;

            StatusMessage(String.Format("Затрачено {0} sec", (dtEnd - dtStart).TotalMilliseconds / 1000));
        }

        private void EnableControls(bool enable)
        {
            buttonGetPermutation.Enabled = enable;

            buttonStop.Enabled = !enable;
        }

        #region ProgressBar

        bool StopProcess = false;

        private void buttonStop_Click(object sender, EventArgs e)
        {

                StopProcess = true;

        }

        private void PerformStep()
        {
            progressBarUpdateBase.PerformStep();
        }

        private void StartProcess(bool start, int maximum, int step = 1, string tooltip = "Background process in progress")
        {

            if (start)
            {
                StopProcess = false;

                buttonStop.Enabled = true;
                progressBarUpdateBase.Style = ProgressBarStyle.Continuous;
                progressBarUpdateBase.Value = 0;
                progressBarUpdateBase.Step = step;
                progressBarUpdateBase.Maximum = maximum;
                BatchWorkTip = tooltip;

            }
            else
            {
                buttonStop.Enabled = false;
                progressBarUpdateBase.Value = 0;
                StopProcess = true;
                BatchWorkTip = "";
            }
        }

        /// <summary>
        /// просто цикл по таймеру показывающий что идет процессобновления базы без кнопок остановит
        /// </summary>
        /// <param name="p"></param>
        /// <param name="max"></param>
        private void StartLoopProcess(bool start, string tooltip = "Background process in progress")
        {

            if (start)
            {
                StopProcess = false;
                buttonStop.Enabled = true;
                buttonStop.Select();
                buttonStop.Focus();
                Application.DoEvents();

                progressBarUpdateBase.Style = ProgressBarStyle.Marquee;
                progressBarUpdateBase.MarqueeAnimationSpeed = 30;
                BatchWorkTip = tooltip;
            }
            else
            {
                StopProcess = true;
                buttonStop.Enabled = false;

                progressBarUpdateBase.Value = 0;
                progressBarUpdateBase.Style = ProgressBarStyle.Continuous;
                progressBarUpdateBase.MarqueeAnimationSpeed = 0;
                BatchWorkTip = "";
            }
        }

        #endregion ProgressBar

        #region ProgressBar Timer
        int ProgressBarCounter = 0;

        private void timerThread_Tick(object sender, EventArgs e)
        {
            try
            {
                labelCount.Text = ProgressBarCounter.ToString();
            }
            catch (Exception ex)
            {
                timerThread.Stop();
                labelCount.Text = "";
                ErrorMessage("Error in timerThread_Tick: " + ex.Message);
            }
        }
        #endregion ProgressBar Timer

        CancellationTokenSource cts;

        void CancelAllThreads()
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BatchWork)
            {
                DialogResult res = MessageBox.Show("Некоторые процессы еще выполняются. Вы действительно хотите выйти из программы, не ожидая их нормальног прекращения?", "Есть запущенные процессы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.No)
                {
                    e.Cancel = true; 
                }

            }
            if (!e.Cancel)
            {
                CancelAllThreads(); 
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            #region Set Save Dialog Properties

            dlg.AddExtension = true;
            dlg.Title = "Сохранить пакет как...";
            dlg.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            dlg.OverwritePrompt = true;
            #endregion

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBoxText.Text);
            }
        }
        public string PrintByteArray(byte[] bytes)
        {

            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                sb.AppendFormat("{0:x2}", b);
            }

            return sb.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxAddressC.Text = "";
                labelKeyLength.Text = "";
                string dataS = textBoxByteData.Text.Trim();
                dataS=dataS.Replace(" ", "");
                labelKeyLength.Text = dataS.Length.ToString();
                byte[] data = Encoding.ASCII.GetBytes(dataS); 
               
                textBoxHex.Text=PrintByteArray(data);

                var privateKeyUC = new Key(data, fCompressedIn: false);

                var bitcoinPrivateKeyUC = privateKeyUC.GetWif(Network.Main);

                textBoxAddressUC.Text = bitcoinPrivateKeyUC.GetAddress().ToString();

                var privateKeyC = new Key(data,fCompressedIn: true);

                var bitcoinPrivateKeyC = privateKeyC.GetWif(Network.Main);

                textBoxAddressC.Text = bitcoinPrivateKeyC.GetAddress().ToString();


            }
            catch(Exception ex)
            {
                textBoxAddressC.Text = ex.ToString();
            }
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private (string,string) GetAddressUC(string dataS)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(dataS);

                var privateKey = new Key(data,fCompressedIn:false);
                var bitcoinPrivateKey = privateKey.GetWif(Network.Main);

                string uncompressed = bitcoinPrivateKey.GetAddress().ToString();

                privateKey = new Key(data, fCompressedIn: true);
                bitcoinPrivateKey = privateKey.GetWif(Network.Main);
                string compressed = bitcoinPrivateKey.GetAddress().ToString();

                return (uncompressed,compressed);
            }
            catch (Exception ex)
            {
                return ("error","error");
            }
        }

        private void buttonFromTextBox_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string searchFor = textBoxFindAddress.Text.Trim();

            foreach (var item in textBoxText.Lines)
            {
                if (String.IsNullOrEmpty(item.Trim()))
                {
                    sb.AppendLine("");
                    continue;
                }

                var addr = GetAddressUC(item.Trim());
                if (addr.Item1== searchFor || addr.Item2 == searchFor)
                {
                    MessageBox.Show("Found " + addr + " from " + item);
                }

                sb.AppendLine(item + " : " + addr);
            }

            textBoxText.Text = sb.ToString();
        }

        private void buttonGetPermutation_Click(object sender, EventArgs e)
        {
            DateTime dtStart;
            if (!StartQuery(out dtStart)) return;
            bool userBreak = false;
            long count = 0;
            int step = 1000;
            try
            {
                int pick = (int) numericUpDownPick.Value;

                string searchFor = textBoxFindAddress.Text.Trim();
                //Получить пермутации
                List<string> things = new List<string>();

                foreach (var item in textBoxInputWords.Lines)
                {
                    if (String.IsNullOrEmpty(item.Trim()))
                    {
                        continue;
                    }
                    things.Add(item.Trim());
                }

                string temp;
                // Use permutations to get rearrangements of other objects:
                var perm = new Permutation(things.Count, pick);
                long max = perm.RowCount;
                StatusMessage("Total permutations: " + max);

                StartProcess(true, (int)max, step);

                foreach (var row in perm.GetRows())
                {
                    count++;
                    temp = String.Join("", Permutation.Permute(row, things));
                    if (temp.Length == 32)
                    {
                        var addr = GetAddressUC(temp);
                        if (addr.Item1 == searchFor || addr.Item2 == searchFor)
                        {
                            string found= "Found " + addr + " from " + temp;
                            textBoxText.Text = found;
                            MessageBox.Show(found);
                            break;
                        }
                    }

                    if (count % step == 0)
                    {
                        labelCount.Text = count.ToString();
                        PerformStep();
                        Application.DoEvents();
                        if (StopProcess)
                        {
                            userBreak = true;
                            return;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorMessage("buttonGetPermutation_Click" + ex.Message);
            }
            finally
            {
                StartProcess(false, 0);
                if (userBreak)
                {
                    StatusMessage("Interrupted by user on step " + count);
                }
                FinallyQueryWork(dtStart);

            }

        }
     }
}
