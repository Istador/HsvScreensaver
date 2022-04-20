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

            char cmd = getCommand(args, 0, 's');
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
            else if ( cmd == 'w' ) {
                Settings.I.Windowed   = true;
                Settings.I.Maximized  = false;
                Settings.I.Fullscreen = false;
                int w = (int.TryParse(getParam(args, 1, ""), out w) ? w : int.MaxValue);
                int h = (int.TryParse(getParam(args, 2, ""), out h) ? h : int.MaxValue);
                Show(w, h);
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

        public static void Show(int width = int.MaxValue, int height = int.MaxValue) {
            // get resolution
            int left   = int.MaxValue;
            int right  = int.MinValue;
            int top    = int.MaxValue;
            int bottom = int.MinValue;
            foreach ( Screen s in Screen.AllScreens ) {
                left   = Math.Min(s.Bounds.Left,   left);
                right  = Math.Max(s.Bounds.Right,  right);
                top    = Math.Min(s.Bounds.Top,    top);
                bottom = Math.Max(s.Bounds.Bottom, bottom);
            }
            width  = Math.Min(width,  right - left);
            height = Math.Min(height, bottom - top);
            Rectangle r = new Rectangle(left, top, width, height);
            using ( ScreensaverWindow scr = new ScreensaverWindow(r) ) {
                scr.Run();
            }
        }

        private static string getParam(string[] args, int index, string _default) {
            if ( args.Length <= index || index < 0 ) { return _default; }
            return args[index].Trim();
        }

        private static char getCommand(string[] args, int index, char _default) {
            return getParam(args, index, "/" + _default).Substring(1, 1).ToLower()[0];
        }
    }
}
