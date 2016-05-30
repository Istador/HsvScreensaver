﻿using System;
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
        private static string settingsPath = Path.Combine(Directory.GetParent(Application.UserAppDataPath).FullName, "config.xml");
        #endregion

        #region serialized attributes
        public string ImagePath = "C:\\Users\\Public\\Pictures\\Sample Pictures\\Tulips.jpg";
        public double Speed = 20.0; // 20 °/s
        public bool VSync = true;
        public bool Fullscreen = false;
        public bool Maximized = false;
        public int[] Monitors = new int[] { 1, 1 };
        public bool ShowAvatar = true;
        public float[] Rainbow = new float[2] { 0.30f, 0.20f };
        public float[] TextureWrap = new float[2] { 1.0f, 1.0f };
        public float[] TextureMove = new float[2] { 0.0f, 0.0f };
        public float[] CorrectPreRGB = new float[3] { 0.0f, 0.0f, 0.0f };
        public float[] CorrectPostRGB = new float[3] { 0.0f, 0.0f, 0.0f };
        public float[] CorrectHSV = new float[3] { 0.0f, 0.0f, 0.0f };
        public bool[] Randomize = new bool[] { true, true, true };
        #endregion

        private Settings() {
            //Directory.Delete(Application.UserAppDataPath); // delete subfolder with version number
        }

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

        public void Save() {
            TextWriter textWriter = null;
            try {
                XmlSerializer serializer = new XmlSerializer(instance.GetType());
                textWriter = new StreamWriter(settingsPath);
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
                if ( File.Exists(settingsPath) ) {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    textReader = new StreamReader(settingsPath);
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
