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
            this.label10 = new System.Windows.Forms.Label();
            this.intensity = new System.Windows.Forms.NumericUpDown();
            this.rndHue = new System.Windows.Forms.CheckBox();
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
            this.avatar = new System.Windows.Forms.Panel();
            this.labAppName = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.urlLink = new System.Windows.Forms.LinkLabel();
            this.urlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preview = new OpenTK.GLControl();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRainbow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).BeginInit();
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
            this.urlToolTip.SetToolTip(this.butCancel, resources.GetString("butCancel.ToolTip"));
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            resources.ApplyResources(this.butSave, "butSave");
            this.butSave.Name = "butSave";
            this.urlToolTip.SetToolTip(this.butSave, resources.GetString("butSave.ToolTip"));
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // editImagePath
            // 
            resources.ApplyResources(this.editImagePath, "editImagePath");
            this.editImagePath.Name = "editImagePath";
            this.urlToolTip.SetToolTip(this.editImagePath, resources.GetString("editImagePath.ToolTip"));
            this.editImagePath.TextChanged += new System.EventHandler(this.ImageChanged);
            // 
            // butOpen
            // 
            resources.ApplyResources(this.butOpen, "butOpen");
            this.butOpen.Name = "butOpen";
            this.urlToolTip.SetToolTip(this.butOpen, resources.GetString("butOpen.ToolTip"));
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.urlToolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // vSync
            // 
            resources.ApplyResources(this.vSync, "vSync");
            this.vSync.Checked = true;
            this.vSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vSync.Name = "vSync";
            this.urlToolTip.SetToolTip(this.vSync, resources.GetString("vSync.ToolTip"));
            this.vSync.UseVisualStyleBackColor = true;
            this.vSync.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // fullScreenMode
            // 
            resources.ApplyResources(this.fullScreenMode, "fullScreenMode");
            this.fullScreenMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullScreenMode.FormattingEnabled = true;
            this.fullScreenMode.Items.AddRange(new object[] {
            resources.GetString("fullScreenMode.Items"),
            resources.GetString("fullScreenMode.Items1"),
            resources.GetString("fullScreenMode.Items2")});
            this.fullScreenMode.Name = "fullScreenMode";
            this.urlToolTip.SetToolTip(this.fullScreenMode, resources.GetString("fullScreenMode.ToolTip"));
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
            this.urlToolTip.SetToolTip(this.xMonitors, resources.GetString("xMonitors.ToolTip"));
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
            this.urlToolTip.SetToolTip(this.yMonitors, resources.GetString("yMonitors.ToolTip"));
            this.yMonitors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMonitors.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xRainbow
            // 
            resources.ApplyResources(this.xRainbow, "xRainbow");
            this.xRainbow.DecimalPlaces = 2;
            this.xRainbow.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.xRainbow, resources.GetString("xRainbow.ToolTip"));
            this.xRainbow.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // yRainbow
            // 
            resources.ApplyResources(this.yRainbow, "yRainbow");
            this.yRainbow.DecimalPlaces = 2;
            this.yRainbow.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.yRainbow, resources.GetString("yRainbow.ToolTip"));
            this.yRainbow.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.intensity);
            this.groupBox1.Controls.Add(this.rndHue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.xRainbow);
            this.groupBox1.Controls.Add(this.yRainbow);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.urlToolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.urlToolTip.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // intensity
            // 
            resources.ApplyResources(this.intensity, "intensity");
            this.intensity.DecimalPlaces = 1;
            this.intensity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.intensity.Name = "intensity";
            this.urlToolTip.SetToolTip(this.intensity, resources.GetString("intensity.ToolTip"));
            this.intensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.intensity.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // rndHue
            // 
            resources.ApplyResources(this.rndHue, "rndHue");
            this.rndHue.Checked = true;
            this.rndHue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rndHue.Name = "rndHue";
            this.urlToolTip.SetToolTip(this.rndHue, resources.GetString("rndHue.ToolTip"));
            this.rndHue.UseVisualStyleBackColor = true;
            this.rndHue.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.urlToolTip.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // speed
            // 
            resources.ApplyResources(this.speed, "speed");
            this.speed.DecimalPlaces = 2;
            this.speed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.speed, resources.GetString("speed.ToolTip"));
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
            this.urlToolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.urlToolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.xMonitors);
            this.groupBox2.Controls.Add(this.fullScreenMode);
            this.groupBox2.Controls.Add(this.yMonitors);
            this.groupBox2.Controls.Add(this.vSync);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.urlToolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.yTextureMove);
            this.groupBox3.Controls.Add(this.xTextureMove);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.yTextureWrap);
            this.groupBox3.Controls.Add(this.xTextureWrap);
            this.groupBox3.Controls.Add(this.editImagePath);
            this.groupBox3.Controls.Add(this.butOpen);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.urlToolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // yTextureMove
            // 
            resources.ApplyResources(this.yTextureMove, "yTextureMove");
            this.yTextureMove.DecimalPlaces = 2;
            this.yTextureMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.yTextureMove, resources.GetString("yTextureMove.ToolTip"));
            this.yTextureMove.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xTextureMove
            // 
            resources.ApplyResources(this.xTextureMove, "xTextureMove");
            this.xTextureMove.DecimalPlaces = 2;
            this.xTextureMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.xTextureMove, resources.GetString("xTextureMove.ToolTip"));
            this.xTextureMove.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.urlToolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.urlToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // yTextureWrap
            // 
            resources.ApplyResources(this.yTextureWrap, "yTextureWrap");
            this.yTextureWrap.DecimalPlaces = 2;
            this.yTextureWrap.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.yTextureWrap, resources.GetString("yTextureWrap.ToolTip"));
            this.yTextureWrap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yTextureWrap.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // xTextureWrap
            // 
            resources.ApplyResources(this.xTextureWrap, "xTextureWrap");
            this.xTextureWrap.DecimalPlaces = 2;
            this.xTextureWrap.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.xTextureWrap, resources.GetString("xTextureWrap.ToolTip"));
            this.xTextureWrap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xTextureWrap.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // avatar
            // 
            resources.ApplyResources(this.avatar, "avatar");
            this.avatar.BackgroundImage = global::de.blackpinguin.gl.hsvscr.Properties.Resources.pingu;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Name = "avatar";
            this.urlToolTip.SetToolTip(this.avatar, resources.GetString("avatar.ToolTip"));
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // labAppName
            // 
            resources.ApplyResources(this.labAppName, "labAppName");
            this.labAppName.Name = "labAppName";
            this.urlToolTip.SetToolTip(this.labAppName, resources.GetString("labAppName.ToolTip"));
            // 
            // labVersion
            // 
            resources.ApplyResources(this.labVersion, "labVersion");
            this.labVersion.Name = "labVersion";
            this.urlToolTip.SetToolTip(this.labVersion, resources.GetString("labVersion.ToolTip"));
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
            resources.ApplyResources(this.preview, "preview");
            this.preview.BackColor = System.Drawing.Color.Black;
            this.preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preview.Name = "preview";
            this.urlToolTip.SetToolTip(this.preview, resources.GetString("preview.ToolTip"));
            this.preview.VSync = true;
            this.preview.Load += new System.EventHandler(this.preview_Load);
            this.preview.Click += new System.EventHandler(this.preview_Click);
            this.preview.Paint += new System.Windows.Forms.PaintEventHandler(this.preview_Paint);
            this.preview.Resize += new System.EventHandler(this.preview_Resize);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
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
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.urlToolTip.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.urlToolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // cPostBlue
            // 
            resources.ApplyResources(this.cPostBlue, "cPostBlue");
            this.cPostBlue.DecimalPlaces = 2;
            this.cPostBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPostBlue, resources.GetString("cPostBlue.ToolTip"));
            this.cPostBlue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPostGreen
            // 
            resources.ApplyResources(this.cPostGreen, "cPostGreen");
            this.cPostGreen.DecimalPlaces = 2;
            this.cPostGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPostGreen, resources.GetString("cPostGreen.ToolTip"));
            this.cPostGreen.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPostRed
            // 
            resources.ApplyResources(this.cPostRed, "cPostRed");
            this.cPostRed.DecimalPlaces = 2;
            this.cPostRed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPostRed, resources.GetString("cPostRed.ToolTip"));
            this.cPostRed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.urlToolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // cValue
            // 
            resources.ApplyResources(this.cValue, "cValue");
            this.cValue.DecimalPlaces = 2;
            this.cValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cValue, resources.GetString("cValue.ToolTip"));
            this.cValue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cSaturation
            // 
            resources.ApplyResources(this.cSaturation, "cSaturation");
            this.cSaturation.DecimalPlaces = 2;
            this.cSaturation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cSaturation, resources.GetString("cSaturation.ToolTip"));
            this.cSaturation.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cHue
            // 
            resources.ApplyResources(this.cHue, "cHue");
            this.cHue.DecimalPlaces = 2;
            this.cHue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.cHue.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            65536});
            this.cHue.Name = "cHue";
            this.urlToolTip.SetToolTip(this.cHue, resources.GetString("cHue.ToolTip"));
            this.cHue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.urlToolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // cPreBlue
            // 
            resources.ApplyResources(this.cPreBlue, "cPreBlue");
            this.cPreBlue.DecimalPlaces = 2;
            this.cPreBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPreBlue, resources.GetString("cPreBlue.ToolTip"));
            this.cPreBlue.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPreGreen
            // 
            resources.ApplyResources(this.cPreGreen, "cPreGreen");
            this.cPreGreen.DecimalPlaces = 2;
            this.cPreGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPreGreen, resources.GetString("cPreGreen.ToolTip"));
            this.cPreGreen.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // cPreRed
            // 
            resources.ApplyResources(this.cPreRed, "cPreRed");
            this.cPreRed.DecimalPlaces = 2;
            this.cPreRed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
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
            this.urlToolTip.SetToolTip(this.cPreRed, resources.GetString("cPreRed.ToolTip"));
            this.cPreRed.ValueChanged += new System.EventHandler(this.SettingsChanged);
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
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.urlLink);
            this.Controls.Add(this.labVersion);
            this.Controls.Add(this.labAppName);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.urlToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.xMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRainbow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).EndInit();
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
        private System.Windows.Forms.Panel avatar;
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
        private System.Windows.Forms.NumericUpDown intensity;
        private System.Windows.Forms.Label label10;
    }
}