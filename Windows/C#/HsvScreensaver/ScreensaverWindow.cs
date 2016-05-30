using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace de.blackpinguin.gl.hsvscr {
    class ScreensaverWindow : GameWindow {

        ScreensaverGL gl;

        public ScreensaverWindow(Rectangle r)
            : base(r.Width, r.Height, GraphicsMode.Default, "HsvScreensaver", GameWindowFlags.FixedWindow) {
            // set up window
            WindowBorder = WindowBorder.Hidden;
            WindowState = (Settings.I.Fullscreen ? WindowState.Fullscreen : (Settings.I.Maximized ? WindowState.Maximized : WindowState.Normal));
            Location = r.Location;
            ClientRectangle = r;

            VSync = (Settings.I.VSync ? VSyncMode.On : VSyncMode.Off);

            CursorVisible = false;
            KeyDown += (sender, ev) => { Close(); };
            MouseDown += (sender, ev) => { Close(); };

            gl = new ScreensaverGL();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            gl.Load(Width, Height);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            gl.Resize(Width, Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e) {
            base.OnUpdateFrame(e);
            gl.UpdateFrame();
        }

        protected override void OnRenderFrame(FrameEventArgs e) {
            base.OnRenderFrame(e);
            gl.RenderFrame();
            SwapBuffers();
        }



    }
}
