using System.Runtime.InteropServices;

namespace LCT
{
    partial class frmLCT
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkDrawDistance = new System.Windows.Forms.CheckBox();
            this.chkAltZoom = new System.Windows.Forms.CheckBox();
            this.chkUnlockZoom = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FOVud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CamXS = new System.Windows.Forms.TrackBar();
            this.checkAOT = new System.Windows.Forms.CheckBox();
            this.chkHotkeys = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.HotKey = new System.Windows.Forms.Timer(this.components);
            this.Mouse = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LCtrlHotKeyRotation = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.ySensitivity = new System.Windows.Forms.NumericUpDown();
            this.xSensitivity = new System.Windows.Forms.NumericUpDown();
            this.MouseHotKeyRotation = new System.Windows.Forms.RadioButton();
            this.chkCamX = new System.Windows.Forms.CheckBox();
            this.chkCamY = new System.Windows.Forms.CheckBox();
            this.CamXchk = new System.Windows.Forms.CheckBox();
            this.CamYchk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Worker = new System.Windows.Forms.Timer(this.components);
            this.FP = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DoSigScan = new System.ComponentModel.BackgroundWorker();
            this.FowTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CamYS = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.chkFOW = new System.Windows.Forms.CheckBox();
            this.chkTP = new System.Windows.Forms.CheckBox();
            this.chkFlyCam = new System.Windows.Forms.CheckBox();
            this.chkAuto = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FOVud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamXS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamYS)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 122;
            this.label12.Text = "Fly Camera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 87;
            this.label11.Text = "Third Person View:";
            // 
            // chkDrawDistance
            // 
            this.chkDrawDistance.AutoSize = true;
            this.chkDrawDistance.BackColor = System.Drawing.Color.DimGray;
            this.chkDrawDistance.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkDrawDistance.Location = new System.Drawing.Point(148, 75);
            this.chkDrawDistance.Name = "chkDrawDistance";
            this.chkDrawDistance.Size = new System.Drawing.Size(15, 14);
            this.chkDrawDistance.TabIndex = 86;
            this.chkDrawDistance.UseVisualStyleBackColor = false;
            this.chkDrawDistance.CheckedChanged += new System.EventHandler(this.chkDrawDistance_CheckedChanged);
            // 
            // chkAltZoom
            // 
            this.chkAltZoom.AutoSize = true;
            this.chkAltZoom.BackColor = System.Drawing.Color.DimGray;
            this.chkAltZoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAltZoom.Location = new System.Drawing.Point(148, 60);
            this.chkAltZoom.Name = "chkAltZoom";
            this.chkAltZoom.Size = new System.Drawing.Size(15, 14);
            this.chkAltZoom.TabIndex = 85;
            this.chkAltZoom.UseVisualStyleBackColor = false;
            this.chkAltZoom.CheckedChanged += new System.EventHandler(this.chkAltZoom_CheckedChanged);
            // 
            // chkUnlockZoom
            // 
            this.chkUnlockZoom.AutoSize = true;
            this.chkUnlockZoom.BackColor = System.Drawing.Color.DimGray;
            this.chkUnlockZoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUnlockZoom.Location = new System.Drawing.Point(148, 45);
            this.chkUnlockZoom.Name = "chkUnlockZoom";
            this.chkUnlockZoom.Size = new System.Drawing.Size(15, 14);
            this.chkUnlockZoom.TabIndex = 84;
            this.chkUnlockZoom.Tag = "gg";
            this.chkUnlockZoom.UseVisualStyleBackColor = false;
            this.chkUnlockZoom.CheckedChanged += new System.EventHandler(this.chkUnlockZoom_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Disable Fog of War:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Extend Draw Distance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Alternate Zoom (Safer):";
            // 
            // FOVud
            // 
            this.FOVud.Cursor = System.Windows.Forms.Cursors.Default;
            this.FOVud.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOVud.Location = new System.Drawing.Point(123, 136);
            this.FOVud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FOVud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FOVud.Name = "FOVud";
            this.FOVud.Size = new System.Drawing.Size(38, 18);
            this.FOVud.TabIndex = 74;
            this.FOVud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.FOVud.ValueChanged += new System.EventHandler(this.FOVud_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Set Field of View:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Unlock Zoom Limits:";
            // 
            // CamXS
            // 
            this.CamXS.BackColor = System.Drawing.Color.DimGray;
            this.CamXS.Cursor = System.Windows.Forms.Cursors.Default;
            this.CamXS.Location = new System.Drawing.Point(36, 177);
            this.CamXS.Maximum = 360;
            this.CamXS.Name = "CamXS";
            this.CamXS.Size = new System.Drawing.Size(131, 45);
            this.CamXS.TabIndex = 47;
            this.CamXS.Value = 180;
            // 
            // checkAOT
            // 
            this.checkAOT.AutoSize = true;
            this.checkAOT.BackColor = System.Drawing.Color.DimGray;
            this.checkAOT.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkAOT.ForeColor = System.Drawing.Color.White;
            this.checkAOT.Location = new System.Drawing.Point(148, 318);
            this.checkAOT.Name = "checkAOT";
            this.checkAOT.Size = new System.Drawing.Size(15, 14);
            this.checkAOT.TabIndex = 52;
            this.checkAOT.UseVisualStyleBackColor = false;
            // 
            // chkHotkeys
            // 
            this.chkHotkeys.AutoSize = true;
            this.chkHotkeys.BackColor = System.Drawing.Color.DimGray;
            this.chkHotkeys.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkHotkeys.ForeColor = System.Drawing.Color.White;
            this.chkHotkeys.Location = new System.Drawing.Point(148, 305);
            this.chkHotkeys.Name = "chkHotkeys";
            this.chkHotkeys.Size = new System.Drawing.Size(15, 14);
            this.chkHotkeys.TabIndex = 49;
            this.chkHotkeys.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Hotkeys are Enabled:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DimGray;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(9, 315);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 17);
            this.label22.TabIndex = 41;
            this.label22.Text = "Always On Top";
            // 
            // HotKey
            // 
            this.HotKey.Interval = 50;
            this.HotKey.Tick += new System.EventHandler(this.HotKey_Tick);
            // 
            // Mouse
            // 
            this.Mouse.Enabled = true;
            this.Mouse.Interval = 1;
            this.Mouse.Tick += new System.EventHandler(this.Mouse_Tick);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(10, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 20);
            this.button5.TabIndex = 130;
            this.button5.Text = "Donate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 305);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 118;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 278);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 117;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LCtrlHotKeyRotation
            // 
            this.LCtrlHotKeyRotation.AutoSize = true;
            this.LCtrlHotKeyRotation.BackColor = System.Drawing.Color.DimGray;
            this.LCtrlHotKeyRotation.Cursor = System.Windows.Forms.Cursors.Default;
            this.LCtrlHotKeyRotation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCtrlHotKeyRotation.ForeColor = System.Drawing.Color.White;
            this.LCtrlHotKeyRotation.Location = new System.Drawing.Point(88, 241);
            this.LCtrlHotKeyRotation.Name = "LCtrlHotKeyRotation";
            this.LCtrlHotKeyRotation.Size = new System.Drawing.Size(79, 17);
            this.LCtrlHotKeyRotation.TabIndex = 64;
            this.LCtrlHotKeyRotation.TabStop = true;
            this.LCtrlHotKeyRotation.Text = "Left Control";
            this.LCtrlHotKeyRotation.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DimGray;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(7, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 136;
            this.label18.Text = "Sensitivity:";
            // 
            // ySensitivity
            // 
            this.ySensitivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.ySensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ySensitivity.Location = new System.Drawing.Point(126, 260);
            this.ySensitivity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ySensitivity.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.ySensitivity.Name = "ySensitivity";
            this.ySensitivity.Size = new System.Drawing.Size(34, 18);
            this.ySensitivity.TabIndex = 133;
            this.ySensitivity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // xSensitivity
            // 
            this.xSensitivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.xSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xSensitivity.Location = new System.Drawing.Point(78, 260);
            this.xSensitivity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.xSensitivity.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.xSensitivity.Name = "xSensitivity";
            this.xSensitivity.Size = new System.Drawing.Size(34, 18);
            this.xSensitivity.TabIndex = 132;
            this.xSensitivity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // MouseHotKeyRotation
            // 
            this.MouseHotKeyRotation.AutoSize = true;
            this.MouseHotKeyRotation.BackColor = System.Drawing.Color.DimGray;
            this.MouseHotKeyRotation.Cursor = System.Windows.Forms.Cursors.Default;
            this.MouseHotKeyRotation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseHotKeyRotation.ForeColor = System.Drawing.Color.White;
            this.MouseHotKeyRotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MouseHotKeyRotation.Location = new System.Drawing.Point(11, 241);
            this.MouseHotKeyRotation.Name = "MouseHotKeyRotation";
            this.MouseHotKeyRotation.Size = new System.Drawing.Size(81, 17);
            this.MouseHotKeyRotation.TabIndex = 63;
            this.MouseHotKeyRotation.TabStop = true;
            this.MouseHotKeyRotation.Text = "Middle Click";
            this.MouseHotKeyRotation.UseVisualStyleBackColor = false;
            // 
            // chkCamX
            // 
            this.chkCamX.AutoSize = true;
            this.chkCamX.BackColor = System.Drawing.Color.DimGray;
            this.chkCamX.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCamX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCamX.ForeColor = System.Drawing.Color.White;
            this.chkCamX.Location = new System.Drawing.Point(99, 223);
            this.chkCamX.Name = "chkCamX";
            this.chkCamX.Size = new System.Drawing.Size(33, 19);
            this.chkCamX.TabIndex = 60;
            this.chkCamX.Text = "X";
            this.chkCamX.UseVisualStyleBackColor = false;
            this.chkCamX.CheckedChanged += new System.EventHandler(this.chkCamX_CheckedChanged);
            // 
            // chkCamY
            // 
            this.chkCamY.AutoSize = true;
            this.chkCamY.BackColor = System.Drawing.Color.DimGray;
            this.chkCamY.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCamY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCamY.ForeColor = System.Drawing.Color.White;
            this.chkCamY.Location = new System.Drawing.Point(130, 223);
            this.chkCamY.Name = "chkCamY";
            this.chkCamY.Size = new System.Drawing.Size(33, 19);
            this.chkCamY.TabIndex = 59;
            this.chkCamY.Text = "Y";
            this.chkCamY.UseVisualStyleBackColor = false;
            this.chkCamY.CheckedChanged += new System.EventHandler(this.chkCamY_CheckedChanged);
            // 
            // CamXchk
            // 
            this.CamXchk.AutoSize = true;
            this.CamXchk.BackColor = System.Drawing.Color.DimGray;
            this.CamXchk.Cursor = System.Windows.Forms.Cursors.Default;
            this.CamXchk.ForeColor = System.Drawing.Color.White;
            this.CamXchk.Location = new System.Drawing.Point(10, 179);
            this.CamXchk.Name = "CamXchk";
            this.CamXchk.Size = new System.Drawing.Size(33, 17);
            this.CamXchk.TabIndex = 51;
            this.CamXchk.Text = "X";
            this.CamXchk.UseVisualStyleBackColor = false;
            this.CamXchk.CheckedChanged += new System.EventHandler(this.CamXchk_CheckedChanged);
            // 
            // CamYchk
            // 
            this.CamYchk.AutoSize = true;
            this.CamYchk.BackColor = System.Drawing.Color.DimGray;
            this.CamYchk.Cursor = System.Windows.Forms.Cursors.Default;
            this.CamYchk.ForeColor = System.Drawing.Color.White;
            this.CamYchk.Location = new System.Drawing.Point(10, 202);
            this.CamYchk.Name = "CamYchk";
            this.CamYchk.Size = new System.Drawing.Size(33, 17);
            this.CamYchk.TabIndex = 50;
            this.CamYchk.Text = "Y";
            this.CamYchk.UseVisualStyleBackColor = false;
            this.CamYchk.CheckedChanged += new System.EventHandler(this.CamYchk_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mouse Rotation:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DimGray;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(110, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 15);
            this.label17.TabIndex = 134;
            this.label17.Text = "Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(64, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 135;
            this.label16.Text = "X";
            // 
            // Worker
            // 
            this.Worker.Enabled = true;
            this.Worker.Interval = 50;
            this.Worker.Tick += new System.EventHandler(this.fovt_Tick);
            // 
            // FP
            // 
            this.FP.Enabled = true;
            this.FP.Tick += new System.EventHandler(this.FP_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Black;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(-1, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(164, 18);
            this.txtStatus.TabIndex = 126;
            this.txtStatus.Text = "Loading...";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(62, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 20);
            this.button1.TabIndex = 131;
            this.button1.Text = "Check for Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update);
            // 
            // DoSigScan
            // 
            this.DoSigScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoSigScan_DoWork);
            // 
            // FowTimer
            // 
            this.FowTimer.Tick += new System.EventHandler(this.FowTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-1, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 18);
            this.textBox1.TabIndex = 132;
            this.textBox1.Text = "Camera Options";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(-1, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 18);
            this.textBox2.TabIndex = 133;
            this.textBox2.Text = "Rotation Options";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CamYS
            // 
            this.CamYS.BackColor = System.Drawing.Color.DimGray;
            this.CamYS.Cursor = System.Windows.Forms.Cursors.Default;
            this.CamYS.Location = new System.Drawing.Point(36, 199);
            this.CamYS.Maximum = 250;
            this.CamYS.Minimum = -100;
            this.CamYS.Name = "CamYS";
            this.CamYS.Size = new System.Drawing.Size(131, 45);
            this.CamYS.TabIndex = 46;
            this.CamYS.Value = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 117);
            this.label9.TabIndex = 137;
            this.label9.Text = "                                                   \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(7, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 104);
            this.label15.TabIndex = 138;
            this.label15.Text = "                                                   \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(-1, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(123, 18);
            this.textBox3.TabIndex = 139;
            this.textBox3.Text = "Options";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 52);
            this.label6.TabIndex = 140;
            this.label6.Text = "                                                   \r\n\r\n\r\n\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(152, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 19);
            this.button2.TabIndex = 141;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 142;
            this.label8.Text = "                                       \r\n";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(161, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(13, 21);
            this.button3.TabIndex = 143;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkFOW
            // 
            this.chkFOW.AutoSize = true;
            this.chkFOW.BackColor = System.Drawing.Color.DimGray;
            this.chkFOW.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFOW.Location = new System.Drawing.Point(148, 120);
            this.chkFOW.Name = "chkFOW";
            this.chkFOW.Size = new System.Drawing.Size(15, 14);
            this.chkFOW.TabIndex = 83;
            this.chkFOW.UseVisualStyleBackColor = false;
            this.chkFOW.CheckedChanged += new System.EventHandler(this.chkFOW_CheckedChanged);
            // 
            // chkTP
            // 
            this.chkTP.AutoSize = true;
            this.chkTP.BackColor = System.Drawing.Color.DimGray;
            this.chkTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTP.Location = new System.Drawing.Point(148, 90);
            this.chkTP.Name = "chkTP";
            this.chkTP.Size = new System.Drawing.Size(15, 14);
            this.chkTP.TabIndex = 144;
            this.chkTP.UseVisualStyleBackColor = false;
            // 
            // chkFlyCam
            // 
            this.chkFlyCam.AutoSize = true;
            this.chkFlyCam.BackColor = System.Drawing.Color.DimGray;
            this.chkFlyCam.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlyCam.Location = new System.Drawing.Point(148, 105);
            this.chkFlyCam.Name = "chkFlyCam";
            this.chkFlyCam.Size = new System.Drawing.Size(15, 14);
            this.chkFlyCam.TabIndex = 145;
            this.chkFlyCam.UseVisualStyleBackColor = false;
            this.chkFlyCam.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkAuto
            // 
            this.chkAuto.Interval = 1000;
            this.chkAuto.Tick += new System.EventHandler(this.HAK_Tick);
            // 
            // frmLCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(174, 360);
            this.Controls.Add(this.chkFlyCam);
            this.Controls.Add(this.chkTP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LCtrlHotKeyRotation);
            this.Controls.Add(this.chkCamY);
            this.Controls.Add(this.chkCamX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkAOT);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chkHotkeys);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ySensitivity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xSensitivity);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.MouseHotKeyRotation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CamYchk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkDrawDistance);
            this.Controls.Add(this.chkAltZoom);
            this.Controls.Add(this.chkUnlockZoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFOW);
            this.Controls.Add(this.FOVud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamYS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CamXS);
            this.Controls.Add(this.CamXchk);
            this.Controls.Add(this.label15);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLCT";
            this.Opacity = 0.95D;
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.LCT_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLCT_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.FOVud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamXS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamYS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkDrawDistance;
        private System.Windows.Forms.CheckBox chkAltZoom;
        private System.Windows.Forms.CheckBox chkUnlockZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown FOVud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar CamXS;
        private System.Windows.Forms.CheckBox checkAOT;
        private System.Windows.Forms.CheckBox chkHotkeys;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer HotKey;
        private System.Windows.Forms.Timer Mouse;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton LCtrlHotKeyRotation;
        private System.Windows.Forms.RadioButton MouseHotKeyRotation;
        private System.Windows.Forms.CheckBox chkCamX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCamY;
        private System.Windows.Forms.CheckBox CamXchk;
        private System.Windows.Forms.CheckBox CamYchk;
        private System.Windows.Forms.Timer Worker;
        private System.Windows.Forms.Timer FP;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker DoSigScan;
        private System.Windows.Forms.Timer FowTimer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown ySensitivity;
        private System.Windows.Forms.NumericUpDown xSensitivity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar CamYS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkFOW;
        private System.Windows.Forms.CheckBox chkTP;
        private System.Windows.Forms.CheckBox chkFlyCam;
        private System.Windows.Forms.Timer chkAuto;
    }
}

