using System;
using OpenTK.Graphics.OpenGL;

namespace de.blackpinguin.gl.hsvscr {

    class BufferObject {
        public static IndexBufferObject Indicies(params int[] ixs) {
            ushort[] uxs = Array.ConvertAll(ixs, i => (ushort) i);
            return new IndexBufferObject(uxs);
        }

        public static VertexBufferObjectD Verticies(params double[] vs) {
            return new VertexBufferObjectD(vs);
        }

        public static VertexBufferObjectF Verticies(params float[] vs) {
            return new VertexBufferObjectF(vs);
        }
    }


    class BufferObject<T> where T : struct {
        protected T[] arr;

        protected BufferTarget Type;
        protected int tsize;
        protected int Buffer;
        protected bool Loaded = false;

        protected BufferObject(BufferTarget type, T[] arr, int tsize) {
            this.Type = type;
            this.arr = arr;
            this.tsize = tsize;
            Buffer = GL.GenBuffer();
        }

        public void Load() {
            if ( !Loaded ) {
                Loaded = true;
                Bind();
                GL.BufferData(Type, (IntPtr) (arr.Length * tsize), arr, BufferUsageHint.StaticDraw);
            }
        }

        public void Bind() { Load(); GL.BindBuffer(Type, Buffer); }
    }

    class IndexBufferObject : BufferObject<ushort> {
        public IndexBufferObject(params ushort[] ixs) : base(BufferTarget.ElementArrayBuffer, ixs, sizeof(ushort)) { }

        public void Draw(PrimitiveType type, int start, int count) {
            Bind();
            GL.DrawElements(type, count, DrawElementsType.UnsignedShort, start);
        }
    }

    class VertexBufferObjectF : BufferObject<float> {
        public VertexBufferObjectF(params float[] vs) : base(BufferTarget.ElementArrayBuffer, vs, sizeof(float)) { }

        public void Draw(int size, int start, int count) {
            Bind();
            GL.VertexPointer(count, VertexPointerType.Float, tsize * size, start);
        }
    }

    class VertexBufferObjectD : BufferObject<double> {
        public VertexBufferObjectD(params double[] vs) : base(BufferTarget.ElementArrayBuffer, vs, sizeof(double)) { }

        public void Draw(int size, int start, int count) {
            Bind();
            GL.VertexPointer(count, VertexPointerType.Double, tsize * size, start);
        }
    }

}
