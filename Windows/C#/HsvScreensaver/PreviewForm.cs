using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices; //DllImport

namespace de.blackpinguin.gl.hsvscr {
    public partial class PreviewForm : Form {

        #region dll import
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);
        #endregion

        ScreensaverGL gl;
        bool loaded = false;

        public PreviewForm(IntPtr PreviewHandle) {
            InitializeComponent();
            SetParent(this.Handle, PreviewHandle);
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            Rectangle ParentRect;
            GetClientRect(PreviewHandle, out ParentRect);
            this.Size = ParentRect.Size;
            this.Location = new Point(0, 0);

            Settings.I.Monitors[0] = 1;
            Settings.I.Monitors[1] = 1;

            gl = new ScreensaverGL();
        }


        private void timer1_Tick(object sender, EventArgs e) {
            if ( gl != null && loaded ) {
                gl.UpdateFrame();
                gl.RenderFrame();
                preview.SwapBuffers();
            }
        }

        private void preview_Load(object sender, EventArgs e) {
            if ( !loaded ) {
                try {
                    gl.Load(preview.Width, preview.Height);
                    loaded = true;
                }
                catch ( Exception ) {
                    loaded = false;
                }
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
    }
}
