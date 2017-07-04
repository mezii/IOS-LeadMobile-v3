namespace IOS_LeadMobile
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabRRS = new System.Windows.Forms.TabPage();
            this.taboffer = new System.Windows.Forms.TabPage();
            this.tabScript = new System.Windows.Forms.TabPage();
            this.tabSupport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.IPOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeoOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScriptOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TracklinkOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.btnStartHome = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.IPHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvertionHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddScript = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgvScript = new System.Windows.Forms.DataGridView();
            this.DirScript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnStartRRS = new System.Windows.Forms.Button();
            this.btnStopRRS = new System.Windows.Forms.Button();
            this.DirRRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppRRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIPRRS = new System.Windows.Forms.ComboBox();
            this.cbAppRRS = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.IPRRRR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtIpSupport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnWipeSupport = new System.Windows.Forms.Button();
            this.btndeviceSupport = new System.Windows.Forms.Button();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.btnInstallApp = new System.Windows.Forms.Button();
            this.btnBackupSupport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabRRS.SuspendLayout();
            this.taboffer.SuspendLayout();
            this.tabScript.SuspendLayout();
            this.tabSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabRRS);
            this.tabControl1.Controls.Add(this.taboffer);
            this.tabControl1.Controls.Add(this.tabScript);
            this.tabControl1.Controls.Add(this.tabSupport);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.btnStop);
            this.tabHome.Controls.Add(this.btnStartHome);
            this.tabHome.Controls.Add(this.dgvHome);
            this.tabHome.Location = new System.Drawing.Point(4, 28);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(948, 644);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabRRS
            // 
            this.tabRRS.Controls.Add(this.btnRestore);
            this.tabRRS.Controls.Add(this.label9);
            this.tabRRS.Controls.Add(this.label8);
            this.tabRRS.Controls.Add(this.IPRRRR);
            this.tabRRS.Controls.Add(this.comboBox3);
            this.tabRRS.Controls.Add(this.cbAppRRS);
            this.tabRRS.Controls.Add(this.cbIPRRS);
            this.tabRRS.Controls.Add(this.btnStopRRS);
            this.tabRRS.Controls.Add(this.btnStartRRS);
            this.tabRRS.Controls.Add(this.dataGridView2);
            this.tabRRS.Location = new System.Drawing.Point(4, 28);
            this.tabRRS.Name = "tabRRS";
            this.tabRRS.Padding = new System.Windows.Forms.Padding(3);
            this.tabRRS.Size = new System.Drawing.Size(948, 644);
            this.tabRRS.TabIndex = 1;
            this.tabRRS.Text = "RRS";
            this.tabRRS.UseVisualStyleBackColor = true;
            // 
            // taboffer
            // 
            this.taboffer.Controls.Add(this.comboBox2);
            this.taboffer.Controls.Add(this.comboBox1);
            this.taboffer.Controls.Add(this.button3);
            this.taboffer.Controls.Add(this.button2);
            this.taboffer.Controls.Add(this.button1);
            this.taboffer.Controls.Add(this.textBox6);
            this.taboffer.Controls.Add(this.textBox4);
            this.taboffer.Controls.Add(this.textBox3);
            this.taboffer.Controls.Add(this.textBox1);
            this.taboffer.Controls.Add(this.label6);
            this.taboffer.Controls.Add(this.label5);
            this.taboffer.Controls.Add(this.label4);
            this.taboffer.Controls.Add(this.label3);
            this.taboffer.Controls.Add(this.label2);
            this.taboffer.Controls.Add(this.label1);
            this.taboffer.Controls.Add(this.dataGridView1);
            this.taboffer.Location = new System.Drawing.Point(4, 28);
            this.taboffer.Name = "taboffer";
            this.taboffer.Padding = new System.Windows.Forms.Padding(3);
            this.taboffer.Size = new System.Drawing.Size(948, 644);
            this.taboffer.TabIndex = 2;
            this.taboffer.Text = "Offer";
            this.taboffer.UseVisualStyleBackColor = true;
            // 
            // tabScript
            // 
            this.tabScript.Controls.Add(this.dgvScript);
            this.tabScript.Controls.Add(this.richTextBox1);
            this.tabScript.Controls.Add(this.textBox2);
            this.tabScript.Controls.Add(this.btnAddScript);
            this.tabScript.Location = new System.Drawing.Point(4, 28);
            this.tabScript.Name = "tabScript";
            this.tabScript.Padding = new System.Windows.Forms.Padding(3);
            this.tabScript.Size = new System.Drawing.Size(948, 644);
            this.tabScript.TabIndex = 3;
            this.tabScript.Text = "Script";
            this.tabScript.UseVisualStyleBackColor = true;
            // 
            // tabSupport
            // 
            this.tabSupport.Controls.Add(this.textBox8);
            this.tabSupport.Controls.Add(this.label12);
            this.tabSupport.Controls.Add(this.btnBackupSupport);
            this.tabSupport.Controls.Add(this.btnInstallApp);
            this.tabSupport.Controls.Add(this.btnOpenUrl);
            this.tabSupport.Controls.Add(this.btndeviceSupport);
            this.tabSupport.Controls.Add(this.btnWipeSupport);
            this.tabSupport.Controls.Add(this.textBox7);
            this.tabSupport.Controls.Add(this.label11);
            this.tabSupport.Controls.Add(this.textBox5);
            this.tabSupport.Controls.Add(this.label10);
            this.tabSupport.Controls.Add(this.label7);
            this.tabSupport.Controls.Add(this.txtIpSupport);
            this.tabSupport.Location = new System.Drawing.Point(4, 28);
            this.tabSupport.Name = "tabSupport";
            this.tabSupport.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupport.Size = new System.Drawing.Size(948, 644);
            this.tabSupport.TabIndex = 4;
            this.tabSupport.Text = "Support";
            this.tabSupport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPOffer,
            this.AppOffer,
            this.GeoOffer,
            this.ProxyOffer,
            this.ScriptOffer,
            this.TracklinkOffer});
            this.dataGridView1.Location = new System.Drawing.Point(403, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 638);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "App:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Geo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proxy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Script:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tracklink:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(293, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 235);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(293, 77);
            this.textBox6.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Refesh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 27);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(293, 27);
            this.comboBox2.TabIndex = 17;
            // 
            // IPOffer
            // 
            this.IPOffer.HeaderText = "IP";
            this.IPOffer.Name = "IPOffer";
            this.IPOffer.Width = 120;
            // 
            // AppOffer
            // 
            this.AppOffer.HeaderText = "App";
            this.AppOffer.Name = "AppOffer";
            this.AppOffer.Width = 80;
            // 
            // GeoOffer
            // 
            this.GeoOffer.HeaderText = "Geo";
            this.GeoOffer.Name = "GeoOffer";
            this.GeoOffer.Width = 50;
            // 
            // ProxyOffer
            // 
            this.ProxyOffer.HeaderText = "Proxy";
            this.ProxyOffer.Name = "ProxyOffer";
            this.ProxyOffer.Width = 80;
            // 
            // ScriptOffer
            // 
            this.ScriptOffer.HeaderText = "Script";
            this.ScriptOffer.Name = "ScriptOffer";
            this.ScriptOffer.Width = 80;
            // 
            // TracklinkOffer
            // 
            this.TracklinkOffer.HeaderText = "Tracklink";
            this.TracklinkOffer.Name = "TracklinkOffer";
            this.TracklinkOffer.Width = 180;
            // 
            // dgvHome
            // 
            this.dgvHome.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPHome,
            this.AppHome,
            this.ConvertionHome,
            this.FailHome,
            this.StatusHome});
            this.dgvHome.Location = new System.Drawing.Point(0, 0);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.Size = new System.Drawing.Size(945, 522);
            this.dgvHome.TabIndex = 0;
            // 
            // btnStartHome
            // 
            this.btnStartHome.Location = new System.Drawing.Point(381, 545);
            this.btnStartHome.Name = "btnStartHome";
            this.btnStartHome.Size = new System.Drawing.Size(75, 66);
            this.btnStartHome.TabIndex = 1;
            this.btnStartHome.Text = "Start";
            this.btnStartHome.UseVisualStyleBackColor = true;
            this.btnStartHome.Click += new System.EventHandler(this.btnStartHome_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(503, 545);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 66);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // IPHome
            // 
            this.IPHome.HeaderText = "IP";
            this.IPHome.Name = "IPHome";
            this.IPHome.Width = 160;
            // 
            // AppHome
            // 
            this.AppHome.HeaderText = "App";
            this.AppHome.Name = "AppHome";
            this.AppHome.Width = 140;
            // 
            // ConvertionHome
            // 
            this.ConvertionHome.HeaderText = "Convertion";
            this.ConvertionHome.Name = "ConvertionHome";
            // 
            // FailHome
            // 
            this.FailHome.HeaderText = "Fail";
            this.FailHome.Name = "FailHome";
            // 
            // StatusHome
            // 
            this.StatusHome.HeaderText = "Status";
            this.StatusHome.Name = "StatusHome";
            this.StatusHome.Width = 400;
            // 
            // btnAddScript
            // 
            this.btnAddScript.Location = new System.Drawing.Point(426, 6);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(75, 26);
            this.btnAddScript.TabIndex = 0;
            this.btnAddScript.Text = "Add";
            this.btnAddScript.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 26);
            this.textBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 603);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // dgvScript
            // 
            this.dgvScript.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScript.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirScript});
            this.dgvScript.Location = new System.Drawing.Point(507, 38);
            this.dgvScript.Name = "dgvScript";
            this.dgvScript.Size = new System.Drawing.Size(438, 600);
            this.dgvScript.TabIndex = 3;
            // 
            // DirScript
            // 
            this.DirScript.HeaderText = "Dir Script";
            this.DirScript.Name = "DirScript";
            this.DirScript.Width = 500;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirRRS,
            this.AppRRS,
            this.DateRRS,
            this.TotalRRS});
            this.dataGridView2.Location = new System.Drawing.Point(3, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(942, 531);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnStartRRS
            // 
            this.btnStartRRS.Location = new System.Drawing.Point(322, 39);
            this.btnStartRRS.Name = "btnStartRRS";
            this.btnStartRRS.Size = new System.Drawing.Size(75, 60);
            this.btnStartRRS.TabIndex = 1;
            this.btnStartRRS.Text = "Start";
            this.btnStartRRS.UseVisualStyleBackColor = true;
            // 
            // btnStopRRS
            // 
            this.btnStopRRS.Location = new System.Drawing.Point(435, 39);
            this.btnStopRRS.Name = "btnStopRRS";
            this.btnStopRRS.Size = new System.Drawing.Size(75, 60);
            this.btnStopRRS.TabIndex = 2;
            this.btnStopRRS.Text = "Stop";
            this.btnStopRRS.UseVisualStyleBackColor = true;
            // 
            // DirRRS
            // 
            this.DirRRS.HeaderText = "Dir";
            this.DirRRS.Name = "DirRRS";
            this.DirRRS.Width = 444;
            // 
            // AppRRS
            // 
            this.AppRRS.HeaderText = "App";
            this.AppRRS.Name = "AppRRS";
            this.AppRRS.Width = 150;
            // 
            // DateRRS
            // 
            this.DateRRS.HeaderText = "Date";
            this.DateRRS.Name = "DateRRS";
            this.DateRRS.Width = 150;
            // 
            // TotalRRS
            // 
            this.TotalRRS.HeaderText = "Total";
            this.TotalRRS.Name = "TotalRRS";
            this.TotalRRS.Width = 150;
            // 
            // cbIPRRS
            // 
            this.cbIPRRS.FormattingEnabled = true;
            this.cbIPRRS.Location = new System.Drawing.Point(55, 6);
            this.cbIPRRS.Name = "cbIPRRS";
            this.cbIPRRS.Size = new System.Drawing.Size(198, 27);
            this.cbIPRRS.TabIndex = 3;
            // 
            // cbAppRRS
            // 
            this.cbAppRRS.FormattingEnabled = true;
            this.cbAppRRS.Location = new System.Drawing.Point(55, 39);
            this.cbAppRRS.Name = "cbAppRRS";
            this.cbAppRRS.Size = new System.Drawing.Size(198, 27);
            this.cbAppRRS.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(55, 72);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 27);
            this.comboBox3.TabIndex = 5;
            // 
            // IPRRRR
            // 
            this.IPRRRR.AutoSize = true;
            this.IPRRRR.Location = new System.Drawing.Point(4, 14);
            this.IPRRRR.Name = "IPRRRR";
            this.IPRRRR.Size = new System.Drawing.Size(23, 19);
            this.IPRRRR.TabIndex = 6;
            this.IPRRRR.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "App";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Script";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(544, 39);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(73, 60);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // txtIpSupport
            // 
            this.txtIpSupport.Location = new System.Drawing.Point(98, 18);
            this.txtIpSupport.Name = "txtIpSupport";
            this.txtIpSupport.Size = new System.Drawing.Size(243, 26);
            this.txtIpSupport.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "IP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tracklink:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(98, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(489, 26);
            this.textBox5.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "App:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(98, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(243, 26);
            this.textBox7.TabIndex = 5;
            // 
            // btnWipeSupport
            // 
            this.btnWipeSupport.Location = new System.Drawing.Point(21, 169);
            this.btnWipeSupport.Name = "btnWipeSupport";
            this.btnWipeSupport.Size = new System.Drawing.Size(75, 51);
            this.btnWipeSupport.TabIndex = 6;
            this.btnWipeSupport.Text = "Wipe";
            this.btnWipeSupport.UseVisualStyleBackColor = true;
            // 
            // btndeviceSupport
            // 
            this.btndeviceSupport.Location = new System.Drawing.Point(140, 169);
            this.btndeviceSupport.Name = "btndeviceSupport";
            this.btndeviceSupport.Size = new System.Drawing.Size(75, 51);
            this.btndeviceSupport.TabIndex = 7;
            this.btndeviceSupport.Text = "Change Device";
            this.btndeviceSupport.UseVisualStyleBackColor = true;
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Location = new System.Drawing.Point(266, 169);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(75, 51);
            this.btnOpenUrl.TabIndex = 8;
            this.btnOpenUrl.Text = "Open Url";
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            // 
            // btnInstallApp
            // 
            this.btnInstallApp.Location = new System.Drawing.Point(393, 169);
            this.btnInstallApp.Name = "btnInstallApp";
            this.btnInstallApp.Size = new System.Drawing.Size(75, 51);
            this.btnInstallApp.TabIndex = 9;
            this.btnInstallApp.Text = "Install App";
            this.btnInstallApp.UseVisualStyleBackColor = true;
            // 
            // btnBackupSupport
            // 
            this.btnBackupSupport.Location = new System.Drawing.Point(512, 169);
            this.btnBackupSupport.Name = "btnBackupSupport";
            this.btnBackupSupport.Size = new System.Drawing.Size(75, 51);
            this.btnBackupSupport.TabIndex = 10;
            this.btnBackupSupport.Text = "Backup";
            this.btnBackupSupport.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Proxy:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(98, 54);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(243, 26);
            this.textBox8.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 677);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabRRS.ResumeLayout(false);
            this.tabRRS.PerformLayout();
            this.taboffer.ResumeLayout(false);
            this.taboffer.PerformLayout();
            this.tabScript.ResumeLayout(false);
            this.tabScript.PerformLayout();
            this.tabSupport.ResumeLayout(false);
            this.tabSupport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabRRS;
        private System.Windows.Forms.TabPage taboffer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabScript;
        private System.Windows.Forms.TabPage tabSupport;
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeoOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScriptOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TracklinkOffer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStartHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvertionHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusHome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirScript;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAddScript;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IPRRRR;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbAppRRS;
        private System.Windows.Forms.ComboBox cbIPRRS;
        private System.Windows.Forms.Button btnStopRRS;
        private System.Windows.Forms.Button btnStartRRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirRRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppRRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRRS;
        private System.Windows.Forms.Button btnBackupSupport;
        private System.Windows.Forms.Button btnInstallApp;
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.Button btndeviceSupport;
        private System.Windows.Forms.Button btnWipeSupport;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIpSupport;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
    }
}

