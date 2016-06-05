using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace de.blackpinguin.gl.hsvscr {
    class ScreensaverGL {
        private Shader shader;
        private Texture tBackground;
        private Texture tAvatar;
        private double hue = 0.0;

        /*private VertexBufferObjectD Verticies;
        private IndexBufferObject Indicies;*/
        DisplayList dlBackground;
        DisplayList dlAvatar;

        /// <summary>
        /// passed time since last get in seconds
        /// </summary>
        private double Δt {
            get {
                long now = DateTime.Now.ToFileTime();
                double _Δt = ((double) (now - _time)) * 0.0000001;
                _time = now;
                return _Δt;
            }
        }
        private long _time = DateTime.Now.ToFileTime(); // last time Δt was accessed

        private double v {
            get {
                return Settings.I.Speed / 360.0;
            }
        }

        private Random rnd = new Random();


        private bool loaded = false;
        public void Load(double Width, double Height) {
            if ( loaded ) { return; }

            Console.WriteLine("gl version: " + GL.GetString(StringName.Version));

            // setup opengl
            GL.ClearColor(Color.White);
            GL.Enable(EnableCap.VertexArray);
            GL.Enable(EnableCap.Texture2D);
            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
            int[] vp = new int[4];
            GL.GetInteger(GetPName.Viewport, vp);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            // load shader
            string vs = Settings.VertexShader;
            string fs = Settings.FragmentShader;
            shader = new Shader(vs, fs);
            shader.Bind();

            // init textures
            GL.ActiveTexture(TextureUnit.Texture0);
            ReloadImage();
            shader.SetVariable("texture", 0);

            // application parameters
            ResetRandom();
            RefreshUniforms();

            // init verticies
            dlBackground = new DisplayList(PrimitiveType.Quads, () => {
                GL.Color4(Color.White);
                GL.TexCoord2(0.0, 1.0);
                GL.Vertex2(-1.0, -1.0);
                GL.TexCoord2(1.0, 1.0);
                GL.Vertex2(1.0, -1.0);
                GL.TexCoord2(1.0, 0.0);
                GL.Vertex2(1.0, 1.0);
                GL.TexCoord2(0.0, 0.0);
                GL.Vertex2(-1.0, 1.0);
            });

            if ( Settings.I.ShowAvatar ) {
                tAvatar = new Texture(Properties.Resources.pingu, true);

                // color blending
                GL.Enable(EnableCap.Blend);
                GL.BlendEquation(BlendEquationMode.FuncAdd);
                GL.BlendFuncSeparate(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha, BlendingFactorSrc.One, BlendingFactorDest.Zero);
                //GL.BlendFuncSeparate(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha, BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);

                double sx = 10.0 / Width;
                double sy = 10.0 / Height;
                double w = 200.0 / Width;
                double h = 200.0 / Height;
                dlAvatar = new DisplayList(PrimitiveType.Quads, () => {
                    GL.Color4(1.0, 1.0, 1.0, 0.8);
                    GL.TexCoord2(0.0, 1.0);
                    GL.Vertex2(1.0 - sx - w, 1.0 - sy - h);
                    GL.TexCoord2(1.0, 1.0);
                    GL.Vertex2(1.0 - sx, 1.0 - sy - h);
                    GL.TexCoord2(1.0, 0.0);
                    GL.Vertex2(1.0 - sx, 1.0 - sy);
                    GL.TexCoord2(0.0, 0.0);
                    GL.Vertex2(1.0 - sx - w, 1.0 - sy);
                });
            }

            loaded = true;
        }

        public void Clear() {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public void ReloadImage() {
            loaded = false;
            if ( tBackground != null ) {
                tBackground.Delete();
            }
            tBackground = new Texture(Settings.I.ImagePath, true);
            loaded = true;
        }

        public void ResetRandom() {
            hue = (Settings.I.Randomize[0] ? rnd.NextDouble() : 0.0);
        }

        public void RefreshUniforms() {
            shader.SetVariable("rainbow", Settings.I.Rainbow[0], Settings.I.Rainbow[1]);
            shader.SetVariable("monitors", Settings.I.Monitors[0], Settings.I.Monitors[1]);
            shader.SetVariable("texWrap", Settings.I.TextureWrap[0], Settings.I.TextureWrap[1]);
            shader.SetVariable("texMove", Settings.I.TextureMove[0], Settings.I.TextureMove[1]);
            shader.SetVariable("correctPreRGB", Settings.I.CorrectPreRGB[0], Settings.I.CorrectPreRGB[1], Settings.I.CorrectPreRGB[2]);
            shader.SetVariable("correctPostRGB", Settings.I.CorrectPostRGB[0], Settings.I.CorrectPostRGB[1], Settings.I.CorrectPostRGB[2]);
            shader.SetVariable("correctHSV", Settings.I.CorrectHSV[0], Settings.I.CorrectHSV[1], Settings.I.CorrectHSV[2]);
        }

        public void Resize(int Width, int Height) {
            if ( !loaded ) { return; }
            GL.Viewport(0, 0, Width, Height);
        }

        public void UpdateFrame() {
            if ( !loaded ) { return; }
            hue = hue + (Δt * v) + 1.0 % 1.0;
            shader.SetVariable("hue", (float) hue);
        }

        public void RenderFrame() {
            if ( !loaded ) { return; }

            Clear();

            // BufferObjects
            /*Verticies.Draw(2, 0, 4);
            Indicies.Draw(PrimitiveType.Quads, 0, 4);*/

            shader.Bind();
            tBackground.Bind();
            dlBackground.Call();
            tBackground.Unbind();
            shader.Unbind();

            if ( Settings.I.ShowAvatar ) {
                tAvatar.Bind();
                dlAvatar.Call();
                tAvatar.Unbind();
            }
        }

    }
}
