using System;
using System.Drawing;
using System.Drawing.Imaging;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace de.blackpinguin.gl.hsvscr {
    class Texture {
        private int id;

        public Texture(string file_name, bool IsRepeated = false, bool IsSmooth = true) : this(new Bitmap(file_name), IsRepeated, IsSmooth) { }

        public Texture(Bitmap bitmap, bool IsRepeated = false, bool IsSmooth = true) {
            try {
                TextureTarget tt = TextureTarget.Texture2D;

                // texture alloc
                GL.GenTextures(1, out id);
                GL.BindTexture(tt, id);

                // load texture
                BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.TexImage2D(tt, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
                bitmap.UnlockBits(data);

                // texture filtering
                GL.TexParameter(tt, TextureParameterName.TextureWrapS, IsRepeated ? Convert.ToInt32(TextureWrapMode.Repeat) : Convert.ToInt32(TextureWrapMode.ClampToEdge));
                GL.TexParameter(tt, TextureParameterName.TextureWrapT, IsRepeated ? Convert.ToInt32(TextureWrapMode.Repeat) : Convert.ToInt32(TextureWrapMode.ClampToEdge));
                GL.TexParameter(tt, TextureParameterName.TextureMagFilter, IsSmooth ? Convert.ToInt32(TextureMagFilter.Linear) : Convert.ToInt32(TextureMagFilter.Nearest));
                GL.TexParameter(tt, TextureParameterName.TextureMinFilter, IsSmooth ? Convert.ToInt32(TextureMinFilter.Linear) : Convert.ToInt32(TextureMinFilter.Nearest));
            }
            catch ( Exception ex ) {
                Console.WriteLine("Error creating Texture:" + Environment.NewLine + ex.Message, "Error");
                id = -1;
            }
        }

        public void Bind() {
            if ( id != -1 ) {
                GL.BindTexture(TextureTarget.Texture2D, id);
            }
        }

        public void Unbind() {
            if ( id != -1 ) {
                GL.BindTexture(TextureTarget.Texture2D, 0);
            }
        }

        public void Delete() {
            if ( id != -1 ) {
                Unbind();
                GL.DeleteTexture(id);
                id = -1;
            }
        }
    }
}
