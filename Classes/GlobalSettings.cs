using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Gemini
{
	public static class Settings
    {
		public static bool WindowMaximized { get; set; }
		public static Rectangle WindowBounds { get; set; }
        public static bool AutoOpen { get; set; }
		public static List<string> RecentlyOpened { get; set; }
		public static bool AutoSaveConfig { get; set; }
		public static ScriptStyle[] ScriptStyles { get; set; }
		public static bool AutoComplete { get; set; }
		public static int AutoCompleteLength { get; set; }
        public static int AutoCompleteFlag { get; set; }
        public static string AutoCompleteCustomWords { get; set; }
        public static List<string> AutoCompleteWords { get; set; }
        public static bool AutoIndent { get; set; }
		public static bool GuideLines { get; set; }
		public static bool LineHighLight { get; set; }
		public static Color LineHighLightColor { get; set; }
        public static bool CodeFolding { get; set; }
        public static bool DebugMode { get; set; }
		public static bool AutoCheckUpdates { get; set; }

        public static void SetDefaults()
        {
            WindowMaximized = false;
            if (Application.OpenForms.Count > 0)
                WindowBounds = Application.OpenForms[0].Bounds;
            else {
                int x = (Screen.PrimaryScreen.Bounds.Width - 800) / 2;
                int y = (Screen.PrimaryScreen.Bounds.Height - 600) / 2;
                WindowBounds = new Rectangle(x, y, 800, 600);
            }
            AutoOpen = true;
            RecentlyOpened = new List<string>();
            AutoSaveConfig = true;
            ScriptStyles = GetScriptStyles();
            AutoComplete = false;
            AutoCompleteLength = 2;
            AutoCompleteFlag = 0;
            AutoCompleteCustomWords = "";
            AutoCompleteWords = new List<string>();
            AutoIndent = true;
            GuideLines = true;
            LineHighLight = false;
            LineHighLightColor = Color.FromArgb(32, 0, 0, 0);
            CodeFolding = true;
            DebugMode = true;
            AutoCheckUpdates = true;
        }

        private static ScriptStyle[] GetScriptStyles()
        {
            using (Font font = new Font("Courier New", 10))
            return new ScriptStyle[] {
				new ScriptStyle("White Space"        , Color.Black          , Color.White   , font),
				new ScriptStyle("Brace Match"        , Color.Purple         , Color.Yellow  , font),
				new ScriptStyle("Comment Line"       , Color.Green          , Color.White   , font),
				new ScriptStyle("Comment Block"      , Color.Green          , Color.White   , font),
				new ScriptStyle("Number"             , Color.DarkRed        , Color.White   , font),
				new ScriptStyle("Keyword"            , Color.Blue           , Color.White   , font),
				new ScriptStyle("Double Quote String", Color.Purple         , Color.White   , font),
				new ScriptStyle("Single Quote String", Color.MediumVioletRed, Color.White   , font),
				new ScriptStyle("Class Name"         , Color.DarkOrange     , Color.White   , font),
				new ScriptStyle("Method Name"        , Color.Black          , Color.White   , font),
				new ScriptStyle("Operator"           , Color.DarkCyan       , Color.White   , font),
				new ScriptStyle("Call"               , Color.Black          , Color.White   , font),
 				new ScriptStyle("Regular Expression" , Color.MediumPurple   , Color.White   , font),
				new ScriptStyle("Global Variable"    , Color.Black          , Color.White   , font),
				new ScriptStyle("Symbol"             , Color.Black          , Color.White   , font),
				new ScriptStyle("Module Name"        , Color.DarkOrange     , Color.White   , font),
				new ScriptStyle("Instance Variable"  , Color.Black          , Color.White   , font),
				new ScriptStyle("Class Variable"     , Color.Black          , Color.White   , font),
				new ScriptStyle("System String"      , Color.Red            , Color.White   , font),
				new ScriptStyle("Line Number"        , Color.Black          , Color.Lavender, font)
			};
        }

		public static void SaveData(string path = "Settings.dat")
		{
            SaveData saveData = new SaveData();
            saveData.SaveVersion = 1;
			saveData.WindowMaximized = Application.OpenForms.Count == 0 ? false :
                                       Application.OpenForms[0].WindowState == FormWindowState.Maximized;
            saveData.WindowBounds = saveData.WindowMaximized ? WindowBounds : Application.OpenForms[0].Bounds;
            saveData.AutoOpen = AutoOpen;
			saveData.RecentlyOpened = RecentlyOpened;
			saveData.AutoSaveConfig = AutoSaveConfig;
			saveData.ScriptStyles = ScriptStyles;
			saveData.AutoComplete = AutoComplete;
			saveData.AutoCompleteLength = AutoCompleteLength;
            saveData.AutoCompleteFlag = AutoCompleteFlag;
			saveData.AutoCompleteCustomWords = AutoCompleteCustomWords;
			saveData.AutoIndent = AutoIndent;
			saveData.GuideLines = GuideLines;
			saveData.LineHighLight = LineHighLight;
			saveData.LineHighLightColor = LineHighLightColor;
            saveData.CodeFolding = CodeFolding;
            saveData.DebugMode = DebugMode;
            saveData.AutoCheckUpdates = AutoCheckUpdates;
			using (Stream stream = File.OpenWrite(path))
				new BinaryFormatter().Serialize(stream, saveData);
		}

        public static void LoadData(string path = "Settings.dat")
        {
            if (File.Exists(path))
                try {
                    SaveData saveData;
                    using (Stream stream = File.OpenRead(path))
                        saveData = (SaveData)new BinaryFormatter().Deserialize(stream);
                    WindowMaximized = saveData.WindowMaximized;
                    WindowBounds = saveData.WindowBounds;
                    AutoOpen = saveData.AutoOpen;
                    RecentlyOpened = saveData.RecentlyOpened;
                    AutoSaveConfig = saveData.AutoSaveConfig;
                    ScriptStyles = saveData.ScriptStyles;
                    AutoComplete = saveData.AutoComplete;
                    AutoCompleteLength = saveData.AutoCompleteLength;
                    AutoCompleteFlag = saveData.AutoCompleteFlag;
                    AutoCompleteCustomWords = saveData.AutoCompleteCustomWords;
                    AutoIndent = saveData.AutoIndent;
                    GuideLines = saveData.GuideLines;
                    LineHighLight = saveData.LineHighLight;
                    LineHighLightColor = saveData.LineHighLightColor;
                    CodeFolding = saveData.CodeFolding;
                    DebugMode = saveData.DebugMode;
                    AutoCheckUpdates = saveData.AutoCheckUpdates;
                } catch (Exception) {
                    SetDefaults();
                    MessageBox.Show("Error accessing settings file.\nDefault settings will be applied.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
	}

	[Serializable]
	public struct SaveData
	{
        public int SaveVersion;
		public bool WindowMaximized;
		public Rectangle WindowBounds;
        public bool AutoOpen;
		public List<string> RecentlyOpened;
		public bool AutoSaveConfig;
		public ScriptStyle[] ScriptStyles;
		public bool AutoComplete;
		public int AutoCompleteLength;
        public int AutoCompleteFlag;
        public string AutoCompleteCustomWords;
		public bool AutoIndent;
		public bool GuideLines;
		public bool LineHighLight;
		public Color LineHighLightColor;
        public bool CodeFolding;
        public bool DebugMode;
		public bool AutoCheckUpdates;
	}

}


