namespace LCT
{
    partial class LCT
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
            this.CamYS = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SkinUD = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.FLYon = new System.Windows.Forms.Button();
            this.FLYoff = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TPVon = new System.Windows.Forms.Button();
            this.TPVoff = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDrawDistance = new System.Windows.Forms.CheckBox();
            this.chkAltZoom = new System.Windows.Forms.CheckBox();
            this.chkUnlockZoom = new System.Windows.Forms.CheckBox();
            this.chkFOW = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.distoff = new System.Windows.Forms.Button();
            this.DrawDistanceOn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.altoff = new System.Windows.Forms.Button();
            this.alton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FOVchk = new System.Windows.Forms.CheckBox();
            this.FOVud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ZoomOff = new System.Windows.Forms.Button();
            this.ZoomOn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CamXS = new System.Windows.Forms.TrackBar();
            this.checkAOT = new System.Windows.Forms.CheckBox();
            this.chkHotkeys = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.HotKey = new System.Windows.Forms.Timer(this.components);
            this.Mouse = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LCtrlHotKeyRotation = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ySensitivity = new System.Windows.Forms.NumericUpDown();
            this.xSensitivity = new System.Windows.Forms.NumericUpDown();
            this.MouseHotKeyRotation = new System.Windows.Forms.RadioButton();
            this.chkCamX = new System.Windows.Forms.CheckBox();
            this.chkCamY = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CamXchk = new System.Windows.Forms.CheckBox();
            this.CamYchk = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Worker = new System.Windows.Forms.Timer(this.components);
            this.chkAuto = new System.Windows.Forms.Timer(this.components);
            this.FP = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DoSigScan = new System.ComponentModel.BackgroundWorker();
            this.FowTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CamYS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamXS)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensitivity)).BeginInit();
            this.SuspendLayout();
            // 
            // CamYS
            // 
            this.CamYS.BackColor = System.Drawing.Color.Black;
            this.CamYS.Location = new System.Drawing.Point(13, 12);
            this.CamYS.Maximum = 250;
            this.CamYS.Minimum = -100;
            this.CamYS.Name = "CamYS";
            this.CamYS.Size = new System.Drawing.Size(145, 45);
            this.CamYS.TabIndex = 46;
            this.CamYS.Value = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.SkinUD);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.FLYon);
            this.groupBox1.Controls.Add(this.FLYoff);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TPVon);
            this.groupBox1.Controls.Add(this.TPVoff);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkDrawDistance);
            this.groupBox1.Controls.Add(this.chkAltZoom);
            this.groupBox1.Controls.Add(this.chkUnlockZoom);
            this.groupBox1.Controls.Add(this.chkFOW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.distoff);
            this.groupBox1.Controls.Add(this.DrawDistanceOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.altoff);
            this.groupBox1.Controls.Add(this.alton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FOVchk);
            this.groupBox1.Controls.Add(this.FOVud);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ZoomOff);
            this.groupBox1.Controls.Add(this.ZoomOn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(1, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 155);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(106, 156);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 127;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SkinUD
            // 
            this.SkinUD.Location = new System.Drawing.Point(121, 153);
            this.SkinUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SkinUD.Name = "SkinUD";
            this.SkinUD.Size = new System.Drawing.Size(37, 20);
            this.SkinUD.TabIndex = 126;
            this.SkinUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(3, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 125;
            this.label15.Text = "Use Alternative Skin:";
            // 
            // FLYon
            // 
            this.FLYon.ForeColor = System.Drawing.Color.Black;
            this.FLYon.Location = new System.Drawing.Point(107, 131);
            this.FLYon.Name = "FLYon";
            this.FLYon.Size = new System.Drawing.Size(29, 21);
            this.FLYon.TabIndex = 124;
            this.FLYon.Text = "On";
            this.FLYon.UseVisualStyleBackColor = true;
            this.FLYon.Click += new System.EventHandler(this.FLYon_Click);
            // 
            // FLYoff
            // 
            this.FLYoff.ForeColor = System.Drawing.Color.Black;
            this.FLYoff.Location = new System.Drawing.Point(135, 131);
            this.FLYoff.Name = "FLYoff";
            this.FLYoff.Size = new System.Drawing.Size(30, 21);
            this.FLYoff.TabIndex = 123;
            this.FLYoff.Text = "Off";
            this.FLYoff.UseVisualStyleBackColor = true;
            this.FLYoff.Click += new System.EventHandler(this.FLYoff_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(3, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Fly Camera:";
            // 
            // TPVon
            // 
            this.TPVon.ForeColor = System.Drawing.Color.Black;
            this.TPVon.Location = new System.Drawing.Point(107, 111);
            this.TPVon.Name = "TPVon";
            this.TPVon.Size = new System.Drawing.Size(29, 21);
            this.TPVon.TabIndex = 121;
            this.TPVon.Text = "On";
            this.TPVon.UseVisualStyleBackColor = true;
            this.TPVon.Click += new System.EventHandler(this.TPVon_Click);
            // 
            // TPVoff
            // 
            this.TPVoff.ForeColor = System.Drawing.Color.Black;
            this.TPVoff.Location = new System.Drawing.Point(135, 111);
            this.TPVoff.Name = "TPVoff";
            this.TPVoff.Size = new System.Drawing.Size(30, 21);
            this.TPVoff.TabIndex = 120;
            this.TPVoff.Text = "Off";
            this.TPVoff.UseVisualStyleBackColor = true;
            this.TPVoff.Click += new System.EventHandler(this.TPVoff_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(2, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Third Person View:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(127, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Auto:";
            // 
            // chkDrawDistance
            // 
            this.chkDrawDistance.AutoSize = true;
            this.chkDrawDistance.Location = new System.Drawing.Point(151, 58);
            this.chkDrawDistance.Name = "chkDrawDistance";
            this.chkDrawDistance.Size = new System.Drawing.Size(15, 14);
            this.chkDrawDistance.TabIndex = 86;
            this.chkDrawDistance.UseVisualStyleBackColor = true;
            // 
            // chkAltZoom
            // 
            this.chkAltZoom.AutoSize = true;
            this.chkAltZoom.Location = new System.Drawing.Point(151, 37);
            this.chkAltZoom.Name = "chkAltZoom";
            this.chkAltZoom.Size = new System.Drawing.Size(15, 14);
            this.chkAltZoom.TabIndex = 85;
            this.chkAltZoom.UseVisualStyleBackColor = true;
            // 
            // chkUnlockZoom
            // 
            this.chkUnlockZoom.AutoSize = true;
            this.chkUnlockZoom.Location = new System.Drawing.Point(151, 16);
            this.chkUnlockZoom.Name = "chkUnlockZoom";
            this.chkUnlockZoom.Size = new System.Drawing.Size(15, 14);
            this.chkUnlockZoom.TabIndex = 84;
            this.chkUnlockZoom.UseVisualStyleBackColor = true;
            // 
            // chkFOW
            // 
            this.chkFOW.AutoSize = true;
            this.chkFOW.Location = new System.Drawing.Point(151, 98);
            this.chkFOW.Name = "chkFOW";
            this.chkFOW.Size = new System.Drawing.Size(15, 14);
            this.chkFOW.TabIndex = 83;
            this.chkFOW.UseVisualStyleBackColor = true;
            this.chkFOW.CheckedChanged += new System.EventHandler(this.chkFOW_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Disable Fog of War (Visual):";
            // 
            // distoff
            // 
            this.distoff.ForeColor = System.Drawing.Color.Black;
            this.distoff.Location = new System.Drawing.Point(119, 54);
            this.distoff.Name = "distoff";
            this.distoff.Size = new System.Drawing.Size(31, 21);
            this.distoff.TabIndex = 81;
            this.distoff.Text = "Off";
            this.distoff.UseVisualStyleBackColor = true;
            this.distoff.Click += new System.EventHandler(this.DrawDistanceOff);
            // 
            // DrawDistanceOn
            // 
            this.DrawDistanceOn.ForeColor = System.Drawing.Color.Black;
            this.DrawDistanceOn.Location = new System.Drawing.Point(91, 54);
            this.DrawDistanceOn.Name = "DrawDistanceOn";
            this.DrawDistanceOn.Size = new System.Drawing.Size(29, 21);
            this.DrawDistanceOn.TabIndex = 79;
            this.DrawDistanceOn.Text = "On";
            this.DrawDistanceOn.UseVisualStyleBackColor = true;
            this.DrawDistanceOn.Click += new System.EventHandler(this.Diston_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Draw Distance++:";
            // 
            // altoff
            // 
            this.altoff.ForeColor = System.Drawing.Color.Black;
            this.altoff.Location = new System.Drawing.Point(119, 33);
            this.altoff.Name = "altoff";
            this.altoff.Size = new System.Drawing.Size(31, 21);
            this.altoff.TabIndex = 78;
            this.altoff.Text = "Off";
            this.altoff.UseVisualStyleBackColor = true;
            this.altoff.Click += new System.EventHandler(this.altoff_Click);
            // 
            // alton
            // 
            this.alton.ForeColor = System.Drawing.Color.Black;
            this.alton.Location = new System.Drawing.Point(91, 33);
            this.alton.Name = "alton";
            this.alton.Size = new System.Drawing.Size(29, 21);
            this.alton.TabIndex = 76;
            this.alton.Text = "On";
            this.alton.UseVisualStyleBackColor = true;
            this.alton.Click += new System.EventHandler(this.alton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(2, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Alternate Zoom:";
            // 
            // FOVchk
            // 
            this.FOVchk.AutoSize = true;
            this.FOVchk.Location = new System.Drawing.Point(98, 79);
            this.FOVchk.Name = "FOVchk";
            this.FOVchk.Size = new System.Drawing.Size(15, 14);
            this.FOVchk.TabIndex = 75;
            this.FOVchk.UseVisualStyleBackColor = true;
            // 
            // FOVud
            // 
            this.FOVud.Location = new System.Drawing.Point(119, 76);
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
            this.FOVud.Size = new System.Drawing.Size(45, 20);
            this.FOVud.TabIndex = 74;
            this.FOVud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Set Field of View:";
            // 
            // ZoomOff
            // 
            this.ZoomOff.ForeColor = System.Drawing.Color.Black;
            this.ZoomOff.Location = new System.Drawing.Point(119, 12);
            this.ZoomOff.Name = "ZoomOff";
            this.ZoomOff.Size = new System.Drawing.Size(31, 21);
            this.ZoomOff.TabIndex = 72;
            this.ZoomOff.Text = "Off";
            this.ZoomOff.UseVisualStyleBackColor = true;
            this.ZoomOff.Click += new System.EventHandler(this.ZoomOff_Click);
            // 
            // ZoomOn
            // 
            this.ZoomOn.ForeColor = System.Drawing.Color.Black;
            this.ZoomOn.Location = new System.Drawing.Point(91, 12);
            this.ZoomOn.Name = "ZoomOn";
            this.ZoomOn.Size = new System.Drawing.Size(29, 21);
            this.ZoomOn.TabIndex = 70;
            this.ZoomOn.Text = "On";
            this.ZoomOn.UseVisualStyleBackColor = true;
            this.ZoomOn.Click += new System.EventHandler(this.ZoomOn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(2, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Unlock Zoom:";
            // 
            // CamXS
            // 
            this.CamXS.Location = new System.Drawing.Point(13, 50);
            this.CamXS.Maximum = 360;
            this.CamXS.Name = "CamXS";
            this.CamXS.Size = new System.Drawing.Size(145, 45);
            this.CamXS.TabIndex = 47;
            this.CamXS.Value = 180;
            // 
            // checkAOT
            // 
            this.checkAOT.AutoSize = true;
            this.checkAOT.Location = new System.Drawing.Point(144, 26);
            this.checkAOT.Name = "checkAOT";
            this.checkAOT.Size = new System.Drawing.Size(15, 14);
            this.checkAOT.TabIndex = 52;
            this.checkAOT.UseVisualStyleBackColor = true;
            // 
            // chkHotkeys
            // 
            this.chkHotkeys.AutoSize = true;
            this.chkHotkeys.Location = new System.Drawing.Point(144, 11);
            this.chkHotkeys.Name = "chkHotkeys";
            this.chkHotkeys.Size = new System.Drawing.Size(15, 14);
            this.chkHotkeys.TabIndex = 49;
            this.chkHotkeys.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Hotkeys are Enabled:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Aqua;
            this.label22.Location = new System.Drawing.Point(3, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 16);
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
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 21);
            this.button5.TabIndex = 130;
            this.button5.Text = "Donate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkAOT);
            this.groupBox7.Controls.Add(this.chkHotkeys);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.ForeColor = System.Drawing.Color.Lime;
            this.groupBox7.Location = new System.Drawing.Point(1, 320);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 45);
            this.groupBox7.TabIndex = 129;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Settings";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(236, 291);
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
            this.numericUpDown1.Location = new System.Drawing.Point(185, 291);
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
            this.LCtrlHotKeyRotation.Location = new System.Drawing.Point(85, 100);
            this.LCtrlHotKeyRotation.Name = "LCtrlHotKeyRotation";
            this.LCtrlHotKeyRotation.Size = new System.Drawing.Size(79, 17);
            this.LCtrlHotKeyRotation.TabIndex = 64;
            this.LCtrlHotKeyRotation.TabStop = true;
            this.LCtrlHotKeyRotation.Text = "Left Control";
            this.LCtrlHotKeyRotation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(5, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Y";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.ySensitivity);
            this.groupBox2.Controls.Add(this.xSensitivity);
            this.groupBox2.Controls.Add(this.LCtrlHotKeyRotation);
            this.groupBox2.Controls.Add(this.MouseHotKeyRotation);
            this.groupBox2.Controls.Add(this.chkCamX);
            this.groupBox2.Controls.Add(this.chkCamY);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CamXchk);
            this.groupBox2.Controls.Add(this.CamYchk);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CamYS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CamXS);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(1, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 145);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Rotation";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(1, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 136;
            this.label18.Text = "Sensitivity:";
            // 
            // ySensitivity
            // 
            this.ySensitivity.Location = new System.Drawing.Point(130, 120);
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
            this.ySensitivity.Size = new System.Drawing.Size(34, 20);
            this.ySensitivity.TabIndex = 133;
            this.ySensitivity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // xSensitivity
            // 
            this.xSensitivity.Location = new System.Drawing.Point(81, 120);
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
            this.xSensitivity.Size = new System.Drawing.Size(34, 20);
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
            this.MouseHotKeyRotation.Location = new System.Drawing.Point(5, 100);
            this.MouseHotKeyRotation.Name = "MouseHotKeyRotation";
            this.MouseHotKeyRotation.Size = new System.Drawing.Size(82, 17);
            this.MouseHotKeyRotation.TabIndex = 63;
            this.MouseHotKeyRotation.TabStop = true;
            this.MouseHotKeyRotation.Text = "Middle Click";
            this.MouseHotKeyRotation.UseVisualStyleBackColor = true;
            // 
            // chkCamX
            // 
            this.chkCamX.AutoSize = true;
            this.chkCamX.Location = new System.Drawing.Point(120, 86);
            this.chkCamX.Name = "chkCamX";
            this.chkCamX.Size = new System.Drawing.Size(15, 14);
            this.chkCamX.TabIndex = 60;
            this.chkCamX.UseVisualStyleBackColor = true;
            // 
            // chkCamY
            // 
            this.chkCamY.AutoSize = true;
            this.chkCamY.Location = new System.Drawing.Point(149, 86);
            this.chkCamY.Name = "chkCamY";
            this.chkCamY.Size = new System.Drawing.Size(15, 14);
            this.chkCamY.TabIndex = 59;
            this.chkCamY.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(104, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(134, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "Y";
            // 
            // CamXchk
            // 
            this.CamXchk.AutoSize = true;
            this.CamXchk.Location = new System.Drawing.Point(5, 64);
            this.CamXchk.Name = "CamXchk";
            this.CamXchk.Size = new System.Drawing.Size(15, 14);
            this.CamXchk.TabIndex = 51;
            this.CamXchk.UseVisualStyleBackColor = true;
            this.CamXchk.CheckedChanged += new System.EventHandler(this.CamXchk_CheckedChanged);
            // 
            // CamYchk
            // 
            this.CamYchk.AutoSize = true;
            this.CamYchk.Location = new System.Drawing.Point(5, 30);
            this.CamYchk.Name = "CamYchk";
            this.CamYchk.Size = new System.Drawing.Size(15, 14);
            this.CamYchk.TabIndex = 50;
            this.CamYchk.UseVisualStyleBackColor = true;
            this.CamYchk.CheckedChanged += new System.EventHandler(this.CamYchk_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(5, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Hotkey Rotation:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label17.Location = new System.Drawing.Point(116, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 16);
            this.label17.TabIndex = 134;
            this.label17.Text = "Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(68, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 16);
            this.label16.TabIndex = 135;
            this.label16.Text = "X";
            // 
            // Worker
            // 
            this.Worker.Enabled = true;
            this.Worker.Interval = 50;
            this.Worker.Tick += new System.EventHandler(this.fovt_Tick);
            // 
            // chkAuto
            // 
            this.chkAuto.Enabled = true;
            this.chkAuto.Interval = 1000;
            this.chkAuto.Tick += new System.EventHandler(this.HAK_Tick);
            // 
            // FP
            // 
            this.FP.Enabled = true;
            this.FP.Tick += new System.EventHandler(this.FP_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Cyan;
            this.txtStatus.Location = new System.Drawing.Point(-1, -1);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(170, 20);
            this.txtStatus.TabIndex = 126;
            this.txtStatus.Text = "Loading...";
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(56, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 21);
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
            // LCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(169, 386);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LCT";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.LCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamYS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamXS)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensitivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar CamYS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown SkinUD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button FLYoff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button TPVon;
        private System.Windows.Forms.Button TPVoff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDrawDistance;
        private System.Windows.Forms.CheckBox chkAltZoom;
        private System.Windows.Forms.CheckBox chkUnlockZoom;
        private System.Windows.Forms.CheckBox chkFOW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button distoff;
        private System.Windows.Forms.Button DrawDistanceOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button altoff;
        private System.Windows.Forms.Button alton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox FOVchk;
        private System.Windows.Forms.NumericUpDown FOVud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ZoomOff;
        private System.Windows.Forms.Button ZoomOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar CamXS;
        private System.Windows.Forms.CheckBox checkAOT;
        private System.Windows.Forms.CheckBox chkHotkeys;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer HotKey;
        private System.Windows.Forms.Timer Mouse;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton LCtrlHotKeyRotation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton MouseHotKeyRotation;
        private System.Windows.Forms.CheckBox chkCamX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCamY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CamXchk;
        private System.Windows.Forms.CheckBox CamYchk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer Worker;
        private System.Windows.Forms.Timer chkAuto;
        private System.Windows.Forms.Timer FP;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button FLYon;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker DoSigScan;
        private System.Windows.Forms.Timer FowTimer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown ySensitivity;
        private System.Windows.Forms.NumericUpDown xSensitivity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

