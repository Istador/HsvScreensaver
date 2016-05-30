namespace de.blackpinguin.gl.hsvscr
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.editImagePath = new System.Windows.Forms.TextBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vSync = new System.Windows.Forms.CheckBox();
            this.fullScreenMode = new System.Windows.Forms.ComboBox();
            this.xMonitors = new System.Windows.Forms.NumericUpDown();
            this.yMonitors = new System.Windows.Forms.NumericUpDown();
            this.xRainbow = new System.Windows.Forms.NumericUpDown();
            this.yRainbow = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.yTextureMove = new System.Windows.Forms.NumericUpDown();
            this.xTextureMove = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yTextureWrap = new System.Windows.Forms.NumericUpDown();
            this.xTextureWrap = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labAppName = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.urlLink = new System.Windows.Forms.LinkLabel();
            this.urlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preview = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cPostBlue = new System.Windows.Forms.NumericUpDown();
            this.cPostGreen = new System.Windows.Forms.NumericUpDown();
            this.cPostRed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.NumericUpDown();
            this.cSaturation = new System.Windows.Forms.NumericUpDown();
            this.cHue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cPreBlue = new System.Windows.Forms.NumericUpDown();
            this.cPreGreen = new System.Windows.Forms.NumericUpDown();
            this.cPreRed = new System.Windows.Forms.NumericUpDown();
            this.rndHue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.xMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRainbow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTextureMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTextureMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTextureWrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTextureWrap)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPostBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPostGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPostRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreRed)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // butCancel
            // 
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            resources.ApplyResources(this.butSave, "butSave");
            this.butSave.Name = "butSave";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // editImagePath
            // 
            resources.ApplyResources(this.editImagePath, "editImagePath");
            this.editImagePath.Name = "editImagePath";
            this.editImagePath.TextChanged += new System.EventHandler(this.ImageChanged);
            // 
            // butOpen
            // 
            resources.ApplyResources(this.butOpen, "butOpen");
            this.butOpen.Name = "butOpen";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // vSync
            // 
            resources.ApplyResources(this.vSync, "vSync");
            this.vSync.Checked = true;
            this.vSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vSync.Name = "vSync";
            this.vSync.UseVisualStyleBackColor = true;
            this.vSync.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // fullScreenMode
            // 
            this.fullScreenMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullScreenMode.FormattingEnabled = true;
            this.fullScreenMode.Items.AddRange(new object[] {
            resources.GetString("fullScreenMode.Items"),
            resources.GetString("fullScreenMode.Items1"),
            resources.GetString("fullScreenMode.Items2")});
            resources.ApplyResources(this.fullScreenMode, "fullScreenMode");
            this.fullScreenMode.Name = "fullScreenMode";
            this.fullScreenMode.SelectedValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xMonitors
            // 
            resources.ApplyResources(this.xMonitors, "xMonitors");
            this.xMonitors.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.xMonitors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xMonitors.Name = "xMonitors";
            this.xMonitors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xMonitors.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // yMonitors
            // 
            resources.ApplyResources(this.yMonitors, "yMonitors");
            this.yMonitors.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.yMonitors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMonitors.Name = "yMonitors";
            this.yMonitors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMonitors.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xRainbow
            // 
            this.xRainbow.DecimalPlaces = 2;
            this.xRainbow.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.xRainbow, "xRainbow");
            this.xRainbow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.xRainbow.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.xRainbow.Name = "xRainbow";
            this.xRainbow.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // yRainbow
            // 
            this.yRainbow.DecimalPlaces = 2;
            this.yRainbow.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.yRainbow, "yRainbow");
            this.yRainbow.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.yRainbow.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.yRainbow.Name = "yRainbow";
            this.yRainbow.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndHue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.xRainbow);
            this.groupBox1.Controls.Add(this.yRainbow);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // speed
            // 
            this.speed.DecimalPlaces = 2;
            this.speed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            resources.ApplyResources(this.speed, "speed");
            this.speed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.speed.Name = "speed";
            this.speed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.speed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.xMonitors);
            this.groupBox2.Controls.Add(this.fullScreenMode);
            this.groupBox2.Controls.Add(this.yMonitors);
            this.groupBox2.Controls.Add(this.vSync);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.yTextureMove);
            this.groupBox3.Controls.Add(this.xTextureMove);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.yTextureWrap);
            this.groupBox3.Controls.Add(this.xTextureWrap);
            this.groupBox3.Controls.Add(this.editImagePath);
            this.groupBox3.Controls.Add(this.butOpen);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // yTextureMove
            // 
            this.yTextureMove.DecimalPlaces = 2;
            this.yTextureMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.yTextureMove, "yTextureMove");
            this.yTextureMove.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yTextureMove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.yTextureMove.Name = "yTextureMove";
            this.yTextureMove.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xTextureMove
            // 
            this.xTextureMove.DecimalPlaces = 2;
            this.xTextureMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.xTextureMove, "xTextureMove");
            this.xTextureMove.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xTextureMove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.xTextureMove.Name = "xTextureMove";
            this.xTextureMove.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // yTextureWrap
            // 
            this.yTextureWrap.DecimalPlaces = 2;
            this.yTextureWrap.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.yTextureWrap, "yTextureWrap");
            this.yTextureWrap.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.yTextureWrap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yTextureWrap.Name = "yTextureWrap";
            this.yTextureWrap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yTextureWrap.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xTextureWrap
            // 
            this.xTextureWrap.DecimalPlaces = 2;
            this.xTextureWrap.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.xTextureWrap, "xTextureWrap");
            this.xTextureWrap.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.xTextureWrap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.xTextureWrap.Name = "xTextureWrap";
            this.xTextureWrap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xTextureWrap.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::de.blackpinguin.gl.hsvscr.Properties.Resources.pingu;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labAppName
            // 
            resources.ApplyResources(this.labAppName, "labAppName");
            this.labAppName.Name = "labAppName";
            // 
            // labVersion
            // 
            resources.ApplyResources(this.labVersion, "labVersion");
            this.labVersion.Name = "labVersion";
            // 
            // urlLink
            // 
            resources.ApplyResources(this.urlLink, "urlLink");
            this.urlLink.Name = "urlLink";
            this.urlLink.TabStop = true;
            this.urlToolTip.SetToolTip(this.urlLink, resources.GetString("urlLink.ToolTip"));
            this.urlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.preview, "preview");
            this.preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preview.Name = "preview";
            this.urlToolTip.SetToolTip(this.preview, resources.GetString("preview.ToolTip"));
            this.preview.VSync = true;
            this.preview.Load += new System.EventHandler(this.preview_Load);
            this.preview.Click += new System.EventHandler(this.preview_Click);
            this.preview.Paint += new System.Windows.Forms.PaintEventHandler(this.preview_Paint);
            this.preview.Resize += new System.EventHandler(this.preview_Resize);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cPostBlue);
            this.groupBox4.Controls.Add(this.cPostGreen);
            this.groupBox4.Controls.Add(this.cPostRed);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cValue);
            this.groupBox4.Controls.Add(this.cSaturation);
            this.groupBox4.Controls.Add(this.cHue);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cPreBlue);
            this.groupBox4.Controls.Add(this.cPreGreen);
            this.groupBox4.Controls.Add(this.cPreRed);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cPostBlue
            // 
            this.cPostBlue.DecimalPlaces = 2;
            this.cPostBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPostBlue, "cPostBlue");
            this.cPostBlue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPostBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPostBlue.Name = "cPostBlue";
            this.cPostBlue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPostGreen
            // 
            this.cPostGreen.DecimalPlaces = 2;
            this.cPostGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPostGreen, "cPostGreen");
            this.cPostGreen.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPostGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPostGreen.Name = "cPostGreen";
            this.cPostGreen.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPostRed
            // 
            this.cPostRed.DecimalPlaces = 2;
            this.cPostRed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPostRed, "cPostRed");
            this.cPostRed.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPostRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPostRed.Name = "cPostRed";
            this.cPostRed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cValue
            // 
            this.cValue.DecimalPlaces = 2;
            this.cValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cValue, "cValue");
            this.cValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cValue.Name = "cValue";
            this.cValue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cSaturation
            // 
            this.cSaturation.DecimalPlaces = 2;
            this.cSaturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cSaturation, "cSaturation");
            this.cSaturation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cSaturation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cSaturation.Name = "cSaturation";
            this.cSaturation.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cHue
            // 
            this.cHue.DecimalPlaces = 2;
            this.cHue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.cHue, "cHue");
            this.cHue.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            65536});
            this.cHue.Name = "cHue";
            this.cHue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cPreBlue
            // 
            this.cPreBlue.DecimalPlaces = 2;
            this.cPreBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPreBlue, "cPreBlue");
            this.cPreBlue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPreBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPreBlue.Name = "cPreBlue";
            this.cPreBlue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPreGreen
            // 
            this.cPreGreen.DecimalPlaces = 2;
            this.cPreGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPreGreen, "cPreGreen");
            this.cPreGreen.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPreGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPreGreen.Name = "cPreGreen";
            this.cPreGreen.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPreRed
            // 
            this.cPreRed.DecimalPlaces = 2;
            this.cPreRed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.cPreRed, "cPreRed");
            this.cPreRed.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cPreRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.cPreRed.Name = "cPreRed";
            this.cPreRed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // rndHue
            // 
            resources.ApplyResources(this.rndHue, "rndHue");
            this.rndHue.Checked = true;
            this.rndHue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rndHue.Name = "rndHue";
            this.rndHue.UseVisualStyleBackColor = true;
            this.rndHue.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.urlLink);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.labAppName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.xMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRainbow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTextureMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTextureMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTextureWrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTextureWrap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPostBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPostGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPostRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPreRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.TextBox editImagePath;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox vSync;
        private System.Windows.Forms.ComboBox fullScreenMode;
        private System.Windows.Forms.NumericUpDown xMonitors;
        private System.Windows.Forms.NumericUpDown yMonitors;
        private System.Windows.Forms.NumericUpDown xRainbow;
        private System.Windows.Forms.NumericUpDown yRainbow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yTextureWrap;
        private System.Windows.Forms.NumericUpDown xTextureWrap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labAppName;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.LinkLabel urlLink;
        private System.Windows.Forms.ToolTip urlToolTip;
        private OpenTK.GLControl preview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown cPreRed;
        private System.Windows.Forms.NumericUpDown cPreBlue;
        private System.Windows.Forms.NumericUpDown cPreGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cValue;
        private System.Windows.Forms.NumericUpDown cSaturation;
        private System.Windows.Forms.NumericUpDown cHue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cPostBlue;
        private System.Windows.Forms.NumericUpDown cPostGreen;
        private System.Windows.Forms.NumericUpDown cPostRed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yTextureMove;
        private System.Windows.Forms.NumericUpDown xTextureMove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox rndHue;
    }
}