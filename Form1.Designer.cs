namespace simp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bmclabel = new Label();
            ToggleButton = new Button();
            PortSel = new ComboBox();
            COMLabel = new Label();
            bmcBox = new TextBox();
            Recbtn = new Button();
            sndBtn = new Button();
            devIdSendBtn = new Button();
            devIdRecBtn = new Button();
            devBox = new TextBox();
            devIdLabel = new Label();
            quanSendBtn = new Button();
            qaunRecBtn = new Button();
            quanBox = new TextBox();
            quanId = new Label();
            partSendBtn = new Button();
            partRecBtn = new Button();
            partQtyBox = new TextBox();
            partQtyId = new Label();
            dampSendBtn = new Button();
            dampRecBtn = new Button();
            dampBox = new TextBox();
            dampLbl = new Label();
            graviySendBtn = new Button();
            gravityRcvBtn = new Button();
            spcBox = new TextBox();
            spcgra = new Label();
            numbPartsSendBtn = new Button();
            numbPartsRcvBtn = new Button();
            numPartstxtBox = new TextBox();
            label3 = new Label();
            RcdTmSendBtn = new Button();
            RcdTmRcvBtn = new Button();
            label4 = new Label();
            TIME = new GroupBox();
            label1 = new Label();
            yrSendBtn = new Button();
            yrRcvBtn = new Button();
            monSendBtn = new Button();
            monRcvBtn = new Button();
            dtSendBtn = new Button();
            dtRcvBtn = new Button();
            hrSendBtn = new Button();
            hrRcvBtn = new Button();
            dttxt = new TextBox();
            montxt = new TextBox();
            yrtxt = new TextBox();
            hrtxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            minSendBtn = new Button();
            mintxt = new TextBox();
            minRcvBtn = new Button();
            label2 = new Label();
            RcdTmtxt = new ComboBox();
            RTDSeltxt = new ComboBox();
            rtdSelSendbtn = new Button();
            rtdRcvBtn = new Button();
            label8 = new Label();
            sensortxt = new ComboBox();
            sensorSendBtn = new Button();
            sensorrcvBtn = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            rtc2txt = new ComboBox();
            rtc2SendBtn = new Button();
            RTC1txt = new ComboBox();
            rtc2RcvBtn = new Button();
            rtc1SendBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            rtc1RcvBtn = new Button();
            groupBox2 = new GroupBox();
            s2maxvalSend = new Button();
            s2maxvalTXT = new TextBox();
            s2maxvalRcv = new Button();
            label19 = new Label();
            s1maxvalSend = new Button();
            s1maxvalTXT = new TextBox();
            s1maxvalRcv = new Button();
            label18 = new Label();
            s2minvalSend = new Button();
            s2minvalTXT = new TextBox();
            s2minvalRcv = new Button();
            label17 = new Label();
            s1minvalSend = new Button();
            s1minvalTXT = new TextBox();
            s1minvalRcv = new Button();
            label16 = new Label();
            s2maxvoltSend = new Button();
            s2maxvoltTXT = new TextBox();
            s2maxvoltRcv = new Button();
            label15 = new Label();
            s1maxvoltSend = new Button();
            s1maxvoltTXT = new TextBox();
            s1maxvoltRcv = new Button();
            label14 = new Label();
            s2minvoltSend = new Button();
            s2minvoltTXT = new TextBox();
            s2minvoltRcv = new Button();
            label13 = new Label();
            s1minvoltSend = new Button();
            s1minvoltTXT = new TextBox();
            s1minvoltRcv = new Button();
            label12 = new Label();
            dataGridView = new DataGridView();
            val1 = new DataGridViewTextBoxColumn();
            val2 = new DataGridViewTextBoxColumn();
            val3 = new DataGridViewTextBoxColumn();
            val4 = new DataGridViewTextBoxColumn();
            val5 = new DataGridViewTextBoxColumn();
            val6 = new DataGridViewTextBoxColumn();
            val7 = new DataGridViewTextBoxColumn();
            val8 = new DataGridViewTextBoxColumn();
            val9 = new DataGridViewTextBoxColumn();
            val10 = new DataGridViewTextBoxColumn();
            tblRecBtn = new Button();
            tblSendBtn = new Button();
            import = new Button();
            filepathText = new TextBox();
            receiveTable = new GroupBox();
            exportBtn = new Button();
            label20 = new Label();
            pictureBox = new PictureBox();
            TIME.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            receiveTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // bmclabel
            // 
            bmclabel.AutoSize = true;
            bmclabel.Location = new Point(20, 187);
            bmclabel.Name = "bmclabel";
            bmclabel.Size = new Size(91, 21);
            bmclabel.TabIndex = 16;
            bmclabel.Text = "BMC CODE:";
            // 
            // ToggleButton
            // 
            ToggleButton.Location = new Point(361, 134);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(106, 30);
            ToggleButton.TabIndex = 15;
            ToggleButton.Text = "Open Port";
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.Click += ToggleButton_Click;
            // 
            // PortSel
            // 
            PortSel.FormattingEnabled = true;
            PortSel.Location = new Point(179, 135);
            PortSel.Name = "PortSel";
            PortSel.Size = new Size(169, 29);
            PortSel.TabIndex = 14;
            // 
            // COMLabel
            // 
            COMLabel.AutoSize = true;
            COMLabel.Location = new Point(20, 139);
            COMLabel.Name = "COMLabel";
            COMLabel.Size = new Size(91, 21);
            COMLabel.TabIndex = 13;
            COMLabel.Text = "COM PORT:";
            // 
            // bmcBox
            // 
            bmcBox.Location = new Point(179, 181);
            bmcBox.Name = "bmcBox";
            bmcBox.Size = new Size(169, 29);
            bmcBox.TabIndex = 17;
            // 
            // Recbtn
            // 
            Recbtn.Location = new Point(361, 184);
            Recbtn.Name = "Recbtn";
            Recbtn.Size = new Size(106, 30);
            Recbtn.TabIndex = 18;
            Recbtn.Text = "Receive";
            Recbtn.UseVisualStyleBackColor = true;
            Recbtn.Click += Recbtn_Click;
            // 
            // sndBtn
            // 
            sndBtn.Location = new Point(485, 184);
            sndBtn.Name = "sndBtn";
            sndBtn.Size = new Size(106, 30);
            sndBtn.TabIndex = 19;
            sndBtn.Text = "Send";
            sndBtn.UseVisualStyleBackColor = true;
            sndBtn.Click += sndBtn_Click;
            // 
            // devIdSendBtn
            // 
            devIdSendBtn.Location = new Point(485, 229);
            devIdSendBtn.Name = "devIdSendBtn";
            devIdSendBtn.Size = new Size(106, 30);
            devIdSendBtn.TabIndex = 23;
            devIdSendBtn.Text = "Send";
            devIdSendBtn.UseVisualStyleBackColor = true;
            devIdSendBtn.Click += devIdSendBtn_Click;
            // 
            // devIdRecBtn
            // 
            devIdRecBtn.Location = new Point(361, 229);
            devIdRecBtn.Name = "devIdRecBtn";
            devIdRecBtn.Size = new Size(106, 30);
            devIdRecBtn.TabIndex = 22;
            devIdRecBtn.Text = "Receive";
            devIdRecBtn.UseVisualStyleBackColor = true;
            devIdRecBtn.Click += devIdRecBtn_Click;
            // 
            // devBox
            // 
            devBox.Location = new Point(179, 226);
            devBox.Name = "devBox";
            devBox.Size = new Size(169, 29);
            devBox.TabIndex = 21;
            // 
            // devIdLabel
            // 
            devIdLabel.AutoSize = true;
            devIdLabel.Location = new Point(20, 230);
            devIdLabel.Name = "devIdLabel";
            devIdLabel.Size = new Size(83, 21);
            devIdLabel.TabIndex = 20;
            devIdLabel.Text = "DEVICE ID:";
            // 
            // quanSendBtn
            // 
            quanSendBtn.Location = new Point(485, 276);
            quanSendBtn.Name = "quanSendBtn";
            quanSendBtn.Size = new Size(106, 30);
            quanSendBtn.TabIndex = 27;
            quanSendBtn.Text = "Send";
            quanSendBtn.UseVisualStyleBackColor = true;
            quanSendBtn.Click += quanSendBtn_Click;
            // 
            // qaunRecBtn
            // 
            qaunRecBtn.Location = new Point(361, 276);
            qaunRecBtn.Name = "qaunRecBtn";
            qaunRecBtn.Size = new Size(106, 30);
            qaunRecBtn.TabIndex = 26;
            qaunRecBtn.Text = "Receive";
            qaunRecBtn.UseVisualStyleBackColor = true;
            qaunRecBtn.Click += qaunRecBtn_Click;
            // 
            // quanBox
            // 
            quanBox.Location = new Point(179, 273);
            quanBox.Name = "quanBox";
            quanBox.Size = new Size(169, 29);
            quanBox.TabIndex = 25;
            // 
            // quanId
            // 
            quanId.AutoSize = true;
            quanId.Location = new Point(20, 278);
            quanId.Name = "quanId";
            quanId.Size = new Size(87, 21);
            quanId.TabIndex = 24;
            quanId.Text = "QUANTITY:";
            // 
            // partSendBtn
            // 
            partSendBtn.Location = new Point(485, 327);
            partSendBtn.Name = "partSendBtn";
            partSendBtn.Size = new Size(106, 30);
            partSendBtn.TabIndex = 31;
            partSendBtn.Text = "Send";
            partSendBtn.UseVisualStyleBackColor = true;
            partSendBtn.Click += partSendBtn_Click;
            // 
            // partRecBtn
            // 
            partRecBtn.Location = new Point(361, 327);
            partRecBtn.Name = "partRecBtn";
            partRecBtn.Size = new Size(106, 30);
            partRecBtn.TabIndex = 30;
            partRecBtn.Text = "Receive";
            partRecBtn.UseVisualStyleBackColor = true;
            partRecBtn.Click += partRecBtn_Click;
            // 
            // partQtyBox
            // 
            partQtyBox.Location = new Point(179, 323);
            partQtyBox.Name = "partQtyBox";
            partQtyBox.Size = new Size(169, 29);
            partQtyBox.TabIndex = 29;
            // 
            // partQtyId
            // 
            partQtyId.AutoSize = true;
            partQtyId.Location = new Point(21, 331);
            partQtyId.Name = "partQtyId";
            partQtyId.Size = new Size(76, 21);
            partQtyId.TabIndex = 28;
            partQtyId.Text = "PARTQTY:";
            // 
            // dampSendBtn
            // 
            dampSendBtn.Location = new Point(485, 372);
            dampSendBtn.Name = "dampSendBtn";
            dampSendBtn.Size = new Size(106, 30);
            dampSendBtn.TabIndex = 35;
            dampSendBtn.Text = "Send";
            dampSendBtn.UseVisualStyleBackColor = true;
            dampSendBtn.Click += dampSendBtn_Click;
            // 
            // dampRecBtn
            // 
            dampRecBtn.Location = new Point(361, 372);
            dampRecBtn.Name = "dampRecBtn";
            dampRecBtn.Size = new Size(106, 30);
            dampRecBtn.TabIndex = 34;
            dampRecBtn.Text = "Receive";
            dampRecBtn.UseVisualStyleBackColor = true;
            dampRecBtn.Click += dampRecBtn_Click;
            // 
            // dampBox
            // 
            dampBox.Location = new Point(179, 369);
            dampBox.Name = "dampBox";
            dampBox.Size = new Size(169, 29);
            dampBox.TabIndex = 33;
            // 
            // dampLbl
            // 
            dampLbl.AutoSize = true;
            dampLbl.Location = new Point(21, 376);
            dampLbl.Name = "dampLbl";
            dampLbl.Size = new Size(84, 21);
            dampLbl.TabIndex = 32;
            dampLbl.Text = "DAMPING:";
            // 
            // graviySendBtn
            // 
            graviySendBtn.Location = new Point(485, 421);
            graviySendBtn.Name = "graviySendBtn";
            graviySendBtn.Size = new Size(106, 30);
            graviySendBtn.TabIndex = 39;
            graviySendBtn.Text = "Send";
            graviySendBtn.UseVisualStyleBackColor = true;
            graviySendBtn.Click += graviySendBtn_Click;
            // 
            // gravityRcvBtn
            // 
            gravityRcvBtn.Location = new Point(361, 421);
            gravityRcvBtn.Name = "gravityRcvBtn";
            gravityRcvBtn.Size = new Size(106, 30);
            gravityRcvBtn.TabIndex = 38;
            gravityRcvBtn.Text = "Receive";
            gravityRcvBtn.UseVisualStyleBackColor = true;
            gravityRcvBtn.Click += gravityRcvBtn_Click;
            // 
            // spcBox
            // 
            spcBox.Location = new Point(179, 418);
            spcBox.Name = "spcBox";
            spcBox.Size = new Size(169, 29);
            spcBox.TabIndex = 37;
            // 
            // spcgra
            // 
            spcgra.AutoSize = true;
            spcgra.Location = new Point(21, 421);
            spcgra.Name = "spcgra";
            spcgra.Size = new Size(140, 21);
            spcgra.TabIndex = 36;
            spcgra.Text = "SPECIFIC GRAVITY:";
            // 
            // numbPartsSendBtn
            // 
            numbPartsSendBtn.Location = new Point(485, 467);
            numbPartsSendBtn.Name = "numbPartsSendBtn";
            numbPartsSendBtn.Size = new Size(106, 30);
            numbPartsSendBtn.TabIndex = 43;
            numbPartsSendBtn.Text = "Send";
            numbPartsSendBtn.UseVisualStyleBackColor = true;
            numbPartsSendBtn.Click += numbPartsSendBtn_Click;
            // 
            // numbPartsRcvBtn
            // 
            numbPartsRcvBtn.Location = new Point(361, 467);
            numbPartsRcvBtn.Name = "numbPartsRcvBtn";
            numbPartsRcvBtn.Size = new Size(106, 30);
            numbPartsRcvBtn.TabIndex = 42;
            numbPartsRcvBtn.Text = "Receive";
            numbPartsRcvBtn.UseVisualStyleBackColor = true;
            numbPartsRcvBtn.Click += numbPartsRcvBtn_Click;
            // 
            // numPartstxtBox
            // 
            numPartstxtBox.Location = new Point(179, 464);
            numPartstxtBox.Name = "numPartstxtBox";
            numPartstxtBox.Size = new Size(169, 29);
            numPartstxtBox.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 467);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 40;
            label3.Text = "NUMBER OF PARTS:";
            // 
            // RcdTmSendBtn
            // 
            RcdTmSendBtn.Location = new Point(485, 514);
            RcdTmSendBtn.Name = "RcdTmSendBtn";
            RcdTmSendBtn.Size = new Size(106, 30);
            RcdTmSendBtn.TabIndex = 47;
            RcdTmSendBtn.Text = "Send";
            RcdTmSendBtn.UseVisualStyleBackColor = true;
            RcdTmSendBtn.Click += RcdTmSendBtn_Click;
            // 
            // RcdTmRcvBtn
            // 
            RcdTmRcvBtn.Location = new Point(361, 514);
            RcdTmRcvBtn.Name = "RcdTmRcvBtn";
            RcdTmRcvBtn.Size = new Size(106, 30);
            RcdTmRcvBtn.TabIndex = 46;
            RcdTmRcvBtn.Text = "Receive";
            RcdTmRcvBtn.UseVisualStyleBackColor = true;
            RcdTmRcvBtn.Click += RcdTmRcvBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 518);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 44;
            label4.Text = "RECORD TIME:";
            // 
            // TIME
            // 
            TIME.Controls.Add(label1);
            TIME.Controls.Add(yrSendBtn);
            TIME.Controls.Add(yrRcvBtn);
            TIME.Controls.Add(monSendBtn);
            TIME.Controls.Add(monRcvBtn);
            TIME.Controls.Add(dtSendBtn);
            TIME.Controls.Add(dtRcvBtn);
            TIME.Controls.Add(hrSendBtn);
            TIME.Controls.Add(hrRcvBtn);
            TIME.Controls.Add(dttxt);
            TIME.Controls.Add(montxt);
            TIME.Controls.Add(yrtxt);
            TIME.Controls.Add(hrtxt);
            TIME.Controls.Add(label7);
            TIME.Controls.Add(label6);
            TIME.Controls.Add(label5);
            TIME.Controls.Add(minSendBtn);
            TIME.Controls.Add(mintxt);
            TIME.Controls.Add(minRcvBtn);
            TIME.Controls.Add(label2);
            TIME.Location = new Point(611, 154);
            TIME.Name = "TIME";
            TIME.Size = new Size(438, 248);
            TIME.TabIndex = 48;
            TIME.TabStop = false;
            TIME.Text = "RTC TIME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 71;
            label1.Text = "MINUTES:";
            // 
            // yrSendBtn
            // 
            yrSendBtn.Location = new Point(315, 204);
            yrSendBtn.Name = "yrSendBtn";
            yrSendBtn.Size = new Size(106, 30);
            yrSendBtn.TabIndex = 69;
            yrSendBtn.Text = "Send";
            yrSendBtn.UseVisualStyleBackColor = true;
            yrSendBtn.Click += yrSendBtn_Click;
            // 
            // yrRcvBtn
            // 
            yrRcvBtn.Location = new Point(187, 203);
            yrRcvBtn.Name = "yrRcvBtn";
            yrRcvBtn.Size = new Size(106, 30);
            yrRcvBtn.TabIndex = 70;
            yrRcvBtn.Text = "Receive";
            yrRcvBtn.UseVisualStyleBackColor = true;
            yrRcvBtn.Click += yrRcvBtn_Click;
            // 
            // monSendBtn
            // 
            monSendBtn.Location = new Point(315, 160);
            monSendBtn.Name = "monSendBtn";
            monSendBtn.Size = new Size(106, 30);
            monSendBtn.TabIndex = 67;
            monSendBtn.Text = "Send";
            monSendBtn.UseVisualStyleBackColor = true;
            monSendBtn.Click += monSendBtn_Click;
            // 
            // monRcvBtn
            // 
            monRcvBtn.Location = new Point(187, 159);
            monRcvBtn.Name = "monRcvBtn";
            monRcvBtn.Size = new Size(106, 30);
            monRcvBtn.TabIndex = 68;
            monRcvBtn.Text = "Receive";
            monRcvBtn.UseVisualStyleBackColor = true;
            monRcvBtn.Click += monRcvBtn_Click;
            // 
            // dtSendBtn
            // 
            dtSendBtn.Location = new Point(315, 120);
            dtSendBtn.Name = "dtSendBtn";
            dtSendBtn.Size = new Size(106, 30);
            dtSendBtn.TabIndex = 65;
            dtSendBtn.Text = "Send";
            dtSendBtn.UseVisualStyleBackColor = true;
            dtSendBtn.Click += dtSendBtn_Click;
            // 
            // dtRcvBtn
            // 
            dtRcvBtn.Location = new Point(187, 119);
            dtRcvBtn.Name = "dtRcvBtn";
            dtRcvBtn.Size = new Size(106, 30);
            dtRcvBtn.TabIndex = 66;
            dtRcvBtn.Text = "Receive";
            dtRcvBtn.UseVisualStyleBackColor = true;
            dtRcvBtn.Click += dtRcvBtn_Click;
            // 
            // hrSendBtn
            // 
            hrSendBtn.Location = new Point(315, 76);
            hrSendBtn.Name = "hrSendBtn";
            hrSendBtn.Size = new Size(106, 30);
            hrSendBtn.TabIndex = 63;
            hrSendBtn.Text = "Send";
            hrSendBtn.UseVisualStyleBackColor = true;
            hrSendBtn.Click += hrSendBtn_Click;
            // 
            // hrRcvBtn
            // 
            hrRcvBtn.Location = new Point(187, 75);
            hrRcvBtn.Name = "hrRcvBtn";
            hrRcvBtn.Size = new Size(106, 30);
            hrRcvBtn.TabIndex = 64;
            hrRcvBtn.Text = "Receive";
            hrRcvBtn.UseVisualStyleBackColor = true;
            hrRcvBtn.Click += hrRcvBtn_Click;
            // 
            // dttxt
            // 
            dttxt.Location = new Point(111, 119);
            dttxt.Name = "dttxt";
            dttxt.Size = new Size(50, 29);
            dttxt.TabIndex = 56;
            // 
            // montxt
            // 
            montxt.Location = new Point(111, 158);
            montxt.Name = "montxt";
            montxt.Size = new Size(50, 29);
            montxt.TabIndex = 55;
            // 
            // yrtxt
            // 
            yrtxt.Location = new Point(111, 203);
            yrtxt.Name = "yrtxt";
            yrtxt.Size = new Size(50, 29);
            yrtxt.TabIndex = 54;
            // 
            // hrtxt
            // 
            hrtxt.Location = new Point(111, 72);
            hrtxt.Name = "hrtxt";
            hrtxt.Size = new Size(50, 29);
            hrtxt.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 122);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 52;
            label7.Text = "DATE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 164);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 51;
            label6.Text = "MONTH:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 50;
            label5.Text = "YEAR:";
            // 
            // minSendBtn
            // 
            minSendBtn.Location = new Point(315, 28);
            minSendBtn.Name = "minSendBtn";
            minSendBtn.Size = new Size(106, 30);
            minSendBtn.TabIndex = 49;
            minSendBtn.Text = "Send";
            minSendBtn.UseVisualStyleBackColor = true;
            minSendBtn.Click += minSendBtn_Click;
            // 
            // mintxt
            // 
            mintxt.Location = new Point(110, 27);
            mintxt.Name = "mintxt";
            mintxt.Size = new Size(50, 29);
            mintxt.TabIndex = 49;
            // 
            // minRcvBtn
            // 
            minRcvBtn.Location = new Point(186, 27);
            minRcvBtn.Name = "minRcvBtn";
            minRcvBtn.Size = new Size(106, 30);
            minRcvBtn.TabIndex = 49;
            minRcvBtn.Text = "Receive";
            minRcvBtn.UseVisualStyleBackColor = true;
            minRcvBtn.Click += minRcvBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 18;
            label2.Text = "HOURS:";
            // 
            // RcdTmtxt
            // 
            RcdTmtxt.FormattingEnabled = true;
            RcdTmtxt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            RcdTmtxt.Location = new Point(179, 514);
            RcdTmtxt.Name = "RcdTmtxt";
            RcdTmtxt.Size = new Size(169, 29);
            RcdTmtxt.TabIndex = 49;
            // 
            // RTDSeltxt
            // 
            RTDSeltxt.FormattingEnabled = true;
            RTDSeltxt.Items.AddRange(new object[] { "0", "1" });
            RTDSeltxt.Location = new Point(179, 564);
            RTDSeltxt.Name = "RTDSeltxt";
            RTDSeltxt.Size = new Size(169, 29);
            RTDSeltxt.TabIndex = 53;
            // 
            // rtdSelSendbtn
            // 
            rtdSelSendbtn.Location = new Point(485, 564);
            rtdSelSendbtn.Name = "rtdSelSendbtn";
            rtdSelSendbtn.Size = new Size(106, 30);
            rtdSelSendbtn.TabIndex = 52;
            rtdSelSendbtn.Text = "Send";
            rtdSelSendbtn.UseVisualStyleBackColor = true;
            rtdSelSendbtn.Click += rtdSelSendbtn_Click;
            // 
            // rtdRcvBtn
            // 
            rtdRcvBtn.Location = new Point(361, 564);
            rtdRcvBtn.Name = "rtdRcvBtn";
            rtdRcvBtn.Size = new Size(106, 30);
            rtdRcvBtn.TabIndex = 51;
            rtdRcvBtn.Text = "Receive";
            rtdRcvBtn.UseVisualStyleBackColor = true;
            rtdRcvBtn.Click += rtdRcvBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 569);
            label8.Name = "label8";
            label8.Size = new Size(96, 21);
            label8.TabIndex = 50;
            label8.Text = "RTD SELECT:";
            // 
            // sensortxt
            // 
            sensortxt.FormattingEnabled = true;
            sensortxt.Items.AddRange(new object[] { "0", "1", "2", "3" });
            sensortxt.Location = new Point(179, 616);
            sensortxt.Name = "sensortxt";
            sensortxt.Size = new Size(169, 29);
            sensortxt.TabIndex = 57;
            // 
            // sensorSendBtn
            // 
            sensorSendBtn.Location = new Point(485, 616);
            sensorSendBtn.Name = "sensorSendBtn";
            sensorSendBtn.Size = new Size(106, 30);
            sensorSendBtn.TabIndex = 56;
            sensorSendBtn.Text = "Send";
            sensorSendBtn.UseVisualStyleBackColor = true;
            sensorSendBtn.Click += sensorSendBtn_Click;
            // 
            // sensorrcvBtn
            // 
            sensorrcvBtn.Location = new Point(361, 616);
            sensorrcvBtn.Name = "sensorrcvBtn";
            sensorrcvBtn.Size = new Size(106, 30);
            sensorrcvBtn.TabIndex = 55;
            sensorrcvBtn.Text = "Receive";
            sensorrcvBtn.UseVisualStyleBackColor = true;
            sensorrcvBtn.Click += sensorrcvBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 621);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 54;
            label9.Text = "SENSOR:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtc2txt);
            groupBox1.Controls.Add(rtc2SendBtn);
            groupBox1.Controls.Add(RTC1txt);
            groupBox1.Controls.Add(rtc2RcvBtn);
            groupBox1.Controls.Add(rtc1SendBtn);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rtc1RcvBtn);
            groupBox1.Location = new Point(27, 671);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 111);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "VOLT DIVIDER FOR TEMP SENSOR";
            // 
            // rtc2txt
            // 
            rtc2txt.FormattingEnabled = true;
            rtc2txt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            rtc2txt.Location = new Point(82, 66);
            rtc2txt.Name = "rtc2txt";
            rtc2txt.Size = new Size(169, 29);
            rtc2txt.TabIndex = 62;
            // 
            // rtc2SendBtn
            // 
            rtc2SendBtn.Location = new Point(402, 66);
            rtc2SendBtn.Name = "rtc2SendBtn";
            rtc2SendBtn.Size = new Size(106, 30);
            rtc2SendBtn.TabIndex = 61;
            rtc2SendBtn.Text = "Send";
            rtc2SendBtn.UseVisualStyleBackColor = true;
            rtc2SendBtn.Click += rtc2SendBtn_Click;
            // 
            // RTC1txt
            // 
            RTC1txt.FormattingEnabled = true;
            RTC1txt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            RTC1txt.Location = new Point(82, 26);
            RTC1txt.Name = "RTC1txt";
            RTC1txt.Size = new Size(169, 29);
            RTC1txt.TabIndex = 62;
            // 
            // rtc2RcvBtn
            // 
            rtc2RcvBtn.Location = new Point(278, 66);
            rtc2RcvBtn.Name = "rtc2RcvBtn";
            rtc2RcvBtn.Size = new Size(106, 30);
            rtc2RcvBtn.TabIndex = 60;
            rtc2RcvBtn.Text = "Receive";
            rtc2RcvBtn.UseVisualStyleBackColor = true;
            rtc2RcvBtn.Click += rtc2RcvBtn_Click;
            // 
            // rtc1SendBtn
            // 
            rtc1SendBtn.Location = new Point(402, 27);
            rtc1SendBtn.Name = "rtc1SendBtn";
            rtc1SendBtn.Size = new Size(106, 30);
            rtc1SendBtn.TabIndex = 61;
            rtc1SendBtn.Text = "Send";
            rtc1SendBtn.UseVisualStyleBackColor = true;
            rtc1SendBtn.Click += rtc1SendBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 68);
            label11.Name = "label11";
            label11.Size = new Size(50, 21);
            label11.TabIndex = 59;
            label11.Text = "RTD2:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 29);
            label10.Name = "label10";
            label10.Size = new Size(50, 21);
            label10.TabIndex = 59;
            label10.Text = "RTD1:";
            // 
            // rtc1RcvBtn
            // 
            rtc1RcvBtn.Location = new Point(278, 27);
            rtc1RcvBtn.Name = "rtc1RcvBtn";
            rtc1RcvBtn.Size = new Size(106, 30);
            rtc1RcvBtn.TabIndex = 60;
            rtc1RcvBtn.Text = "Receive";
            rtc1RcvBtn.UseVisualStyleBackColor = true;
            rtc1RcvBtn.Click += rtc1RcvBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(s2maxvalSend);
            groupBox2.Controls.Add(s2maxvalTXT);
            groupBox2.Controls.Add(s2maxvalRcv);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(s1maxvalSend);
            groupBox2.Controls.Add(s1maxvalTXT);
            groupBox2.Controls.Add(s1maxvalRcv);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(s2minvalSend);
            groupBox2.Controls.Add(s2minvalTXT);
            groupBox2.Controls.Add(s2minvalRcv);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(s1minvalSend);
            groupBox2.Controls.Add(s1minvalTXT);
            groupBox2.Controls.Add(s1minvalRcv);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(s2maxvoltSend);
            groupBox2.Controls.Add(s2maxvoltTXT);
            groupBox2.Controls.Add(s2maxvoltRcv);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(s1maxvoltSend);
            groupBox2.Controls.Add(s1maxvoltTXT);
            groupBox2.Controls.Add(s1maxvoltRcv);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(s2minvoltSend);
            groupBox2.Controls.Add(s2minvoltTXT);
            groupBox2.Controls.Add(s2minvoltRcv);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(s1minvoltSend);
            groupBox2.Controls.Add(s1minvoltTXT);
            groupBox2.Controls.Add(s1minvoltRcv);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(611, 425);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 375);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "SENSOR (S)";
            // 
            // s2maxvalSend
            // 
            s2maxvalSend.Location = new Point(315, 322);
            s2maxvalSend.Name = "s2maxvalSend";
            s2maxvalSend.Size = new Size(106, 30);
            s2maxvalSend.TabIndex = 102;
            s2maxvalSend.Text = "Send";
            s2maxvalSend.UseVisualStyleBackColor = true;
            s2maxvalSend.Click += s2maxvalSend_Click;
            // 
            // s2maxvalTXT
            // 
            s2maxvalTXT.Location = new Point(124, 321);
            s2maxvalTXT.Name = "s2maxvalTXT";
            s2maxvalTXT.Size = new Size(50, 29);
            s2maxvalTXT.TabIndex = 101;
            // 
            // s2maxvalRcv
            // 
            s2maxvalRcv.Location = new Point(187, 321);
            s2maxvalRcv.Name = "s2maxvalRcv";
            s2maxvalRcv.Size = new Size(106, 30);
            s2maxvalRcv.TabIndex = 103;
            s2maxvalRcv.Text = "Receive";
            s2maxvalRcv.UseVisualStyleBackColor = true;
            s2maxvalRcv.Click += s2maxvalRcv_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 324);
            label19.Name = "label19";
            label19.Size = new Size(99, 21);
            label19.TabIndex = 100;
            label19.Text = "S2 MAX VAL:";
            // 
            // s1maxvalSend
            // 
            s1maxvalSend.Location = new Point(315, 287);
            s1maxvalSend.Name = "s1maxvalSend";
            s1maxvalSend.Size = new Size(106, 30);
            s1maxvalSend.TabIndex = 98;
            s1maxvalSend.Text = "Send";
            s1maxvalSend.UseVisualStyleBackColor = true;
            s1maxvalSend.Click += s1maxvalSend_Click;
            // 
            // s1maxvalTXT
            // 
            s1maxvalTXT.Location = new Point(124, 286);
            s1maxvalTXT.Name = "s1maxvalTXT";
            s1maxvalTXT.Size = new Size(50, 29);
            s1maxvalTXT.TabIndex = 97;
            // 
            // s1maxvalRcv
            // 
            s1maxvalRcv.Location = new Point(187, 286);
            s1maxvalRcv.Name = "s1maxvalRcv";
            s1maxvalRcv.Size = new Size(106, 30);
            s1maxvalRcv.TabIndex = 99;
            s1maxvalRcv.Text = "Receive";
            s1maxvalRcv.UseVisualStyleBackColor = true;
            s1maxvalRcv.Click += s1maxvalRcv_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 289);
            label18.Name = "label18";
            label18.Size = new Size(99, 21);
            label18.TabIndex = 96;
            label18.Text = "S1 MAX VAL:";
            // 
            // s2minvalSend
            // 
            s2minvalSend.Location = new Point(315, 244);
            s2minvalSend.Name = "s2minvalSend";
            s2minvalSend.Size = new Size(106, 30);
            s2minvalSend.TabIndex = 94;
            s2minvalSend.Text = "Send";
            s2minvalSend.UseVisualStyleBackColor = true;
            s2minvalSend.Click += s2minvalSend_Click;
            // 
            // s2minvalTXT
            // 
            s2minvalTXT.Location = new Point(124, 243);
            s2minvalTXT.Name = "s2minvalTXT";
            s2minvalTXT.Size = new Size(50, 29);
            s2minvalTXT.TabIndex = 93;
            // 
            // s2minvalRcv
            // 
            s2minvalRcv.Location = new Point(187, 243);
            s2minvalRcv.Name = "s2minvalRcv";
            s2minvalRcv.Size = new Size(106, 30);
            s2minvalRcv.TabIndex = 95;
            s2minvalRcv.Text = "Receive";
            s2minvalRcv.UseVisualStyleBackColor = true;
            s2minvalRcv.Click += s2minvalRcv_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 246);
            label17.Name = "label17";
            label17.Size = new Size(96, 21);
            label17.TabIndex = 92;
            label17.Text = "S2 MIN VAL:";
            // 
            // s1minvalSend
            // 
            s1minvalSend.Location = new Point(315, 201);
            s1minvalSend.Name = "s1minvalSend";
            s1minvalSend.Size = new Size(106, 30);
            s1minvalSend.TabIndex = 90;
            s1minvalSend.Text = "Send";
            s1minvalSend.UseVisualStyleBackColor = true;
            s1minvalSend.Click += s1minvalSend_Click;
            // 
            // s1minvalTXT
            // 
            s1minvalTXT.Location = new Point(124, 199);
            s1minvalTXT.Name = "s1minvalTXT";
            s1minvalTXT.Size = new Size(50, 29);
            s1minvalTXT.TabIndex = 89;
            // 
            // s1minvalRcv
            // 
            s1minvalRcv.Location = new Point(187, 199);
            s1minvalRcv.Name = "s1minvalRcv";
            s1minvalRcv.Size = new Size(106, 30);
            s1minvalRcv.TabIndex = 91;
            s1minvalRcv.Text = "Receive";
            s1minvalRcv.UseVisualStyleBackColor = true;
            s1minvalRcv.Click += s1minvalRcv_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 203);
            label16.Name = "label16";
            label16.Size = new Size(96, 21);
            label16.TabIndex = 88;
            label16.Text = "S1 MIN VAL:";
            // 
            // s2maxvoltSend
            // 
            s2maxvoltSend.Location = new Point(315, 162);
            s2maxvoltSend.Name = "s2maxvoltSend";
            s2maxvoltSend.Size = new Size(106, 30);
            s2maxvoltSend.TabIndex = 86;
            s2maxvoltSend.Text = "Send";
            s2maxvoltSend.UseVisualStyleBackColor = true;
            s2maxvoltSend.Click += s2maxvoltSend_Click;
            // 
            // s2maxvoltTXT
            // 
            s2maxvoltTXT.Location = new Point(124, 161);
            s2maxvoltTXT.Name = "s2maxvoltTXT";
            s2maxvoltTXT.Size = new Size(50, 29);
            s2maxvoltTXT.TabIndex = 85;
            // 
            // s2maxvoltRcv
            // 
            s2maxvoltRcv.Location = new Point(187, 161);
            s2maxvoltRcv.Name = "s2maxvoltRcv";
            s2maxvoltRcv.Size = new Size(106, 30);
            s2maxvoltRcv.TabIndex = 87;
            s2maxvoltRcv.Text = "Receive";
            s2maxvoltRcv.UseVisualStyleBackColor = true;
            s2maxvoltRcv.Click += s2maxvoltRcv_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 164);
            label15.Name = "label15";
            label15.Size = new Size(109, 21);
            label15.TabIndex = 84;
            label15.Text = "S2 MAX VOLT:";
            // 
            // s1maxvoltSend
            // 
            s1maxvoltSend.Location = new Point(315, 115);
            s1maxvoltSend.Name = "s1maxvoltSend";
            s1maxvoltSend.Size = new Size(106, 30);
            s1maxvoltSend.TabIndex = 82;
            s1maxvoltSend.Text = "Send";
            s1maxvoltSend.UseVisualStyleBackColor = true;
            s1maxvoltSend.Click += s1maxvoltSend_Click;
            // 
            // s1maxvoltTXT
            // 
            s1maxvoltTXT.Location = new Point(124, 114);
            s1maxvoltTXT.Name = "s1maxvoltTXT";
            s1maxvoltTXT.Size = new Size(50, 29);
            s1maxvoltTXT.TabIndex = 81;
            // 
            // s1maxvoltRcv
            // 
            s1maxvoltRcv.Location = new Point(187, 114);
            s1maxvoltRcv.Name = "s1maxvoltRcv";
            s1maxvoltRcv.Size = new Size(106, 30);
            s1maxvoltRcv.TabIndex = 83;
            s1maxvoltRcv.Text = "Receive";
            s1maxvoltRcv.UseVisualStyleBackColor = true;
            s1maxvoltRcv.Click += s1maxvoltRcv_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 118);
            label14.Name = "label14";
            label14.Size = new Size(109, 21);
            label14.TabIndex = 80;
            label14.Text = "S1 MAX VOLT:";
            // 
            // s2minvoltSend
            // 
            s2minvoltSend.Location = new Point(315, 70);
            s2minvoltSend.Name = "s2minvoltSend";
            s2minvoltSend.Size = new Size(106, 30);
            s2minvoltSend.TabIndex = 78;
            s2minvoltSend.Text = "Send";
            s2minvoltSend.UseVisualStyleBackColor = true;
            s2minvoltSend.Click += s2minvoltSend_Click;
            // 
            // s2minvoltTXT
            // 
            s2minvoltTXT.Location = new Point(124, 69);
            s2minvoltTXT.Name = "s2minvoltTXT";
            s2minvoltTXT.Size = new Size(50, 29);
            s2minvoltTXT.TabIndex = 77;
            // 
            // s2minvoltRcv
            // 
            s2minvoltRcv.Location = new Point(187, 69);
            s2minvoltRcv.Name = "s2minvoltRcv";
            s2minvoltRcv.Size = new Size(106, 30);
            s2minvoltRcv.TabIndex = 79;
            s2minvoltRcv.Text = "Receive";
            s2minvoltRcv.UseVisualStyleBackColor = true;
            s2minvoltRcv.Click += s2minvoltRcv_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 72);
            label13.Name = "label13";
            label13.Size = new Size(106, 21);
            label13.TabIndex = 76;
            label13.Text = "S2 MIN VOLT:";
            // 
            // s1minvoltSend
            // 
            s1minvoltSend.Location = new Point(315, 28);
            s1minvoltSend.Name = "s1minvoltSend";
            s1minvoltSend.Size = new Size(106, 30);
            s1minvoltSend.TabIndex = 74;
            s1minvoltSend.Text = "Send";
            s1minvoltSend.UseVisualStyleBackColor = true;
            s1minvoltSend.Click += s1minvoltSend_Click;
            // 
            // s1minvoltTXT
            // 
            s1minvoltTXT.Location = new Point(124, 27);
            s1minvoltTXT.Name = "s1minvoltTXT";
            s1minvoltTXT.Size = new Size(50, 29);
            s1minvoltTXT.TabIndex = 73;
            // 
            // s1minvoltRcv
            // 
            s1minvoltRcv.Location = new Point(187, 27);
            s1minvoltRcv.Name = "s1minvoltRcv";
            s1minvoltRcv.Size = new Size(106, 30);
            s1minvoltRcv.TabIndex = 75;
            s1minvoltRcv.Text = "Receive";
            s1minvoltRcv.UseVisualStyleBackColor = true;
            s1minvoltRcv.Click += s1minvoltRcv_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 30);
            label12.Name = "label12";
            label12.Size = new Size(106, 21);
            label12.TabIndex = 72;
            label12.Text = "S1 MIN VOLT:";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { val1, val2, val3, val4, val5, val6, val7, val8, val9, val10 });
            dataGridView.Location = new Point(25, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(970, 706);
            dataGridView.TabIndex = 60;
            // 
            // val1
            // 
            val1.HeaderText = "val1";
            val1.MinimumWidth = 6;
            val1.Name = "val1";
            // 
            // val2
            // 
            val2.HeaderText = "val2";
            val2.MinimumWidth = 6;
            val2.Name = "val2";
            // 
            // val3
            // 
            val3.HeaderText = "val3";
            val3.MinimumWidth = 6;
            val3.Name = "val3";
            // 
            // val4
            // 
            val4.HeaderText = "val4";
            val4.MinimumWidth = 6;
            val4.Name = "val4";
            // 
            // val5
            // 
            val5.HeaderText = "val5";
            val5.MinimumWidth = 6;
            val5.Name = "val5";
            // 
            // val6
            // 
            val6.HeaderText = "val6";
            val6.MinimumWidth = 6;
            val6.Name = "val6";
            // 
            // val7
            // 
            val7.HeaderText = "val7";
            val7.MinimumWidth = 6;
            val7.Name = "val7";
            // 
            // val8
            // 
            val8.HeaderText = "val8";
            val8.MinimumWidth = 6;
            val8.Name = "val8";
            // 
            // val9
            // 
            val9.HeaderText = "val9";
            val9.MinimumWidth = 6;
            val9.Name = "val9";
            // 
            // val10
            // 
            val10.HeaderText = "val10";
            val10.MinimumWidth = 6;
            val10.Name = "val10";
            // 
            // tblRecBtn
            // 
            tblRecBtn.Location = new Point(37, 29);
            tblRecBtn.Name = "tblRecBtn";
            tblRecBtn.Size = new Size(106, 30);
            tblRecBtn.TabIndex = 61;
            tblRecBtn.Text = "Receive";
            tblRecBtn.UseVisualStyleBackColor = true;
            tblRecBtn.Click += tblRecBtn_Click;
            // 
            // tblSendBtn
            // 
            tblSendBtn.Location = new Point(780, 30);
            tblSendBtn.Name = "tblSendBtn";
            tblSendBtn.Size = new Size(106, 30);
            tblSendBtn.TabIndex = 62;
            tblSendBtn.Text = "Send";
            tblSendBtn.UseVisualStyleBackColor = true;
            tblSendBtn.Click += tblSendBtn_Click;
            // 
            // import
            // 
            import.Location = new Point(150, 29);
            import.Name = "import";
            import.Size = new Size(106, 30);
            import.TabIndex = 64;
            import.Text = "Import File ";
            import.UseVisualStyleBackColor = true;
            import.Click += import_Click;
            // 
            // filepathText
            // 
            filepathText.Location = new Point(262, 31);
            filepathText.Name = "filepathText";
            filepathText.Size = new Size(510, 29);
            filepathText.TabIndex = 65;
            // 
            // receiveTable
            // 
            receiveTable.Controls.Add(exportBtn);
            receiveTable.Controls.Add(tblSendBtn);
            receiveTable.Controls.Add(import);
            receiveTable.Controls.Add(filepathText);
            receiveTable.Controls.Add(dataGridView);
            receiveTable.Controls.Add(tblRecBtn);
            receiveTable.Location = new Point(1066, 154);
            receiveTable.Name = "receiveTable";
            receiveTable.Size = new Size(1018, 823);
            receiveTable.TabIndex = 67;
            receiveTable.TabStop = false;
            receiveTable.Text = "Data To Receive";
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(889, 30);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(106, 30);
            exportBtn.TabIndex = 66;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Baskerville Old Face", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Highlight;
            label20.Location = new Point(704, 44);
            label20.Name = "label20";
            label20.Size = new Size(504, 50);
            label20.TabIndex = 68;
            label20.Text = "BMC CONFIGURATOR";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.company;
            pictureBox.Location = new Point(27, 9);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(322, 87);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 73;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1020);
            Controls.Add(pictureBox);
            Controls.Add(label20);
            Controls.Add(receiveTable);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(sensortxt);
            Controls.Add(sensorSendBtn);
            Controls.Add(sensorrcvBtn);
            Controls.Add(label9);
            Controls.Add(RTDSeltxt);
            Controls.Add(rtdSelSendbtn);
            Controls.Add(rtdRcvBtn);
            Controls.Add(label8);
            Controls.Add(RcdTmtxt);
            Controls.Add(TIME);
            Controls.Add(RcdTmSendBtn);
            Controls.Add(RcdTmRcvBtn);
            Controls.Add(label4);
            Controls.Add(numbPartsSendBtn);
            Controls.Add(numbPartsRcvBtn);
            Controls.Add(numPartstxtBox);
            Controls.Add(label3);
            Controls.Add(graviySendBtn);
            Controls.Add(gravityRcvBtn);
            Controls.Add(spcBox);
            Controls.Add(spcgra);
            Controls.Add(dampSendBtn);
            Controls.Add(dampRecBtn);
            Controls.Add(dampBox);
            Controls.Add(dampLbl);
            Controls.Add(partSendBtn);
            Controls.Add(partRecBtn);
            Controls.Add(partQtyBox);
            Controls.Add(partQtyId);
            Controls.Add(quanSendBtn);
            Controls.Add(qaunRecBtn);
            Controls.Add(quanBox);
            Controls.Add(quanId);
            Controls.Add(devIdSendBtn);
            Controls.Add(devIdRecBtn);
            Controls.Add(devBox);
            Controls.Add(devIdLabel);
            Controls.Add(sndBtn);
            Controls.Add(Recbtn);
            Controls.Add(bmcBox);
            Controls.Add(bmclabel);
            Controls.Add(ToggleButton);
            Controls.Add(PortSel);
            Controls.Add(COMLabel);
            MaximizeBox = false;
            MaximumSize = new Size(2156, 1067);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1918, 1067);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAMUDRA TECHNOLOGIES";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            TIME.ResumeLayout(false);
            TIME.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            receiveTable.ResumeLayout(false);
            receiveTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button clsBtn;
        private ComboBox paritySel;
        private ComboBox stpSel;
        private ComboBox dataSel;
        private ComboBox baudSel;
        private Label paritybits;
        private Label serialbits;
        private Label databits;
        private Label bmclabel;
        private Button ToggleButton;
        private ComboBox PortSel;
        private Label COMLabel;
        private TextBox bmcBox;
        private Button Recbtn;
        private Button sndBtn;
        private Button devIdSendBtn;
        private Button devIdRecBtn;
        private TextBox devBox;
        private Label devIdLabel;
        private Button quanSendBtn;
        private Button qaunRecBtn;
        private TextBox quanBox;
        private Label quanId;
        private Button partSendBtn;
        private Button partRecBtn;
        private TextBox partQtyBox;
        private Label partQtyId;
        private Button dampSendBtn;
        private Button dampRecBtn;
        private TextBox dampBox;
        private Label dampLbl;
        private Button graviySendBtn;
        private Button gravityRcvBtn;
        private TextBox spcBox;
        private Label spcgra;
        private Button numbPartsSendBtn;
        private Button numbPartsRcvBtn;
        private TextBox numPartstxtBox;
        private Label label3;
        private Button RcdTmSendBtn;
        private Button RcdTmRcvBtn;
        private Label label4;
        private GroupBox TIME;
        private TextBox mintxt;
        private Button minRcvBtn;
        private Label label2;
        private Button yrSendBtn;
        private Button yrRcvBtn;
        private Button monSendBtn;
        private Button monRcvBtn;
        private Button dtSendBtn;
        private Button dtRcvBtn;
        private Button hrSendBtn;
        private Button hrRcvBtn;
        private TextBox dttxt;
        private TextBox montxt;
        private TextBox yrtxt;
        private TextBox hrtxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button minSendBtn;
        private Label label1;
        private ComboBox RcdTmtxt;
        private ComboBox RTDSeltxt;
        private Button rtdSelSendbtn;
        private Button rtdRcvBtn;
        private Label label8;
        private ComboBox sensortxt;
        private Button sensorSendBtn;
        private Button sensorrcvBtn;
        private Label label9;
        private GroupBox groupBox1;
        private ComboBox rtc2txt;
        private Button rtc2SendBtn;
        private ComboBox RTC1txt;
        private Button rtc2RcvBtn;
        private Button rtc1SendBtn;
        private Label label11;
        private Label label10;
        private Button rtc1RcvBtn;
        private GroupBox groupBox2;
        private Button s1minvoltSend;
        private TextBox s1minvoltTXT;
        private Button s1minvoltRcv;
        private Label label12;
        private Button s2maxvalSend;
        private TextBox s2maxvalTXT;
        private Button s2maxvalRcv;
        private Label label19;
        private Button s1maxvalSend;
        private TextBox s1maxvalTXT;
        private Button s1maxvalRcv;
        private Label label18;
        private Button s2minvalSend;
        private TextBox s2minvalTXT;
        private Button s2minvalRcv;
        private Label label17;
        private Button s1minvalSend;
        private TextBox s1minvalTXT;
        private Button s1minvalRcv;
        private Label label16;
        private Button s2maxvoltSend;
        private TextBox s2maxvoltTXT;
        private Button s2maxvoltRcv;
        private Label label15;
        private Button s1maxvoltSend;
        private TextBox s1maxvoltTXT;
        private Button s1maxvoltRcv;
        private Label label14;
        private Button s2minvoltSend;
        private TextBox s2minvoltTXT;
        private Button s2minvoltRcv;
        private Label label13;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn val1;
        private DataGridViewTextBoxColumn val2;
        private DataGridViewTextBoxColumn val3;
        private DataGridViewTextBoxColumn val4;
        private DataGridViewTextBoxColumn val5;
        private DataGridViewTextBoxColumn val6;
        private DataGridViewTextBoxColumn val7;
        private DataGridViewTextBoxColumn val8;
        private DataGridViewTextBoxColumn val9;
        private DataGridViewTextBoxColumn val10;
        private Button tblRecBtn;
        private Button tblSendBtn;
        private Button import;
        private TextBox filepathText;
        private GroupBox receiveTable;
        private Label label20;
        private PictureBox pictureBox;
        private Button exportBtn;
    }
}