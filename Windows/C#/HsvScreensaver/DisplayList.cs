using OpenTK.Graphics.OpenGL;

namespace de.blackpinguin.gl.hsvscr {
    public delegate void Action();

    class DisplayList {
        private int id;

        public DisplayList(Action a) {
            id = GL.GenLists(1);
            GL.NewList(id, ListMode.Compile);
            a();
            GL.EndList();
        }

        public DisplayList(PrimitiveType pt, Action a) {
            id = GL.GenLists(1);
            GL.NewList(id, ListMode.Compile);
            GL.Begin(pt);
            a();
            GL.End();
            GL.EndList();
        }

        public void Call() {
            GL.CallList(id);
        }
    }
}
