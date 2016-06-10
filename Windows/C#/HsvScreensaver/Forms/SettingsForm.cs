using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace de.blackpinguin.gl.hsvscr {
    public partial class SettingsForm : Form {
        ScreensaverGL gl;
        bool loaded = false;
        FastBitmap dark = null;

        public SettingsForm() {
            InitializeComponent();

            // darken avatar
            dark = new FastBitmap(Properties.Resources.pingu);
            for ( int y = 0 ; y < dark.Height ; y++ ) {
                for ( int x = 0 ; x < dark.Width ; x++ ) {
                    byte[] c = dark.Get(x, y);
                    for ( byte i = 0 ; i < c.Length ; i++ ) {
                        int j = Math.Max(0, c[i] - 20);
                        //int j = c[i] - 20;
                        //Console.WriteLine(j + " -> " + (byte) j);
                        c[i] = (byte) j;
                    }
                    dark.Set(x, y, c);
                }
                //break;
            }
            if ( ! Settings.I.ShowAvatar ) {
                avatar.BackgroundImage = dark.Img;
            }

            editImagePath.Text = Settings.I.ImagePath;
            xTextureWrap.Value = (Decimal) Settings.I.TextureWrap[0];
            yTextureWrap.Value = (Decimal) Settings.I.TextureWrap[1];
            xTextureMove.Value = (Decimal) Settings.I.TextureMove[0];
            yTextureMove.Value = (Decimal) Settings.I.TextureMove[1];

            cPreRed.Value = (Decimal) Settings.I.CorrectPreRGB[0];
            cPreGreen.Value = (Decimal) Settings.I.CorrectPreRGB[1];
            cPreBlue.Value = (Decimal) Settings.I.CorrectPreRGB[2];

            cHue.Value = (Decimal) (Settings.I.CorrectHSV[0] * 3.6);
            cSaturation.Value = (Decimal) Settings.I.CorrectHSV[1];
            cValue.Value = (Decimal) Settings.I.CorrectHSV[2];

            cPostRed.Value = (Decimal) Settings.I.CorrectPostRGB[0];
            cPostGreen.Value = (Decimal) Settings.I.CorrectPostRGB[1];
            cPostBlue.Value = (Decimal) Settings.I.CorrectPostRGB[2];

            xMonitors.Value = Settings.I.Monitors[0];
            yMonitors.Value = Settings.I.Monitors[1];
            fullScreenMode.SelectedIndex = Settings.I.Fullscreen ? 2 : (Settings.I.Maximized ? 1 : 0);
            vSync.Checked = Settings.I.VSync;
            if ( ! Settings.I.VSync ) { vSync.Enabled = true; }

            speed.Value = (Decimal) Settings.I.Speed;
            intensity.Value = (Decimal) (Settings.I.Intensity * 100.0f);
            xRainbow.Value = (Decimal) Settings.I.Rainbow[0];
            yRainbow.Value = (Decimal) Settings.I.Rainbow[1];
            rndHue.Checked = Settings.I.Randomize[0];

            AssemblyName app = Assembly.GetExecutingAssembly().GetName();
            labAppName.Text = app.Name;
            labVersion.Text = "Version " + app.Version;

            //urlToolTip.SetToolTip(urlLink, "https://rcl.blackpinguin.de/");

            gl = new ScreensaverGL();
        }


        private void butCancel_Click(object sender, EventArgs e) {
            Settings.I.Load();
            this.Close();
        }

        private void butSave_Click(object sender, EventArgs e) {
            SettingsChanged(null, null);
            Settings.I.Save();
            this.Close();
        }

        private void butOpen_Click(object sender, EventArgs e) {
            DialogResult res = openFileDialog1.ShowDialog();
            if ( res == DialogResult.OK ) {
                editImagePath.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://rcl.blackpinguin.de/");
        }

        private void SettingsChanged(object sender, EventArgs e) {
            if ( gl != null ) {
                timer1.Enabled = false;
                preview.Enabled = false;

                Settings.I.ImagePath = editImagePath.Text;
                Settings.I.TextureWrap[0] = (float) xTextureWrap.Value;
                Settings.I.TextureWrap[1] = (float) yTextureWrap.Value;
                Settings.I.TextureMove[0] = (float) xTextureMove.Value;
                Settings.I.TextureMove[1] = (float) yTextureMove.Value;

                Settings.I.Monitors[0] = (int) xMonitors.Value;
                Settings.I.Monitors[1] = (int) yMonitors.Value;
                Settings.I.Fullscreen = fullScreenMode.SelectedIndex == 2;
                Settings.I.Maximized = fullScreenMode.SelectedIndex == 1;
                Settings.I.VSync = vSync.Checked;

                Settings.I.CorrectPreRGB[0] = (float) cPreRed.Value;
                Settings.I.CorrectPreRGB[1] = (float) cPreGreen.Value;
                Settings.I.CorrectPreRGB[2] = (float) cPreBlue.Value;

                Settings.I.CorrectHSV[0] = (float) cHue.Value / 3.6f;
                Settings.I.CorrectHSV[1] = (float) cSaturation.Value;
                Settings.I.CorrectHSV[2] = (float) cValue.Value;

                Settings.I.CorrectPostRGB[0] = (float) cPostRed.Value;
                Settings.I.CorrectPostRGB[1] = (float) cPostGreen.Value;
                Settings.I.CorrectPostRGB[2] = (float) cPostBlue.Value;

                Settings.I.Speed = (float) speed.Value;
                Settings.I.Intensity = (float) intensity.Value * 0.01f;
                Settings.I.Rainbow[0] = (float) xRainbow.Value;
                Settings.I.Rainbow[1] = (float) yRainbow.Value;

                if ( rndHue.Checked != Settings.I.Randomize[0] ) {
                    Settings.I.Randomize[0] = rndHue.Checked;
                    gl.ResetRandom();
                }

                if ( loaded ) {
                    gl.RefreshUniforms();
                }

                preview.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private void ImageChanged(object sender, EventArgs e) {
            if ( gl != null && editImagePath.Text != Settings.I.ImagePath ) {
                timer1.Enabled = false;
                preview.Enabled = false;

                Settings.I.ImagePath = editImagePath.Text;

                try {
                    loaded = false;
                    gl.Load(preview.Width, preview.Height);
                    gl.ReloadImage();
                    loaded = true;
                }
                catch ( Exception ) {
                    loaded = false;
                    gl.Clear();
                    preview.SwapBuffers();
                }

                preview.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private void preview_Load(object sender, EventArgs e) {
            if ( !loaded ) {
                bool ava = Settings.I.ShowAvatar;
                Settings.I.ShowAvatar = true;
                try {
                    gl.Load(preview.Width, preview.Height);
                    loaded = true;
                }
                catch ( Exception ) {
                    loaded = false;
                    //Console.WriteLine(ex.Message.ToString() + " : " + ex.StackTrace.ToString());
                }
                Settings.I.ShowAvatar = ava;
            }
        }

        private void preview_Paint(object sender, PaintEventArgs e) {
            if ( gl != null && loaded ) {
                gl.RenderFrame();
                preview.SwapBuffers();
            }
        }

        private void preview_Resize(object sender, EventArgs e) {
            if ( gl != null && loaded ) {
                gl.Resize(preview.Width, preview.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if ( gl != null && loaded ) {
                gl.UpdateFrame();
                gl.RenderFrame();
                preview.SwapBuffers();
            }
        }

        private void preview_Click(object sender, EventArgs e) {
            if ( gl != null && loaded ) {
                new System.Threading.Thread(() => {
                    Program.Show();
                }).Start();
            }
        }

        private void avatar_Click(object sender, EventArgs e) {
            Bitmap pic = Properties.Resources.pingu;

            Settings.I.ShowAvatar = !Settings.I.ShowAvatar;
            if ( !Settings.I.ShowAvatar ) {
                pic = dark.Img;
            }
            avatar.BackgroundImage = pic;
        }
    }
}
