using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;

namespace de.blackpinguin.gl.hsvscr {
    [Serializable()]
    public class Settings {
        #region non serialized
        [NonSerialized()]
        private static Settings instance = null;
        [NonSerialized()]
        private static string settingsDir = null;
        #endregion
        
        #region serialized attributes
        // texture
        public string ImagePath = "C:\\Users\\Public\\Pictures\\Sample Pictures\\Tulips.jpg";
        public float[] TextureWrap = new float[2] { 1.0f, 1.0f };
        public float[] TextureMove = new float[2] { 0.0f, 0.0f };
        public bool ShowAvatar = true;

        // monitor
        public bool VSync = true;
        public bool Fullscreen = false;
        public bool Maximized = false;
        public int[] Monitors = new int[] { 1, 1 };
        
        // color fix
        public float[] CorrectPreRGB = new float[3] { 0.0f, 0.0f, 0.0f };
        public float[] CorrectPostRGB = new float[3] { 0.0f, 0.0f, 0.0f };
        public float[] CorrectHSV = new float[3] { 0.0f, 0.0f, 0.0f };

        // Hue Animation
        public double Speed = 20.0; // 20 °/s
        public float Intensity = 1.0f; // 100 %
        public float[] Rainbow = new float[2] { 0.30f, 0.20f };
        public bool[] Randomize = new bool[] { true, true, true };
        #endregion

        private Settings() {}

        public static Settings I {
            get {
                if ( instance == null ) {
                    instance = new Settings();
                    instance.Load();
                    //instance.Save();
                }
                return instance;
            }
        }


        public static string SettingsDir {
            get {
                if (settingsDir == null) {
                    settingsDir = Directory.GetParent(Application.UserAppDataPath).FullName;
                    Directory.Delete(Application.UserAppDataPath); // delete subfolder with version number
                }
                return settingsDir;
            }
        }

        public static string SettingsFile {
            get {
                return Path.Combine(SettingsDir, "config.xml");
            }
        }


        public static string VertexShader {
            get {
                try {
                    string path = Path.Combine(SettingsDir, "vert.glsl");
                    if (File.Exists(path)) {
                        return File.ReadAllText(path);
                    }
                }
                catch (Exception) { }
                return Properties.Resources.vert;
            }
        }


        public static string FragmentShader {
            get {
                try {
                    string path = Path.Combine(SettingsDir, "frag.glsl");
                    if (File.Exists(path)) {
                        return File.ReadAllText(path);
                    }
                }
                catch (Exception) { }
                return Properties.Resources.frag;
            }
        }


        public void Save() {
            TextWriter textWriter = null;
            try {
                XmlSerializer serializer = new XmlSerializer(instance.GetType());
                textWriter = new StreamWriter(SettingsFile);
                serializer.Serialize(textWriter, instance);
            }
            catch ( Exception ex ) {
                MessageBox.Show(string.Format("Error saving settings: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if ( textWriter != null ) { textWriter.Close(); }
            }
        }

        public void Load() {
            StreamReader textReader = null;
            XmlTextReader xmlReader = null;
            try {
                if ( File.Exists(SettingsFile) ) {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    textReader = new StreamReader(SettingsFile);
                    xmlReader = new XmlTextReader(textReader);

                    if ( serializer.CanDeserialize(xmlReader) ) {
                        instance = ((Settings) serializer.Deserialize(xmlReader));
                    }
                    else {
                        Save();
                    }
                }
                else {
                    Save();
                }
            }
            catch ( Exception ex ) {
                MessageBox.Show(string.Format("Error reading settings: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if ( xmlReader != null ) { xmlReader.Close(); }
                if ( textReader != null ) { textReader.Close(); }
            }
        }
    }
}
