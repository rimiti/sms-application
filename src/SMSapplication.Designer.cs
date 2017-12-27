using System.Drawing;
namespace SMSapplication
{
    partial class SMSapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSapplication));
            this.tabSMSapplication = new System.Windows.Forms.TabControl();
            this.tbPortSettings = new System.Windows.Forms.TabPage();
            this.gboPortSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1Port = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.checkBPort1 = new System.Windows.Forms.CheckBox();
            this.groupBox2Ports = new System.Windows.Forms.GroupBox();
            this.checkBPort2 = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboPortName2P1 = new System.Windows.Forms.ComboBox();
            this.cboPortName2P2 = new System.Windows.Forms.ComboBox();
            this.groupBox4Ports = new System.Windows.Forms.GroupBox();
            this.checkBPort4 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboPortName4P1 = new System.Windows.Forms.ComboBox();
            this.cboPortName4P4 = new System.Windows.Forms.ComboBox();
            this.cboPortName4P3 = new System.Windows.Forms.ComboBox();
            this.cboPortName4P2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtWriteTimeOut = new System.Windows.Forms.TextBox();
            this.txtReadTimeOut = new System.Windows.Forms.TextBox();
            this.cboParityBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSendSMS = new System.Windows.Forms.TabPage();
            this.gboSendSMS = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSIM = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tbReadSMS = new System.Windows.Forms.TabPage();
            this.gboReadSMS = new System.Windows.Forms.GroupBox();
            this.rbReadStoreUnSent = new System.Windows.Forms.RadioButton();
            this.rbReadStoreSent = new System.Windows.Forms.RadioButton();
            this.rbReadUnRead = new System.Windows.Forms.RadioButton();
            this.rbReadAll = new System.Windows.Forms.RadioButton();
            this.btnReadSMS = new System.Windows.Forms.Button();
            this.lvwMessages = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSentTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbDeleteSMS = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCountSMS = new System.Windows.Forms.Button();
            this.txtCountSMS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gboDeleteSMS = new System.Windows.Forms.GroupBox();
            this.rbDeleteReadSMS = new System.Windows.Forms.RadioButton();
            this.btnDeleteSMS = new System.Windows.Forms.Button();
            this.rbDeleteAllSMS = new System.Windows.Forms.RadioButton();
            this.tbRequestSMS = new System.Windows.Forms.TabPage();
            this.lblMsgView = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCurrentPortError = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSimStatusErrors = new System.Windows.Forms.Label();
            this.lblSimStatus = new System.Windows.Forms.Label();
            this.lblSimStatusName = new System.Windows.Forms.Label();
            this.labelCurrentPort = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.countSMSnok = new System.Windows.Forms.Label();
            this.countSMSok = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRequestStop = new System.Windows.Forms.Button();
            this.btnRequestStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalSendSMS = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.urlChecker = new System.Windows.Forms.TextBox();
            this.gboConnectionStatus = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.nbErrorToSwitch = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tabSMSapplication.SuspendLayout();
            this.tbPortSettings.SuspendLayout();
            this.gboPortSettings.SuspendLayout();
            this.groupBox1Port.SuspendLayout();
            this.groupBox2Ports.SuspendLayout();
            this.groupBox4Ports.SuspendLayout();
            this.tbSendSMS.SuspendLayout();
            this.gboSendSMS.SuspendLayout();
            this.tbReadSMS.SuspendLayout();
            this.gboReadSMS.SuspendLayout();
            this.tbDeleteSMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboDeleteSMS.SuspendLayout();
            this.tbRequestSMS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSendSMS)).BeginInit();
            this.gboConnectionStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbErrorToSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSMSapplication
            // 
            this.tabSMSapplication.Controls.Add(this.tbPortSettings);
            this.tabSMSapplication.Controls.Add(this.tbSendSMS);
            this.tabSMSapplication.Controls.Add(this.tbReadSMS);
            this.tabSMSapplication.Controls.Add(this.tbDeleteSMS);
            this.tabSMSapplication.Controls.Add(this.tbRequestSMS);
            this.tabSMSapplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSMSapplication.Location = new System.Drawing.Point(12, 12);
            this.tabSMSapplication.Name = "tabSMSapplication";
            this.tabSMSapplication.SelectedIndex = 0;
            this.tabSMSapplication.Size = new System.Drawing.Size(773, 498);
            this.tabSMSapplication.TabIndex = 0;
            // 
            // tbPortSettings
            // 
            this.tbPortSettings.Controls.Add(this.gboPortSettings);
            this.tbPortSettings.Location = new System.Drawing.Point(4, 22);
            this.tbPortSettings.Name = "tbPortSettings";
            this.tbPortSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbPortSettings.Size = new System.Drawing.Size(765, 472);
            this.tbPortSettings.TabIndex = 0;
            this.tbPortSettings.Text = "Port Settings";
            this.tbPortSettings.UseVisualStyleBackColor = true;
            // 
            // gboPortSettings
            // 
            this.gboPortSettings.Controls.Add(this.groupBox1Port);
            this.gboPortSettings.Controls.Add(this.groupBox2Ports);
            this.gboPortSettings.Controls.Add(this.groupBox4Ports);
            this.gboPortSettings.Controls.Add(this.label12);
            this.gboPortSettings.Controls.Add(this.txtPinCode);
            this.gboPortSettings.Controls.Add(this.btnOK);
            this.gboPortSettings.Controls.Add(this.txtWriteTimeOut);
            this.gboPortSettings.Controls.Add(this.txtReadTimeOut);
            this.gboPortSettings.Controls.Add(this.cboParityBits);
            this.gboPortSettings.Controls.Add(this.cboStopBits);
            this.gboPortSettings.Controls.Add(this.cboDataBits);
            this.gboPortSettings.Controls.Add(this.cboBaudRate);
            this.gboPortSettings.Controls.Add(this.label7);
            this.gboPortSettings.Controls.Add(this.label6);
            this.gboPortSettings.Controls.Add(this.label5);
            this.gboPortSettings.Controls.Add(this.label4);
            this.gboPortSettings.Controls.Add(this.label3);
            this.gboPortSettings.Controls.Add(this.label2);
            this.gboPortSettings.Location = new System.Drawing.Point(16, 17);
            this.gboPortSettings.Name = "gboPortSettings";
            this.gboPortSettings.Size = new System.Drawing.Size(730, 436);
            this.gboPortSettings.TabIndex = 0;
            this.gboPortSettings.TabStop = false;
            this.gboPortSettings.Text = "Port Settings";
            // 
            // groupBox1Port
            // 
            this.groupBox1Port.Controls.Add(this.label27);
            this.groupBox1Port.Controls.Add(this.cboPortName);
            this.groupBox1Port.Controls.Add(this.label26);
            this.groupBox1Port.Controls.Add(this.checkBPort1);
            this.groupBox1Port.Location = new System.Drawing.Point(56, 31);
            this.groupBox1Port.Name = "groupBox1Port";
            this.groupBox1Port.Size = new System.Drawing.Size(275, 96);
            this.groupBox1Port.TabIndex = 23;
            this.groupBox1Port.TabStop = false;
            this.groupBox1Port.Text = "Solo Sim";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(127, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 17);
            this.label27.TabIndex = 2;
            this.label27.Text = "1 Port";
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(111, 54);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(121, 21);
            this.cboPortName.TabIndex = 1;
            this.cboPortName.Text = "     ----- Choose -----";
            this.cboPortName.Click += new System.EventHandler(this.cboPortName_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 58);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Port Name 1";
            // 
            // checkBPort1
            // 
            this.checkBPort1.AutoSize = true;
            this.checkBPort1.Location = new System.Drawing.Point(254, 10);
            this.checkBPort1.Name = "checkBPort1";
            this.checkBPort1.Size = new System.Drawing.Size(15, 14);
            this.checkBPort1.TabIndex = 18;
            this.checkBPort1.UseVisualStyleBackColor = true;
            this.checkBPort1.CheckedChanged += new System.EventHandler(this.checkBPort2_CheckedChanged);
            // 
            // groupBox2Ports
            // 
            this.groupBox2Ports.Controls.Add(this.checkBPort2);
            this.groupBox2Ports.Controls.Add(this.label25);
            this.groupBox2Ports.Controls.Add(this.label24);
            this.groupBox2Ports.Controls.Add(this.label22);
            this.groupBox2Ports.Controls.Add(this.cboPortName2P1);
            this.groupBox2Ports.Controls.Add(this.cboPortName2P2);
            this.groupBox2Ports.Location = new System.Drawing.Point(367, 257);
            this.groupBox2Ports.Name = "groupBox2Ports";
            this.groupBox2Ports.Size = new System.Drawing.Size(302, 139);
            this.groupBox2Ports.TabIndex = 22;
            this.groupBox2Ports.TabStop = false;
            this.groupBox2Ports.Text = " Multi Sim ";
            // 
            // checkBPort2
            // 
            this.checkBPort2.AutoSize = true;
            this.checkBPort2.Location = new System.Drawing.Point(280, 10);
            this.checkBPort2.Name = "checkBPort2";
            this.checkBPort2.Size = new System.Drawing.Size(15, 14);
            this.checkBPort2.TabIndex = 25;
            this.checkBPort2.UseVisualStyleBackColor = true;
            this.checkBPort2.CheckedChanged += new System.EventHandler(this.checkBPort2_CheckedChanged_1);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(51, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Port Name 2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Port Name 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(136, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "2 Ports";
            // 
            // cboPortName2P1
            // 
            this.cboPortName2P1.FormattingEnabled = true;
            this.cboPortName2P1.Location = new System.Drawing.Point(132, 60);
            this.cboPortName2P1.Name = "cboPortName2P1";
            this.cboPortName2P1.Size = new System.Drawing.Size(121, 21);
            this.cboPortName2P1.TabIndex = 21;
            this.cboPortName2P1.Text = "     ----- Choose -----";
            this.cboPortName2P1.Click += new System.EventHandler(this.cboPortName2P1_Click);
            // 
            // cboPortName2P2
            // 
            this.cboPortName2P2.FormattingEnabled = true;
            this.cboPortName2P2.Location = new System.Drawing.Point(132, 87);
            this.cboPortName2P2.Name = "cboPortName2P2";
            this.cboPortName2P2.Size = new System.Drawing.Size(121, 21);
            this.cboPortName2P2.TabIndex = 20;
            this.cboPortName2P2.Text = "     ----- Choose -----";
            // 
            // groupBox4Ports
            // 
            this.groupBox4Ports.Controls.Add(this.checkBPort4);
            this.groupBox4Ports.Controls.Add(this.label21);
            this.groupBox4Ports.Controls.Add(this.label20);
            this.groupBox4Ports.Controls.Add(this.label19);
            this.groupBox4Ports.Controls.Add(this.label18);
            this.groupBox4Ports.Controls.Add(this.label17);
            this.groupBox4Ports.Controls.Add(this.cboPortName4P1);
            this.groupBox4Ports.Controls.Add(this.cboPortName4P4);
            this.groupBox4Ports.Controls.Add(this.cboPortName4P3);
            this.groupBox4Ports.Controls.Add(this.cboPortName4P2);
            this.groupBox4Ports.Location = new System.Drawing.Point(367, 31);
            this.groupBox4Ports.Name = "groupBox4Ports";
            this.groupBox4Ports.Size = new System.Drawing.Size(302, 194);
            this.groupBox4Ports.TabIndex = 19;
            this.groupBox4Ports.TabStop = false;
            this.groupBox4Ports.Text = " Multi Sim ";
            // 
            // checkBPort4
            // 
            this.checkBPort4.AutoSize = true;
            this.checkBPort4.Location = new System.Drawing.Point(281, 10);
            this.checkBPort4.Name = "checkBPort4";
            this.checkBPort4.Size = new System.Drawing.Size(15, 14);
            this.checkBPort4.TabIndex = 27;
            this.checkBPort4.UseVisualStyleBackColor = true;
            this.checkBPort4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(136, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "4 Ports";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(51, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Port Name 4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Port Name 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Port Name 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Port Name 1";
            // 
            // cboPortName4P1
            // 
            this.cboPortName4P1.FormattingEnabled = true;
            this.cboPortName4P1.Location = new System.Drawing.Point(132, 59);
            this.cboPortName4P1.Name = "cboPortName4P1";
            this.cboPortName4P1.Size = new System.Drawing.Size(121, 21);
            this.cboPortName4P1.TabIndex = 21;
            this.cboPortName4P1.Text = "     ----- Choose -----";
            this.cboPortName4P1.Click += new System.EventHandler(this.cboPortName4P1_Click);
            // 
            // cboPortName4P4
            // 
            this.cboPortName4P4.FormattingEnabled = true;
            this.cboPortName4P4.Location = new System.Drawing.Point(132, 141);
            this.cboPortName4P4.Name = "cboPortName4P4";
            this.cboPortName4P4.Size = new System.Drawing.Size(121, 21);
            this.cboPortName4P4.TabIndex = 20;
            this.cboPortName4P4.Text = "     ----- Choose -----";
            // 
            // cboPortName4P3
            // 
            this.cboPortName4P3.FormattingEnabled = true;
            this.cboPortName4P3.Location = new System.Drawing.Point(132, 114);
            this.cboPortName4P3.Name = "cboPortName4P3";
            this.cboPortName4P3.Size = new System.Drawing.Size(121, 21);
            this.cboPortName4P3.TabIndex = 19;
            this.cboPortName4P3.Text = "     ----- Choose -----";
            // 
            // cboPortName4P2
            // 
            this.cboPortName4P2.FormattingEnabled = true;
            this.cboPortName4P2.Location = new System.Drawing.Point(132, 87);
            this.cboPortName4P2.Name = "cboPortName4P2";
            this.cboPortName4P2.Size = new System.Drawing.Size(121, 21);
            this.cboPortName4P2.TabIndex = 18;
            this.cboPortName4P2.Text = "     ----- Choose -----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Pin code";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(166, 334);
            this.txtPinCode.MaxLength = 4;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(121, 20);
            this.txtPinCode.TabIndex = 15;
            this.txtPinCode.Text = "1234";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(131, 385);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "Connect";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtWriteTimeOut
            // 
            this.txtWriteTimeOut.Location = new System.Drawing.Point(168, 289);
            this.txtWriteTimeOut.MaxLength = 5;
            this.txtWriteTimeOut.Name = "txtWriteTimeOut";
            this.txtWriteTimeOut.Size = new System.Drawing.Size(121, 20);
            this.txtWriteTimeOut.TabIndex = 13;
            this.txtWriteTimeOut.Text = "300";
            // 
            // txtReadTimeOut
            // 
            this.txtReadTimeOut.Location = new System.Drawing.Point(168, 263);
            this.txtReadTimeOut.MaxLength = 5;
            this.txtReadTimeOut.Name = "txtReadTimeOut";
            this.txtReadTimeOut.Size = new System.Drawing.Size(121, 20);
            this.txtReadTimeOut.TabIndex = 12;
            this.txtReadTimeOut.Text = "300";
            // 
            // cboParityBits
            // 
            this.cboParityBits.FormattingEnabled = true;
            this.cboParityBits.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.cboParityBits.Location = new System.Drawing.Point(168, 236);
            this.cboParityBits.Name = "cboParityBits";
            this.cboParityBits.Size = new System.Drawing.Size(121, 21);
            this.cboParityBits.TabIndex = 11;
            this.cboParityBits.Text = "None";
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(168, 209);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 21);
            this.cboStopBits.TabIndex = 10;
            this.cboStopBits.Text = "1";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(168, 182);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 21);
            this.cboDataBits.TabIndex = 9;
            this.cboDataBits.Text = "8";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cboBaudRate.Location = new System.Drawing.Point(168, 154);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 8;
            this.cboBaudRate.Text = "115200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Write Timeout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Read Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // tbSendSMS
            // 
            this.tbSendSMS.Controls.Add(this.gboSendSMS);
            this.tbSendSMS.Location = new System.Drawing.Point(4, 22);
            this.tbSendSMS.Name = "tbSendSMS";
            this.tbSendSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbSendSMS.Size = new System.Drawing.Size(765, 472);
            this.tbSendSMS.TabIndex = 1;
            this.tbSendSMS.Text = "Send SMS";
            this.tbSendSMS.UseVisualStyleBackColor = true;
            // 
            // gboSendSMS
            // 
            this.gboSendSMS.Controls.Add(this.label8);
            this.gboSendSMS.Controls.Add(this.btnSendSMS);
            this.gboSendSMS.Controls.Add(this.label9);
            this.gboSendSMS.Controls.Add(this.txtSIM);
            this.gboSendSMS.Controls.Add(this.txtMessage);
            this.gboSendSMS.Location = new System.Drawing.Point(145, 50);
            this.gboSendSMS.Name = "gboSendSMS";
            this.gboSendSMS.Size = new System.Drawing.Size(479, 352);
            this.gboSendSMS.TabIndex = 43;
            this.gboSendSMS.TabStop = false;
            this.gboSendSMS.Text = "Send SMS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Message";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(198, 297);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(75, 25);
            this.btnSendSMS.TabIndex = 40;
            this.btnSendSMS.Text = "Send";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Phone number";
            // 
            // txtSIM
            // 
            this.txtSIM.Location = new System.Drawing.Point(185, 62);
            this.txtSIM.MaxLength = 15;
            this.txtSIM.Name = "txtSIM";
            this.txtSIM.Size = new System.Drawing.Size(118, 20);
            this.txtSIM.TabIndex = 41;
            this.txtSIM.Text = "+33";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(75, 131);
            this.txtMessage.MaxLength = 160;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(323, 134);
            this.txtMessage.TabIndex = 39;
            // 
            // tbReadSMS
            // 
            this.tbReadSMS.Controls.Add(this.gboReadSMS);
            this.tbReadSMS.Location = new System.Drawing.Point(4, 22);
            this.tbReadSMS.Name = "tbReadSMS";
            this.tbReadSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbReadSMS.Size = new System.Drawing.Size(765, 472);
            this.tbReadSMS.TabIndex = 2;
            this.tbReadSMS.Text = "Read SMS";
            this.tbReadSMS.UseVisualStyleBackColor = true;
            // 
            // gboReadSMS
            // 
            this.gboReadSMS.Controls.Add(this.rbReadStoreUnSent);
            this.gboReadSMS.Controls.Add(this.rbReadStoreSent);
            this.gboReadSMS.Controls.Add(this.rbReadUnRead);
            this.gboReadSMS.Controls.Add(this.rbReadAll);
            this.gboReadSMS.Controls.Add(this.btnReadSMS);
            this.gboReadSMS.Controls.Add(this.lvwMessages);
            this.gboReadSMS.Location = new System.Drawing.Point(144, 60);
            this.gboReadSMS.Name = "gboReadSMS";
            this.gboReadSMS.Size = new System.Drawing.Size(481, 347);
            this.gboReadSMS.TabIndex = 43;
            this.gboReadSMS.TabStop = false;
            this.gboReadSMS.Text = "Read SMS";
            // 
            // rbReadStoreUnSent
            // 
            this.rbReadStoreUnSent.AutoSize = true;
            this.rbReadStoreUnSent.Location = new System.Drawing.Point(191, 53);
            this.rbReadStoreUnSent.Name = "rbReadStoreUnSent";
            this.rbReadStoreUnSent.Size = new System.Drawing.Size(144, 17);
            this.rbReadStoreUnSent.TabIndex = 48;
            this.rbReadStoreUnSent.Text = "Read Store UnSent SMS";
            this.rbReadStoreUnSent.UseVisualStyleBackColor = true;
            // 
            // rbReadStoreSent
            // 
            this.rbReadStoreSent.AutoSize = true;
            this.rbReadStoreSent.Location = new System.Drawing.Point(191, 30);
            this.rbReadStoreSent.Name = "rbReadStoreSent";
            this.rbReadStoreSent.Size = new System.Drawing.Size(130, 17);
            this.rbReadStoreSent.TabIndex = 47;
            this.rbReadStoreSent.Text = "Read Store Sent SMS";
            this.rbReadStoreSent.UseVisualStyleBackColor = true;
            // 
            // rbReadUnRead
            // 
            this.rbReadUnRead.AutoSize = true;
            this.rbReadUnRead.Location = new System.Drawing.Point(24, 53);
            this.rbReadUnRead.Name = "rbReadUnRead";
            this.rbReadUnRead.Size = new System.Drawing.Size(120, 17);
            this.rbReadUnRead.TabIndex = 45;
            this.rbReadUnRead.Text = "Read UnRead SMS";
            this.rbReadUnRead.UseVisualStyleBackColor = true;
            // 
            // rbReadAll
            // 
            this.rbReadAll.AutoSize = true;
            this.rbReadAll.Location = new System.Drawing.Point(24, 30);
            this.rbReadAll.Name = "rbReadAll";
            this.rbReadAll.Size = new System.Drawing.Size(91, 17);
            this.rbReadAll.TabIndex = 44;
            this.rbReadAll.Text = "Read All SMS";
            this.rbReadAll.UseVisualStyleBackColor = true;
            // 
            // btnReadSMS
            // 
            this.btnReadSMS.Location = new System.Drawing.Point(203, 300);
            this.btnReadSMS.Name = "btnReadSMS";
            this.btnReadSMS.Size = new System.Drawing.Size(75, 25);
            this.btnReadSMS.TabIndex = 41;
            this.btnReadSMS.Text = "Read";
            this.btnReadSMS.UseVisualStyleBackColor = true;
            this.btnReadSMS.Click += new System.EventHandler(this.btnReadSMS_Click);
            // 
            // lvwMessages
            // 
            this.lvwMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colSentTime,
            this.colSender,
            this.colMessage});
            this.lvwMessages.FullRowSelect = true;
            this.lvwMessages.Location = new System.Drawing.Point(16, 127);
            this.lvwMessages.MultiSelect = false;
            this.lvwMessages.Name = "lvwMessages";
            this.lvwMessages.Size = new System.Drawing.Size(448, 152);
            this.lvwMessages.TabIndex = 38;
            this.lvwMessages.UseCompatibleStateImageBehavior = false;
            this.lvwMessages.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            this.colIndex.Width = 43;
            // 
            // colSentTime
            // 
            this.colSentTime.Text = "SentTime";
            this.colSentTime.Width = 69;
            // 
            // colSender
            // 
            this.colSender.Text = "Sender";
            this.colSender.Width = 50;
            // 
            // colMessage
            // 
            this.colMessage.Text = "Message";
            this.colMessage.Width = 275;
            // 
            // tbDeleteSMS
            // 
            this.tbDeleteSMS.Controls.Add(this.groupBox1);
            this.tbDeleteSMS.Controls.Add(this.gboDeleteSMS);
            this.tbDeleteSMS.Location = new System.Drawing.Point(4, 22);
            this.tbDeleteSMS.Name = "tbDeleteSMS";
            this.tbDeleteSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeleteSMS.Size = new System.Drawing.Size(765, 472);
            this.tbDeleteSMS.TabIndex = 3;
            this.tbDeleteSMS.Text = "Delete SMS";
            this.tbDeleteSMS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCountSMS);
            this.groupBox1.Controls.Add(this.txtCountSMS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(167, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 96);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count SMS";
            // 
            // btnCountSMS
            // 
            this.btnCountSMS.Location = new System.Drawing.Point(149, 55);
            this.btnCountSMS.Name = "btnCountSMS";
            this.btnCountSMS.Size = new System.Drawing.Size(75, 25);
            this.btnCountSMS.TabIndex = 46;
            this.btnCountSMS.Text = "Count";
            this.btnCountSMS.UseVisualStyleBackColor = true;
            this.btnCountSMS.Click += new System.EventHandler(this.btnCountSMS_Click);
            // 
            // txtCountSMS
            // 
            this.txtCountSMS.Location = new System.Drawing.Point(80, 26);
            this.txtCountSMS.Name = "txtCountSMS";
            this.txtCountSMS.ReadOnly = true;
            this.txtCountSMS.Size = new System.Drawing.Size(34, 20);
            this.txtCountSMS.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Count SMS";
            // 
            // gboDeleteSMS
            // 
            this.gboDeleteSMS.Controls.Add(this.rbDeleteReadSMS);
            this.gboDeleteSMS.Controls.Add(this.btnDeleteSMS);
            this.gboDeleteSMS.Controls.Add(this.rbDeleteAllSMS);
            this.gboDeleteSMS.Location = new System.Drawing.Point(167, 206);
            this.gboDeleteSMS.Name = "gboDeleteSMS";
            this.gboDeleteSMS.Size = new System.Drawing.Size(375, 153);
            this.gboDeleteSMS.TabIndex = 44;
            this.gboDeleteSMS.TabStop = false;
            this.gboDeleteSMS.Text = "Delete SMS";
            // 
            // rbDeleteReadSMS
            // 
            this.rbDeleteReadSMS.AutoSize = true;
            this.rbDeleteReadSMS.Checked = true;
            this.rbDeleteReadSMS.Location = new System.Drawing.Point(16, 58);
            this.rbDeleteReadSMS.Name = "rbDeleteReadSMS";
            this.rbDeleteReadSMS.Size = new System.Drawing.Size(114, 17);
            this.rbDeleteReadSMS.TabIndex = 45;
            this.rbDeleteReadSMS.TabStop = true;
            this.rbDeleteReadSMS.Text = "Delete Read SMS ";
            this.rbDeleteReadSMS.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSMS
            // 
            this.btnDeleteSMS.Location = new System.Drawing.Point(149, 111);
            this.btnDeleteSMS.Name = "btnDeleteSMS";
            this.btnDeleteSMS.Size = new System.Drawing.Size(75, 25);
            this.btnDeleteSMS.TabIndex = 42;
            this.btnDeleteSMS.Text = "Delete";
            this.btnDeleteSMS.UseVisualStyleBackColor = true;
            this.btnDeleteSMS.Click += new System.EventHandler(this.btnDeleteSMS_Click);
            // 
            // rbDeleteAllSMS
            // 
            this.rbDeleteAllSMS.AutoSize = true;
            this.rbDeleteAllSMS.Location = new System.Drawing.Point(16, 26);
            this.rbDeleteAllSMS.Name = "rbDeleteAllSMS";
            this.rbDeleteAllSMS.Size = new System.Drawing.Size(96, 17);
            this.rbDeleteAllSMS.TabIndex = 43;
            this.rbDeleteAllSMS.Text = "Delete All SMS";
            this.rbDeleteAllSMS.UseVisualStyleBackColor = true;
            // 
            // tbRequestSMS
            // 
            this.tbRequestSMS.Controls.Add(this.lblMsgView);
            this.tbRequestSMS.Controls.Add(this.groupBox2);
            this.tbRequestSMS.Location = new System.Drawing.Point(4, 22);
            this.tbRequestSMS.Name = "tbRequestSMS";
            this.tbRequestSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tbRequestSMS.Size = new System.Drawing.Size(765, 472);
            this.tbRequestSMS.TabIndex = 4;
            this.tbRequestSMS.Text = "Request SMS";
            this.tbRequestSMS.UseVisualStyleBackColor = true;
            // 
            // lblMsgView
            // 
            this.lblMsgView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgView.Location = new System.Drawing.Point(28, 452);
            this.lblMsgView.Name = "lblMsgView";
            this.lblMsgView.Size = new System.Drawing.Size(700, 15);
            this.lblMsgView.TabIndex = 1;
            this.lblMsgView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCurrentPortError);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.labelCurrentPort);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.countSMSnok);
            this.groupBox2.Controls.Add(this.countSMSok);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnRequestStop);
            this.groupBox2.Controls.Add(this.btnRequestStart);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(20, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 433);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request SMS";
            // 
            // labelCurrentPortError
            // 
            this.labelCurrentPortError.AutoSize = true;
            this.labelCurrentPortError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPortError.Location = new System.Drawing.Point(269, 297);
            this.labelCurrentPortError.Name = "labelCurrentPortError";
            this.labelCurrentPortError.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentPortError.TabIndex = 10;
            this.labelCurrentPortError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSimStatusErrors);
            this.groupBox4.Controls.Add(this.lblSimStatus);
            this.groupBox4.Controls.Add(this.lblSimStatusName);
            this.groupBox4.Location = new System.Drawing.Point(204, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 99);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Sim status ";
            // 
            // lblSimStatusErrors
            // 
            this.lblSimStatusErrors.AutoSize = true;
            this.lblSimStatusErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimStatusErrors.Location = new System.Drawing.Point(208, 24);
            this.lblSimStatusErrors.Name = "lblSimStatusErrors";
            this.lblSimStatusErrors.Size = new System.Drawing.Size(0, 15);
            this.lblSimStatusErrors.TabIndex = 2;
            // 
            // lblSimStatus
            // 
            this.lblSimStatus.AutoSize = true;
            this.lblSimStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimStatus.Location = new System.Drawing.Point(139, 24);
            this.lblSimStatus.Name = "lblSimStatus";
            this.lblSimStatus.Size = new System.Drawing.Size(0, 15);
            this.lblSimStatus.TabIndex = 1;
            // 
            // lblSimStatusName
            // 
            this.lblSimStatusName.AutoSize = true;
            this.lblSimStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimStatusName.Location = new System.Drawing.Point(44, 24);
            this.lblSimStatusName.Name = "lblSimStatusName";
            this.lblSimStatusName.Size = new System.Drawing.Size(0, 15);
            this.lblSimStatusName.TabIndex = 0;
            // 
            // labelCurrentPort
            // 
            this.labelCurrentPort.AutoSize = true;
            this.labelCurrentPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPort.ForeColor = System.Drawing.Color.Black;
            this.labelCurrentPort.Location = new System.Drawing.Point(314, 264);
            this.labelCurrentPort.Name = "labelCurrentPort";
            this.labelCurrentPort.Size = new System.Drawing.Size(0, 17);
            this.labelCurrentPort.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(294, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Current port:";
            // 
            // countSMSnok
            // 
            this.countSMSnok.AutoSize = true;
            this.countSMSnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSMSnok.ForeColor = System.Drawing.Color.Red;
            this.countSMSnok.Location = new System.Drawing.Point(592, 264);
            this.countSMSnok.Name = "countSMSnok";
            this.countSMSnok.Size = new System.Drawing.Size(16, 17);
            this.countSMSnok.TabIndex = 6;
            this.countSMSnok.Text = "0";
            // 
            // countSMSok
            // 
            this.countSMSok.AutoSize = true;
            this.countSMSok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSMSok.ForeColor = System.Drawing.Color.Green;
            this.countSMSok.Location = new System.Drawing.Point(99, 264);
            this.countSMSok.Name = "countSMSok";
            this.countSMSok.Size = new System.Drawing.Size(16, 17);
            this.countSMSok.TabIndex = 5;
            this.countSMSok.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(527, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "SMS non envoy�:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(69, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "SMS envoy�:";
            // 
            // btnRequestStop
            // 
            this.btnRequestStop.Location = new System.Drawing.Point(556, 327);
            this.btnRequestStop.Name = "btnRequestStop";
            this.btnRequestStop.Size = new System.Drawing.Size(75, 23);
            this.btnRequestStop.TabIndex = 2;
            this.btnRequestStop.Text = "Stop";
            this.btnRequestStop.UseVisualStyleBackColor = true;
            this.btnRequestStop.Click += new System.EventHandler(this.btnRequestStop_Click);
            // 
            // btnRequestStart
            // 
            this.btnRequestStart.Location = new System.Drawing.Point(72, 327);
            this.btnRequestStart.Name = "btnRequestStart";
            this.btnRequestStart.Size = new System.Drawing.Size(75, 23);
            this.btnRequestStart.TabIndex = 1;
            this.btnRequestStart.Text = "Start";
            this.btnRequestStart.UseVisualStyleBackColor = true;
            this.btnRequestStart.Click += new System.EventHandler(this.btnRequestStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nbErrorToSwitch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.intervalSendSMS);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.urlChecker);
            this.groupBox3.Location = new System.Drawing.Point(27, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 152);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Url Checker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send SMS interval (second)";
            // 
            // intervalSendSMS
            // 
            this.intervalSendSMS.Location = new System.Drawing.Point(185, 112);
            this.intervalSendSMS.Name = "intervalSendSMS";
            this.intervalSendSMS.Size = new System.Drawing.Size(43, 20);
            this.intervalSendSMS.TabIndex = 2;
            this.intervalSendSMS.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Set the url to donwload Json";
            // 
            // urlChecker
            // 
            this.urlChecker.Location = new System.Drawing.Point(135, 49);
            this.urlChecker.Name = "urlChecker";
            this.urlChecker.Size = new System.Drawing.Size(372, 20);
            this.urlChecker.TabIndex = 0;
            this.urlChecker.Text = "http://mywebsite.com/api/smsStatus.php?state=nok";
            // 
            // gboConnectionStatus
            // 
            this.gboConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.gboConnectionStatus.Controls.Add(this.label23);
            this.gboConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.gboConnectionStatus.Controls.Add(this.btnDisconnect);
            this.gboConnectionStatus.Location = new System.Drawing.Point(185, 519);
            this.gboConnectionStatus.Name = "gboConnectionStatus";
            this.gboConnectionStatus.Size = new System.Drawing.Size(361, 56);
            this.gboConnectionStatus.TabIndex = 41;
            this.gboConnectionStatus.TabStop = false;
            this.gboConnectionStatus.Text = "Connection Status";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Connection Status :";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(25, 32);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.lblConnectionStatus.TabIndex = 36;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(259, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 25);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.statusBar1.Location = new System.Drawing.Point(0, 589);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(802, 20);
            this.statusBar1.TabIndex = 75;
            this.statusBar1.Text = "Message";
            // 
            // nbErrorToSwitch
            // 
            this.nbErrorToSwitch.Location = new System.Drawing.Point(396, 112);
            this.nbErrorToSwitch.Name = "nbErrorToSwitch";
            this.nbErrorToSwitch.Size = new System.Drawing.Size(42, 20);
            this.nbErrorToSwitch.TabIndex = 4;
            this.nbErrorToSwitch.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(352, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Numbers of errors to switch";
            // 
            // SMSapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 609);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.gboConnectionStatus);
            this.Controls.Add(this.tabSMSapplication);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SMSapplication";
            this.Text = "Texto-SMS-Gratuit";
            this.Load += new System.EventHandler(this.SMSapplication_Load);
            this.tabSMSapplication.ResumeLayout(false);
            this.tbPortSettings.ResumeLayout(false);
            this.gboPortSettings.ResumeLayout(false);
            this.gboPortSettings.PerformLayout();
            this.groupBox1Port.ResumeLayout(false);
            this.groupBox1Port.PerformLayout();
            this.groupBox2Ports.ResumeLayout(false);
            this.groupBox2Ports.PerformLayout();
            this.groupBox4Ports.ResumeLayout(false);
            this.groupBox4Ports.PerformLayout();
            this.tbSendSMS.ResumeLayout(false);
            this.gboSendSMS.ResumeLayout(false);
            this.gboSendSMS.PerformLayout();
            this.tbReadSMS.ResumeLayout(false);
            this.gboReadSMS.ResumeLayout(false);
            this.gboReadSMS.PerformLayout();
            this.tbDeleteSMS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboDeleteSMS.ResumeLayout(false);
            this.gboDeleteSMS.PerformLayout();
            this.tbRequestSMS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSendSMS)).EndInit();
            this.gboConnectionStatus.ResumeLayout(false);
            this.gboConnectionStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbErrorToSwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSMSapplication;
        private System.Windows.Forms.TabPage tbPortSettings;
        private System.Windows.Forms.TabPage tbSendSMS;
        private System.Windows.Forms.TabPage tbReadSMS;
        private System.Windows.Forms.TabPage tbDeleteSMS;
        private System.Windows.Forms.GroupBox gboPortSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWriteTimeOut;
        private System.Windows.Forms.TextBox txtReadTimeOut;
        private System.Windows.Forms.ComboBox cboParityBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gboSendSMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSIM;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.GroupBox gboReadSMS;
        private System.Windows.Forms.Button btnReadSMS;
        private System.Windows.Forms.ListView lvwMessages;
        private System.Windows.Forms.ColumnHeader colSender;
        private System.Windows.Forms.ColumnHeader colMessage;
        private System.Windows.Forms.GroupBox gboConnectionStatus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnDeleteSMS;
        private System.Windows.Forms.GroupBox gboDeleteSMS;
        private System.Windows.Forms.RadioButton rbDeleteAllSMS;
        private System.Windows.Forms.RadioButton rbDeleteReadSMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCountSMS;
        private System.Windows.Forms.TextBox txtCountSMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.RadioButton rbReadUnRead;
        private System.Windows.Forms.RadioButton rbReadAll;
        private System.Windows.Forms.RadioButton rbReadStoreUnSent;
        private System.Windows.Forms.RadioButton rbReadStoreSent;
        private System.Windows.Forms.ColumnHeader colSentTime;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.TabPage tbRequestSMS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urlChecker;
        private System.Windows.Forms.Button btnRequestStop;
        private System.Windows.Forms.Button btnRequestStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label countSMSnok;
        private System.Windows.Forms.Label countSMSok;
        private System.Windows.Forms.CheckBox checkBPort1;
        private System.Windows.Forms.Label labelCurrentPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4Ports;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboPortName4P1;
        private System.Windows.Forms.ComboBox cboPortName4P4;
        private System.Windows.Forms.ComboBox cboPortName4P3;
        private System.Windows.Forms.ComboBox cboPortName4P2;
        private System.Windows.Forms.GroupBox groupBox2Ports;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboPortName2P1;
        private System.Windows.Forms.ComboBox cboPortName2P2;
        private System.Windows.Forms.GroupBox groupBox1Port;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox checkBPort2;
        private System.Windows.Forms.CheckBox checkBPort4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalSendSMS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSimStatusName;
        private System.Windows.Forms.Label lblSimStatus;
        private System.Windows.Forms.Label lblSimStatusErrors;
        private System.Windows.Forms.Label labelCurrentPortError;
        private System.Windows.Forms.Label lblMsgView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nbErrorToSwitch;
    }
}

