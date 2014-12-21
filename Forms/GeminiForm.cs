using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using IronRuby.Builtins;
using ScintillaNet;

namespace Gemini
{
    public partial class GeminiForm : Form
	{
		[DllImport("User32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

	#region Fields and Properties

		private string _projectDirectory = "";
        private string _projectScriptPath = "";
        private string _projectGamePath = "";
		private string _projectEngine = "";
        private bool _projectNeedSave = false;
        private byte[] _projectLastSave;
        private List<int> _usedSections = new List<int>();
        private List<Script> _scripts = new List<Script>();
        private FindReplaceDialog _findReplaceDialog = new FindReplaceDialog();
        private Process _charmap = new Process();
        private Form splashScreen;

	#endregion

	#region Contructor

		/// <summary>
		/// Initializes form components, child forms, and the Ruby engine.
		/// </summary>
		[EnvironmentPermissionAttribute(SecurityAction.LinkDemand, Unrestricted = true)]
		public GeminiForm()
        {
            ExtractResources();
            InitializeComponent();
            this.Icon = Icon.FromHandle(Properties.Resources.gemini_ico.GetHicon());
            splitContainer_EditorSearches.Panel2Collapsed = true;
            Ruby.CreateRuntime();
            Settings.SetDefaults();
            Settings.LoadData();
            ApplySettings();
            UpdateMenusEnabled();
            UpdateScriptStatus();
            if (Settings.AutoOpen && Settings.RecentlyOpened.Count > 0)
                OpenRecentProject(0, false);
            if (Settings.AutoCheckUpdates)
                new UpdateForm();
        }

		/// <summary>
		/// Applies all changes that are configured in the settings
		/// </summary>
		private void ApplySettings()
		{
            UpdateMenusChecked();
            UpdateRecentProjectList();
            UpdateAutoCompleteWords();
            foreach (Script script in _scripts) {
                script.UpdateSettings();
                script.SetStyle();
            }
			this.Bounds = Settings.WindowBounds;
            if (Settings.WindowMaximized)
			    this.WindowState = FormWindowState.Maximized;
		}

        private void GeminiForm_OnLoad(object sender, EventArgs e)
        {
        }

	#endregion

    #region Main Form Events

        /// <summary>
        /// Cleans up resources and saves the state of the current settings for next time
        /// </summary>
        private void GeminiForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (!CloseProject(true)) {
                e.Cancel = true;
                return;
            }
            if (Settings.AutoSaveConfig)
                SaveConfiguration(false);
            try { _charmap.Kill(); } catch { }
        }

        /// <summary>
        /// Automatically rewrite the latest save when the script file is overwritten by RPG Maker
        /// </summary>
        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = false;
            DateTime t = DateTime.Now;
            while ((DateTime.Now - t).TotalMilliseconds < 1000)
                try {
                    File.WriteAllBytes(_projectScriptPath, _projectLastSave);
                    break;
                } catch {}
            fileSystemWatcher.EnableRaisingEvents = true;
        }

    #endregion

    #region Menu File Events

        private void mainMenu_ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            UpdateMenusEnabled();
        }

        private void mainMenu_ToolStripMenuItem_NewProjectRMXP_Click(object sender, EventArgs e)
        {
            using (NewProjectForm dialog = new NewProjectForm("RMXP"))
                if (dialog.ShowDialog() == DialogResult.OK)
                    CreateProject("RMXP", dialog.GameTitle, dialog.ProjectDirectory, dialog.IncludeLibrary, dialog.OpenProject);
        }

        private void mainMenu_ToolStripMenuItem_NewProjectRMVX_Click(object sender, EventArgs e)
        {
            using (NewProjectForm dialog = new NewProjectForm("RMVX"))
                if (dialog.ShowDialog() == DialogResult.OK)
                    CreateProject("RMVX", dialog.GameTitle, dialog.ProjectDirectory, dialog.IncludeLibrary, dialog.OpenProject);
        }

        private void mainMenu_ToolStripMenuItem_NewProjectRMVXAce_Click(object sender, EventArgs e)
        {
            using (NewProjectForm dialog = new NewProjectForm("RMVXAce"))
                if (dialog.ShowDialog() == DialogResult.OK)
                    CreateProject("RMVXAce", dialog.GameTitle, dialog.ProjectDirectory, dialog.IncludeLibrary, dialog.OpenProject);
        }

		/// <summary>
		/// Starts open dialog for opening RMXP/RMVX project files
		/// </summary>
		private void mainMenu_ToolStripMenuItem_OpenProject_Click(object sender, EventArgs e)
		{
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Filter = "RPG Makers Projects & Scripts|*.rxproj;*.rvproj;*.rvproj2;*.rxdata;*.rvdata;*.rvdata2|" +
                                    "RMXP Project|*.rxproj|RMVX Project|*.rvproj|RMVXAce Project|*.rvproj2|" +
                                    "RMXP Script|*.rxdata|RMVX Script|*.rvdata|RMVXAce Script|*.rvdata2|" +
                                    "All Documents|*.*";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Title = "Ouvrir Projet...";
                if (dialog.ShowDialog() == DialogResult.OK)
                    OpenProject(dialog.FileName);
            }
		}

        private void mainMenu_ToolStripMenuItem_AutoOpenProject_Click(object sender, EventArgs e)
        {
            Settings.AutoOpen = !Settings.AutoOpen;
            UpdateMenusChecked();
            mainMenu_ToolStripMenuItem_File.ShowDropDown();
            mainMenu_ToolStripMenuItem_OpenRecentProject.ShowDropDown();
            mainMenu_ToolStripMenuItem_AutoOpenProject.Select();
        }

        /// <summary>
        /// Opens the selected recent document after ensuring it still exists
        /// </summary>
        private void mainMenu_ToolStripMenuItem_OpenRecentProject_Click(object sender, EventArgs e)
        {
            OpenRecentProject(mainMenu_ToolStripMenuItem_OpenRecentProject.DropDownItems.IndexOf((ToolStripItem)sender) - 2, true);
        }

        private void mainMenu_ToolStripMenuItem_CloseProject_Click(object sender, EventArgs e)
        {
            CloseProject(true);
        }

		/// <summary>
		/// Updates the text of each script, then Marshals it using Ruby
		/// </summary>
		private void mainMenu_ToolStripMenuItem_SaveProject_Click(object sender, EventArgs e)
		{
            SaveScripts();
		}

		/// <summary>
		/// Imports an existing text document or .rb file into the editor, adding it to the Scipt list
		/// </summary>
		private void mainMenu_ToolStripMenuItem_ImportScripts_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog()) {
				dialog.DefaultExt = "txt";
				dialog.Filter = "Text Document|*.txt|Ruby Script|*.rb|All Documents|*.*";
				dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				dialog.Title = "Importer Scripts...";
                dialog.Multiselect = true;
				DialogResult result = dialog.ShowDialog();
				if (result == DialogResult.OK)
                    ImportScripts(-1, false, dialog.FileNames);
			}

        }

        private void mainMenu_ToolStripMenuItem_ExportScriptsRMData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                dialog.FileName = Path.GetFileName(_projectScriptPath);
                dialog.Filter = _projectEngine + " Scripts|*" + Path.GetExtension(_projectScriptPath) + "|All Documents|*.*";
                dialog.InitialDirectory = _projectDirectory;
                dialog.Title = "Exporter Scripts...";
                if (dialog.ShowDialog() == DialogResult.OK)
                    SaveScripts(dialog.FileName);
            }
        }

        /// <summary>
        /// Exports the scripts with a .txt extension
        /// </summary>
        private void mainMenu_ToolStripMenuItem_ExportScriptsText_Click(object sender, EventArgs e)
        {
            ExportScripts(".txt");
        }

        /// <summary>
        /// Exports the scripts with an .rb extension
        /// </summary>
        private void mainMenu_ToolStripMenuItem_ExportScriptsRuby_Click(object sender, EventArgs e)
        {
            ExportScripts(".rb");
        }

        private void mainMenu_ToolStripMenuItem_SaveSettings_Click(object sender, EventArgs e)
        {
            SaveConfiguration(true);
        }

        /// <summary>
        /// Toggles auto-save of configuration when the program exits
        /// </summary>
        private void mainMenu_ToolStripMenuItem_AutoSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.AutoSaveConfig = !Settings.AutoSaveConfig;
            UpdateMenusChecked();
            mainMenu_ToolStripMenuItem_File.ShowDropDown();
            mainMenu_ToolStripMenuItem_SaveSettings.ShowDropDown();
            mainMenu_ToolStripMenuItem_AutoSaveSettings.Select();
        }

        /// <summary>
        /// Load default settings.
        /// </summary>
        private void mainMenu_ToolStripMenuItem_DeleteSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr que vous voulez supprimer tous les paramètres?",
                "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Settings.SetDefaults();
            ApplySettings();
        }

		/// <summary>
		/// Exits the application
		/// </summary>
		private void mainMenu_ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
        }

    #endregion

    #region Menu Edit Events

        private void mainMenu_ToolStripMenuItem_Undo_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.Undo);
        }

        private void mainMenu_ToolStripMenuItem_Redo_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.Redo);
        }

        private void mainMenu_ToolStripMenuItem_Cut_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.Cut);
        }

        private void mainMenu_ToolStripMenuItem_Copy_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.Copy);
        }

        private void mainMenu_ToolStripMenuItem_Paste_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.Paste);
        }

        private void mainMenu_ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.DeleteBack);
        }

        private void mainMenu_ToolStripMenuItem_SelectAll_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.SelectAll);
        }

        /// <summary>
        /// Opens the quick-find dialog
        /// </summary>
        private void mainMenu_ToolStripMenuItem_IncrementalSearch_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null) {
                script.Scintilla.Commands.Execute(BindableCommand.IncrementalSearch);
                Point p = script.Scintilla.PointToClient(MousePosition);
                if (script.Scintilla.Bounds.Contains(p))
                    script.Scintilla.FindReplace.IncrementalSearcher.Location = p;
            }
        }

		/// <summary>
		/// Opens the find/replace dialog with the Find tab selected
		/// </summary>
		private void mainMenu_ToolStripMenuItem_Find_Click(object sender, EventArgs e)
        {
            ShowFind();
		}

		/// <summary>
		/// Opens the find/replace dialog with the Replace tab selected
		/// </summary>
		private void mainMenu_ToolStripMenuItem_Replace_Click(object sender, EventArgs e)
        {
            ShowReplace();
		}

		/// <summary>
		/// Opens the dialog for the "goto line"
		/// </summary>
		private void mainMenu_ToolStripMenuItem_GoToLine_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.ShowGoTo);
        }

        private void mainMenu_ToolStripMenuItem_ToggleComment_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.ToggleLineComment);
        }

        /// <summary>
        /// Batch comments all selected lines
        /// </summary>
        private void mainMenu_ToolStripMenuItem_Comment_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.LineComment);
        }

        /// <summary>
        /// Batch uncomments all selected lines
        /// </summary>
        private void mainMenu_ToolStripMenuItem_UnComment_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Commands.Execute(BindableCommand.LineUncomment);
        }

        /// <summary>
        /// Initiates the function to apply the proper structuring to the open script
        /// </summary>
        private void mainMenu_ToolStripMenuItem_StructureScriptCurrent_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.StructureScript();
        }

        /// <summary>
        /// Applies the restructuring to all scripts that are opened currently
        /// </summary>
        private void mainMenu_ToolStripMenuItem_StructureScriptOpen_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (Script script in _scripts)
                if (script.Opened)
                    script.StructureScript();
            this.Enabled = true;
        }

        /// <summary>
        /// Applies the restructuring to all scripts
        /// </summary>
        private void mainMenu_ToolStripMenuItem_StructureScriptAll_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (Script script in _scripts)
                script.StructureScript();
            UpdateScriptsName();
            this.Enabled = true;
        }

        private void mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.RemoveEmptyLines();
        }

        private void mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (Script script in _scripts)
                if (script.Opened)
                    script.RemoveEmptyLines();
            this.Enabled = true;
        }

        private void mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            foreach (Script script in _scripts)
                script.RemoveEmptyLines();
            UpdateScriptsName();
            this.Enabled = true;
        }

    #endregion

    #region Menu Settings Events

        /// <summary>
		/// Displays the style editor dialog
		/// </summary>
		private void mainMenu_ToolStripMenuItem_StylesConfig_Click(object sender, EventArgs e)
		{
			using (StyleEditorForm dialog = new StyleEditorForm())
				if (dialog.ShowDialog() == DialogResult.OK) {
					Settings.ScriptStyles = dialog.Styles;
					foreach (Script script in _scripts)
						script.SetStyle();
				}
		}

		/// <summary>
		/// Calls the dialog for configuring the autocomplete function
		/// </summary>
		private void mainMenu_ToolStripMenuItem_AutoCompleteConfig_Click(object sender, EventArgs e)
		{
            using (AutoCompleteForm dialog = new AutoCompleteForm())
                if (dialog.ShowDialog() == DialogResult.OK) {
                    Settings.AutoCompleteLength = (int)dialog.numericUpDownCharacters.Value;
                    Settings.AutoCompleteCustomWords = dialog.textBoxList.Text;
                    Settings.AutoCompleteFlag = 0;
                    for (int i = 0; i < dialog.checkedListBoxGroups.Items.Count; i++ )
                        if (dialog.checkedListBoxGroups.GetItemChecked(i))
                            Settings.AutoCompleteFlag |= 1 << i;
                    UpdateAutoCompleteWords();
                }
		}

		/// <summary>
		/// Toggles auto-complete on/off
		/// </summary>
		private void mainMenu_ToolStripMenuItem_AutoComplete_Click(object sender, EventArgs e)
		{
            Settings.AutoComplete = !Settings.AutoComplete;
            UpdateMenusChecked();
			if (Settings.AutoComplete && Settings.AutoCompleteFlag == 0) {
                DialogResult result = MessageBox.Show("Liste d'auto-complétion est vide, souhaitez-vous la configurer maintenant?",
					"Configuration Requis", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (result == DialogResult.Yes)
					mainMenu_ToolStripMenuItem_AutoCompleteConfig_Click(sender, e);
            } else if (sender == mainMenu_ToolStripMenuItem_AutoComplete) {
                mainMenu_ToolStripMenuItem_Settings.ShowDropDown();
                mainMenu_ToolStripMenuItem_AutoComplete.Select();
            }
		}

		/// <summary>
		/// Toggles the guide-lines on/off
		/// </summary>
		private void mainMenu_ToolStripMenuItem_IndentGuides_Click(object sender, EventArgs e)
		{
            Settings.GuideLines = !Settings.GuideLines;
            UpdateMenusChecked();
			foreach (Script script in _scripts)
                script.UpdateSettings();
            if (sender == mainMenu_ToolStripMenuItem_IndentGuides) {
                mainMenu_ToolStripMenuItem_Settings.ShowDropDown();
                mainMenu_ToolStripMenuItem_IndentGuides.Select();
            }
		}

		/// <summary>
		/// Toggles auto-indenting on/off
		/// </summary>
		private void mainMenu_ToolStripMenuItem_AutoIndent_Click(object sender, EventArgs e)
		{
            Settings.AutoIndent = !Settings.AutoIndent;
            UpdateMenusChecked();
            foreach (Script script in _scripts)
                script.UpdateSettings();
            if (sender == mainMenu_ToolStripMenuItem_AutoIndent) {
                mainMenu_ToolStripMenuItem_Settings.ShowDropDown();
                mainMenu_ToolStripMenuItem_AutoIndent.Select();
            }
		}

		/// <summary>
		/// Toggles the line highlighter on/off
		/// </summary>
		private void mainMenu_ToolStripMenuItem_LineHighlight_Click(object sender, EventArgs e)
		{
            Settings.LineHighLight = !Settings.LineHighLight;
            UpdateMenusChecked();
			foreach (Script script in _scripts)
                script.UpdateSettings();
            if (sender == mainMenu_ToolStripMenuItem_LineHighlight) {
                mainMenu_ToolStripMenuItem_Settings.ShowDropDown();
                mainMenu_ToolStripMenuItem_LineHighlight.Select();
            }
		}

		/// <summary>
		/// Opens the dialog for changing the color/opacity of the line highlighter
		/// </summary>
		private void mainMenu_ToolStripMenuItem_HighlightColor_Click(object sender, EventArgs e)
		{
			using (ColorChooserForm dialog = new ColorChooserForm()) {
				dialog.Color = Settings.LineHighLightColor;
				if (dialog.ShowDialog() == DialogResult.OK) {
					Settings.LineHighLightColor = dialog.Color;
					foreach (Script script in _scripts)
                        script.UpdateSettings();
				}
			}
		}

        private void mainMenu_ToolStripMenuItem_CodeFolding_Click(object sender, EventArgs e)
        {
            Settings.CodeFolding = !Settings.CodeFolding;
            UpdateMenusChecked();
            foreach (Script script in _scripts)
                script.UpdateSettings();
            if (sender == mainMenu_ToolStripMenuItem_CodeFolding) {
                mainMenu_ToolStripMenuItem_Settings.ShowDropDown();
                mainMenu_ToolStripMenuItem_CodeFolding.Select();
            }
        }

    #endregion

    #region Menu Game Events

        private void mainMenu_ToolStripMenuItem_Help_Click(object sender, EventArgs e)
        {
            if (_projectEngine == "RMXP")           Help.ShowHelp(this, "RPGXP.chm");
            else if (_projectEngine == "RMVX")      Help.ShowHelp(this, "RPGVX.chm");
            else if (_projectEngine == "RMVXAce")   Help.ShowHelp(this, "RPGVXAce.chm");
        }

        /// <summary>
        /// Event raised that will begin execution of the game. Runs in test mode and auto-saves if configured to do so.
        /// </summary>
        private void mainMenu_ToolStripMenuItem_Run_Click(object sender, EventArgs e)
        {
            if (_projectGamePath == "") {
                MessageBox.Show("Vous ne pouvez pas tester le jeu lors de l'édition de '.r*data'.\nPour ce faire vous devez ouvrir le projet '.r*proj'.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NeedSave()) {
                DialogResult result = MessageBox.Show("Sauvegarde les changements?",
                  "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                    SaveScripts();
            }
            string arguments = "";
            if (!Settings.DebugMode)                arguments = "";
            else if (_projectEngine == "RMXP")      arguments = "debug";
            else if (_projectEngine == "RMVX")      arguments = "test";
            else if (_projectEngine == "RMVXAce")   arguments = "console test";
            try { Process.Start(_projectGamePath, arguments); }
            catch { MessageBox.Show("Impossible de lancer le jeu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mainMenu_ToolStripMenuItem_Debug_Click(object sender, EventArgs e)
        {
            Settings.DebugMode = !Settings.DebugMode;
            UpdateMenusChecked();
            if (sender == mainMenu_ToolStripMenuItem_Debug) {
                mainMenu_ToolStripMenuItem_Game.ShowDropDown();
                mainMenu_ToolStripMenuItem_Debug.Select();
            }
        }

        private void mainMenu_ToolStripMenuItem_ProjectFolder_Click(object sender, EventArgs e)
        {
            if (_projectDirectory == "")
                return;
            Process.Start(_projectDirectory);
        }
        
    #endregion

    #region Menu About Events
        
        private void mainMenu_ToolStripMenuItem_CheckForUpdates_Click(object sender, EventArgs e)
        {
            using (UpdateForm dialog = new UpdateForm())
                if (dialog.ShowDialog() == DialogResult.OK) {
                    if (NeedSave()) {
                        DialogResult result = MessageBox.Show("Enregistrer les modifications avant de fermer?",
                            "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                            SaveScripts();
                    }
                    CloseProject(false);
                    Close();
                    dialog.StartProcess();
                }
        }

        private void mainMenu_ToolStripMenuItem_AutoCheckUpdates_Click(object sender, EventArgs e)
        {
            Settings.AutoCheckUpdates = !Settings.AutoCheckUpdates;
            UpdateMenusChecked();
            mainMenu_ToolStripMenuItem_About.ShowDropDown();
            mainMenu_ToolStripMenuItem_CheckForUpdates.ShowDropDown();
            mainMenu_ToolStripMenuItem_AutoCheckUpdates.Select();
        }

        private void mainMenu_ToolStripMenuItem_VersionHistory_Click(object sender, EventArgs e)
        {
            try { Process.Start("VersionHistory.html"); }
            catch { MessageBox.Show("Historique de version introuvable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mainMenu_ToolStripMenuItem_AboutGemini_Click(object sender, EventArgs e)
        {
            using (AboutForm dialog = new AboutForm())
                dialog.ShowDialog();
        }

    #endregion

    #region Script Editor Events

        /// <summary>
        /// Opens the native Character Map for creating special Unicode characters
        /// </summary>
        private void scriptsEditor_ToolStripButton_SpecialChars_Click(object sender, EventArgs e)
        {
            _charmap.StartInfo.FileName = "charmap.exe";
            try {
                if (!_charmap.HasExited) {
                    SetForegroundWindow(_charmap.MainWindowHandle);
                    return;
                }
            } catch { }
            try { _charmap.Start(); }
            catch {
                MessageBox.Show("\"C:/Windows/System32/charmap.exe\" n'a pu être trouvée sur le système.",
                    "Fichier Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scriptsEditor_ToolStripMenuItem_FindNext_Click(object sender, EventArgs e)
        {
            _findReplaceDialog.FindNext();
        }

        private void scriptsEditor_ToolStripMenuItem_FindPrevious_Click(object sender, EventArgs e)
        {
            _findReplaceDialog.FindPrevious();
        }

        private void scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete_Click(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null) {
                List<string> words = new List<string>();
                if (script.Scintilla.Selection.Length == 0) {
                    string word = script.Scintilla.GetWordFromPosition(script.Scintilla.CurrentPos);
                    if (word.Length > 1)
                        words.Add(word);
                } else
                    for (int pos = script.Scintilla.Selection.Range.Start; pos < script.Scintilla.Selection.Range.End; pos++) {
                        string word = script.Scintilla.GetWordFromPosition(pos);
                        if (word.Length > 1 && !words.Contains(word))
                            words.Add(word);
                    }
                if (words.Count > 0) {
                    Settings.AutoCompleteCustomWords += " " + string.Join(" ", words);
                    UpdateAutoCompleteWords();
                }
            }
        }

        private void scriptsEditor_TabControl_GotFocus(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script != null)
                script.Scintilla.Focus();
        }

        /// <summary>
        /// Updates the labels accordingly with the activated script
        /// </summary>
        private void scriptsEditor_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Script script = GetActiveScript();
            if (script == null)
                _findReplaceDialog.Hide();
            else {
                _findReplaceDialog.Scintilla = script.Scintilla;
                scriptsList_ListBox.SelectedIndex = _scripts.IndexOf(script);
            }
            UpdateScriptStatus();
        }

        private void scriptsEditor_TabControl_TabPageRemoving(object sender, TabControlCancelEventArgs e)
        {
            Script script = _scripts.Find(delegate(Script s) { return s.Opened && s.TabPage == e.TabPage; });
            if (script == null)
                return;
            if (script.NeedApplyChanges) {
                DialogResult result = MessageBox.Show(
                    "Appliquer les modifications à ce script avant de fermer?\r\n\r\nNote: Ne enregistre pas les données de manière permanente",
                    "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    script.ApplyChanges();
                else if (result == DialogResult.Cancel) {
                    e.Cancel = true;
                    return;
                }
            }
            script.Dispose();
            UpdateScriptsName();
            UpdateMenusEnabled();
        }

        /// <summary>
        /// Enables/disables the comment controls depending on the selection, as well as the selection length label.
        /// </summary>
        private void Scintilla_Changed(object sender, EventArgs e)
        {
            UpdateMenusEnabled();
            UpdateScriptStatus();
            UpdateScriptsName();
        }

    #endregion

    #region Script List Menu Events

        /// <summary>
        /// Either opens a new page of the selected script, or selects the appropriate tab if it is already open.
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0)
                OpenScript(index);
        }

        /// <summary>
        /// Inserts a new Script control at index
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Insert_Click(object sender, EventArgs e)
        {
            InsertScript(scriptsList_ListBox.SelectedIndex, true, "New Script", "");
        }

        /// <summary>
        /// Removes currently selected script from list, and copies to clipboard
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Cut_Click(object sender, EventArgs e)
        {
            scriptsList_ToolStripMenuItem_Copy_Click(sender, e);
            scriptsList_ToolStripMenuItem_Delete_Click(sender, e);
        }

        /// <summary>
        /// Copies selected script to the clipboard
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Copy_Click(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0) {
                SetClipboardScript(_scripts[index]);
                UpdateMenusEnabled();
            }
        }

        /// <summary>
        /// Paste the script from the clipboard to the selected index
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Paste_Click(object sender, EventArgs e)
        {
            RubyArray rmScript = GetClipboardScript();
            if (rmScript != null)
                InsertScript(scriptsList_ListBox.SelectedIndex, false, rmScript);
        }

        /// <summary>
        /// Deletes the currently selected script
        /// </summary>
        private void scriptsList_ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0) {
                _projectNeedSave = true;
                if (_scripts[index].Opened) {
                    int tabIndex = scriptsEditor_TabControl.TabPages.IndexOf(_scripts[index].TabPage);
                    if (scriptsEditor_TabControl.SelectedIndex == tabIndex)
                        scriptsEditor_TabControl.SelectedIndex = tabIndex + 1 < scriptsEditor_TabControl.TabCount ? tabIndex + 1 : tabIndex - 1;
                }
                _scripts[index].Dispose();
                _scripts.RemoveAt(index);
                scriptsList_ListBox.Items.RemoveAt(index);
                scriptsList_ListBox.SelectedIndex = index < scriptsList_ListBox.Items.Count ? index : index - 1;
                scriptsList_ListBox.Focus();
                if (scriptsList_ListBox.SelectedIndex == -1)
                    scriptsList_TextBox_Name.ResetText();
            }
        }

        /// <summary>
        /// Moves selected scripts order up one in the list
        /// </summary>
        private void scriptsList_ToolStripMenuItem_MoveUp_Click(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index > 0) {
                _projectNeedSave = true;
                Script script = _scripts[index];
                _scripts.RemoveAt(index);
                _scripts.Insert(index - 1, script);
                UpdateScriptsName();
                scriptsList_ListBox.SelectedIndex = index - 1;
            }
        }

        /// <summary>
        /// Moves selected scripts order down one in the list
        /// </summary>
        private void scriptsList_ToolStripMenuItem_MoveDown_Click(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0 && index < scriptsList_ListBox.Items.Count - 1) {
                _projectNeedSave = true;
                Script script = _scripts[index];
                _scripts.RemoveAt(index);
                _scripts.Insert(index + 1, script);
                UpdateScriptsName();
                scriptsList_ListBox.SelectedIndex = index + 1;
            }
        }

        /// <summary>
        /// Creates/Focuses the search form for the scripts
        /// </summary>
        private void scriptsList_ToolStripMenuItem_BatchSearch_Click(object sender, EventArgs e)
        {
            ShowSearch();
        }

    #endregion
        
    #region Script List Events

        /// <summary>
        /// Changes the title in the name box to reflect the selected script
        /// </summary>
        private void scriptsList_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0)
                scriptsList_TextBox_Name.Text = _scripts[index].Title;
            UpdateMenusEnabled();
        }

        /// <summary>
        /// Moves the index of the script list with the right-mouse before context menu is called + dragndrop with left-mouse
        /// </summary>
        private void scriptsList_ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1) {
                if (scriptsList_ListBox.SelectedIndex >= 0)
                    scriptsList_ListBox.DoDragDrop(scriptsList_ListBox.SelectedItem, DragDropEffects.Move);
            } else if (e.Button == MouseButtons.Right) {
                int index = scriptsList_ListBox.IndexFromPoint(e.Location);
                if (index >= 0)
                    scriptsList_ListBox.SelectedIndex = index;
            }
            scriptsList_ListBox_SelectedIndexChanged(sender, e);// otherwise it doesn't fire because of MouseDown
        }

        private void scriptsList_ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                scriptsList_ToolStripMenuItem_Open_Click(sender, e);
        }

        /// <summary>
        /// Determines if paths are project files, then loads the scripts
        /// </summary>
        private void scriptsList_ListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (IsProject(paths)) {
                    foreach (string path in paths)
                        if (IsProject(path)) {
                            OpenProject(path);
                            return;
                        }
                } else if (_projectEngine != "")
                    ImportScripts(-1, false, paths);
            }
        }

        /// <summary>
        /// Sort the script list + change the cursor
        /// </summary>
        private void scriptsList_ListBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                if (_projectEngine != "" || IsProject((string[])e.Data.GetData(DataFormats.FileDrop)))
                    e.Effect = DragDropEffects.All;
            } else if (e.Data.GetDataPresent(DataFormats.StringFormat) && scriptsList_ListBox.Focused) {
                int hoverId = scriptsList_ListBox.IndexFromPoint(scriptsList_ListBox.PointToClient(new Point(e.X, e.Y)));
                if (hoverId >= 0 && scriptsList_ListBox.SelectedIndex >= 0) {
                    if (hoverId < scriptsList_ListBox.SelectedIndex)
                        scriptsList_ToolStripMenuItem_MoveUp_Click(sender, e);
                    else if (hoverId > scriptsList_ListBox.SelectedIndex)
                        scriptsList_ToolStripMenuItem_MoveDown_Click(sender, e);
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        /// <summary>
        /// Applies name change to all open documents and script title when text is changed
        /// </summary>
        private void scriptsList_TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            int index = scriptsList_ListBox.SelectedIndex;
            if (index >= 0 && _scripts[index].Title != scriptsList_TextBox_Name.Text) {
                _projectNeedSave = true;
                _scripts[index].Title = scriptsList_TextBox_Name.Text;
                UpdateScriptsName();
            }
        }

    #endregion

    #region Script Search Events
        
        private void searches_ToolStripButton_Click(object sender, EventArgs e)
        {
            Search((SearchControl)((ToolStripButton)sender).GetCurrentParent().Parent);
        }

        /// <summary>
        /// Goes to the line in the script of the clicked result
        /// </summary>
        private void searches_ListView_ItemActivate(object sender, EventArgs e)
        {
            SearchResult result = (SearchResult)((ListView)sender).SelectedItems[0];
            int index = _scripts.FindIndex(delegate(Script script) { return (script.Section == result.Section); });
            if (index != -1) {
                OpenScript(index);
                _scripts[index].Scintilla.GoTo.Line(result.Line);
            }
        }

        private void searches_TabControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (searches_TabControl.TabCount == 1)
                splitContainer_EditorSearches.Panel2Collapsed = true;
        }

    #endregion

    #region Project Methods
        
        private void CreateProject(string engine, string title, string directory, bool library, bool open)
        {
            try {
                directory += @"\";
                if (engine == "RMXP") {
                    foreach (string dir in Properties.Resources.RMXP_Directories.Split(' '))
                        Directory.CreateDirectory(directory + dir);
                    string data = "Gemini.Files.XP_Project.Data.";
                    foreach (string resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                        if (resource.StartsWith(data))
                            CopyResource(resource, directory + @"Data\" + resource.Remove(0, data.Length));
                    CopyResource("Gemini.Files.XP_Project.Game.exe", directory + "Game.exe");
                    if (library)
                        CopyResource("Gemini.Files.XP_Project.RGSS102E.dll", directory + "RGSS102E.dll");
                    File.WriteAllText(directory + "Game.ini", "[Game]\r\nRTP1=Standard\r\nLibrary=RGSS102E.dll\r\nScripts=Data\\Scripts.rxdata\r\nTitle=" + title);
                    File.WriteAllText(directory + "Game.rxproj", "RPGXP 1.00");
                    if (open)
                        OpenProject(directory + "Game.rxproj");
                } else if (engine == "RMVX") {
                    foreach (string dir in Properties.Resources.RMVX_Directories.Split(' '))
                        Directory.CreateDirectory(directory + dir);
                    string data = "Gemini.Files.VX_Project.Data.";
                    foreach (string resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                        if (resource.StartsWith(data))
                            CopyResource(resource, directory + @"Data\" + resource.Remove(0, data.Length));
                    CopyResource("Gemini.Files.VX_Project.Game.exe", directory + "Game.exe");
                    if (library)
                        CopyResource("Gemini.Files.VX_Project.RGSS202E.dll", directory + "RGSS202E.dll");
                    File.WriteAllText(directory + "Game.ini", "[Game]\r\nRTP=RPGVX\r\nLibrary=RGSS202E.dll\r\nScripts=Data\\Scripts.rvdata\r\nTitle=" + title);
                    File.WriteAllText(directory + "Game.rvproj", "RPGVX 1.00");
                    if (open)
                        OpenProject(directory + "Game.rvproj");
                } else if (engine == "RMVXAce") {
                    foreach (string dir in Properties.Resources.RMVXAce_Directories.Split(' '))
                        Directory.CreateDirectory(directory + dir);
                    string data = "Gemini.Files.VXAce_Project.Data.";
                    foreach (string resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                        if (resource.StartsWith(data))
                            CopyResource(resource, directory + @"Data\" + resource.Remove(0, data.Length));
                    CopyResource("Gemini.Files.VXAce_Project.Game.exe", directory + "Game.exe");
                    if (library)
                        CopyResource("Gemini.Files.VXAce_Project.RGSS300.dll", directory + @"System\RGSS300.dll");
                    File.WriteAllText(directory + "Game.ini", "[Game]\r\nRTP=RPGVXAce\r\nLibrary=System\\RGSS300.dll\r\nScripts=Data\\Scripts.rvdata2\r\nTitle=" + title);
                    File.WriteAllText(directory + "Game.rvproj2", "RPGVXAce 1.00");
                    if (open)
                        OpenProject(directory + "Game.rvproj2");
                }
            } catch {
                MessageBox.Show("Impossible de créer un nouveau projet.\nAssurer vous que vous avez suffisamment de privilèges pour créer des fichiers dans le répertoire indiqué.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenProject(string projectPath)
        {
            if (!CloseProject(true))
                return;
            _projectDirectory = Path.GetDirectoryName(projectPath) + @"\";
            switch (Path.GetExtension(projectPath)) {
            case ".rxproj" :
                _projectEngine = "RMXP";
                _projectScriptPath = GetScriptsPath();
                _projectGamePath = _projectDirectory + "Game.exe";
                break;
            case ".rvproj" :
                _projectEngine = "RMVX";
                _projectScriptPath = GetScriptsPath();
                _projectGamePath = _projectDirectory + "Game.exe";
                break;
            case ".rvproj2" :
                _projectEngine = "RMVXAce";
                _projectScriptPath = GetScriptsPath();
                _projectGamePath = _projectDirectory + "Game.exe";
                break;
            case ".rxdata" :
                _projectEngine = "RMXP";
                _projectScriptPath = projectPath;
                break;
            case ".rvdata" :
                _projectEngine = "RMVX";
                _projectScriptPath = projectPath;
                break;
            case ".rvdata2" :
                _projectEngine = "RMVXAce";
                _projectScriptPath = projectPath;
                break;
            }
            this.Enabled = false;
            if (LoadScripts()) {
                AddRecentProject(projectPath);
                UpdateTitle(projectPath);
                UpdateMenusEnabled();
                UpdateAutoCompleteWords();
            } else
                CloseProject(false);
            this.Enabled = true;
        }

        private void OpenRecentProject(int id, bool showErrorMessage)
        {
            if (id < 0 || id >= Settings.RecentlyOpened.Count)
                return;
            string path = Settings.RecentlyOpened[id];
            if (File.Exists(path))
                OpenProject(path);
            else {
                if (showErrorMessage)
                    MessageBox.Show("Le fichier n'existe plus et sera supprimé de la liste.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Settings.RecentlyOpened.RemoveAt(id);
                UpdateRecentProjectList();
            }
        }

        /// <summary>
        /// Adds an entry to the recent file lists, ensuring there are no duplicates
        /// </summary>
        /// <param name="projectPath">The path of the file to add</param>
        /// <param name="ext">The extension of the file, which determines the icon</param>
        private void AddRecentProject(string path)
        {
            if (Settings.RecentlyOpened.Contains(path))
                Settings.RecentlyOpened.Remove(path);
            else if (Settings.RecentlyOpened.Count > 8)
                Settings.RecentlyOpened.RemoveAt(8);
            Settings.RecentlyOpened.Insert(0, path);
            UpdateRecentProjectList();
        }

        private bool CloseProject(bool showSaveMessage)
        {
            if (showSaveMessage && NeedSave()) {
                DialogResult result = MessageBox.Show("Save changes before closing?",
                  "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                    return false;
                else if (result == DialogResult.Yes)
                    SaveScripts();
            }
            fileSystemWatcher.EnableRaisingEvents = false;
            foreach (Script script in _scripts)
                script.Dispose();
            _scripts.Clear();
            _usedSections.Clear();
            scriptsEditor_TabControl.TabPages.Clear();
            scriptsList_ListBox.Items.Clear();
            scriptsList_TextBox_Name.ResetText();
            _projectDirectory = _projectScriptPath = _projectGamePath = _projectEngine = "";
            _projectNeedSave = false;
            _projectLastSave = null;
            UpdateTitle();
            UpdateMenusEnabled();
            return true;
        }

        private bool IsProject(params string[] filenames)
        {
            foreach (string filename in filenames) {
                string ext = Path.GetExtension(filename);
                if (ext == ".rxproj" || ext == ".rvproj" || ext == ".rvproj2" ||
                    ext == ".rxdata" || ext == ".rvdata" || ext == ".rvdata2")
                    return true;
            }
            return false;
        }

		private void SaveConfiguration(bool showMessage)
		{
			try {
				Settings.SaveData();
				if (showMessage)
                    MessageBox.Show("La configuration a été correctement enregistré.", "Message");
			} catch {
				if (showMessage)
					MessageBox.Show("Une erreur s'est produite pour sauvegarder la configuration.\nVeuillez vous assurer que vous avez accès en écriture à:\n\t" +
						Application.StartupPath, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

    #endregion

    #region Scripts Methods

        /// <summary>
        /// Returns the currently active script
        /// </summary>
        /// <returns>The active script if there is one, else null</returns>
        private Script GetActiveScript()
        {
            return _scripts.Find(delegate(Script s) { return s.Opened && s.TabPage == scriptsEditor_TabControl.SelectedTab; });
        }

        /// <summary>
        /// Ensure the file exists and is in the proper format, then loads the game's scripts
        /// </summary>
        private bool LoadScripts()
        {
            if (File.Exists(_projectScriptPath))
                try {
                    RubyArray rmScripts = (RubyArray)Ruby.MarshalLoad(_projectLastSave = File.ReadAllBytes(_projectScriptPath));
                    _scripts.Capacity = rmScripts.Capacity;
                    foreach (RubyArray rmScript in rmScripts)
                        InsertScript(-1, false, rmScript);
                    _projectNeedSave = false;
                    fileSystemWatcher.Path = Path.GetDirectoryName(_projectScriptPath);
                    fileSystemWatcher.Filter = Path.GetFileName(_projectScriptPath);
                    fileSystemWatcher.EnableRaisingEvents = true;
                    return true;
                } catch {
                    MessageBox.Show("Une erreur est survenue lors du chargement des scripts.\r\nAssurez-vous que les données sont dans le format correct.",
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("Impossible de trouver le fichier\r\n" + _projectScriptPath, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void SaveScripts()
        {
            SaveScripts(_projectScriptPath);
        }

        private void SaveScripts(string path)
        {
            if (path == "")
                return;
            bool saveCopy = path != _projectScriptPath;
            this.Enabled = false;
            fileSystemWatcher.EnableRaisingEvents = false;
            RubyArray data = new RubyArray(_scripts.Count);
            for (int i = 0; i < _scripts.Count; i++) {
                if (!saveCopy) {
                    _scripts[i].ApplyChanges();
                    _scripts[i].NeedSave = false;
                }
                RubyArray rmScript = _scripts[i].RMScript;
                if (_scripts[i].NeedApplyChanges)
                    rmScript = new RubyArray() { rmScript[0], rmScript[1], Ruby.ZlibDeflate(_scripts[i].Text) };
                data[i] = rmScript;
            }
            byte[] save = Ruby.MarshalDump(data);
            try {
                File.WriteAllBytes(path, save);
                fileSystemWatcher.EnableRaisingEvents = true;
            } catch {
                MessageBox.Show("Une erreur s'est produite pour sauvegarder les scripts.\nAssurer vous que vous avez accès en écriture:\n\t" +
                    Path.GetDirectoryName(path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
            if (!saveCopy) {
                _projectLastSave = save;
                _projectNeedSave = false;
                UpdateScriptsName();
            }
        }

        /// <summary>
        /// Adds a new script to the list
        /// </summary>
        /// <param name="index">The insert position. Count from the end if negative</param>
        /// <param name="open">Determines if page will be opened after adding</param>
        /// <param name="args">(RubyArray rmScript) or (string title, string text)</param>
        private void InsertScript(int index, bool open, params object[] args)
        {
            Script script;
            if (args.Length == 1) {
                RubyArray rmScript = (RubyArray)args[0];
                rmScript[0] = GetRandomSection();
                script = new Script(rmScript);
            } else if (args.Length == 2)
                script = new Script(GetRandomSection(), (string)args[0], (string)args[1]);
            else
                return;
            if (index < 0)
                index += _scripts.Count + 1;
            _scripts.Insert(index, script);
            scriptsList_ListBox.Items.Insert(index, script.TabPageTitle);
            scriptsList_ListBox.SelectedIndex = index;
            if (open)
                OpenScript(index);
            _projectNeedSave = true;
        }

        /// <summary>
        /// Creates a new tab with a Scintilla control and adds it to the TabControl
        /// </summary>
        /// <param name="index">The script that will be loaded into the page</param>
        private void OpenScript(int index)
        {
            if (!_scripts[index].Opened) {
                _scripts[index].Scintilla.ContextMenuStrip = scriptsEditor_ContextMenuStrip;
                _scripts[index].Scintilla.SelectionChanged += new EventHandler(Scintilla_Changed);
                _scripts[index].Scintilla.TextChanged += new EventHandler<EventArgs>(Scintilla_Changed);
                scriptsEditor_TabControl.TabPages.Add(_scripts[index].TabPage);
            }
            scriptsEditor_TabControl.SelectedTab = _scripts[index].TabPage;
            UpdateMenusEnabled();
        }

        private void ImportScripts(int insertPos, bool open, params string[] paths)
        {
            foreach (string path in paths)
                if (File.Exists(path))
                    try {
                        InsertScript(insertPos, open, Path.GetFileNameWithoutExtension(path), File.ReadAllText(path));
                        if (insertPos >= 0)
                            insertPos++;
                    } catch {
                        MessageBox.Show("Impossible d'importer le fichier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        /// <summary>
        /// Exports the scripts using the passed filed extension to determine the file type
        /// </summary> 
        /// <param name="extension">The extension to save the files as</param>
        private void ExportScripts(string extension)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()) {
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                dialog.Description = "Choisissez le répertoire pour enregistrer les fichiers...";
                if (dialog.ShowDialog() == DialogResult.OK) {
                    this.Enabled = false;
                    try {
                        Regex removeInvalidChars = new Regex(
                            "[{" + Regex.Escape(new string(Path.GetInvalidFileNameChars())) + "}]",
                            RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.CultureInvariant);
                        for (int i = 0; i < _scripts.Count; i++) {
                            string filename = String.Format("{0:000} - {1}", i, _scripts[i].Title);
                            filename = removeInvalidChars.Replace(filename, "");
                            File.WriteAllText(dialog.SelectedPath + "/" + filename + extension, _scripts[i].Text);
                            if (!_scripts[i].Opened)
                                _scripts[i].Dispose();
                        }
                    } catch {
                        MessageBox.Show("Une erreur s'est produite, l'exportation a été arrêté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Enabled = true;
                }
            }
        }

    #endregion

    #region Clipboard Methods

        /// <summary>
        /// Get a script from the clipboard
        /// </summary>
        /// <returns>A script if there is one, else null</returns>
        private RubyArray GetClipboardScript()
        {
            String format = ClipboardContainsScript();
            if (format != null)
                try {
                    MemoryStream stream = (MemoryStream)System.Windows.Forms.Clipboard.GetData(format);
                    byte[] data = new byte[4];
                    stream.Read(data, 0, data.Length);
                    data = new byte[BitConverter.ToInt32(data, 0)];
                    stream.Read(data, 0, data.Length);
                    return (RubyArray)Ruby.MarshalLoad(data);
                } catch {
                    MessageBox.Show("Clipboard error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return null;
        }

        /// <summary>
        /// Set the passed script to the clipboard in the current project format
        /// </summary>
        /// <param name="script">The script to copy</param>
        private void SetClipboardScript(Script script)
        {
            RubyArray rmScript = script.RMScript;
            if (script.NeedApplyChanges)
                rmScript = new RubyArray() { rmScript[0], rmScript[1], Ruby.ZlibDeflate(script.Text) };
            byte[] data = Ruby.MarshalDump(rmScript);
            MemoryStream stream = new MemoryStream();
            stream.Write(BitConverter.GetBytes(data.Length), 0, 4);
            stream.Write(data, 0, data.Length);
            string format = "";
            if (_projectEngine == "RMXP")         format = "RPGXP SCRIPT";
            else if (_projectEngine == "RMVX")    format = "RPGVX SCRIPT";
            else if (_projectEngine == "RMVXAce") format = "VX Ace SCRIPT";
            System.Windows.Forms.Clipboard.SetData(format, stream);
        }

        /// <summary>
        /// Check if the clipboard contains a script
        /// </summary>
        /// <returns>The script format if there is one, else null</returns>
        private string ClipboardContainsScript()
        {
            foreach (string format in new string[] { "RPGXP SCRIPT", "RPGVX SCRIPT", "VX Ace SCRIPT" })
                if (System.Windows.Forms.Clipboard.ContainsData(format))
                    return format;
            return null;
        }

    #endregion

    #region Search Methods

        private void ShowFind()
        {
            Script script = GetActiveScript();
            if (script == null)
                return;
            _findReplaceDialog.Scintilla = script.Scintilla;
            if (!_findReplaceDialog.Visible)
                _findReplaceDialog.Show(this);
            _findReplaceDialog.tabAll.SelectedTab = _findReplaceDialog.tabAll.TabPages["tpgFind"];
            ScintillaNet.Range selRange = _findReplaceDialog.Scintilla.Selection.Range;
            if (selRange.IsMultiLine)
                _findReplaceDialog.chkSearchSelectionF.Checked = true;
            else if (selRange.Length > 0)
                _findReplaceDialog.cboFindF.Text = selRange.Text;
            _findReplaceDialog.cboFindF.Select();
            _findReplaceDialog.cboFindF.SelectAll();
        }

        private void ShowReplace()
        {
            Script script = GetActiveScript();
            if (script == null)
                return;
            _findReplaceDialog.Scintilla = script.Scintilla;
            if (!_findReplaceDialog.Visible)
                _findReplaceDialog.Show(this);
            _findReplaceDialog.tabAll.SelectedTab = _findReplaceDialog.tabAll.TabPages["tpgReplace"];
            ScintillaNet.Range selRange = _findReplaceDialog.Scintilla.Selection.Range;
            if (selRange.IsMultiLine)
                _findReplaceDialog.chkSearchSelectionR.Checked = true;
            else if (selRange.Length > 0)
                _findReplaceDialog.cboFindR.Text = selRange.Text;
            _findReplaceDialog.cboFindR.Select();
            _findReplaceDialog.cboFindR.SelectAll();
        }

        private void ShowSearch()
        {
            TabPage tabPage = new TabPage("Nouvelle Recherche");
            SearchControl searchControl = new SearchControl();
            searchControl.toolStripButton_Search.Click += new EventHandler(searches_ToolStripButton_Click);
            searchControl.listView_Results.ItemActivate += new EventHandler(searches_ListView_ItemActivate);
            tabPage.Controls.Add(searchControl);
            searches_TabControl.TabPages.Add(tabPage);
            searches_TabControl.SelectedTab = tabPage;
            splitContainer_EditorSearches.Panel2Collapsed = false;
            if (splitContainer_EditorSearches.Panel2.ClientSize.Height < 200)
                splitContainer_EditorSearches.SplitterDistance -= 200 - splitContainer_EditorSearches.Panel2.ClientSize.Height;
            searchControl.toolStripTextBox_SearchString.Focus();
        }

        private void Search(SearchControl control)
        {
            // Set appropriate flag
            ScintillaNet.SearchFlags flags = ScintillaNet.SearchFlags.Empty;
            if (control.toolStripMenuItem_RegExp.Checked)
                flags |= ScintillaNet.SearchFlags.RegExp;
            if (control.toolStripMenuItem_MatchCase.Checked)
                flags |= ScintillaNet.SearchFlags.MatchCase;
            if (control.toolStripMenuItem_WholeWord.Checked)
                flags |= ScintillaNet.SearchFlags.WholeWord;
            if (control.toolStripMenuItem_WordStart.Checked)
                flags |= ScintillaNet.SearchFlags.WordStart;
            // Determine search location
            List<Script> searchLocation = new List<Script>();
            if (control.toolStripComboBox_Scope.SelectedIndex == 0) {
                Script script = GetActiveScript();
                if (script != null)
                    searchLocation.Add(script);
            } else if (control.toolStripComboBox_Scope.SelectedIndex == 1) {
                foreach (Script script in _scripts)
                    if (script.Opened)
                        searchLocation.Add(script);
            } else
                searchLocation = _scripts;
            // Execute search
            if (searchLocation.Count > 0) {
                control.listView_Results.Items.Clear();
                control.Parent.Text = control.toolStripTextBox_SearchString.Text;
                control.label_Statistics.Text = "Recherche...";
                control.label_Statistics.Update();
                int scriptCount = 0;
                this.Enabled = false;
                foreach (Script script in searchLocation) {
                    SearchResult[] results = script.Search(control.toolStripTextBox_SearchString.Text, flags);
                    if (results.Length > 0) {
                        scriptCount++;
                        control.listView_Results.Items.AddRange(results);
                        control.label_Statistics.Text = String.Format(@"{0} resultat {1} trouver{2} script{3}.",
                            control.listView_Results.Items.Count, control.listView_Results.Items.Count > 1 ? "s" : "",
                            scriptCount, scriptCount > 1 ? "s" : "");
                        control.label_Statistics.Update();
                    }
                }
                this.Enabled = true;
                if (scriptCount == 0)
                    control.label_Statistics.Text = "Aucun résultat correspondant n'a été trouvé dans la recherche.";
            } else
                control.label_Statistics.Text = "Il ne existe actuellement aucun document ouvert.";
        }

    #endregion

    #region Misc Methods
        
        private void ExtractResources()
        {
            string toExtract = "Gemini.Files.ToExtract.";
            foreach (string resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                if (resource.StartsWith(toExtract))
                    try { CopyResource(resource, resource.Remove(0, toExtract.Length)); } catch {}
        }

        /// <summary>
        /// Copies an embedded resource to an external place on the hard-drive
        /// </summary>
        /// <param name="path">The path the resource will be saved to</param>
        private void CopyResource(string resource, string path)
        {
            using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
            using (FileStream resourceFile = new FileStream(path, FileMode.Create)) {
                byte[] b = new byte[s.Length + 1];
                s.Read(b, 0, Convert.ToInt32(s.Length));
                resourceFile.Write(b, 0, Convert.ToInt32(b.Length - 1));
                resourceFile.Flush();
            }
        }

        /// <summary>
        /// Reads the game's Game.ini file and retrieves the title of the game, then returns it
        /// </summary>
        private string GetGameTitle()
        {
            string ini = _projectDirectory + "Game.ini";
            if (File.Exists(ini))
                foreach (string line in File.ReadAllLines(ini))
                    if (line.StartsWith("Title="))
                        return line.Replace("Title=", "").Trim();
            return "Untitled";
        }

        /// <summary>
        /// Reads the game's Game.ini file and retrieves the scripts path, then returns it
        /// </summary>
        private string GetScriptsPath()
        {
            string ini = _projectDirectory + "Game.ini";
            if (File.Exists(ini))
                foreach (string line in File.ReadAllLines(ini))
                    if (line.StartsWith("Scripts="))
                        return _projectDirectory + line.Replace("Scripts=", "").Trim();
            if (_projectEngine == "RMXP")           return  _projectDirectory + @"Data\Scripts.rxdata";
            else if (_projectEngine == "RMVX")      return  _projectDirectory + @"Data\Scripts.rvdata";
            else if (_projectEngine == "RMVXAce")   return  _projectDirectory + @"Data\Scripts.rvdata2";
            return "";
        }

        /// <summary>
        /// Retrieves a non-repeatable random integer
        /// </summary>
        /// <returns>Random integer</returns>
        private int GetRandomSection()
        {
            Random random = new Random();
            int section;
            do section = random.Next(int.MaxValue);
            while (_usedSections.Contains(section));
            _usedSections.Add(section);
            return section;
        }

        private bool NeedSave()
        {
            if (_projectNeedSave)
                return true;
            foreach (Script script in _scripts)
                if (script.NeedSave)
                    return true;
            return false;
        }
        
    #endregion
        
    #region Update Methods

        private void UpdateAutoCompleteWords()
        {
            string words = "";
            if ((Settings.AutoCompleteFlag & (1 << 0)) != 0) {
                if (_projectEngine == "RMXP")           words += Gemini.Properties.Resources.Ruby181_Constants + " ";
                else if (_projectEngine == "RMVX")      words += Gemini.Properties.Resources.Ruby181_Constants + " ";
                else if (_projectEngine == "RMVXAce")   words += Gemini.Properties.Resources.Ruby192_Constants + " ";
            }
            if ((Settings.AutoCompleteFlag & (1 << 1)) != 0)
                words += Gemini.Properties.Resources.Ruby_Keywords + " ";
            if ((Settings.AutoCompleteFlag & (1 << 2)) != 0) {
                if (_projectEngine == "RMXP")           words += Gemini.Properties.Resources.Ruby181_KernelFunctions + " ";
                else if (_projectEngine == "RMVX")      words += Gemini.Properties.Resources.Ruby181_KernelFunctions + " ";
                else if (_projectEngine == "RMVXAce")   words += Gemini.Properties.Resources.Ruby192_KernelFunctions + " ";
            }
            if ((Settings.AutoCompleteFlag & (1 << 3)) != 0) {
                if (_projectEngine == "RMXP")           words += Gemini.Properties.Resources.RMXP_Constants + " ";
                else if (_projectEngine == "RMVX")      words += Gemini.Properties.Resources.RMVX_Constants + " ";
                else if (_projectEngine == "RMVXAce")   words += Gemini.Properties.Resources.RMVXAce_Constants + " ";
            }
            if ((Settings.AutoCompleteFlag & (1 << 4)) != 0) {
                if (_projectEngine == "RMXP")           words += Gemini.Properties.Resources.RMXP_Globals + " ";
                else if (_projectEngine == "RMVX")      words += Gemini.Properties.Resources.RMVX_Globals + " ";
                else if (_projectEngine == "RMVXAce")   words += Gemini.Properties.Resources.RMVXAce_Globals + " ";
            }
            if ((Settings.AutoCompleteFlag & (1 << 5)) != 0)
                words += Settings.AutoCompleteCustomWords;
            Settings.AutoCompleteWords.Clear();
            foreach (string word in words.Split(' '))
                if (word.Length != 0 && !Settings.AutoCompleteWords.Contains(word))
                    Settings.AutoCompleteWords.Add(word);
            Settings.AutoCompleteWords.Sort();
        }

        private void UpdateTitle(string projectPath = "")
        {
            if (_projectEngine == "")
                this.Text = "Gemini";
            else if (_projectGamePath == "")
                this.Text = _projectEngine + " - " + projectPath;
            else
                this.Text = _projectEngine + " - " + GetGameTitle() + " - " + projectPath;
            Bitmap icon = null;
            if (_projectEngine == "RMXP")         icon = Properties.Resources.rmxp_script;
            else if (_projectEngine == "RMVX")    icon = Properties.Resources.rmvx_script;
            else if (_projectEngine == "RMVXAce") icon = Properties.Resources.rmvxace_script;
            mainMenu_ToolStripMenuItem_ExportScriptsRMData.Image = icon;
        }

        private void UpdateRecentProjectList()
        {
            while (mainMenu_ToolStripMenuItem_OpenRecentProject.DropDownItems.Count > 2)
                mainMenu_ToolStripMenuItem_OpenRecentProject.DropDownItems.RemoveAt(2);
            foreach (string path in Settings.RecentlyOpened) {
                string ext = Path.GetExtension(path);
                Bitmap icon = null;
                if (ext == ".rxproj")       icon = Properties.Resources.rmxp_icon;
                else if (ext == ".rvproj")  icon = Properties.Resources.rmvx_icon;
                else if (ext == ".rvproj2") icon = Properties.Resources.rmvxace_icon;
                else if (ext == ".rxdata")  icon = Properties.Resources.rmxp_script;
                else if (ext == ".rvdata")  icon = Properties.Resources.rmvx_script;
                else if (ext == ".rvdata2") icon = Properties.Resources.rmvxace_script;
                ToolStripMenuItem item = new ToolStripMenuItem(path, icon, new EventHandler(mainMenu_ToolStripMenuItem_OpenRecentProject_Click));
                mainMenu_ToolStripMenuItem_OpenRecentProject.DropDownItems.Add(item);
            }
        }

        private void UpdateMenusEnabled()
        {
            Script script = GetActiveScript();
            bool project = _projectEngine != "";
            bool editor = project && script != null;
            bool editorSelection = editor && script.Scintilla.Selection.Length > 0;
            bool editorUndo = editor && script.Scintilla.UndoRedo.CanUndo;
            bool editorRedo = editor && script.Scintilla.UndoRedo.CanRedo;
            bool editorPaste = editor && script.Scintilla.Clipboard.CanPaste;
            bool listSelection = project && scriptsList_ListBox.SelectedIndex != -1;
            bool listMoveUp = listSelection && scriptsList_ListBox.SelectedIndex != 0;
            bool listMoveDown = listSelection && scriptsList_ListBox.SelectedIndex != scriptsList_ListBox.Items.Count-1;
            bool listPaste = project && ClipboardContainsScript() != null;

            mainMenu_ToolStripMenuItem_CloseProject.Enabled = project;
            mainMenu_ToolStripMenuItem_SaveProject.Enabled = project;
            mainMenu_ToolStripMenuItem_ImportScripts.Enabled = project;
            mainMenu_ToolStripMenuItem_ExportScripts.Enabled = project;
            mainMenu_ToolStripMenuItem_ExportScriptsRMData.Enabled = project;
            mainMenu_ToolStripMenuItem_ExportScriptsText.Enabled = project;
            mainMenu_ToolStripMenuItem_ExportScriptsRuby.Enabled = project;

            mainMenu_ToolStripMenuItem_Undo.Enabled = editorUndo;
            mainMenu_ToolStripMenuItem_Redo.Enabled = editorRedo;
            mainMenu_ToolStripMenuItem_Cut.Enabled = editorSelection;
            mainMenu_ToolStripMenuItem_Copy.Enabled = editorSelection;
            mainMenu_ToolStripMenuItem_Paste.Enabled = editorPaste;
            mainMenu_ToolStripMenuItem_Delete.Enabled = editorSelection;
            mainMenu_ToolStripMenuItem_SelectAll.Enabled = editor;
            mainMenu_ToolStripMenuItem_BatchSearch.Enabled = project;
            mainMenu_ToolStripMenuItem_IncrementalSearch.Enabled = editor;
            mainMenu_ToolStripMenuItem_Find.Enabled = editor;
            mainMenu_ToolStripMenuItem_Replace.Enabled = editor;
            mainMenu_ToolStripMenuItem_GoToLine.Enabled = editor;
            mainMenu_ToolStripMenuItem_BatchComment.Enabled = project;
            mainMenu_ToolStripMenuItem_Comment.Enabled = editor;
            mainMenu_ToolStripMenuItem_UnComment.Enabled = editor;
            mainMenu_ToolStripMenuItem_ToggleComment.Enabled = editor;
            mainMenu_ToolStripMenuItem_StructureScript.Enabled = project;
            mainMenu_ToolStripMenuItem_StructureScriptCurrent.Enabled = editor;
            mainMenu_ToolStripMenuItem_StructureScriptOpen.Enabled = editor;
            mainMenu_ToolStripMenuItem_StructureScriptAll.Enabled = project;
            mainMenu_ToolStripMenuItem_RemoveEmptyLines.Enabled = project;
            mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Enabled = editor;
            mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.Enabled = editor;
            mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.Enabled = project;
            mainMenu_ToolStripMenuItem_Help.Enabled = project;
            mainMenu_ToolStripMenuItem_Run.Enabled = project;
            mainMenu_ToolStripMenuItem_Debug.Enabled = project;
            mainMenu_ToolStripMenuItem_ProjectFolder.Enabled = project;

            scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Enabled = editor;

            scriptsList_ToolStripMenuItem_Open.Enabled = listSelection;
            scriptsList_ToolStripMenuItem_Insert.Enabled = project;
            scriptsList_ToolStripMenuItem_Cut.Enabled = listSelection;
            scriptsList_ToolStripMenuItem_Copy.Enabled = listSelection;
            scriptsList_ToolStripMenuItem_Paste.Enabled = listPaste;
            scriptsList_ToolStripMenuItem_Delete.Enabled = listSelection;
            scriptsList_ToolStripMenuItem_MoveUp.Enabled = listMoveUp;
            scriptsList_ToolStripMenuItem_MoveDown.Enabled = listMoveDown;

            // below are just duplicates
            
            mainMenu_ToolStripMenuItem_RunF12.Enabled = mainMenu_ToolStripMenuItem_Run.Enabled;

            scriptsList_ToolStripMenuItem_BatchSearch.Enabled = mainMenu_ToolStripMenuItem_BatchSearch.Enabled;

            scriptsList_ToolStripButton_ImportScripts.Enabled = mainMenu_ToolStripMenuItem_ImportScripts.Enabled;
            scriptsList_ToolStripButton_Open.Enabled = scriptsList_ToolStripMenuItem_Open.Enabled;
            scriptsList_ToolStripButton_Insert.Enabled = scriptsList_ToolStripMenuItem_Insert.Enabled;
            scriptsList_ToolStripButton_Delete.Enabled = scriptsList_ToolStripMenuItem_Delete.Enabled;
            scriptsList_ToolStripButton_MoveUp.Enabled = scriptsList_ToolStripMenuItem_MoveUp.Enabled;
            scriptsList_ToolStripButton_MoveDown.Enabled = scriptsList_ToolStripMenuItem_MoveDown.Enabled;
            scriptsList_ToolStripButton_BatchSearch.Enabled = mainMenu_ToolStripMenuItem_BatchSearch.Enabled;

            scriptsEditor_ToolStripMenuItem_Undo.Enabled = mainMenu_ToolStripMenuItem_Undo.Enabled;
            scriptsEditor_ToolStripMenuItem_Redo.Enabled = mainMenu_ToolStripMenuItem_Redo.Enabled;
            scriptsEditor_ToolStripMenuItem_Cut.Enabled = mainMenu_ToolStripMenuItem_Cut.Enabled;
            scriptsEditor_ToolStripMenuItem_Copy.Enabled = mainMenu_ToolStripMenuItem_Copy.Enabled;
            scriptsEditor_ToolStripMenuItem_Paste.Enabled = mainMenu_ToolStripMenuItem_Paste.Enabled;
            scriptsEditor_ToolStripMenuItem_Delete.Enabled = mainMenu_ToolStripMenuItem_Delete.Enabled;
            scriptsEditor_ToolStripMenuItem_SelectAll.Enabled = mainMenu_ToolStripMenuItem_SelectAll.Enabled;
            scriptsEditor_ToolStripMenuItem_IncrementalSearch.Enabled = mainMenu_ToolStripMenuItem_IncrementalSearch.Enabled;
            scriptsEditor_ToolStripMenuItem_Find.Enabled = mainMenu_ToolStripMenuItem_Find.Enabled;
            scriptsEditor_ToolStripMenuItem_FindNext.Enabled = mainMenu_ToolStripMenuItem_Find.Enabled;
            scriptsEditor_ToolStripMenuItem_FindPrevious.Enabled = mainMenu_ToolStripMenuItem_Find.Enabled;
            scriptsEditor_ToolStripMenuItem_Replace.Enabled = mainMenu_ToolStripMenuItem_Replace.Enabled;
            scriptsEditor_ToolStripMenuItem_GoToLine.Enabled = mainMenu_ToolStripMenuItem_GoToLine.Enabled;
            scriptsEditor_ToolStripMenuItem_Comment.Enabled = mainMenu_ToolStripMenuItem_ToggleComment.Enabled;

            scriptsEditor_ToolStripButton_SaveProject.Enabled = mainMenu_ToolStripMenuItem_SaveProject.Enabled;
            scriptsEditor_ToolStripButton_IncrementalSearch.Enabled = mainMenu_ToolStripMenuItem_IncrementalSearch.Enabled;
            scriptsEditor_ToolStripButton_Find.Enabled = mainMenu_ToolStripMenuItem_Find.Enabled;
            scriptsEditor_ToolStripButton_Replace.Enabled = mainMenu_ToolStripMenuItem_Replace.Enabled;
            scriptsEditor_ToolStripButton_GoToLine.Enabled = mainMenu_ToolStripMenuItem_GoToLine.Enabled;
            scriptsEditor_ToolStripButton_Comment.Enabled = mainMenu_ToolStripMenuItem_ToggleComment.Enabled;
            scriptsEditor_ToolStripButton_StructureScript.Enabled = mainMenu_ToolStripMenuItem_StructureScriptCurrent.Enabled;
            scriptsEditor_ToolStripButton_RemoveEmptyLines.Enabled = mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Enabled;
            scriptsEditor_ToolStripButton_Run.Enabled = mainMenu_ToolStripMenuItem_Run.Enabled;
            scriptsEditor_ToolStripButton_Debug.Enabled = mainMenu_ToolStripMenuItem_Debug.Enabled;
            scriptsEditor_ToolStripButton_ProjectFolder.Enabled = mainMenu_ToolStripMenuItem_ProjectFolder.Enabled;
            scriptsEditor_ToolStripButton_CloseProject.Enabled = mainMenu_ToolStripMenuItem_CloseProject.Enabled;
        }

        private void UpdateMenusChecked()
        {
            mainMenu_ToolStripMenuItem_AutoOpenProject.Checked = Settings.AutoOpen;
            mainMenu_ToolStripMenuItem_AutoSaveSettings.Checked = Settings.AutoSaveConfig;
            mainMenu_ToolStripMenuItem_AutoComplete.Checked = Settings.AutoComplete;
            scriptsEditor_ToolStripButton_AutoComplete.Checked = Settings.AutoComplete;
            mainMenu_ToolStripMenuItem_AutoIndent.Checked = Settings.AutoIndent;
            scriptsEditor_ToolStripButton_AutoIndent.Checked = Settings.AutoIndent;
            mainMenu_ToolStripMenuItem_IndentGuides.Checked = Settings.GuideLines;
            scriptsEditor_ToolStripButton_IndentGuides.Checked = Settings.GuideLines;
            mainMenu_ToolStripMenuItem_LineHighlight.Checked = Settings.LineHighLight;
            scriptsEditor_ToolStripButton_LineHighlight.Checked = Settings.LineHighLight;
            mainMenu_ToolStripMenuItem_CodeFolding.Checked = Settings.CodeFolding;
            scriptsEditor_ToolStripButton_CodeFolding.Checked = Settings.CodeFolding;
            mainMenu_ToolStripMenuItem_Debug.Checked = Settings.DebugMode;
            scriptsEditor_ToolStripButton_Debug.Checked = Settings.DebugMode;
            mainMenu_ToolStripMenuItem_AutoCheckUpdates.Checked = Settings.AutoCheckUpdates;
        }

        private void UpdateScriptStatus()
        {
            Script script = GetActiveScript();
            scriptsEditor_ToolStripStatusLabel_Characters.Text = script == null ? "" :
                String.Format("Lignes: {0}  Caractères: {1}", script.Scintilla.Lines.Count, script.Scintilla.TextLength);
            scriptsEditor_ToolStripStatusLabel_Filler.Text = (script == null || script.Scintilla.Selection.Length == 0) ? "" :
                String.Format("Seléction: {0}", script.Scintilla.Selection.Length);
            scriptsEditor_ToolStripStatusLabel_Position.Text = script == null ? "" :
                String.Format("Position: {0}", script.Scintilla.CurrentPos);
        }

        private void UpdateScriptsName()
        {
            for (int i = 0; i < _scripts.Count; i++)
                if ((string)scriptsList_ListBox.Items[i] != _scripts[i].TabPageTitle)
                    scriptsList_ListBox.Items[i] = _scripts[i].TabPageTitle;
        }
        
    #endregion

        private void mainMenu_ToolStripMenuItem_File_Click(object sender, EventArgs e)
        {

        }


    }
}