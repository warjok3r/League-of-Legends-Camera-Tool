using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;



namespace LCT
{
    public partial class frmLCT : Form
    {

        public frmLCT()
        {
            InitializeComponent();
        }
        
        //Randomise Window Name
        private void LCT_Load(object sender, EventArgs e)
        {
            Text = Path.GetRandomFileName().Replace(".", "");
        }

        void frmLCT_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message msg = Message.Create(Handle, 0xA1, (IntPtr)0x02, IntPtr.Zero);
            base.WndProc(ref msg);
        }

        #region "Imports"

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        #endregion
       
        #region "Address Cache"
        // Memory Address Cache
        IntPtr sig_MinMax1;
        IntPtr sig_MixMax2;
        IntPtr sig_ThirdPerson;
        IntPtr sig_Fly;
        IntPtr sig_FieldOfView;
        IntPtr sig_Blank;
        IntPtr sig_AltZoom;
        IntPtr sig_FogofWar;
        IntPtr sig_X_Rotation;
        IntPtr sig_CreateHero;
        IntPtr sig_DrawDistance;
        #endregion

        IntPtr ClientBase;

        public string Status;

        int ScanFail;
                 //   this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LCT_MouseClick);

        IntPtr free;

        public decimal MouseX;
        public decimal MouseY;

        public float xx = 180f;
        public float yy = 56f;


        //Find Process
        private void FP_Tick(object sender, EventArgs e)
        {
            txtStatus.Text = Status;
            Process[] processesByName = Process.GetProcessesByName("League of Legends");
            if (processesByName.Length != 1)
            {
                Status = "Searching for LoL Game...";
                FP.Interval = 100;

                //Release
                Function.ClearPID();
                sig_MinMax1 = free;
                sig_DrawDistance = free;
                chkTP.Checked = false;
                chkFlyCam.Checked = false;
                ScanFail = 0;                
            }
            if (processesByName.Length != 0)
            {
                Status = "Game Found, Tool Ready";
              //  FP.Interval = 1000;
                if (sig_MinMax1.ToInt32() == 0)
                {
                    if (!DoSigScan.IsBusy)
                    {
                        Status = "Scanning...";
                        DoSigScan.RunWorkerAsync();
                    }
                }
            }
        }


        
        private void ZoomOn_Click(object sender, EventArgs e)
        {
            Function.WriteFloat(sig_Blank.ToInt32(), 99999f);
            Function.WriteFloat(sig_Blank.ToInt32() + 0x04, -99999f );

            Thread.Sleep(100);

            byte[] floatVals = BitConverter.GetBytes(sig_Blank.ToInt32());
            Function.WriteByteArray(sig_MinMax1.ToInt32() - 9, 4, floatVals );
            Function.WriteByteArray(sig_MixMax2.ToInt32() + 28, 4, floatVals );

            byte[] floatVals2 = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x04);
            Function.WriteByteArray(sig_MinMax1.ToInt32() + 4, 4, floatVals2);
            Function.WriteByteArray(sig_MixMax2.ToInt32() + 0x29, 4, floatVals2);            
        }

        private void ZoomOff_Click(object sender, EventArgs e)
        {
            Function.WriteFloat(sig_Blank.ToInt32(), 2250f);
            Function.WriteFloat(sig_Blank.ToInt32() + 0x04, 1000f);
        }

        private void alton_Click(object sender, EventArgs e)
        {

            Function.WriteFloat(sig_Blank.ToInt32() + 0x0C, 1000f);

            Thread.Sleep(100);

            byte[] floatVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x0C);
            Function.WriteByteArray(sig_AltZoom.ToInt32() + 0x22, 4, floatVals);
            Function.WriteByteArray(sig_AltZoom.ToInt32() + 0x32, 4, floatVals);

            
        }

        private void altoff_Click(object sender, EventArgs e)
        {
            Function.WriteFloat(sig_Blank.ToInt32() + 0x0C, 600);
        }

        private void Diston_Click(object sender, EventArgs e)
        {
            Function.WriteFloat(sig_DrawDistance.ToInt32(), 100000f);

        }

        private void DrawDistanceOff(object sender, EventArgs e)
        {
            Function.WriteFloat(sig_DrawDistance.ToInt32(), 5000f);
        }

        private void TPVon_Click(object sender, EventArgs e)
        {
            chkDrawDistance.Checked = true;
            Thread.Sleep(200);
            Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x06, 1, new byte[] { 0x75 });
        }

        private void TPVoff_Click(object sender, EventArgs e)
        {
            Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x06, 1, new byte[] { 0x74 });
        }

        private void FLYon_Click(object sender, EventArgs e)
        {
            chkDrawDistance.Checked = true;
            Thread.Sleep(200);
            Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x0C, 1, new byte[] { 0x75 });
            Function.WriteByteArray(sig_Fly.ToInt32() - 0x03, 1, new byte[] { 0x75 });
        }

        private void FLYoff_Click(object sender, EventArgs e)
        {
            Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x0C, 1, new byte[] { 0x74 });
            Function.WriteByteArray(sig_Fly.ToInt32() - 0x03, 1, new byte[] { 0x74 });
        }

        private void fovt_Tick(object sender, EventArgs e)
        {
            byte[] CamYVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x10);

            byte[] CamXVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x14);
           

            if (CamYchk.Checked)
            {
                Function.WriteByteArray(sig_AltZoom.ToInt32() - 0x055, 4, CamYVals );
                Function.WriteFloat(sig_Blank.ToInt32() + 0x10, (float)CamYS.Value);
            }
            if (CamXchk.Checked)
            {
                Function.WriteByteArray(sig_X_Rotation.ToInt32() - 0x24, 4, CamXVals);
                Function.WriteFloat(sig_Blank.ToInt32() + 0x14, (float)CamXS.Value);
            }

            if (chkCamX.Checked)
            {
                Function.WriteFloat(sig_Blank.ToInt32() + 0x14, xx);
                Function.WriteByteArray(sig_X_Rotation.ToInt32() - 0x24, 4, CamXVals);
            }

            if (chkCamY.Checked)
            {
                  Function.WriteFloat(sig_Blank.ToInt32() + 0x10, yy);
                Function.WriteByteArray(sig_AltZoom.ToInt32() - 0x055, 4, CamYVals);
            }

            if (chkHotkeys.Checked)
            {
                HotKey.Enabled = true;
            }
            if (!chkHotkeys.Checked)
            {
                HotKey.Enabled = false;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.Multiply)))
            {
                chkHotkeys.Checked = false;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.Divide)))
            {
                chkHotkeys.Checked = true;
            }
            if (checkAOT.Checked)
            {
                base.TopMost = true;
            }
            if (!checkAOT.Checked)
            {
                base.TopMost = false;
            }

            if (chkAltZoom.Checked == true || chkUnlockZoom.Checked == true || chkDrawDistance.Checked == true || chkFlyCam.Checked == true || chkTP.Checked == true || chkFOW.Checked == true)
            {
                FowTimer.Enabled = true;
            }
            else
            {
            //    FowTimer.Enabled = false;
            }
        }

        private void Mouse_Tick(object sender, EventArgs e)
        {
            numericUpDown1.Value = Cursor.Position.X;
            numericUpDown2.Value = Cursor.Position.Y;

            MouseX = Cursor.Position.X;
            MouseY = Cursor.Position.Y;
        }

        private void HotKey_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad0)))
            {
                chkDrawDistance.Checked = true;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.Decimal)))
            {
                chkDrawDistance.Checked = false;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad1)))
            {
                chkUnlockZoom.Checked = true;               
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad3)))
            {
                chkUnlockZoom.Checked = false;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad7)))
            {
                chkAltZoom.Checked = true;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad9)))
            {
                chkAltZoom.Checked = false;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad8)))
            {
                if (CamYS.Value < 250)
                {
                    CamYS.Value++;
                }
                CamYchk.Checked = true;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad2)))
            {
                if (CamYS.Value > 1)
                {
                    CamYS.Value--;
                }
                CamYchk.Checked = true;
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad6)))
            {
                if (CamXS.Value < 350)
                {
                    CamXS.Value++;
                }
                CamXchk.Checked = true;
                Thread.Sleep(100);
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad4)))
            {
                if (CamXS.Value > 5)
                {
                    CamXS.Value--;
                }
                CamXchk.Checked = true;
                Thread.Sleep(100);
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.Add)))
            {
                if (FOVud.Value < 1000M)
                {
                    //     FOVud.Value = decimal.op_Increment(FOVud.Value);
                }
                
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.Subtract)))
            {
                if (FOVud.Value > 1M)
                {
                    //           FOVud.Value = decimal.op_Decrement(FOVud.Value);
                }
            }
            if (Convert.ToBoolean(GetAsyncKeyState(Keys.NumPad5)))
            {
                chkUnlockZoom.Checked = false;
                FOVud.Value = 50M;
                chkAltZoom.Checked = false;
                CamYS.Value = 0x38;
                CamXS.Value = 3;
                chkFOW.Checked = false;
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bool LCtrl;
            if (MouseHotKeyRotation.Checked)
            {
                LCtrl = Convert.ToBoolean(GetAsyncKeyState(Keys.MButton));
                if (chkCamX.Checked && LCtrl)
                {
                    if (numericUpDown1.Value < MouseX)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x14, xx + (float)xSensitivity.Value);
                        xx += (float)xSensitivity.Value;
                    }
                    else if (numericUpDown1.Value > MouseX)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x14, xx - (float)xSensitivity.Value);
                        xx -= (float)xSensitivity.Value;
                    }
                }
            }
            else if (LCtrlHotKeyRotation.Checked)
            {
                LCtrl = Convert.ToBoolean(GetAsyncKeyState(Keys.LControlKey));
                if ((chkCamX.Checked) && LCtrl)
                {
                    if (numericUpDown1.Value < MouseX)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x14, xx + (float)xSensitivity.Value);
                        xx += (float)xSensitivity.Value;
                    }
                    else if (numericUpDown1.Value > MouseX)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x14, xx - (float)xSensitivity.Value);
                        xx -= (float)xSensitivity.Value;
                    }
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            byte[] CamYVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x10);

            bool HotKey;
            if (MouseHotKeyRotation.Checked)
            {
                HotKey = Convert.ToBoolean(GetAsyncKeyState(Keys.MButton));
                if ((chkCamY.Checked) && HotKey)
                {
                    if (numericUpDown2.Value < MouseY)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x10, yy - (float)ySensitivity.Value);
                        yy -= (float)ySensitivity.Value;
                    }
                    if (numericUpDown2.Value > MouseY)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x10, yy + (float)ySensitivity.Value);
                        yy += (float)ySensitivity.Value;
                    }
                }
            }
            if (LCtrlHotKeyRotation.Checked)
            {
                HotKey = Convert.ToBoolean(GetAsyncKeyState(Keys.LControlKey));
                if ((chkCamY.Checked) && HotKey)
                {
                    if (numericUpDown2.Value < MouseY)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x10, yy - (float)ySensitivity.Value);
                        yy -= (float)ySensitivity.Value;
                    }
                    if (numericUpDown2.Value > MouseY)
                    {
                        Function.WriteFloat(sig_Blank.ToInt32() + 0x10, yy + (float)ySensitivity.Value);
                        yy += (float)ySensitivity.Value;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=W8PSTHPJ5CZ9E&lc=NZ&item_name=%2aM%2a&currency_code=NZD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted");
        }



        private void CamYchk_CheckedChanged(object sender, EventArgs e)
        {
            CamYS.Value = 56;
            chkCamY.Checked = false;
        }

        private void CamXchk_CheckedChanged(object sender, EventArgs e)
        {
            CamXS.Value = 180;
            chkCamX.Checked = false;
        }

        private void Update(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/sh/r3wr04yrz27v968/5ACZLgxd_U");

        //    System.Diagnostics.Process.Start("http://www.mpgh.net/forum/forumdisplay.php?f=258");

       //       System.Diagnostics.Process.Start("http://www.unknowncheats.me/forum/other-mmorpg-and-strategy/108000-league-legends-camera-tool-zoom-hack-third-person-more.html");
        }


        private void DoSigScan_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)  //Run Signature scan in a separate thread so it doesn't kill the GUI
        {
            //Find and set Base address to scan from
            ClientBase = Function.GetModuleBaseAddress("League of Legends", "League of Legends.exe");
            if (ClientBase.ToInt32() == 0)
            {
                ClientBase = Function.GetModuleBaseAddress("League of Legends", "League Of Legends.exe");
            }

            Status = "Scanning...";
            SigScan scan = new SigScan(new IntPtr(ClientBase.ToInt32() + 0x1000), 0xffffff);

            sig_MinMax1 = scan.FindPattern(new byte[] { 0x0F, 0x2F, 0xE8, 0x77, 0x0D }, "xxxxx", 5); //MinMax1
            sig_MixMax2 = scan.FindPattern(new byte[] { 0x84, 0xC9, 0x74, 0x1A, 0x85, 0xC0 }, "xxx?xx", 6); //MinMax2

            sig_ThirdPerson = scan.FindPattern(new byte[] { 0x55, 0x8B, 0xEC, 0xA1, 0x7C, 0xCF, 0x09, 0x02, 0x83, 0xEC, 0x18, 0x56, 0x48, 0x74, 0x32, 0xFF, 0x75, 0x08, 0x48, 0x74, 0x20, 0x48, 0x74, 0x0C, 0xE8 }, "x????????????x????xx?xx?x", 25); //tpv
            sig_Fly = scan.FindPattern(new byte[] { 0xA1, 0xFC, 0xB3, 0xD4, 0x03, 0x48, 0x74, 0x0A, 0x48 }, "x????x??x", 9); //tpv

            sig_FieldOfView = scan.FindPattern(new byte[] { 0xF3, 0x0F, 0x5C, 0xEA, 0xF3, 0x0F, 0x5C, 0xCC }, "xxxxxxxx", 8); //fov

            sig_Blank = scan.FindPattern(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, }, "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", 40);

            sig_AltZoom = scan.FindPattern(new byte[] { 0xF3, 0x0F, 0x10, 0x5D, 0xEC, 0xF3, 0x0F, 0x10, 0x55, 0xE8, 0x0F, 0x57, 0x15 }, "xxxx?xxxx?xxx", 13);  //alt

            sig_FogofWar = scan.FindPattern(new byte[] { 0x85, 0xC0, 0x74, 0x0E, 0x8B, 040, 0x0C, 0x85, 0xC0, 0x74, 0x05 }, "xxxx???xxxx", 11);

            sig_X_Rotation = scan.FindPattern(new byte[] { 0xD9, 0x55, 0xF8, 0xD9, 0xE1, 0xDD, 0x05, 0x98, 0x56, 0xA4, 0x01, 0xD9, 0xC9, 0xDF, 0xF1, 0xDD, 0xD8 }, "x??xxxx????xxxxxx", 17);

            sig_CreateHero = scan.FindPattern(new byte[] { 0x0F, 0x84, 0x52, 0x03, 0x00, 0x00, 0x68, 0xA4, 0x48, 0xDE, 0x00, 0x6A, 0x00, 0x6A, 0x01, 0x6A, 0x03, 0xE8, 0x09, 0x26, 0xD0, 0xFF, 0x83, 0xC4, 0x10, 0x8D, 0x43, 0x17, 0x50 }, "x?????x????xxxxxxx??????????x", 29);

            //Draw distance sig is in another part of the executable (rdata?) so to save time and memory start a new scan further north of the base address.
            sig_DrawDistance = new SigScan(new IntPtr(ClientBase.ToInt32() + 0x0200000), 0xffffff).FindPattern(new byte[] { 

                    0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,    
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,   
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x48, 0x42,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7A, 0x44, 0x00, 0x00, 0x7A, 0x44, 0x00, 0x00, 0x00, 0x00,
                    0x75, 0x19, 0xD7, 0x43, 0x90, 0x88, 0xBA, 0x44, 0x40, 0xE6, 0xF5, 0x41, 0x00, 0x00, 0x48, 0x42,
                 }, "xxxx????????????????????????????????????????????????????????????????????????????????????????????????????????xxxx", 112);
            
            
  /*          //Draw distance sig is in another part of the executable (rdata?) so to save time and memory start a new scan further north of the base address.
            sig_DrawDistance = new SigScan(new IntPtr(sig_ClientBase.ToInt32() + 0x0200000), 0xffffff).FindPattern(new byte[] { 
                    0, 0, 0, 0, 0, 0, 0x80, 0x3f, 0xff, 0xff, 0xff, 0xff, 
                    0xd4, 90, 120, 1, 0xb0, 0x91, 0x7a, 1, 0x94, 0x91, 0x7a, 1, 0, 0, 0, 0, 
                    0xd4, 90, 120, 1, 0xe8, 0x1f, 0x7d, 1, 0xc0, 0x1f, 0x7d, 1, 1, 0, 0, 0, 
                    0, 0, 0xb9, 0x45, 0x90, 0x88, 0xba, 0x44, 0x9f, 3, 130, 0x45, 0, 0, 0x48, 0x42
                 }, "xxxx????????????????????xxxx????????????????????????????xxxx", 0x36);*/
            //Clean Up
            GC.Collect();

            //Check if one or all of the patterns are broken
            if (sig_MinMax1 == IntPtr.Zero || sig_MixMax2 == IntPtr.Zero || sig_ThirdPerson == IntPtr.Zero || sig_Fly == IntPtr.Zero || sig_FieldOfView == IntPtr.Zero || sig_Blank == IntPtr.Zero || sig_AltZoom == IntPtr.Zero || sig_FogofWar == IntPtr.Zero || sig_X_Rotation == IntPtr.Zero || sig_DrawDistance == IntPtr.Zero)
            {
                //Check if just one or more patterns are broken
                if ((sig_MinMax1.ToInt32() + sig_MixMax2.ToInt32() + sig_ThirdPerson.ToInt32() + sig_Fly.ToInt32() + sig_FieldOfView.ToInt32() + sig_Blank.ToInt32() + sig_AltZoom.ToInt32() + sig_FogofWar.ToInt32() + sig_X_Rotation.ToInt32() + sig_DrawDistance.ToInt32()) != 0)
                {
                    Status = "Scan Fail, Check Updates";
                    Thread.Sleep(100);
                    FP.Enabled = false;
                }

                //Check if all patterns are broken or there was an issue scanning the executable.
                if ((sig_MinMax1.ToInt32() + sig_MixMax2.ToInt32() + sig_ThirdPerson.ToInt32() + sig_Fly.ToInt32() + sig_FieldOfView.ToInt32() + sig_Blank.ToInt32() + sig_AltZoom.ToInt32() + sig_FogofWar.ToInt32() + sig_X_Rotation.ToInt32() + sig_DrawDistance.ToInt32()) == 0)
                {
                    //Scan failed so add 1 to scan fail
                    ScanFail = ScanFail + 1;
                    //Target Process might not be fully loaded yet so wait one second and then continue.
                    Thread.Sleep(1000);

                    //If scan has failed 10 times switch off the find process timer and display error status.
                    if (ScanFail > 10)
                    {
                        Status = "Scan Error";
                        Thread.Sleep(100);
                        FP.Enabled = false;
                    }
                }
            }
        }

        private void FowTimer_Tick(object sender, EventArgs e)
        {
            if (chkFOW.Checked)
            {
                Function.WriteByteArray(sig_FogofWar.ToInt32() - 0x19, 1, new byte[] { 0x1 });
            }
            if (!chkFOW.Checked)
            {
                Function.WriteByteArray(sig_FogofWar.ToInt32() - 0x19, 1, new byte[] { 0x0 });
            }

            if (chkUnlockZoom.Checked)
            {
                Function.WriteFloat(sig_Blank.ToInt32(), 99999f);
                Function.WriteFloat(sig_Blank.ToInt32() + 0x04, -99999f);

                Thread.SpinWait(100);

                byte[] floatVals = BitConverter.GetBytes(sig_Blank.ToInt32());
                Function.WriteByteArray(sig_MinMax1.ToInt32() - 9, 4, floatVals);
                Function.WriteByteArray(sig_MixMax2.ToInt32() + 28, 4, floatVals);

                byte[] floatVals2 = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x04);
                Function.WriteByteArray(sig_MinMax1.ToInt32() + 4, 4, floatVals2);
                Function.WriteByteArray(sig_MixMax2.ToInt32() + 0x29, 4, floatVals2);  
            }
            if (!chkUnlockZoom.Checked)
            {
                Function.WriteFloat(sig_Blank.ToInt32(), 2250f);
                Function.WriteFloat(sig_Blank.ToInt32() + 0x04, 1000f);
            }

            if (chkAltZoom.Checked)
            {
                Function.WriteFloat(sig_Blank.ToInt32() + 0x0C, 1000f);

                Thread.SpinWait(100);

                byte[] floatVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x0C);
                Function.WriteByteArray(sig_AltZoom.ToInt32() + 0x22, 4, floatVals);
                Function.WriteByteArray(sig_AltZoom.ToInt32() + 0x32, 4, floatVals);
            }
            if (!chkAltZoom.Checked)
            {
                Function.WriteFloat(sig_Blank.ToInt32() + 0x0C, 600);
            }

            if (chkDrawDistance.Checked)
            {
                Function.WriteFloat(sig_DrawDistance.ToInt32(), 100000f);
            }
            if (!chkDrawDistance.Checked)
            {
                Function.WriteFloat(sig_DrawDistance.ToInt32(), 5000f);
            }

            if (chkTP.Checked)
            {
                chkDrawDistance.Checked = true;
                Thread.SpinWait(200);
                Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x06, 1, new byte[] { 0x75 });
            }
            if (!chkTP.Checked)
            {
                Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x06, 1, new byte[] { 0x74 });
            }

            if (chkFlyCam.Checked)
            {
                chkDrawDistance.Checked = true;
                Thread.SpinWait(200);
                Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x0C, 1, new byte[] { 0x75 });
                Function.WriteByteArray(sig_Fly.ToInt32() - 0x03, 1, new byte[] { 0x75 });
            }
            if (!chkFlyCam.Checked)
            {
                Function.WriteByteArray(sig_ThirdPerson.ToInt32() - 0x0C, 1, new byte[] { 0x74 });
                Function.WriteByteArray(sig_Fly.ToInt32() - 0x03, 1, new byte[] { 0x74 });
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FOVud_ValueChanged(object sender, EventArgs e)
        {
            byte[] FOVVals = BitConverter.GetBytes(sig_Blank.ToInt32() + 0x08);

                Function.WriteByteArray(sig_FieldOfView.ToInt32() + 0xF, 4, FOVVals);
                float FOVv = float.Parse(FOVud.Value.ToString());
                Function.WriteFloat(sig_Blank.ToInt32() + 0x08, FOVv);            
        }

        private void chkCamX_CheckedChanged(object sender, EventArgs e)
        {
            CamXchk.Checked = false;
        }

        private void chkCamY_CheckedChanged(object sender, EventArgs e)
        {
            CamYchk.Checked = false;
        }

        private void chkDrawDistance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAltZoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUnlockZoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chkHotkeys.Checked = false;
        }


        private void chkFOW_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.Show();
        }

        private void HAK_Tick(object sender, EventArgs e)
        {

        }

    }
}


/* Old Cave for X-rotation before it was in the client, modifies a register at achieve X-rotation
             byte[] array = BitConverter.GetBytes(Blank2 - (AltZ.ToInt32() + 0x38));
             Function.WriteByteArray(AltZ.ToInt32() + 0x33, 1, new byte[] { 0xe9 });
             Function.WriteByteArray(AltZ.ToInt32() + 0x34, 4, array);
             Function.WriteByteArray(AltZ.ToInt32() + 0x38, 2, new byte[] { 0x90, 0x90 });

             byte[] array2 = BitConverter.GetBytes((AltZ.ToInt32() + 0x33) - (Blank2 + 10));

             Function.WriteByteArray(Blank2, 8, new byte[] { 0x0F, 0x28, 0xE0, 0x36, 0xF3, 0x0F, 0x59, 0x25 });

             Function.WriteByteArray(Blank2 + 8, 4, floatVals );
                
 
             Function.WriteByteArray(Blank2 + 12, 1, new byte[] { 0xe9 });
             Function.WriteByteArray(Blank2 + 13, 4, array2);
    */


/*          Old Skin mod, code broken atm            
            int num = (this.sig_Blank.ToInt32() + 0x22) - this.sig_CreateHero.ToInt32();
            byte[] bytes = BitConverter.GetBytes(uint.Parse(num.ToString("X"), NumberStyles.AllowHexSpecifier));
            num = this.sig_CreateHero.ToInt32() + 6;
            byte[] array = BitConverter.GetBytes(uint.Parse(num.ToString("X"), NumberStyles.AllowHexSpecifier));
            Function.WriteByteArray(this.sig_CreateHero.ToInt32() - 0x07, 1, new byte[] { 0xe9 });
            Function.WriteByteArray(this.sig_CreateHero.ToInt32() - 0x06, 4, bytes);
           Function.WriteByteArray(this.sig_CreateHero.ToInt32() - 0x02, 1, new byte[] { 0x90 });
            Function.WriteByteArray(this.sig_Blank.ToInt32() + 0x20, 0x2d, new byte[] { 
                    0x83, 0xc4, 0x10, 0x8d, 0x43, 0x17, 0x60, 0x8b, 0xf3, 0xba, 140, 0x66, 0xcf, 1, 0x3e, 0x83, 
                    0x7a, 0x10, 15, 0x7e, 3, 0x3e, 0x8b, 0x12, 0x33, 0xc9, 0x33, 0xdb, 0x3e, 0x8a, 0x1c, 10, 
                    0x3e, 0x3a, 0x1c, 8, 0x75, 12, 0x41, 0x83, 0xfb, 0, 0x75, 240, 0xb0
                 });
            byte[] buffer3 = BitConverter.GetBytes(uint.Parse(this.numericUpDown3.Value.ToString(), NumberStyles.AllowHexSpecifier));
            Function.WriteByteArray(this.sig_Blank.ToInt32() + 0x4d, 1, buffer3);
            Function.WriteByteArray(this.sig_Blank.ToInt32() + 0x4e, 6, new byte[] { 0x3e, 0x88, 70, 0x13, 0x61, 0x68 });
            Function.WriteByteArray(this.sig_Blank.ToInt32() + 0x54, 4, array);
            Function.WriteByteArray(this.sig_Blank.ToInt32() + 0x58, 1, new byte[] { 0xc3 });

*/