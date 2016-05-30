using System;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace de.blackpinguin.gl.hsvscr {
    class Shader : IDisposable {
        public enum Type {
            Vertex = 0x1,
            Fragment = 0x2
        }

        public static bool IsSupported {
            get {
                return (new Version(GL.GetString(StringName.Version).Substring(0, 3)) >= new Version(2, 0) ? true : false);
            }
        }

        private int Program = 0;
        private Dictionary<string, int> Variables = new Dictionary<string, int>();


        public static void Bind(Shader shader) {
            if ( shader != null && shader.Program > 0 ) {
                shader.Bind();
            }
            else {
                GL.UseProgram(0);
            }
        }

        public void Bind() {
            if ( Program > 0 ) {
                GL.UseProgram(Program);
            }
        }

        public void Unbind() {
            GL.UseProgram(0);
        }

        public void Dispose() {
            if ( Program != 0 ) {
                GL.DeleteProgram(Program);
            }
        }


        public Shader(string source, Type type) {
            if ( !IsSupported ) {
                Console.WriteLine("Failed to create Shader." + Environment.NewLine + "Your system doesn't support Shader.", "Error");
                return;
            }

            if ( type == Type.Vertex ) {
                Compile(source, "");
            }
            else {
                Compile("", source);
            }
        }

        public Shader(string vsource, string fsource) {
            if ( !IsSupported ) {
                Console.WriteLine("Failed to create Shader." + Environment.NewLine + "Your system doesn't support Shader.", "Error");
                return;
            }

            Compile(vsource, fsource);
        }

        private bool Compile(string src, ShaderType t) {
            if ( src.Trim() == "" ) {
                return true;
            }

            // compile shader
            int shader = GL.CreateShader(t);
            GL.ShaderSource(shader, src);
            GL.CompileShader(shader);

            // check compile status
            int status_code = -1;
            string info = "";
            GL.GetShaderInfoLog(shader, out info);
            GL.GetShader(shader, ShaderParameter.CompileStatus, out status_code);
            if ( status_code != 1 ) {
                Console.WriteLine("Failed to Compile Shader Source." + Environment.NewLine + info + Environment.NewLine + "Status Code: " + status_code.ToString());
                GL.DeleteShader(shader);
                GL.DeleteProgram(Program);
                Program = 0;
                return false;
            }

            GL.AttachShader(Program, shader);
            GL.DeleteShader(shader);
            return true;

        }

        private bool Compile(string vertexSource = "", string fragmentSource = "") {
            if ( vertexSource == "" && fragmentSource == "" ) {
                Console.WriteLine("Failed to compile Shader." + Environment.NewLine + "Nothing to Compile.", "Error");
                return false;
            }

            // cleanup
            if ( Program > 0 ) {
                GL.DeleteProgram(Program);
            }
            Variables.Clear();

            // create program and link with both shaders
            Program = GL.CreateProgram();
            if ( !Compile(vertexSource, ShaderType.VertexShader) ) { return false; }
            if ( !Compile(fragmentSource, ShaderType.FragmentShader) ) { return false; }
            GL.LinkProgram(Program);

            // check linker status
            int status_code = -1;
            string info = "";
            GL.GetProgramInfoLog(Program, out info);
            GL.GetProgram(Program, GetProgramParameterName.LinkStatus, out status_code);
            if ( status_code != 1 ) {
                Console.WriteLine("Failed to Link Shader Program." + Environment.NewLine + info + Environment.NewLine + "Status Code: " + status_code.ToString());
                GL.DeleteProgram(Program);
                Program = 0;
                return false;
            }

            return true;
        }



        private int GetVariableLocation(string name) {
            if ( Variables.ContainsKey(name) )
                return Variables[name];

            int location = GL.GetUniformLocation(Program, name);

            if ( location != -1 ) {
                Variables.Add(name, location);
            }
            else {
                Console.WriteLine("Failed to retrieve Variable Location." + Environment.NewLine + "Variable Name " + name + " not found.", "Error");
            }

            return location;
        }

        private void Uniform(int loc, float x) { if ( loc != -1 ) GL.Uniform1(loc, x); }
        private void Uniform(int loc, float x, float y) { if ( loc != -1 ) GL.Uniform2(loc, x, y); }
        private void Uniform(int loc, float x, float y, float z) { if ( loc != -1 ) GL.Uniform3(loc, x, y, z); }
        private void Uniform(int loc, float x, float y, float z, float w) { if ( loc != -1 ) GL.Uniform4(loc, x, y, z, w); }
        private void Uniform(int loc, double x) { if ( loc != -1 ) GL.Uniform1(loc, x); }
        private void Uniform(int loc, double x, double y) { if ( loc != -1 ) GL.Uniform2(loc, x, y); }
        private void Uniform(int loc, double x, double y, double z) { if ( loc != -1 ) GL.Uniform3(loc, x, y, z); }
        private void Uniform(int loc, double x, double y, double z, double w) { if ( loc != -1 ) GL.Uniform4(loc, x, y, z, w); }

        private void IfProgram(Action a) {
            if ( Program <= 0 ) { return; }
            GL.UseProgram(Program);
            a();
            GL.UseProgram(0);
        }

        public void SetVariable(string name, float x) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x); });
        }
        public void SetVariable(string name, float x, float y) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y); });
        }
        public void SetVariable(string name, float x, float y, float z) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y, z); });
        }
        public void SetVariable(string name, float x, float y, float z, float w) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y, z, w); });
        }

        public void SetVariable(string name, double x) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x); });
        }
        public void SetVariable(string name, double x, double y) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y); });
        }
        public void SetVariable(string name, double x, double y, double z) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y, z); });
        }
        public void SetVariable(string name, double x, double y, double z, double w) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x, y, z, w); });
        }

        public void SetVariable(string name, int x) {
            IfProgram(() => { Uniform(GetVariableLocation(name), x); });
        }
    }
}
