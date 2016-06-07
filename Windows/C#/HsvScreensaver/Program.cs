using System;
using System.Drawing;
using System.Windows.Forms;

namespace de.blackpinguin.gl.hsvscr {
    class Program {

        [STAThread]
        static void Main(string[] args) {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            char cmd = getParam(args, 0, 's');
            if ( cmd == 'c' ) {
                Configure();
            }
            else if ( cmd == 'p' ) {
                Preview(args);
            }
            else if ( cmd == 's' ) {
                #if DEBUG
                Configure();
                #else
                Show();
                #endif
            }
            else {
                Configure();
            }
        }


        public static void Configure() {
            Application.Run(new SettingsForm());
        }

        private static void Preview(string[] args) {
            IntPtr Ptr = new IntPtr(long.Parse(args[1]));
            Application.Run(new PreviewForm(Ptr));
        }

        public static void Show() {
            // get resolution
            int left = int.MaxValue;
            int right = int.MinValue;
            int top = int.MaxValue;
            int bottom = int.MinValue;
            foreach ( Screen s in Screen.AllScreens ) {
                left = Math.Min(s.Bounds.Left, left);
                right = Math.Max(s.Bounds.Right, right);
                top = Math.Min(s.Bounds.Top, top);
                bottom = Math.Max(s.Bounds.Bottom, bottom);
            }
            Rectangle r = new Rectangle(left, top, right - left, bottom - top);
            using ( ScreensaverWindow scr = new ScreensaverWindow(r) ) {
                scr.Run();
            }
        }

        private static char getParam(string[] args, int index, char _default) {
            if ( args.Length <= index || index < 0 ) { return _default; }
            return args[index].Trim().Substring(1, 1).ToLower()[0];
        }
    }
}
