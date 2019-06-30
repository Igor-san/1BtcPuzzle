namespace OneBTCPuzzle
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.progressBarUpdateBase = new System.Windows.Forms.ProgressBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerThread = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelKeyLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFindAddress = new System.Windows.Forms.TextBox();
            this.textBoxAddressUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxAddressC = new System.Windows.Forms.TextBox();
            this.textBoxByteData = new System.Windows.Forms.TextBox();
            this.buttonKeyToAddress = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGetPermutation = new System.Windows.Forms.Button();
            this.textBoxInputWords = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.numericUpDownPick = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPick)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLog.Location = new System.Drawing.Point(0, 434);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(1185, 94);
            this.textBoxLog.TabIndex = 4;
            this.textBoxLog.WordWrap = false;
            // 
            // progressBarUpdateBase
            // 
            this.progressBarUpdateBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarUpdateBase.Location = new System.Drawing.Point(0, 0);
            this.progressBarUpdateBase.Name = "progressBarUpdateBase";
            this.progressBarUpdateBase.Size = new System.Drawing.Size(1104, 33);
            this.progressBarUpdateBase.TabIndex = 25;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(9, 6);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 27;
            this.labelCount.Text = "_";
            this.toolTip1.SetToolTip(this.labelCount, "счетчик");
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.Location = new System.Drawing.Point(1104, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 33);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerThread
            // 
            this.timerThread.Tick += new System.EventHandler(this.timerThread_Tick);
            // 
            // labelKeyLength
            // 
            this.labelKeyLength.AutoSize = true;
            this.labelKeyLength.Location = new System.Drawing.Point(526, 14);
            this.labelKeyLength.Name = "labelKeyLength";
            this.labelKeyLength.Size = new System.Drawing.Size(25, 13);
            this.labelKeyLength.TabIndex = 41;
            this.labelKeyLength.Text = "Len";
            this.toolTip1.SetToolTip(this.labelKeyLength, "Длина HEX представления в байтах");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Address C:";
            this.toolTip1.SetToolTip(this.label2, "compressed");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Address UC:";
            this.toolTip1.SetToolTip(this.label4, "uncompressed");
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 431);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1185, 3);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 431);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarUpdateBase);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 24);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxFindAddress);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxAddressUC);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxHex);
            this.panel3.Controls.Add(this.labelKeyLength);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxAddressC);
            this.panel3.Controls.Add(this.textBoxByteData);
            this.panel3.Controls.Add(this.buttonKeyToAddress);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 84);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Search for:";
            // 
            // textBoxFindAddress
            // 
            this.textBoxFindAddress.Location = new System.Drawing.Point(106, 45);
            this.textBoxFindAddress.Name = "textBoxFindAddress";
            this.textBoxFindAddress.Size = new System.Drawing.Size(405, 20);
            this.textBoxFindAddress.TabIndex = 47;
            this.textBoxFindAddress.Text = "179sxfh6rw6bHSo5wVUhLP96k46QaEzVP";
            // 
            // textBoxAddressUC
            // 
            this.textBoxAddressUC.Location = new System.Drawing.Point(765, 55);
            this.textBoxAddressUC.Name = "textBoxAddressUC";
            this.textBoxAddressUC.Size = new System.Drawing.Size(405, 20);
            this.textBoxAddressUC.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Hex:";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(765, 5);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(405, 20);
            this.textBoxHex.TabIndex = 43;
            // 
            // textBoxAddressC
            // 
            this.textBoxAddressC.Location = new System.Drawing.Point(765, 29);
            this.textBoxAddressC.Name = "textBoxAddressC";
            this.textBoxAddressC.Size = new System.Drawing.Size(405, 20);
            this.textBoxAddressC.TabIndex = 39;
            // 
            // textBoxByteData
            // 
            this.textBoxByteData.Location = new System.Drawing.Point(106, 11);
            this.textBoxByteData.Name = "textBoxByteData";
            this.textBoxByteData.Size = new System.Drawing.Size(405, 20);
            this.textBoxByteData.TabIndex = 38;
            this.textBoxByteData.Text = "InsertPlainTextPhraseHere32Chara";
            // 
            // buttonKeyToAddress
            // 
            this.buttonKeyToAddress.Location = new System.Drawing.Point(9, 9);
            this.buttonKeyToAddress.Name = "buttonKeyToAddress";
            this.buttonKeyToAddress.Size = new System.Drawing.Size(91, 23);
            this.buttonKeyToAddress.TabIndex = 37;
            this.buttonKeyToAddress.Text = "KeyToAddress";
            this.buttonKeyToAddress.UseVisualStyleBackColor = true;
            this.buttonKeyToAddress.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numericUpDownPick);
            this.panel4.Controls.Add(this.buttonGetPermutation);
            this.panel4.Controls.Add(this.textBoxInputWords);
            this.panel4.Controls.Add(this.textBoxText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 266);
            this.panel4.TabIndex = 7;
            // 
            // buttonGetPermutation
            // 
            this.buttonGetPermutation.Location = new System.Drawing.Point(527, 17);
            this.buttonGetPermutation.Name = "buttonGetPermutation";
            this.buttonGetPermutation.Size = new System.Drawing.Size(75, 108);
            this.buttonGetPermutation.TabIndex = 2;
            this.buttonGetPermutation.Text = "<-search ";
            this.buttonGetPermutation.UseVisualStyleBackColor = true;
            this.buttonGetPermutation.Click += new System.EventHandler(this.buttonGetPermutation_Click);
            // 
            // textBoxInputWords
            // 
            this.textBoxInputWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputWords.Location = new System.Drawing.Point(610, 3);
            this.textBoxInputWords.Multiline = true;
            this.textBoxInputWords.Name = "textBoxInputWords";
            this.textBoxInputWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInputWords.Size = new System.Drawing.Size(560, 260);
            this.textBoxInputWords.TabIndex = 1;
            this.textBoxInputWords.Text = "Why\r\nThe\r\nComb\r\nOf\r\nNatasha\r\nOtomoski\r\nHas\r\nTwenty\r\nOne\r\nTeeth\r\nQuestion\r\nMark\r\nD" +
    "ot\r\nPlain\r\nText";
            this.textBoxInputWords.WordWrap = false;
            // 
            // textBoxText
            // 
            this.textBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxText.Location = new System.Drawing.Point(6, 3);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxText.Size = new System.Drawing.Size(515, 260);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.WordWrap = false;
            // 
            // numericUpDownPick
            // 
            this.numericUpDownPick.Location = new System.Drawing.Point(543, 156);
            this.numericUpDownPick.Name = "numericUpDownPick";
            this.numericUpDownPick.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownPick.TabIndex = 3;
            this.numericUpDownPick.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "words";
            this.toolTip1.SetToolTip(this.label1, "by so words");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxLog);
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "1 BTC Puzzle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ProgressBar progressBarUpdateBase;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerThread;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonKeyToAddress;
        private System.Windows.Forms.TextBox textBoxByteData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddressC;
        private System.Windows.Forms.Label labelKeyLength;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGetPermutation;
        private System.Windows.Forms.TextBox textBoxInputWords;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddressUC;
        private System.Windows.Forms.TextBox textBoxFindAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPick;
    }
}

