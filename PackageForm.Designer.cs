namespace ShippingProject
{
    partial class PackageForm
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
            this.components = new System.ComponentModel.Container();
            this.cmbBxCompany = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOvernight = new System.Windows.Forms.RadioButton();
            this.radTwoDay = new System.Windows.Forms.RadioButton();
            this.radStanderd = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSendZipAst = new System.Windows.Forms.Label();
            this.lblSendStateAst = new System.Windows.Forms.Label();
            this.lblSendCityAst = new System.Windows.Forms.Label();
            this.lblSendAddAst = new System.Windows.Forms.Label();
            this.lblLoadBar = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.lblSendNameAst = new System.Windows.Forms.Label();
            this.txtSenderZip = new System.Windows.Forms.TextBox();
            this.txtSenderState = new System.Windows.Forms.TextBox();
            this.txtSenderCity = new System.Windows.Forms.TextBox();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRecZipAst = new System.Windows.Forms.Label();
            this.lblRecStateAst = new System.Windows.Forms.Label();
            this.lblRecCityAst = new System.Windows.Forms.Label();
            this.lblRecAddAst = new System.Windows.Forms.Label();
            this.lblRecNameAst = new System.Windows.Forms.Label();
            this.txtRecipZip = new System.Windows.Forms.TextBox();
            this.txtRecipState = new System.Windows.Forms.TextBox();
            this.txtRecipCity = new System.Windows.Forms.TextBox();
            this.txtRecipAddress = new System.Windows.Forms.TextBox();
            this.txtRecipName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShipAst = new System.Windows.Forms.Label();
            this.lblWeightAst = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBxCompany
            // 
            this.cmbBxCompany.FormattingEnabled = true;
            this.cmbBxCompany.Items.AddRange(new object[] {
            "UPS",
            "FEDEX",
            "USPS"});
            this.cmbBxCompany.Location = new System.Drawing.Point(160, 28);
            this.cmbBxCompany.Name = "cmbBxCompany";
            this.cmbBxCompany.Size = new System.Drawing.Size(154, 33);
            this.cmbBxCompany.TabIndex = 0;
            this.cmbBxCompany.Text = "Choose Shipper";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOvernight);
            this.groupBox1.Controls.Add(this.radTwoDay);
            this.groupBox1.Controls.Add(this.radStanderd);
            this.groupBox1.Location = new System.Drawing.Point(357, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // radOvernight
            // 
            this.radOvernight.AutoSize = true;
            this.radOvernight.Location = new System.Drawing.Point(6, 80);
            this.radOvernight.Name = "radOvernight";
            this.radOvernight.Size = new System.Drawing.Size(141, 29);
            this.radOvernight.TabIndex = 2;
            this.radOvernight.Text = "Overnight";
            this.radOvernight.UseVisualStyleBackColor = true;
            // 
            // radTwoDay
            // 
            this.radTwoDay.AutoSize = true;
            this.radTwoDay.Location = new System.Drawing.Point(6, 52);
            this.radTwoDay.Name = "radTwoDay";
            this.radTwoDay.Size = new System.Drawing.Size(144, 29);
            this.radTwoDay.TabIndex = 1;
            this.radTwoDay.Text = "2 Day Air";
            this.radTwoDay.UseVisualStyleBackColor = true;
            // 
            // radStanderd
            // 
            this.radStanderd.AutoSize = true;
            this.radStanderd.Checked = true;
            this.radStanderd.Location = new System.Drawing.Point(6, 24);
            this.radStanderd.Name = "radStanderd";
            this.radStanderd.Size = new System.Drawing.Size(133, 29);
            this.radStanderd.TabIndex = 0;
            this.radStanderd.TabStop = true;
            this.radStanderd.Text = "Standard";
            this.radStanderd.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(160, 83);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(154, 33);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Package Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shipping Company";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(223, 511);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 40);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(443, 511);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstInvoice
            // 
            this.lstInvoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.HorizontalExtent = 1600;
            this.lstInvoice.HorizontalScrollbar = true;
            this.lstInvoice.ItemHeight = 29;
            this.lstInvoice.Location = new System.Drawing.Point(569, 33);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.ScrollAlwaysVisible = true;
            this.lstInvoice.Size = new System.Drawing.Size(473, 525);
            this.lstInvoice.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSendZipAst);
            this.groupBox2.Controls.Add(this.lblSendStateAst);
            this.groupBox2.Controls.Add(this.lblSendCityAst);
            this.groupBox2.Controls.Add(this.lblSendAddAst);
            this.groupBox2.Controls.Add(this.lblLoadBar);
            this.groupBox2.Controls.Add(this.lblPerc);
            this.groupBox2.Controls.Add(this.bar);
            this.groupBox2.Controls.Add(this.lblSendNameAst);
            this.groupBox2.Controls.Add(this.txtSenderZip);
            this.groupBox2.Controls.Add(this.txtSenderState);
            this.groupBox2.Controls.Add(this.txtSenderCity);
            this.groupBox2.Controls.Add(this.txtSenderAddress);
            this.groupBox2.Controls.Add(this.txtSenderName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender";
            // 
            // lblSendZipAst
            // 
            this.lblSendZipAst.AutoSize = true;
            this.lblSendZipAst.BackColor = System.Drawing.Color.Transparent;
            this.lblSendZipAst.ForeColor = System.Drawing.Color.Red;
            this.lblSendZipAst.Location = new System.Drawing.Point(280, 83);
            this.lblSendZipAst.Name = "lblSendZipAst";
            this.lblSendZipAst.Size = new System.Drawing.Size(24, 25);
            this.lblSendZipAst.TabIndex = 17;
            this.lblSendZipAst.Text = "*";
            this.lblSendZipAst.Visible = false;
            // 
            // lblSendStateAst
            // 
            this.lblSendStateAst.AutoSize = true;
            this.lblSendStateAst.BackColor = System.Drawing.Color.Transparent;
            this.lblSendStateAst.ForeColor = System.Drawing.Color.Red;
            this.lblSendStateAst.Location = new System.Drawing.Point(196, 80);
            this.lblSendStateAst.Name = "lblSendStateAst";
            this.lblSendStateAst.Size = new System.Drawing.Size(24, 25);
            this.lblSendStateAst.TabIndex = 14;
            this.lblSendStateAst.Text = "*";
            this.lblSendStateAst.Visible = false;
            // 
            // lblSendCityAst
            // 
            this.lblSendCityAst.AutoSize = true;
            this.lblSendCityAst.BackColor = System.Drawing.Color.Transparent;
            this.lblSendCityAst.ForeColor = System.Drawing.Color.Red;
            this.lblSendCityAst.Location = new System.Drawing.Point(20, 84);
            this.lblSendCityAst.Name = "lblSendCityAst";
            this.lblSendCityAst.Size = new System.Drawing.Size(24, 25);
            this.lblSendCityAst.TabIndex = 16;
            this.lblSendCityAst.Text = "*";
            this.lblSendCityAst.Visible = false;
            // 
            // lblSendAddAst
            // 
            this.lblSendAddAst.AutoSize = true;
            this.lblSendAddAst.BackColor = System.Drawing.Color.Transparent;
            this.lblSendAddAst.ForeColor = System.Drawing.Color.Red;
            this.lblSendAddAst.Location = new System.Drawing.Point(-5, 52);
            this.lblSendAddAst.Name = "lblSendAddAst";
            this.lblSendAddAst.Size = new System.Drawing.Size(24, 25);
            this.lblSendAddAst.TabIndex = 15;
            this.lblSendAddAst.Text = "*";
            this.lblSendAddAst.Visible = false;
            // 
            // lblLoadBar
            // 
            this.lblLoadBar.AutoSize = true;
            this.lblLoadBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoadBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoadBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLoadBar.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadBar.Location = new System.Drawing.Point(105, 5);
            this.lblLoadBar.Name = "lblLoadBar";
            this.lblLoadBar.Size = new System.Drawing.Size(314, 85);
            this.lblLoadBar.TabIndex = 5;
            this.lblLoadBar.Text = "Loading...";
            this.lblLoadBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadBar.Visible = false;
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(208, 80);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(89, 25);
            this.lblPerc.TabIndex = 14;
            this.lblPerc.Text = "label15";
            this.lblPerc.Visible = false;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.Control;
            this.bar.ForeColor = System.Drawing.Color.Green;
            this.bar.Location = new System.Drawing.Point(8, 65);
            this.bar.MarqueeAnimationSpeed = 1000;
            this.bar.Maximum = 95;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(528, 48);
            this.bar.TabIndex = 13;
            this.bar.Visible = false;
            // 
            // lblSendNameAst
            // 
            this.lblSendNameAst.AutoSize = true;
            this.lblSendNameAst.BackColor = System.Drawing.Color.Transparent;
            this.lblSendNameAst.ForeColor = System.Drawing.Color.Red;
            this.lblSendNameAst.Location = new System.Drawing.Point(2, 21);
            this.lblSendNameAst.Name = "lblSendNameAst";
            this.lblSendNameAst.Size = new System.Drawing.Size(24, 25);
            this.lblSendNameAst.TabIndex = 6;
            this.lblSendNameAst.Text = "*";
            this.lblSendNameAst.Visible = false;
            // 
            // txtSenderZip
            // 
            this.txtSenderZip.Location = new System.Drawing.Point(378, 81);
            this.txtSenderZip.Name = "txtSenderZip";
            this.txtSenderZip.Size = new System.Drawing.Size(100, 33);
            this.txtSenderZip.TabIndex = 9;
            this.txtSenderZip.Text = "65807";
            // 
            // txtSenderState
            // 
            this.txtSenderState.Location = new System.Drawing.Point(253, 80);
            this.txtSenderState.Name = "txtSenderState";
            this.txtSenderState.Size = new System.Drawing.Size(34, 33);
            this.txtSenderState.TabIndex = 8;
            this.txtSenderState.Text = "Mo";
            // 
            // txtSenderCity
            // 
            this.txtSenderCity.Location = new System.Drawing.Point(76, 81);
            this.txtSenderCity.Name = "txtSenderCity";
            this.txtSenderCity.Size = new System.Drawing.Size(121, 33);
            this.txtSenderCity.TabIndex = 7;
            this.txtSenderCity.Text = "Nixa";
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Location = new System.Drawing.Point(77, 49);
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(401, 33);
            this.txtSenderAddress.TabIndex = 6;
            this.txtSenderAddress.Text = "2029 N Wedgecrest Dr ";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(77, 18);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(210, 33);
            this.txtSenderName.TabIndex = 5;
            this.txtSenderName.Text = "Kalin Bowden";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zip Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRecZipAst);
            this.groupBox3.Controls.Add(this.lblRecStateAst);
            this.groupBox3.Controls.Add(this.lblRecCityAst);
            this.groupBox3.Controls.Add(this.lblRecAddAst);
            this.groupBox3.Controls.Add(this.lblRecNameAst);
            this.groupBox3.Controls.Add(this.txtRecipZip);
            this.groupBox3.Controls.Add(this.txtRecipState);
            this.groupBox3.Controls.Add(this.txtRecipCity);
            this.groupBox3.Controls.Add(this.txtRecipAddress);
            this.groupBox3.Controls.Add(this.txtRecipName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(9, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 133);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recipient";
            // 
            // lblRecZipAst
            // 
            this.lblRecZipAst.AutoSize = true;
            this.lblRecZipAst.BackColor = System.Drawing.Color.Transparent;
            this.lblRecZipAst.ForeColor = System.Drawing.Color.Red;
            this.lblRecZipAst.Location = new System.Drawing.Point(291, 86);
            this.lblRecZipAst.Name = "lblRecZipAst";
            this.lblRecZipAst.Size = new System.Drawing.Size(24, 25);
            this.lblRecZipAst.TabIndex = 22;
            this.lblRecZipAst.Text = "*";
            this.lblRecZipAst.Visible = false;
            // 
            // lblRecStateAst
            // 
            this.lblRecStateAst.AutoSize = true;
            this.lblRecStateAst.BackColor = System.Drawing.Color.Transparent;
            this.lblRecStateAst.ForeColor = System.Drawing.Color.Red;
            this.lblRecStateAst.Location = new System.Drawing.Point(197, 86);
            this.lblRecStateAst.Name = "lblRecStateAst";
            this.lblRecStateAst.Size = new System.Drawing.Size(24, 25);
            this.lblRecStateAst.TabIndex = 21;
            this.lblRecStateAst.Text = "*";
            this.lblRecStateAst.Visible = false;
            // 
            // lblRecCityAst
            // 
            this.lblRecCityAst.AutoSize = true;
            this.lblRecCityAst.BackColor = System.Drawing.Color.Transparent;
            this.lblRecCityAst.ForeColor = System.Drawing.Color.Red;
            this.lblRecCityAst.Location = new System.Drawing.Point(6, 86);
            this.lblRecCityAst.Name = "lblRecCityAst";
            this.lblRecCityAst.Size = new System.Drawing.Size(24, 25);
            this.lblRecCityAst.TabIndex = 20;
            this.lblRecCityAst.Text = "*";
            this.lblRecCityAst.Visible = false;
            // 
            // lblRecAddAst
            // 
            this.lblRecAddAst.AutoSize = true;
            this.lblRecAddAst.BackColor = System.Drawing.Color.Transparent;
            this.lblRecAddAst.ForeColor = System.Drawing.Color.Red;
            this.lblRecAddAst.Location = new System.Drawing.Point(-4, 56);
            this.lblRecAddAst.Name = "lblRecAddAst";
            this.lblRecAddAst.Size = new System.Drawing.Size(24, 25);
            this.lblRecAddAst.TabIndex = 19;
            this.lblRecAddAst.Text = "*";
            this.lblRecAddAst.Visible = false;
            // 
            // lblRecNameAst
            // 
            this.lblRecNameAst.AutoSize = true;
            this.lblRecNameAst.BackColor = System.Drawing.Color.Transparent;
            this.lblRecNameAst.ForeColor = System.Drawing.Color.Red;
            this.lblRecNameAst.Location = new System.Drawing.Point(6, 25);
            this.lblRecNameAst.Name = "lblRecNameAst";
            this.lblRecNameAst.Size = new System.Drawing.Size(24, 25);
            this.lblRecNameAst.TabIndex = 18;
            this.lblRecNameAst.Text = "*";
            this.lblRecNameAst.Visible = false;
            // 
            // txtRecipZip
            // 
            this.txtRecipZip.Location = new System.Drawing.Point(378, 84);
            this.txtRecipZip.Name = "txtRecipZip";
            this.txtRecipZip.Size = new System.Drawing.Size(100, 33);
            this.txtRecipZip.TabIndex = 12;
            this.txtRecipZip.Text = "65807";
            // 
            // txtRecipState
            // 
            this.txtRecipState.Location = new System.Drawing.Point(259, 83);
            this.txtRecipState.Name = "txtRecipState";
            this.txtRecipState.Size = new System.Drawing.Size(34, 33);
            this.txtRecipState.TabIndex = 11;
            this.txtRecipState.Text = "mo";
            // 
            // txtRecipCity
            // 
            this.txtRecipCity.Location = new System.Drawing.Point(77, 83);
            this.txtRecipCity.Name = "txtRecipCity";
            this.txtRecipCity.Size = new System.Drawing.Size(121, 33);
            this.txtRecipCity.TabIndex = 10;
            this.txtRecipCity.Text = "funtow";
            // 
            // txtRecipAddress
            // 
            this.txtRecipAddress.Location = new System.Drawing.Point(77, 53);
            this.txtRecipAddress.Name = "txtRecipAddress";
            this.txtRecipAddress.Size = new System.Drawing.Size(401, 33);
            this.txtRecipAddress.TabIndex = 9;
            this.txtRecipAddress.Text = "2010 fun Road";
            // 
            // txtRecipName
            // 
            this.txtRecipName.Location = new System.Drawing.Point(77, 22);
            this.txtRecipName.Name = "txtRecipName";
            this.txtRecipName.Size = new System.Drawing.Size(210, 33);
            this.txtRecipName.TabIndex = 8;
            this.txtRecipName.Text = "Jarret Stewart";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Zip Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblShipAst);
            this.groupBox4.Controls.Add(this.lblWeightAst);
            this.groupBox4.Controls.Add(this.cmbBxCompany);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtWeight);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(10, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 145);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Package Info";
            // 
            // lblShipAst
            // 
            this.lblShipAst.AutoSize = true;
            this.lblShipAst.BackColor = System.Drawing.Color.Transparent;
            this.lblShipAst.ForeColor = System.Drawing.Color.Red;
            this.lblShipAst.Location = new System.Drawing.Point(-5, 31);
            this.lblShipAst.Name = "lblShipAst";
            this.lblShipAst.Size = new System.Drawing.Size(24, 25);
            this.lblShipAst.TabIndex = 6;
            this.lblShipAst.Text = "*";
            this.lblShipAst.Visible = false;
            // 
            // lblWeightAst
            // 
            this.lblWeightAst.AutoSize = true;
            this.lblWeightAst.BackColor = System.Drawing.Color.Transparent;
            this.lblWeightAst.ForeColor = System.Drawing.Color.Red;
            this.lblWeightAst.Location = new System.Drawing.Point(3, 78);
            this.lblWeightAst.Name = "lblWeightAst";
            this.lblWeightAst.Size = new System.Drawing.Size(24, 25);
            this.lblWeightAst.TabIndex = 5;
            this.lblWeightAst.Text = "*";
            this.lblWeightAst.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Shipping Details";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDayToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearAllToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // viewDayToolStripMenuItem
            // 
            this.viewDayToolStripMenuItem.Name = "viewDayToolStripMenuItem";
            this.viewDayToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.viewDayToolStripMenuItem.Text = "View Day";
            this.viewDayToolStripMenuItem.Click += new System.EventHandler(this.viewDayToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrieveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 30);
            this.toolStripMenuItem1.Text = "Log";
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.retrieveToolStripMenuItem.Text = "Retrieve";
            this.retrieveToolStripMenuItem.Click += new System.EventHandler(this.retrieveToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.clearAllToolStripMenuItem.Text = "Clear List";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.submitToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.submitToolStripMenuItem.Text = "Submit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1042, 558);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstInvoice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PackageForm";
            this.Text = "Package Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOvernight;
        private System.Windows.Forms.RadioButton radTwoDay;
        private System.Windows.Forms.RadioButton radStanderd;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSenderState;
        private System.Windows.Forms.TextBox txtSenderCity;
        private System.Windows.Forms.TextBox txtSenderAddress;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenderZip;
        private System.Windows.Forms.TextBox txtRecipState;
        private System.Windows.Forms.TextBox txtRecipCity;
        private System.Windows.Forms.TextBox txtRecipAddress;
        private System.Windows.Forms.TextBox txtRecipName;
        private System.Windows.Forms.TextBox txtRecipZip;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label lblLoadBar;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWeightAst;
        private System.Windows.Forms.Label lblSendZipAst;
        private System.Windows.Forms.Label lblSendStateAst;
        private System.Windows.Forms.Label lblSendCityAst;
        private System.Windows.Forms.Label lblSendAddAst;
        private System.Windows.Forms.Label lblSendNameAst;
        private System.Windows.Forms.Label lblRecZipAst;
        private System.Windows.Forms.Label lblRecStateAst;
        private System.Windows.Forms.Label lblRecCityAst;
        private System.Windows.Forms.Label lblRecAddAst;
        private System.Windows.Forms.Label lblRecNameAst;
        private System.Windows.Forms.Label lblShipAst;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
    }
}