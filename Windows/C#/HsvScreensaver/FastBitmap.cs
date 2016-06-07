using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace de.blackpinguin.gl.hsvscr {

    class FastBitmap {
        private Bitmap _Img;
        public Bitmap Img {
            get { Unlock(); return _Img; }
            private set { _Img = value; } }
        private BitmapData ImgData { get; set; }
        private Rectangle r;
        private unsafe byte* Ptr;
        private int bpp;

        public int Depth { get; private set; }
        public int Width { get { return _Img.Width; } }
        public int Height { get { return _Img.Height; } }

        private bool locked = false;

        public unsafe void Lock() {
            if ( locked ) { return; }
            ImgData = _Img.LockBits(r, ImageLockMode.ReadWrite, _Img.PixelFormat);
            Ptr = (byte*) ImgData.Scan0.ToPointer();
            locked = true;
        }

        public void Unlock() {
            if (! locked) { return; }
            _Img.UnlockBits(ImgData);
            locked = false;
        }

        public FastBitmap(string filename) : this(new Bitmap(filename)) { }

        public FastBitmap(Bitmap img) {
            _Img = img;

            Depth = System.Drawing.Bitmap.GetPixelFormatSize(_Img.PixelFormat);
            if ( Depth != 8 && Depth != 24 && Depth != 32 ) {
                throw new ArgumentException("Bild nicht geeignet (Farbtiefe)");
            }

            r = new Rectangle(0, 0, Width, Height);

            bpp = Image.GetPixelFormatSize(_Img.PixelFormat) / 8;
        }

        public unsafe Color GetColor(int x, int y) {
            Lock();

            byte[] c = Get(x, y);
            byte a = 0, r = 0, g = 0, b = 0;
            if ( c.Length == 1 ) {
                a = 255;
                b = r = g = c[0];
            }
            else if ( c.Length == 3 ) {
                b = c[0];
                g = c[1];
                r = c[2];
                a = 255;
            }
            else if ( c.Length == 4 ) {
                b = c[0];
                g = c[1];
                r = c[2];
                a = c[3];
            }
            return Color.FromArgb(a, r, g, b);
        }

        public unsafe byte[] Get(int x, int y) {
            Lock();

            byte* data = Ptr + y * ImgData.Stride + x * bpp;

            byte n = (byte) (Depth / 8);
            byte[] o = new byte[n];
            for ( byte i = 0 ; i < n ; i++ ) {
                o[i] = *(data++);
            }
            return o; // bgra
        }

        public unsafe void Set(int x, int y, byte[] bgra) {
            switch ( bgra.Length ) {
                case 1:
                Set(x, y, bgra[0], bgra[0], bgra[0]);
                return;
                case 3:
                Set(x, y, bgra[2], bgra[1], bgra[0]);
                return;
                case 4:
                Set(x, y, bgra[2], bgra[1], bgra[0], bgra[3]);
                return;
                default:
                Set(x, y, 0, 0, 0);
                return;
            }
        }

        public unsafe void Set(int x, int y, Color c) {
            Set(x, y, c.R, c.G, c.B, c.A);
        }


        public unsafe void Set(int x, int y, byte r, byte g, byte b, byte a = 255) {
            Lock();

            byte* data = Ptr + y * ImgData.Stride + x * bpp;

            if ( Depth == 32 ) { // bgra
                *(data++) = b;
                *(data++) = g;
                *(data++) = r;
                *(data++) = a;
                return;
            }
            if ( Depth == 24 ) { // bgr
                *(data++) = b;
                *(data++) = g;
                *(data++) = r;
                return;

            }
            if ( Depth == 8 ) {
                *(data++) = Math.Max(r, Math.Max(g, b));
                return;
            }
        }
    }
}