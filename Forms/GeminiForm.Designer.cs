namespace Gemini
{
    partial class GeminiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
				_findReplaceDialog.Dispose();
				_charmap.Dispose();
                foreach (Script script in _scripts)
                    script.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
            this.mainMenu_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenu_ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_OpenRecentProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_SaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_CloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ImportScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ExportScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ExportScriptsText = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_SaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ClearSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_BatchSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_IncrementalSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_GoToLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_BatchComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ToggleComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Comment = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_UnComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_StructureScript = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_StructureScriptAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_StylesConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoIndent = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_IndentGuides = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_CodeFolding = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_LineHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_HighlightColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_RunF12 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_ProjectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_VersionHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_ToolStripMenuItem_AboutGemini = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_GroupBox = new System.Windows.Forms.GroupBox();
            this.scriptsList_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.scriptsList_ToolStripButton_ImportScripts = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_Insert = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_Delete = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_ToolStripButton_BatchSearch = new System.Windows.Forms.ToolStripButton();
            this.scriptsList_Label_Name = new System.Windows.Forms.Label();
            this.scriptsList_TextBox_Name = new System.Windows.Forms.TextBox();
            this.scriptsList_ListBox = new System.Windows.Forms.ListBox();
            this.scriptsList_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scriptsList_ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_MoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_MoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsList_ToolStripMenuItem_BatchSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_GroupBox = new System.Windows.Forms.GroupBox();
            this.scriptsEditor_TabControl = new Gemini.AdvancedTabControl();
            this.scriptsEditor_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.scriptsEditor_ToolStripStatusLabel_Characters = new System.Windows.Forms.ToolStripStatusLabel();
            this.scriptsEditor_ToolStripStatusLabel_Filler = new System.Windows.Forms.ToolStripStatusLabel();
            this.scriptsEditor_ToolStripStatusLabel_Position = new System.Windows.Forms.ToolStripStatusLabel();
            this.scriptsEditor_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.scriptsEditor_ToolStripButton_SaveProject = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_OpenProject = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_SpecialChars = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_StyleConfig = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_AutoComplete = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_AutoIndent = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_IndentGuides = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_CodeFolding = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_LineHighlight = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_HighlightColor = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_IncrementalSearch = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_Find = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_Replace = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_GoToLine = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_Comment = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_StructureScript = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_Run = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_Debug = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_ProjectFolder = new System.Windows.Forms.ToolStripButton();
            this.scriptsEditor_ToolStripButton_CloseProject = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.scriptsEditor_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scriptsEditor_ToolStripMenuItem_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_FindPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_GoToLine = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_Comment = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.splitContainer_EditorSearches = new System.Windows.Forms.SplitContainer();
            this.searches_GroupBox = new System.Windows.Forms.GroupBox();
            this.searches_TabControl = new Gemini.AdvancedTabControl();
            toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu_MenuStrip.SuspendLayout();
            this.scriptsList_GroupBox.SuspendLayout();
            this.scriptsList_ToolStrip.SuspendLayout();
            this.scriptsList_ContextMenuStrip.SuspendLayout();
            this.scriptsEditor_GroupBox.SuspendLayout();
            this.scriptsEditor_StatusStrip.SuspendLayout();
            this.scriptsEditor_ToolStrip.SuspendLayout();
            this.scriptsEditor_ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditorSearches)).BeginInit();
            this.splitContainer_EditorSearches.Panel1.SuspendLayout();
            this.splitContainer_EditorSearches.Panel2.SuspendLayout();
            this.splitContainer_EditorSearches.SuspendLayout();
            this.searches_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator21
            // 
            toolStripSeparator21.Name = "toolStripSeparator21";
            toolStripSeparator21.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripSeparator17
            // 
            toolStripSeparator17.Name = "toolStripSeparator17";
            toolStripSeparator17.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripSeparator18
            // 
            toolStripSeparator18.Name = "toolStripSeparator18";
            toolStripSeparator18.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(278, 6);
            // 
            // toolStripSeparator19
            // 
            toolStripSeparator19.Name = "toolStripSeparator19";
            toolStripSeparator19.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripSeparator22
            // 
            toolStripSeparator22.Name = "toolStripSeparator22";
            toolStripSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator20
            // 
            toolStripSeparator20.Name = "toolStripSeparator20";
            toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new System.Drawing.Size(242, 6);
            // 
            // mainMenu_MenuStrip
            // 
            this.mainMenu_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_File,
            this.mainMenu_ToolStripMenuItem_Edit,
            this.mainMenu_ToolStripMenuItem_Settings,
            this.mainMenu_ToolStripMenuItem_Game,
            this.mainMenu_ToolStripMenuItem_About});
            this.mainMenu_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenu_MenuStrip.Name = "mainMenu_MenuStrip";
            this.mainMenu_MenuStrip.Size = new System.Drawing.Size(790, 24);
            this.mainMenu_MenuStrip.TabIndex = 0;
            this.mainMenu_MenuStrip.Text = "mainMenu_MenuStrip";
            // 
            // mainMenu_ToolStripMenuItem_File
            // 
            this.mainMenu_ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_NewProject,
            this.mainMenu_ToolStripMenuItem_OpenProject,
            this.mainMenu_ToolStripMenuItem_OpenRecentProject,
            this.mainMenu_ToolStripMenuItem_SaveProject,
            this.mainMenu_ToolStripMenuItem_CloseProject,
            toolStripSeparator3,
            this.mainMenu_ToolStripMenuItem_ImportScripts,
            this.mainMenu_ToolStripMenuItem_ExportScripts,
            toolStripSeparator4,
            this.mainMenu_ToolStripMenuItem_SaveSettings,
            this.mainMenu_ToolStripMenuItem_ClearSettings,
            toolStripSeparator6,
            this.mainMenu_ToolStripMenuItem_Exit});
            this.mainMenu_ToolStripMenuItem_File.Name = "mainMenu_ToolStripMenuItem_File";
            this.mainMenu_ToolStripMenuItem_File.Size = new System.Drawing.Size(54, 20);
            this.mainMenu_ToolStripMenuItem_File.Text = "Fichier";
            this.mainMenu_ToolStripMenuItem_File.DropDownOpening += new System.EventHandler(this.mainMenu_ToolStripMenuItem_DropDownOpening);
            this.mainMenu_ToolStripMenuItem_File.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_File_Click);
            // 
            // mainMenu_ToolStripMenuItem_NewProject
            // 
            this.mainMenu_ToolStripMenuItem_NewProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP,
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX,
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce});
            this.mainMenu_ToolStripMenuItem_NewProject.Image = global::Gemini.Properties.Resources.Document;
            this.mainMenu_ToolStripMenuItem_NewProject.Name = "mainMenu_ToolStripMenuItem_NewProject";
            this.mainMenu_ToolStripMenuItem_NewProject.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_NewProject.Text = "Nouveau Projet";
            this.mainMenu_ToolStripMenuItem_NewProject.ToolTipText = "Créer un nouveau projet";
            // 
            // mainMenu_ToolStripMenuItem_NewProjectRMXP
            // 
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP.Image = global::Gemini.Properties.Resources.rmxp_icon;
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP.Name = "mainMenu_ToolStripMenuItem_NewProjectRMXP";
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP.Size = new System.Drawing.Size(172, 22);
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP.Text = "RPG Maker XP";
            this.mainMenu_ToolStripMenuItem_NewProjectRMXP.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_NewProjectRMXP_Click);
            // 
            // mainMenu_ToolStripMenuItem_NewProjectRMVX
            // 
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX.Image = global::Gemini.Properties.Resources.rmvx_icon;
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX.Name = "mainMenu_ToolStripMenuItem_NewProjectRMVX";
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX.Size = new System.Drawing.Size(172, 22);
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX.Text = "RPG Maker VX";
            this.mainMenu_ToolStripMenuItem_NewProjectRMVX.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_NewProjectRMVX_Click);
            // 
            // mainMenu_ToolStripMenuItem_NewProjectRMVXAce
            // 
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce.Image = global::Gemini.Properties.Resources.rmvxace_icon;
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce.Name = "mainMenu_ToolStripMenuItem_NewProjectRMVXAce";
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce.Size = new System.Drawing.Size(172, 22);
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce.Text = "RPG Maker VX Ace";
            this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_NewProjectRMVXAce_Click);
            // 
            // mainMenu_ToolStripMenuItem_OpenProject
            // 
            this.mainMenu_ToolStripMenuItem_OpenProject.Image = global::Gemini.Properties.Resources.Open_file;
            this.mainMenu_ToolStripMenuItem_OpenProject.Name = "mainMenu_ToolStripMenuItem_OpenProject";
            this.mainMenu_ToolStripMenuItem_OpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mainMenu_ToolStripMenuItem_OpenProject.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_OpenProject.Text = "Ouvrir Projet";
            this.mainMenu_ToolStripMenuItem_OpenProject.ToolTipText = "Ouvrir un projet existant";
            this.mainMenu_ToolStripMenuItem_OpenProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_OpenProject_Click);
            // 
            // mainMenu_ToolStripMenuItem_OpenRecentProject
            // 
            this.mainMenu_ToolStripMenuItem_OpenRecentProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_AutoOpenProject,
            toolStripSeparator21});
            this.mainMenu_ToolStripMenuItem_OpenRecentProject.Image = global::Gemini.Properties.Resources.History;
            this.mainMenu_ToolStripMenuItem_OpenRecentProject.Name = "mainMenu_ToolStripMenuItem_OpenRecentProject";
            this.mainMenu_ToolStripMenuItem_OpenRecentProject.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_OpenRecentProject.Text = "Ouvrir Récent...";
            // 
            // mainMenu_ToolStripMenuItem_AutoOpenProject
            // 
            this.mainMenu_ToolStripMenuItem_AutoOpenProject.Name = "mainMenu_ToolStripMenuItem_AutoOpenProject";
            this.mainMenu_ToolStripMenuItem_AutoOpenProject.Size = new System.Drawing.Size(256, 22);
            this.mainMenu_ToolStripMenuItem_AutoOpenProject.Text = "Ouvrir le plus récent au démarrage";
            this.mainMenu_ToolStripMenuItem_AutoOpenProject.ToolTipText = "Toggle auto loading of the last project";
            this.mainMenu_ToolStripMenuItem_AutoOpenProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoOpenProject_Click);
            // 
            // mainMenu_ToolStripMenuItem_SaveProject
            // 
            this.mainMenu_ToolStripMenuItem_SaveProject.Image = global::Gemini.Properties.Resources.Save;
            this.mainMenu_ToolStripMenuItem_SaveProject.Name = "mainMenu_ToolStripMenuItem_SaveProject";
            this.mainMenu_ToolStripMenuItem_SaveProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mainMenu_ToolStripMenuItem_SaveProject.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_SaveProject.Text = "Sauvegarder";
            this.mainMenu_ToolStripMenuItem_SaveProject.ToolTipText = "Sauvegarde le projet";
            this.mainMenu_ToolStripMenuItem_SaveProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_SaveProject_Click);
            // 
            // mainMenu_ToolStripMenuItem_CloseProject
            // 
            this.mainMenu_ToolStripMenuItem_CloseProject.Image = global::Gemini.Properties.Resources.CloseProject;
            this.mainMenu_ToolStripMenuItem_CloseProject.Name = "mainMenu_ToolStripMenuItem_CloseProject";
            this.mainMenu_ToolStripMenuItem_CloseProject.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_CloseProject.Text = "Fermer";
            this.mainMenu_ToolStripMenuItem_CloseProject.ToolTipText = "Ferme le projet";
            this.mainMenu_ToolStripMenuItem_CloseProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_CloseProject_Click);
            // 
            // mainMenu_ToolStripMenuItem_ImportScripts
            // 
            this.mainMenu_ToolStripMenuItem_ImportScripts.Image = global::Gemini.Properties.Resources.folder_up;
            this.mainMenu_ToolStripMenuItem_ImportScripts.Name = "mainMenu_ToolStripMenuItem_ImportScripts";
            this.mainMenu_ToolStripMenuItem_ImportScripts.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_ImportScripts.Text = "Importer Scripts";
            this.mainMenu_ToolStripMenuItem_ImportScripts.ToolTipText = "Importer des scripts";
            this.mainMenu_ToolStripMenuItem_ImportScripts.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ImportScripts_Click);
            // 
            // mainMenu_ToolStripMenuItem_ExportScripts
            // 
            this.mainMenu_ToolStripMenuItem_ExportScripts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData,
            this.mainMenu_ToolStripMenuItem_ExportScriptsText,
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby});
            this.mainMenu_ToolStripMenuItem_ExportScripts.Image = global::Gemini.Properties.Resources.folder_export;
            this.mainMenu_ToolStripMenuItem_ExportScripts.Name = "mainMenu_ToolStripMenuItem_ExportScripts";
            this.mainMenu_ToolStripMenuItem_ExportScripts.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_ExportScripts.Text = "Exporter Scripts...";
            this.mainMenu_ToolStripMenuItem_ExportScripts.ToolTipText = "Exporter des scripts";
            // 
            // mainMenu_ToolStripMenuItem_ExportScriptsRMData
            // 
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData.Name = "mainMenu_ToolStripMenuItem_ExportScriptsRMData";
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData.Size = new System.Drawing.Size(160, 22);
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData.Text = "RM Data File";
            this.mainMenu_ToolStripMenuItem_ExportScriptsRMData.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ExportScriptsRMData_Click);
            // 
            // mainMenu_ToolStripMenuItem_ExportScriptsText
            // 
            this.mainMenu_ToolStripMenuItem_ExportScriptsText.Image = global::Gemini.Properties.Resources.text_icon;
            this.mainMenu_ToolStripMenuItem_ExportScriptsText.Name = "mainMenu_ToolStripMenuItem_ExportScriptsText";
            this.mainMenu_ToolStripMenuItem_ExportScriptsText.Size = new System.Drawing.Size(160, 22);
            this.mainMenu_ToolStripMenuItem_ExportScriptsText.Text = "Documents Text";
            this.mainMenu_ToolStripMenuItem_ExportScriptsText.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ExportScriptsText_Click);
            // 
            // mainMenu_ToolStripMenuItem_ExportScriptsRuby
            // 
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby.Image = global::Gemini.Properties.Resources.ruby_icon;
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby.Name = "mainMenu_ToolStripMenuItem_ExportScriptsRuby";
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby.Size = new System.Drawing.Size(160, 22);
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby.Text = "Ruby Scripts";
            this.mainMenu_ToolStripMenuItem_ExportScriptsRuby.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ExportScriptsRuby_Click);
            // 
            // mainMenu_ToolStripMenuItem_SaveSettings
            // 
            this.mainMenu_ToolStripMenuItem_SaveSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings});
            this.mainMenu_ToolStripMenuItem_SaveSettings.Image = global::Gemini.Properties.Resources.Save;
            this.mainMenu_ToolStripMenuItem_SaveSettings.Name = "mainMenu_ToolStripMenuItem_SaveSettings";
            this.mainMenu_ToolStripMenuItem_SaveSettings.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_SaveSettings.Text = "Sauvegarder Paramètres";
            this.mainMenu_ToolStripMenuItem_SaveSettings.ToolTipText = "Sauvegarder les paramètres";
            this.mainMenu_ToolStripMenuItem_SaveSettings.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_SaveSettings_Click);
            // 
            // mainMenu_ToolStripMenuItem_AutoSaveSettings
            // 
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings.Name = "mainMenu_ToolStripMenuItem_AutoSaveSettings";
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings.Size = new System.Drawing.Size(167, 22);
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings.Text = "Auto-Save on Exit";
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings.ToolTipText = "Toggle auto-saving of settings on application closing";
            this.mainMenu_ToolStripMenuItem_AutoSaveSettings.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoSaveSettings_Click);
            // 
            // mainMenu_ToolStripMenuItem_ClearSettings
            // 
            this.mainMenu_ToolStripMenuItem_ClearSettings.Image = global::Gemini.Properties.Resources.Delete;
            this.mainMenu_ToolStripMenuItem_ClearSettings.Name = "mainMenu_ToolStripMenuItem_ClearSettings";
            this.mainMenu_ToolStripMenuItem_ClearSettings.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_ClearSettings.Text = "Supprimer Paramètres";
            this.mainMenu_ToolStripMenuItem_ClearSettings.ToolTipText = "Supprimer les paramètres";
            this.mainMenu_ToolStripMenuItem_ClearSettings.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_DeleteSettings_Click);
            // 
            // mainMenu_ToolStripMenuItem_Exit
            // 
            this.mainMenu_ToolStripMenuItem_Exit.Image = global::Gemini.Properties.Resources.exit;
            this.mainMenu_ToolStripMenuItem_Exit.Name = "mainMenu_ToolStripMenuItem_Exit";
            this.mainMenu_ToolStripMenuItem_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mainMenu_ToolStripMenuItem_Exit.Size = new System.Drawing.Size(201, 22);
            this.mainMenu_ToolStripMenuItem_Exit.Text = "Quitter";
            this.mainMenu_ToolStripMenuItem_Exit.ToolTipText = "Quitter Gemini";
            this.mainMenu_ToolStripMenuItem_Exit.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Exit_Click);
            // 
            // mainMenu_ToolStripMenuItem_Edit
            // 
            this.mainMenu_ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_Undo,
            this.mainMenu_ToolStripMenuItem_Redo,
            toolStripSeparator16,
            this.mainMenu_ToolStripMenuItem_Cut,
            this.mainMenu_ToolStripMenuItem_Copy,
            this.mainMenu_ToolStripMenuItem_Paste,
            this.mainMenu_ToolStripMenuItem_Delete,
            this.mainMenu_ToolStripMenuItem_SelectAll,
            toolStripSeparator17,
            this.mainMenu_ToolStripMenuItem_BatchSearch,
            this.mainMenu_ToolStripMenuItem_IncrementalSearch,
            this.mainMenu_ToolStripMenuItem_Find,
            this.mainMenu_ToolStripMenuItem_Replace,
            this.mainMenu_ToolStripMenuItem_GoToLine,
            toolStripSeparator18,
            this.mainMenu_ToolStripMenuItem_BatchComment,
            this.mainMenu_ToolStripMenuItem_StructureScript,
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines});
            this.mainMenu_ToolStripMenuItem_Edit.Name = "mainMenu_ToolStripMenuItem_Edit";
            this.mainMenu_ToolStripMenuItem_Edit.Size = new System.Drawing.Size(49, 20);
            this.mainMenu_ToolStripMenuItem_Edit.Text = "Editer";
            this.mainMenu_ToolStripMenuItem_Edit.DropDownOpening += new System.EventHandler(this.mainMenu_ToolStripMenuItem_DropDownOpening);
            // 
            // mainMenu_ToolStripMenuItem_Undo
            // 
            this.mainMenu_ToolStripMenuItem_Undo.Image = global::Gemini.Properties.Resources.undo;
            this.mainMenu_ToolStripMenuItem_Undo.Name = "mainMenu_ToolStripMenuItem_Undo";
            this.mainMenu_ToolStripMenuItem_Undo.ShortcutKeyDisplayString = "Ctrl + Z";
            this.mainMenu_ToolStripMenuItem_Undo.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Undo.Text = "Précédant";
            this.mainMenu_ToolStripMenuItem_Undo.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Undo_Click);
            // 
            // mainMenu_ToolStripMenuItem_Redo
            // 
            this.mainMenu_ToolStripMenuItem_Redo.Image = global::Gemini.Properties.Resources.redo;
            this.mainMenu_ToolStripMenuItem_Redo.Name = "mainMenu_ToolStripMenuItem_Redo";
            this.mainMenu_ToolStripMenuItem_Redo.ShortcutKeyDisplayString = "Ctrl + Y";
            this.mainMenu_ToolStripMenuItem_Redo.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Redo.Text = "Suivant";
            this.mainMenu_ToolStripMenuItem_Redo.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Redo_Click);
            // 
            // mainMenu_ToolStripMenuItem_Cut
            // 
            this.mainMenu_ToolStripMenuItem_Cut.Image = global::Gemini.Properties.Resources.cut;
            this.mainMenu_ToolStripMenuItem_Cut.Name = "mainMenu_ToolStripMenuItem_Cut";
            this.mainMenu_ToolStripMenuItem_Cut.ShortcutKeyDisplayString = "Ctrl + X";
            this.mainMenu_ToolStripMenuItem_Cut.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Cut.Text = "Couper";
            this.mainMenu_ToolStripMenuItem_Cut.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Cut_Click);
            // 
            // mainMenu_ToolStripMenuItem_Copy
            // 
            this.mainMenu_ToolStripMenuItem_Copy.Image = global::Gemini.Properties.Resources.copy;
            this.mainMenu_ToolStripMenuItem_Copy.Name = "mainMenu_ToolStripMenuItem_Copy";
            this.mainMenu_ToolStripMenuItem_Copy.ShortcutKeyDisplayString = "Ctrl + C";
            this.mainMenu_ToolStripMenuItem_Copy.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Copy.Text = "Copier";
            this.mainMenu_ToolStripMenuItem_Copy.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Copy_Click);
            // 
            // mainMenu_ToolStripMenuItem_Paste
            // 
            this.mainMenu_ToolStripMenuItem_Paste.Image = global::Gemini.Properties.Resources.paste;
            this.mainMenu_ToolStripMenuItem_Paste.Name = "mainMenu_ToolStripMenuItem_Paste";
            this.mainMenu_ToolStripMenuItem_Paste.ShortcutKeyDisplayString = "Ctrl + V";
            this.mainMenu_ToolStripMenuItem_Paste.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Paste.Text = "Coller";
            this.mainMenu_ToolStripMenuItem_Paste.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Paste_Click);
            // 
            // mainMenu_ToolStripMenuItem_Delete
            // 
            this.mainMenu_ToolStripMenuItem_Delete.Image = global::Gemini.Properties.Resources.delete2;
            this.mainMenu_ToolStripMenuItem_Delete.Name = "mainMenu_ToolStripMenuItem_Delete";
            this.mainMenu_ToolStripMenuItem_Delete.ShortcutKeyDisplayString = "Suppr";
            this.mainMenu_ToolStripMenuItem_Delete.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Delete.Text = "Supprimer";
            this.mainMenu_ToolStripMenuItem_Delete.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Delete_Click);
            // 
            // mainMenu_ToolStripMenuItem_SelectAll
            // 
            this.mainMenu_ToolStripMenuItem_SelectAll.Image = global::Gemini.Properties.Resources.select_all;
            this.mainMenu_ToolStripMenuItem_SelectAll.Name = "mainMenu_ToolStripMenuItem_SelectAll";
            this.mainMenu_ToolStripMenuItem_SelectAll.ShortcutKeyDisplayString = "Ctrl + A";
            this.mainMenu_ToolStripMenuItem_SelectAll.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_SelectAll.Text = "Tous séléctionné";
            this.mainMenu_ToolStripMenuItem_SelectAll.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_SelectAll_Click);
            // 
            // mainMenu_ToolStripMenuItem_BatchSearch
            // 
            this.mainMenu_ToolStripMenuItem_BatchSearch.Image = global::Gemini.Properties.Resources.find3;
            this.mainMenu_ToolStripMenuItem_BatchSearch.Name = "mainMenu_ToolStripMenuItem_BatchSearch";
            this.mainMenu_ToolStripMenuItem_BatchSearch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.mainMenu_ToolStripMenuItem_BatchSearch.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_BatchSearch.Text = "Recherche Batch";
            this.mainMenu_ToolStripMenuItem_BatchSearch.Visible = false;
            this.mainMenu_ToolStripMenuItem_BatchSearch.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_BatchSearch_Click);
            // 
            // mainMenu_ToolStripMenuItem_IncrementalSearch
            // 
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.Image = global::Gemini.Properties.Resources.find2;
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.Name = "mainMenu_ToolStripMenuItem_IncrementalSearch";
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.ShortcutKeyDisplayString = "Ctrl + I";
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.Text = "Recherche incrémentielle";
            this.mainMenu_ToolStripMenuItem_IncrementalSearch.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_IncrementalSearch_Click);
            // 
            // mainMenu_ToolStripMenuItem_Find
            // 
            this.mainMenu_ToolStripMenuItem_Find.Image = global::Gemini.Properties.Resources.find;
            this.mainMenu_ToolStripMenuItem_Find.Name = "mainMenu_ToolStripMenuItem_Find";
            this.mainMenu_ToolStripMenuItem_Find.ShortcutKeyDisplayString = "Ctrl + F";
            this.mainMenu_ToolStripMenuItem_Find.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Find.Text = "Trouver";
            this.mainMenu_ToolStripMenuItem_Find.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Find_Click);
            // 
            // mainMenu_ToolStripMenuItem_Replace
            // 
            this.mainMenu_ToolStripMenuItem_Replace.Image = global::Gemini.Properties.Resources.replace;
            this.mainMenu_ToolStripMenuItem_Replace.Name = "mainMenu_ToolStripMenuItem_Replace";
            this.mainMenu_ToolStripMenuItem_Replace.ShortcutKeyDisplayString = "Ctrl + H";
            this.mainMenu_ToolStripMenuItem_Replace.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_Replace.Text = "Remplacer";
            this.mainMenu_ToolStripMenuItem_Replace.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Replace_Click);
            // 
            // mainMenu_ToolStripMenuItem_GoToLine
            // 
            this.mainMenu_ToolStripMenuItem_GoToLine.Image = global::Gemini.Properties.Resources.go_to;
            this.mainMenu_ToolStripMenuItem_GoToLine.Name = "mainMenu_ToolStripMenuItem_GoToLine";
            this.mainMenu_ToolStripMenuItem_GoToLine.ShortcutKeyDisplayString = "Ctrl + G";
            this.mainMenu_ToolStripMenuItem_GoToLine.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_GoToLine.Text = "Aller à la ligne";
            this.mainMenu_ToolStripMenuItem_GoToLine.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_GoToLine_Click);
            // 
            // mainMenu_ToolStripMenuItem_BatchComment
            // 
            this.mainMenu_ToolStripMenuItem_BatchComment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_ToggleComment,
            this.mainMenu_ToolStripMenuItem_Comment,
            this.mainMenu_ToolStripMenuItem_UnComment});
            this.mainMenu_ToolStripMenuItem_BatchComment.Image = global::Gemini.Properties.Resources.comment;
            this.mainMenu_ToolStripMenuItem_BatchComment.Name = "mainMenu_ToolStripMenuItem_BatchComment";
            this.mainMenu_ToolStripMenuItem_BatchComment.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_BatchComment.Text = "Batch Sélection de Commentaire";
            this.mainMenu_ToolStripMenuItem_BatchComment.ToolTipText = "Comment selected lines";
            // 
            // mainMenu_ToolStripMenuItem_ToggleComment
            // 
            this.mainMenu_ToolStripMenuItem_ToggleComment.Name = "mainMenu_ToolStripMenuItem_ToggleComment";
            this.mainMenu_ToolStripMenuItem_ToggleComment.ShortcutKeyDisplayString = "Ctrl + Q";
            this.mainMenu_ToolStripMenuItem_ToggleComment.Size = new System.Drawing.Size(165, 22);
            this.mainMenu_ToolStripMenuItem_ToggleComment.Text = "Aller à...";
            this.mainMenu_ToolStripMenuItem_ToggleComment.ToolTipText = "Toggle comment on selected lines";
            this.mainMenu_ToolStripMenuItem_ToggleComment.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ToggleComment_Click);
            // 
            // mainMenu_ToolStripMenuItem_Comment
            // 
            this.mainMenu_ToolStripMenuItem_Comment.Name = "mainMenu_ToolStripMenuItem_Comment";
            this.mainMenu_ToolStripMenuItem_Comment.Size = new System.Drawing.Size(165, 22);
            this.mainMenu_ToolStripMenuItem_Comment.Text = "Comment";
            this.mainMenu_ToolStripMenuItem_Comment.ToolTipText = "Add comment on selected lines";
            this.mainMenu_ToolStripMenuItem_Comment.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Comment_Click);
            // 
            // mainMenu_ToolStripMenuItem_UnComment
            // 
            this.mainMenu_ToolStripMenuItem_UnComment.Name = "mainMenu_ToolStripMenuItem_UnComment";
            this.mainMenu_ToolStripMenuItem_UnComment.Size = new System.Drawing.Size(165, 22);
            this.mainMenu_ToolStripMenuItem_UnComment.Text = "Uncomment";
            this.mainMenu_ToolStripMenuItem_UnComment.ToolTipText = "Remove comment on selected lines";
            this.mainMenu_ToolStripMenuItem_UnComment.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_UnComment_Click);
            // 
            // mainMenu_ToolStripMenuItem_StructureScript
            // 
            this.mainMenu_ToolStripMenuItem_StructureScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent,
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen,
            this.mainMenu_ToolStripMenuItem_StructureScriptAll});
            this.mainMenu_ToolStripMenuItem_StructureScript.Image = global::Gemini.Properties.Resources.outline;
            this.mainMenu_ToolStripMenuItem_StructureScript.Name = "mainMenu_ToolStripMenuItem_StructureScript";
            this.mainMenu_ToolStripMenuItem_StructureScript.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_StructureScript.Text = "Structure Script";
            this.mainMenu_ToolStripMenuItem_StructureScript.ToolTipText = "Appliquer structure propre à l\'écriture";
            // 
            // mainMenu_ToolStripMenuItem_StructureScriptCurrent
            // 
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent.Name = "mainMenu_ToolStripMenuItem_StructureScriptCurrent";
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent.Text = "Actuel";
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent.ToolTipText = "Script Actuel";
            this.mainMenu_ToolStripMenuItem_StructureScriptCurrent.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StructureScriptCurrent_Click);
            // 
            // mainMenu_ToolStripMenuItem_StructureScriptOpen
            // 
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen.Name = "mainMenu_ToolStripMenuItem_StructureScriptOpen";
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen.Text = "Ouvrir";
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen.ToolTipText = "Tous les scripts ouvert";
            this.mainMenu_ToolStripMenuItem_StructureScriptOpen.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StructureScriptOpen_Click);
            // 
            // mainMenu_ToolStripMenuItem_StructureScriptAll
            // 
            this.mainMenu_ToolStripMenuItem_StructureScriptAll.Name = "mainMenu_ToolStripMenuItem_StructureScriptAll";
            this.mainMenu_ToolStripMenuItem_StructureScriptAll.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_StructureScriptAll.Text = "Tous";
            this.mainMenu_ToolStripMenuItem_StructureScriptAll.ToolTipText = "Tous les scripts";
            this.mainMenu_ToolStripMenuItem_StructureScriptAll.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StructureScriptAll_Click);
            // 
            // mainMenu_ToolStripMenuItem_RemoveEmptyLines
            // 
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent,
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen,
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll});
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.Image = global::Gemini.Properties.Resources.emptyspace;
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.Name = "mainMenu_ToolStripMenuItem_RemoveEmptyLines";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.Size = new System.Drawing.Size(250, 22);
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.Text = "Supprimer Ligne Vide";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLines.ToolTipText = "Supprimer Ligne Vide";
            // 
            // mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent
            // 
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Name = "mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Text = "Actuel";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.ToolTipText = "Script Actuel";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent_Click);
            // 
            // mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen
            // 
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.Name = "mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.Text = "Ouvrir";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.ToolTipText = "Tous les scripts ouverts";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen_Click);
            // 
            // mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll
            // 
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.Name = "mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.Size = new System.Drawing.Size(108, 22);
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.Text = "Tous";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.ToolTipText = "Tous les scripts ouvert";
            this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll_Click);
            // 
            // mainMenu_ToolStripMenuItem_Settings
            // 
            this.mainMenu_ToolStripMenuItem_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_StylesConfig,
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig,
            toolStripSeparator7,
            this.mainMenu_ToolStripMenuItem_AutoComplete,
            this.mainMenu_ToolStripMenuItem_AutoIndent,
            this.mainMenu_ToolStripMenuItem_IndentGuides,
            this.mainMenu_ToolStripMenuItem_CodeFolding,
            this.mainMenu_ToolStripMenuItem_LineHighlight});
            this.mainMenu_ToolStripMenuItem_Settings.Name = "mainMenu_ToolStripMenuItem_Settings";
            this.mainMenu_ToolStripMenuItem_Settings.Size = new System.Drawing.Size(78, 20);
            this.mainMenu_ToolStripMenuItem_Settings.Text = "Paramètres";
            // 
            // mainMenu_ToolStripMenuItem_StylesConfig
            // 
            this.mainMenu_ToolStripMenuItem_StylesConfig.Image = global::Gemini.Properties.Resources.theme;
            this.mainMenu_ToolStripMenuItem_StylesConfig.Name = "mainMenu_ToolStripMenuItem_StylesConfig";
            this.mainMenu_ToolStripMenuItem_StylesConfig.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_StylesConfig.Text = "Styles Configuration";
            this.mainMenu_ToolStripMenuItem_StylesConfig.ToolTipText = "Modifier les styles de l\'éditeur";
            this.mainMenu_ToolStripMenuItem_StylesConfig.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StylesConfig_Click);
            // 
            // mainMenu_ToolStripMenuItem_AutoCompleteConfig
            // 
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.Image = global::Gemini.Properties.Resources.tool;
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.Name = "mainMenu_ToolStripMenuItem_AutoCompleteConfig";
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.Text = "Paramètres de saisie semi-automatique";
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.ToolTipText = "Configurer la saisie semi-automatique";
            this.mainMenu_ToolStripMenuItem_AutoCompleteConfig.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoCompleteConfig_Click);
            // 
            // mainMenu_ToolStripMenuItem_AutoComplete
            // 
            this.mainMenu_ToolStripMenuItem_AutoComplete.Image = global::Gemini.Properties.Resources.text_complete;
            this.mainMenu_ToolStripMenuItem_AutoComplete.Name = "mainMenu_ToolStripMenuItem_AutoComplete";
            this.mainMenu_ToolStripMenuItem_AutoComplete.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_AutoComplete.Text = "Auto-Complete";
            this.mainMenu_ToolStripMenuItem_AutoComplete.ToolTipText = "Configurer Auto-Complete";
            this.mainMenu_ToolStripMenuItem_AutoComplete.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoComplete_Click);
            // 
            // mainMenu_ToolStripMenuItem_AutoIndent
            // 
            this.mainMenu_ToolStripMenuItem_AutoIndent.Image = global::Gemini.Properties.Resources.indent;
            this.mainMenu_ToolStripMenuItem_AutoIndent.Name = "mainMenu_ToolStripMenuItem_AutoIndent";
            this.mainMenu_ToolStripMenuItem_AutoIndent.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_AutoIndent.Text = "Auto-Indentation";
            this.mainMenu_ToolStripMenuItem_AutoIndent.ToolTipText = "Configurer Auto-Indentation";
            this.mainMenu_ToolStripMenuItem_AutoIndent.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoIndent_Click);
            // 
            // mainMenu_ToolStripMenuItem_IndentGuides
            // 
            this.mainMenu_ToolStripMenuItem_IndentGuides.Image = global::Gemini.Properties.Resources.ruler;
            this.mainMenu_ToolStripMenuItem_IndentGuides.Name = "mainMenu_ToolStripMenuItem_IndentGuides";
            this.mainMenu_ToolStripMenuItem_IndentGuides.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_IndentGuides.Text = "Indent Guides";
            this.mainMenu_ToolStripMenuItem_IndentGuides.ToolTipText = "Configuration tiret";
            this.mainMenu_ToolStripMenuItem_IndentGuides.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_IndentGuides_Click);
            // 
            // mainMenu_ToolStripMenuItem_CodeFolding
            // 
            this.mainMenu_ToolStripMenuItem_CodeFolding.Image = global::Gemini.Properties.Resources.fold;
            this.mainMenu_ToolStripMenuItem_CodeFolding.Name = "mainMenu_ToolStripMenuItem_CodeFolding";
            this.mainMenu_ToolStripMenuItem_CodeFolding.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_CodeFolding.Text = "Code Folding";
            this.mainMenu_ToolStripMenuItem_CodeFolding.ToolTipText = "Configuration Developper Code";
            this.mainMenu_ToolStripMenuItem_CodeFolding.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_CodeFolding_Click);
            // 
            // mainMenu_ToolStripMenuItem_LineHighlight
            // 
            this.mainMenu_ToolStripMenuItem_LineHighlight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_HighlightColor});
            this.mainMenu_ToolStripMenuItem_LineHighlight.Image = global::Gemini.Properties.Resources.highlight;
            this.mainMenu_ToolStripMenuItem_LineHighlight.Name = "mainMenu_ToolStripMenuItem_LineHighlight";
            this.mainMenu_ToolStripMenuItem_LineHighlight.Size = new System.Drawing.Size(281, 22);
            this.mainMenu_ToolStripMenuItem_LineHighlight.Text = "Surligneur";
            this.mainMenu_ToolStripMenuItem_LineHighlight.ToolTipText = "Configurer Surligneur";
            this.mainMenu_ToolStripMenuItem_LineHighlight.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_LineHighlight_Click);
            // 
            // mainMenu_ToolStripMenuItem_HighlightColor
            // 
            this.mainMenu_ToolStripMenuItem_HighlightColor.Image = global::Gemini.Properties.Resources.Color_wheel;
            this.mainMenu_ToolStripMenuItem_HighlightColor.Name = "mainMenu_ToolStripMenuItem_HighlightColor";
            this.mainMenu_ToolStripMenuItem_HighlightColor.Size = new System.Drawing.Size(184, 22);
            this.mainMenu_ToolStripMenuItem_HighlightColor.Text = "Sélectionner Couleur";
            this.mainMenu_ToolStripMenuItem_HighlightColor.ToolTipText = "Changer la couleur";
            this.mainMenu_ToolStripMenuItem_HighlightColor.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_HighlightColor_Click);
            // 
            // mainMenu_ToolStripMenuItem_Game
            // 
            this.mainMenu_ToolStripMenuItem_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_Help,
            this.mainMenu_ToolStripMenuItem_Run,
            this.mainMenu_ToolStripMenuItem_RunF12,
            this.mainMenu_ToolStripMenuItem_Debug,
            this.mainMenu_ToolStripMenuItem_ProjectFolder});
            this.mainMenu_ToolStripMenuItem_Game.Name = "mainMenu_ToolStripMenuItem_Game";
            this.mainMenu_ToolStripMenuItem_Game.Size = new System.Drawing.Size(36, 20);
            this.mainMenu_ToolStripMenuItem_Game.Text = "Jeu";
            // 
            // mainMenu_ToolStripMenuItem_Help
            // 
            this.mainMenu_ToolStripMenuItem_Help.Image = global::Gemini.Properties.Resources.Help;
            this.mainMenu_ToolStripMenuItem_Help.Name = "mainMenu_ToolStripMenuItem_Help";
            this.mainMenu_ToolStripMenuItem_Help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mainMenu_ToolStripMenuItem_Help.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_Help.Text = "Aide";
            this.mainMenu_ToolStripMenuItem_Help.ToolTipText = "Ouvrir l\'aide";
            this.mainMenu_ToolStripMenuItem_Help.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Help_Click);
            // 
            // mainMenu_ToolStripMenuItem_Run
            // 
            this.mainMenu_ToolStripMenuItem_Run.Image = global::Gemini.Properties.Resources.play;
            this.mainMenu_ToolStripMenuItem_Run.Name = "mainMenu_ToolStripMenuItem_Run";
            this.mainMenu_ToolStripMenuItem_Run.ShortcutKeyDisplayString = "F5 | F12";
            this.mainMenu_ToolStripMenuItem_Run.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mainMenu_ToolStripMenuItem_Run.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_Run.Text = "Lancer";
            this.mainMenu_ToolStripMenuItem_Run.ToolTipText = "Lancer le jeu";
            this.mainMenu_ToolStripMenuItem_Run.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Run_Click);
            // 
            // mainMenu_ToolStripMenuItem_RunF12
            // 
            this.mainMenu_ToolStripMenuItem_RunF12.Image = global::Gemini.Properties.Resources.play;
            this.mainMenu_ToolStripMenuItem_RunF12.Name = "mainMenu_ToolStripMenuItem_RunF12";
            this.mainMenu_ToolStripMenuItem_RunF12.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mainMenu_ToolStripMenuItem_RunF12.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_RunF12.Text = "Lancer avec F12";
            this.mainMenu_ToolStripMenuItem_RunF12.ToolTipText = "Lancer le jeu";
            this.mainMenu_ToolStripMenuItem_RunF12.Visible = false;
            this.mainMenu_ToolStripMenuItem_RunF12.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Run_Click);
            // 
            // mainMenu_ToolStripMenuItem_Debug
            // 
            this.mainMenu_ToolStripMenuItem_Debug.Image = global::Gemini.Properties.Resources.Debug;
            this.mainMenu_ToolStripMenuItem_Debug.Name = "mainMenu_ToolStripMenuItem_Debug";
            this.mainMenu_ToolStripMenuItem_Debug.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_Debug.Text = "Mode Debug";
            this.mainMenu_ToolStripMenuItem_Debug.ToolTipText = "Mode Debug";
            this.mainMenu_ToolStripMenuItem_Debug.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Debug_Click);
            // 
            // mainMenu_ToolStripMenuItem_ProjectFolder
            // 
            this.mainMenu_ToolStripMenuItem_ProjectFolder.Image = global::Gemini.Properties.Resources.Folder_Open;
            this.mainMenu_ToolStripMenuItem_ProjectFolder.Name = "mainMenu_ToolStripMenuItem_ProjectFolder";
            this.mainMenu_ToolStripMenuItem_ProjectFolder.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_ProjectFolder.Text = "Dossier du projet";
            this.mainMenu_ToolStripMenuItem_ProjectFolder.ToolTipText = "Ouvrir dossier projet";
            this.mainMenu_ToolStripMenuItem_ProjectFolder.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ProjectFolder_Click);
            // 
            // mainMenu_ToolStripMenuItem_About
            // 
            this.mainMenu_ToolStripMenuItem_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_CheckForUpdates,
            this.mainMenu_ToolStripMenuItem_VersionHistory,
            toolStripSeparator19,
            this.mainMenu_ToolStripMenuItem_AboutGemini});
            this.mainMenu_ToolStripMenuItem_About.Name = "mainMenu_ToolStripMenuItem_About";
            this.mainMenu_ToolStripMenuItem_About.Size = new System.Drawing.Size(67, 20);
            this.mainMenu_ToolStripMenuItem_About.Text = "A propos";
            // 
            // mainMenu_ToolStripMenuItem_CheckForUpdates
            // 
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates});
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.Image = global::Gemini.Properties.Resources.update;
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.Name = "mainMenu_ToolStripMenuItem_CheckForUpdates";
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.Size = new System.Drawing.Size(173, 22);
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.Text = "Vérifier Mise à Jour";
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.ToolTipText = "Vérifier les mises à jour";
            this.mainMenu_ToolStripMenuItem_CheckForUpdates.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_CheckForUpdates_Click);
            // 
            // mainMenu_ToolStripMenuItem_AutoCheckUpdates
            // 
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates.Name = "mainMenu_ToolStripMenuItem_AutoCheckUpdates";
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates.Size = new System.Drawing.Size(182, 22);
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates.Text = "Auto-Check on Start";
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates.ToolTipText = "Toggle auto-check for updates on application starting";
            this.mainMenu_ToolStripMenuItem_AutoCheckUpdates.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoCheckUpdates_Click);
            // 
            // mainMenu_ToolStripMenuItem_VersionHistory
            // 
            this.mainMenu_ToolStripMenuItem_VersionHistory.Image = global::Gemini.Properties.Resources.changelog;
            this.mainMenu_ToolStripMenuItem_VersionHistory.Name = "mainMenu_ToolStripMenuItem_VersionHistory";
            this.mainMenu_ToolStripMenuItem_VersionHistory.Size = new System.Drawing.Size(173, 22);
            this.mainMenu_ToolStripMenuItem_VersionHistory.Text = "Historique Version";
            this.mainMenu_ToolStripMenuItem_VersionHistory.ToolTipText = "Voir Historique version";
            this.mainMenu_ToolStripMenuItem_VersionHistory.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_VersionHistory_Click);
            // 
            // mainMenu_ToolStripMenuItem_AboutGemini
            // 
            this.mainMenu_ToolStripMenuItem_AboutGemini.Image = global::Gemini.Properties.Resources.gemini_ico;
            this.mainMenu_ToolStripMenuItem_AboutGemini.Name = "mainMenu_ToolStripMenuItem_AboutGemini";
            this.mainMenu_ToolStripMenuItem_AboutGemini.Size = new System.Drawing.Size(173, 22);
            this.mainMenu_ToolStripMenuItem_AboutGemini.Text = "A propos...";
            this.mainMenu_ToolStripMenuItem_AboutGemini.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AboutGemini_Click);
            // 
            // scriptsList_GroupBox
            // 
            this.scriptsList_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scriptsList_GroupBox.Controls.Add(this.scriptsList_ToolStrip);
            this.scriptsList_GroupBox.Controls.Add(this.scriptsList_Label_Name);
            this.scriptsList_GroupBox.Controls.Add(this.scriptsList_TextBox_Name);
            this.scriptsList_GroupBox.Controls.Add(this.scriptsList_ListBox);
            this.scriptsList_GroupBox.Location = new System.Drawing.Point(12, 27);
            this.scriptsList_GroupBox.Name = "scriptsList_GroupBox";
            this.scriptsList_GroupBox.Size = new System.Drawing.Size(200, 522);
            this.scriptsList_GroupBox.TabIndex = 1;
            this.scriptsList_GroupBox.TabStop = false;
            this.scriptsList_GroupBox.Text = "Scripts";
            // 
            // scriptsList_ToolStrip
            // 
            this.scriptsList_ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scriptsList_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.scriptsList_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsList_ToolStripButton_ImportScripts,
            toolStripSeparator22,
            this.scriptsList_ToolStripButton_Open,
            this.scriptsList_ToolStripButton_Insert,
            this.scriptsList_ToolStripButton_Delete,
            toolStripSeparator20,
            this.scriptsList_ToolStripButton_MoveUp,
            this.scriptsList_ToolStripButton_MoveDown,
            this.scriptsList_ToolStripButton_BatchSearch});
            this.scriptsList_ToolStrip.Location = new System.Drawing.Point(3, 494);
            this.scriptsList_ToolStrip.Name = "scriptsList_ToolStrip";
            this.scriptsList_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.scriptsList_ToolStrip.Size = new System.Drawing.Size(194, 25);
            this.scriptsList_ToolStrip.TabIndex = 6;
            this.scriptsList_ToolStrip.Text = "toolStrip1";
            // 
            // scriptsList_ToolStripButton_ImportScripts
            // 
            this.scriptsList_ToolStripButton_ImportScripts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_ImportScripts.Image = global::Gemini.Properties.Resources.folder_up;
            this.scriptsList_ToolStripButton_ImportScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_ImportScripts.Name = "scriptsList_ToolStripButton_ImportScripts";
            this.scriptsList_ToolStripButton_ImportScripts.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_ImportScripts.Text = "Import Scripts";
            this.scriptsList_ToolStripButton_ImportScripts.ToolTipText = "Importer Scripts";
            this.scriptsList_ToolStripButton_ImportScripts.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ImportScripts_Click);
            // 
            // scriptsList_ToolStripButton_Open
            // 
            this.scriptsList_ToolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_Open.Image = global::Gemini.Properties.Resources.OpenFile;
            this.scriptsList_ToolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_Open.Name = "scriptsList_ToolStripButton_Open";
            this.scriptsList_ToolStripButton_Open.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_Open.Text = "Open Script (Enter)";
            this.scriptsList_ToolStripButton_Open.ToolTipText = "Ouvrir Script (Entrée)";
            this.scriptsList_ToolStripButton_Open.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Open_Click);
            // 
            // scriptsList_ToolStripButton_Insert
            // 
            this.scriptsList_ToolStripButton_Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_Insert.Image = global::Gemini.Properties.Resources.Add;
            this.scriptsList_ToolStripButton_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_Insert.Name = "scriptsList_ToolStripButton_Insert";
            this.scriptsList_ToolStripButton_Insert.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_Insert.Text = "Insert New Script (Ins)";
            this.scriptsList_ToolStripButton_Insert.ToolTipText = "Nouveau Script (Ins)";
            this.scriptsList_ToolStripButton_Insert.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Insert_Click);
            // 
            // scriptsList_ToolStripButton_Delete
            // 
            this.scriptsList_ToolStripButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_Delete.Image = global::Gemini.Properties.Resources.Delete;
            this.scriptsList_ToolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_Delete.Name = "scriptsList_ToolStripButton_Delete";
            this.scriptsList_ToolStripButton_Delete.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_Delete.Text = "Delete Script (Suppr)";
            this.scriptsList_ToolStripButton_Delete.ToolTipText = "Supprimer Script (Suppr)";
            this.scriptsList_ToolStripButton_Delete.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Delete_Click);
            // 
            // scriptsList_ToolStripButton_MoveUp
            // 
            this.scriptsList_ToolStripButton_MoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_MoveUp.Image = global::Gemini.Properties.Resources.up;
            this.scriptsList_ToolStripButton_MoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_MoveUp.Name = "scriptsList_ToolStripButton_MoveUp";
            this.scriptsList_ToolStripButton_MoveUp.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_MoveUp.Text = "Move Script Up (Ctrl+Up)";
            this.scriptsList_ToolStripButton_MoveUp.ToolTipText = "Deplacer vers le haut";
            this.scriptsList_ToolStripButton_MoveUp.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_MoveUp_Click);
            // 
            // scriptsList_ToolStripButton_MoveDown
            // 
            this.scriptsList_ToolStripButton_MoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_MoveDown.Image = global::Gemini.Properties.Resources.down;
            this.scriptsList_ToolStripButton_MoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_MoveDown.Name = "scriptsList_ToolStripButton_MoveDown";
            this.scriptsList_ToolStripButton_MoveDown.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_MoveDown.Text = "Move Script Down (Ctrl+Down)";
            this.scriptsList_ToolStripButton_MoveDown.ToolTipText = "Deplacer vers le bas";
            this.scriptsList_ToolStripButton_MoveDown.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_MoveDown_Click);
            // 
            // scriptsList_ToolStripButton_BatchSearch
            // 
            this.scriptsList_ToolStripButton_BatchSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.scriptsList_ToolStripButton_BatchSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsList_ToolStripButton_BatchSearch.Image = global::Gemini.Properties.Resources.find3;
            this.scriptsList_ToolStripButton_BatchSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsList_ToolStripButton_BatchSearch.Name = "scriptsList_ToolStripButton_BatchSearch";
            this.scriptsList_ToolStripButton_BatchSearch.Size = new System.Drawing.Size(23, 22);
            this.scriptsList_ToolStripButton_BatchSearch.Text = "New Search (Ctrl+Maj+F)";
            this.scriptsList_ToolStripButton_BatchSearch.ToolTipText = "Nouvelle Recherche (Ctrl+Maj+F)";
            this.scriptsList_ToolStripButton_BatchSearch.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_BatchSearch_Click);
            // 
            // scriptsList_Label_Name
            // 
            this.scriptsList_Label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scriptsList_Label_Name.AutoSize = true;
            this.scriptsList_Label_Name.Location = new System.Drawing.Point(6, 470);
            this.scriptsList_Label_Name.Name = "scriptsList_Label_Name";
            this.scriptsList_Label_Name.Size = new System.Drawing.Size(32, 13);
            this.scriptsList_Label_Name.TabIndex = 5;
            this.scriptsList_Label_Name.Text = "Nom:";
            // 
            // scriptsList_TextBox_Name
            // 
            this.scriptsList_TextBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptsList_TextBox_Name.Location = new System.Drawing.Point(44, 467);
            this.scriptsList_TextBox_Name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.scriptsList_TextBox_Name.Name = "scriptsList_TextBox_Name";
            this.scriptsList_TextBox_Name.Size = new System.Drawing.Size(150, 20);
            this.scriptsList_TextBox_Name.TabIndex = 1;
            this.toolTip.SetToolTip(this.scriptsList_TextBox_Name, "Editer le nom du script");
            this.scriptsList_TextBox_Name.TextChanged += new System.EventHandler(this.scriptsList_TextBox_Name_TextChanged);
            // 
            // scriptsList_ListBox
            // 
            this.scriptsList_ListBox.AllowDrop = true;
            this.scriptsList_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptsList_ListBox.ContextMenuStrip = this.scriptsList_ContextMenuStrip;
            this.scriptsList_ListBox.FormattingEnabled = true;
            this.scriptsList_ListBox.IntegralHeight = false;
            this.scriptsList_ListBox.Location = new System.Drawing.Point(6, 19);
            this.scriptsList_ListBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.scriptsList_ListBox.Name = "scriptsList_ListBox";
            this.scriptsList_ListBox.Size = new System.Drawing.Size(188, 442);
            this.scriptsList_ListBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.scriptsList_ListBox, "Double-cliquez pour ouvrir le script");
            this.scriptsList_ListBox.SelectedIndexChanged += new System.EventHandler(this.scriptsList_ListBox_SelectedIndexChanged);
            this.scriptsList_ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.scriptsList_ListBox_DragDrop);
            this.scriptsList_ListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.scriptsList_ListBox_DragOver);
            this.scriptsList_ListBox.DoubleClick += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Open_Click);
            this.scriptsList_ListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scriptsList_ListBox_KeyDown);
            this.scriptsList_ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scriptsList_ListBox_MouseDown);
            // 
            // scriptsList_ContextMenuStrip
            // 
            this.scriptsList_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsList_ToolStripMenuItem_Open,
            this.scriptsList_ToolStripMenuItem_Insert,
            this.scriptsList_ToolStripMenuItem_Cut,
            this.scriptsList_ToolStripMenuItem_Copy,
            this.scriptsList_ToolStripMenuItem_Paste,
            this.scriptsList_ToolStripMenuItem_Delete,
            toolStripSeparator1,
            this.scriptsList_ToolStripMenuItem_MoveUp,
            this.scriptsList_ToolStripMenuItem_MoveDown,
            toolStripSeparator2,
            this.scriptsList_ToolStripMenuItem_BatchSearch});
            this.scriptsList_ContextMenuStrip.Name = "scriptsList_ContextMenuStrip";
            this.scriptsList_ContextMenuStrip.Size = new System.Drawing.Size(211, 214);
            this.scriptsList_ContextMenuStrip.Opened += new System.EventHandler(this.mainMenu_ToolStripMenuItem_DropDownOpening);
            // 
            // scriptsList_ToolStripMenuItem_Open
            // 
            this.scriptsList_ToolStripMenuItem_Open.Image = global::Gemini.Properties.Resources.OpenFile;
            this.scriptsList_ToolStripMenuItem_Open.Name = "scriptsList_ToolStripMenuItem_Open";
            this.scriptsList_ToolStripMenuItem_Open.ShortcutKeyDisplayString = "Entrée";
            this.scriptsList_ToolStripMenuItem_Open.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Open.Text = "Ouvrir";
            this.scriptsList_ToolStripMenuItem_Open.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Open_Click);
            // 
            // scriptsList_ToolStripMenuItem_Insert
            // 
            this.scriptsList_ToolStripMenuItem_Insert.Image = global::Gemini.Properties.Resources.Add;
            this.scriptsList_ToolStripMenuItem_Insert.Name = "scriptsList_ToolStripMenuItem_Insert";
            this.scriptsList_ToolStripMenuItem_Insert.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.scriptsList_ToolStripMenuItem_Insert.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Insert.Text = "Insérer";
            this.scriptsList_ToolStripMenuItem_Insert.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Insert_Click);
            // 
            // scriptsList_ToolStripMenuItem_Cut
            // 
            this.scriptsList_ToolStripMenuItem_Cut.Image = global::Gemini.Properties.Resources.cut;
            this.scriptsList_ToolStripMenuItem_Cut.Name = "scriptsList_ToolStripMenuItem_Cut";
            this.scriptsList_ToolStripMenuItem_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.scriptsList_ToolStripMenuItem_Cut.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Cut.Text = "Couper";
            this.scriptsList_ToolStripMenuItem_Cut.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Cut_Click);
            // 
            // scriptsList_ToolStripMenuItem_Copy
            // 
            this.scriptsList_ToolStripMenuItem_Copy.Image = global::Gemini.Properties.Resources.copy;
            this.scriptsList_ToolStripMenuItem_Copy.Name = "scriptsList_ToolStripMenuItem_Copy";
            this.scriptsList_ToolStripMenuItem_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.scriptsList_ToolStripMenuItem_Copy.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Copy.Text = "Copier";
            this.scriptsList_ToolStripMenuItem_Copy.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Copy_Click);
            // 
            // scriptsList_ToolStripMenuItem_Paste
            // 
            this.scriptsList_ToolStripMenuItem_Paste.Image = global::Gemini.Properties.Resources.paste;
            this.scriptsList_ToolStripMenuItem_Paste.Name = "scriptsList_ToolStripMenuItem_Paste";
            this.scriptsList_ToolStripMenuItem_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.scriptsList_ToolStripMenuItem_Paste.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Paste.Text = "Coller";
            this.scriptsList_ToolStripMenuItem_Paste.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Paste_Click);
            // 
            // scriptsList_ToolStripMenuItem_Delete
            // 
            this.scriptsList_ToolStripMenuItem_Delete.Image = global::Gemini.Properties.Resources.Delete;
            this.scriptsList_ToolStripMenuItem_Delete.Name = "scriptsList_ToolStripMenuItem_Delete";
            this.scriptsList_ToolStripMenuItem_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.scriptsList_ToolStripMenuItem_Delete.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_Delete.Text = "Supprimer";
            this.scriptsList_ToolStripMenuItem_Delete.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_Delete_Click);
            // 
            // scriptsList_ToolStripMenuItem_MoveUp
            // 
            this.scriptsList_ToolStripMenuItem_MoveUp.Image = global::Gemini.Properties.Resources.up;
            this.scriptsList_ToolStripMenuItem_MoveUp.Name = "scriptsList_ToolStripMenuItem_MoveUp";
            this.scriptsList_ToolStripMenuItem_MoveUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.scriptsList_ToolStripMenuItem_MoveUp.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_MoveUp.Text = "Vers le haut";
            this.scriptsList_ToolStripMenuItem_MoveUp.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_MoveUp_Click);
            // 
            // scriptsList_ToolStripMenuItem_MoveDown
            // 
            this.scriptsList_ToolStripMenuItem_MoveDown.Image = global::Gemini.Properties.Resources.down;
            this.scriptsList_ToolStripMenuItem_MoveDown.Name = "scriptsList_ToolStripMenuItem_MoveDown";
            this.scriptsList_ToolStripMenuItem_MoveDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.scriptsList_ToolStripMenuItem_MoveDown.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_MoveDown.Text = "Vers le bas";
            this.scriptsList_ToolStripMenuItem_MoveDown.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_MoveDown_Click);
            // 
            // scriptsList_ToolStripMenuItem_BatchSearch
            // 
            this.scriptsList_ToolStripMenuItem_BatchSearch.Image = global::Gemini.Properties.Resources.find3;
            this.scriptsList_ToolStripMenuItem_BatchSearch.Name = "scriptsList_ToolStripMenuItem_BatchSearch";
            this.scriptsList_ToolStripMenuItem_BatchSearch.ShortcutKeyDisplayString = "Ctrl+Maj+F";
            this.scriptsList_ToolStripMenuItem_BatchSearch.Size = new System.Drawing.Size(210, 22);
            this.scriptsList_ToolStripMenuItem_BatchSearch.Text = "Rechercher...";
            this.scriptsList_ToolStripMenuItem_BatchSearch.Click += new System.EventHandler(this.scriptsList_ToolStripMenuItem_BatchSearch_Click);
            // 
            // scriptsEditor_GroupBox
            // 
            this.scriptsEditor_GroupBox.Controls.Add(this.scriptsEditor_TabControl);
            this.scriptsEditor_GroupBox.Controls.Add(this.scriptsEditor_StatusStrip);
            this.scriptsEditor_GroupBox.Controls.Add(this.scriptsEditor_ToolStrip);
            this.scriptsEditor_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsEditor_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.scriptsEditor_GroupBox.Name = "scriptsEditor_GroupBox";
            this.scriptsEditor_GroupBox.Size = new System.Drawing.Size(554, 312);
            this.scriptsEditor_GroupBox.TabIndex = 2;
            this.scriptsEditor_GroupBox.TabStop = false;
            this.scriptsEditor_GroupBox.Text = "Editeur";
            // 
            // scriptsEditor_TabControl
            // 
            this.scriptsEditor_TabControl.AllowDrop = true;
            this.scriptsEditor_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsEditor_TabControl.Location = new System.Drawing.Point(3, 41);
            this.scriptsEditor_TabControl.Name = "scriptsEditor_TabControl";
            this.scriptsEditor_TabControl.SelectedIndex = 0;
            this.scriptsEditor_TabControl.Size = new System.Drawing.Size(548, 246);
            this.scriptsEditor_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.scriptsEditor_TabControl.TabIndex = 0;
            this.scriptsEditor_TabControl.TabPageRemoving += new Gemini.AdvancedTabControl.TabPageRemovingEventHandler(this.scriptsEditor_TabControl_TabPageRemoving);
            this.scriptsEditor_TabControl.SelectedIndexChanged += new System.EventHandler(this.scriptsEditor_TabControl_SelectedIndexChanged);
            this.scriptsEditor_TabControl.GotFocus += new System.EventHandler(this.scriptsEditor_TabControl_GotFocus);
            // 
            // scriptsEditor_StatusStrip
            // 
            this.scriptsEditor_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsEditor_ToolStripStatusLabel_Characters,
            this.scriptsEditor_ToolStripStatusLabel_Filler,
            this.scriptsEditor_ToolStripStatusLabel_Position});
            this.scriptsEditor_StatusStrip.Location = new System.Drawing.Point(3, 287);
            this.scriptsEditor_StatusStrip.Name = "scriptsEditor_StatusStrip";
            this.scriptsEditor_StatusStrip.Size = new System.Drawing.Size(548, 22);
            this.scriptsEditor_StatusStrip.SizingGrip = false;
            this.scriptsEditor_StatusStrip.TabIndex = 2;
            this.scriptsEditor_StatusStrip.Text = "scriptsEditor_StatusStrip";
            // 
            // scriptsEditor_ToolStripStatusLabel_Characters
            // 
            this.scriptsEditor_ToolStripStatusLabel_Characters.Name = "scriptsEditor_ToolStripStatusLabel_Characters";
            this.scriptsEditor_ToolStripStatusLabel_Characters.Size = new System.Drawing.Size(0, 17);
            this.scriptsEditor_ToolStripStatusLabel_Characters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scriptsEditor_ToolStripStatusLabel_Filler
            // 
            this.scriptsEditor_ToolStripStatusLabel_Filler.Name = "scriptsEditor_ToolStripStatusLabel_Filler";
            this.scriptsEditor_ToolStripStatusLabel_Filler.Size = new System.Drawing.Size(533, 17);
            this.scriptsEditor_ToolStripStatusLabel_Filler.Spring = true;
            // 
            // scriptsEditor_ToolStripStatusLabel_Position
            // 
            this.scriptsEditor_ToolStripStatusLabel_Position.Name = "scriptsEditor_ToolStripStatusLabel_Position";
            this.scriptsEditor_ToolStripStatusLabel_Position.Size = new System.Drawing.Size(0, 17);
            this.scriptsEditor_ToolStripStatusLabel_Position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scriptsEditor_ToolStrip
            // 
            this.scriptsEditor_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.scriptsEditor_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsEditor_ToolStripButton_SaveProject,
            this.scriptsEditor_ToolStripButton_OpenProject,
            toolStripSeparator8,
            this.scriptsEditor_ToolStripButton_SpecialChars,
            this.scriptsEditor_ToolStripButton_StyleConfig,
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig,
            toolStripSeparator9,
            this.scriptsEditor_ToolStripButton_AutoComplete,
            this.scriptsEditor_ToolStripButton_AutoIndent,
            this.scriptsEditor_ToolStripButton_IndentGuides,
            this.scriptsEditor_ToolStripButton_CodeFolding,
            this.scriptsEditor_ToolStripButton_LineHighlight,
            this.scriptsEditor_ToolStripButton_HighlightColor,
            toolStripSeparator10,
            this.scriptsEditor_ToolStripButton_IncrementalSearch,
            this.scriptsEditor_ToolStripButton_Find,
            this.scriptsEditor_ToolStripButton_Replace,
            this.scriptsEditor_ToolStripButton_GoToLine,
            toolStripSeparator11,
            this.scriptsEditor_ToolStripButton_Comment,
            this.scriptsEditor_ToolStripButton_StructureScript,
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines,
            toolStripSeparator5,
            this.scriptsEditor_ToolStripButton_Run,
            this.scriptsEditor_ToolStripButton_Debug,
            this.scriptsEditor_ToolStripButton_ProjectFolder,
            this.scriptsEditor_ToolStripButton_CloseProject});
            this.scriptsEditor_ToolStrip.Location = new System.Drawing.Point(3, 16);
            this.scriptsEditor_ToolStrip.Name = "scriptsEditor_ToolStrip";
            this.scriptsEditor_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.scriptsEditor_ToolStrip.Size = new System.Drawing.Size(548, 25);
            this.scriptsEditor_ToolStrip.TabIndex = 1;
            this.scriptsEditor_ToolStrip.Text = "scriptsEditor_ToolStrip";
            // 
            // scriptsEditor_ToolStripButton_SaveProject
            // 
            this.scriptsEditor_ToolStripButton_SaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_SaveProject.Image = global::Gemini.Properties.Resources.Save;
            this.scriptsEditor_ToolStripButton_SaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_SaveProject.Name = "scriptsEditor_ToolStripButton_SaveProject";
            this.scriptsEditor_ToolStripButton_SaveProject.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_SaveProject.Text = "Enregistrer Projet (Ctrl+S)";
            this.scriptsEditor_ToolStripButton_SaveProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_SaveProject_Click);
            // 
            // scriptsEditor_ToolStripButton_OpenProject
            // 
            this.scriptsEditor_ToolStripButton_OpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_OpenProject.Image = global::Gemini.Properties.Resources.Open_file;
            this.scriptsEditor_ToolStripButton_OpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_OpenProject.Name = "scriptsEditor_ToolStripButton_OpenProject";
            this.scriptsEditor_ToolStripButton_OpenProject.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_OpenProject.Text = "Ouvrir Projet (Ctrl+O)";
            this.scriptsEditor_ToolStripButton_OpenProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_OpenProject_Click);
            // 
            // scriptsEditor_ToolStripButton_SpecialChars
            // 
            this.scriptsEditor_ToolStripButton_SpecialChars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_SpecialChars.Image = global::Gemini.Properties.Resources.charmap;
            this.scriptsEditor_ToolStripButton_SpecialChars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_SpecialChars.Name = "scriptsEditor_ToolStripButton_SpecialChars";
            this.scriptsEditor_ToolStripButton_SpecialChars.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_SpecialChars.Text = "Caractères Spéciaux";
            this.scriptsEditor_ToolStripButton_SpecialChars.Click += new System.EventHandler(this.scriptsEditor_ToolStripButton_SpecialChars_Click);
            // 
            // scriptsEditor_ToolStripButton_StyleConfig
            // 
            this.scriptsEditor_ToolStripButton_StyleConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_StyleConfig.Image = global::Gemini.Properties.Resources.theme;
            this.scriptsEditor_ToolStripButton_StyleConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_StyleConfig.Name = "scriptsEditor_ToolStripButton_StyleConfig";
            this.scriptsEditor_ToolStripButton_StyleConfig.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_StyleConfig.Text = "Style Configuration";
            this.scriptsEditor_ToolStripButton_StyleConfig.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StylesConfig_Click);
            // 
            // scriptsEditor_ToolStripButton_AutoCompleteConfig
            // 
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.Image = global::Gemini.Properties.Resources.tool;
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.Name = "scriptsEditor_ToolStripButton_AutoCompleteConfig";
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.Text = "Auto-Complete Configuration";
            this.scriptsEditor_ToolStripButton_AutoCompleteConfig.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoCompleteConfig_Click);
            // 
            // scriptsEditor_ToolStripButton_AutoComplete
            // 
            this.scriptsEditor_ToolStripButton_AutoComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_AutoComplete.Image = global::Gemini.Properties.Resources.text_complete;
            this.scriptsEditor_ToolStripButton_AutoComplete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_AutoComplete.Name = "scriptsEditor_ToolStripButton_AutoComplete";
            this.scriptsEditor_ToolStripButton_AutoComplete.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_AutoComplete.Text = "Auto-Complete";
            this.scriptsEditor_ToolStripButton_AutoComplete.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoComplete_Click);
            // 
            // scriptsEditor_ToolStripButton_AutoIndent
            // 
            this.scriptsEditor_ToolStripButton_AutoIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_AutoIndent.Image = global::Gemini.Properties.Resources.indent;
            this.scriptsEditor_ToolStripButton_AutoIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_AutoIndent.Name = "scriptsEditor_ToolStripButton_AutoIndent";
            this.scriptsEditor_ToolStripButton_AutoIndent.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_AutoIndent.Text = "Auto-Indentation";
            this.scriptsEditor_ToolStripButton_AutoIndent.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_AutoIndent_Click);
            // 
            // scriptsEditor_ToolStripButton_IndentGuides
            // 
            this.scriptsEditor_ToolStripButton_IndentGuides.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_IndentGuides.Image = global::Gemini.Properties.Resources.ruler;
            this.scriptsEditor_ToolStripButton_IndentGuides.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_IndentGuides.Name = "scriptsEditor_ToolStripButton_IndentGuides";
            this.scriptsEditor_ToolStripButton_IndentGuides.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_IndentGuides.Text = "Developper Guide";
            this.scriptsEditor_ToolStripButton_IndentGuides.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_IndentGuides_Click);
            // 
            // scriptsEditor_ToolStripButton_CodeFolding
            // 
            this.scriptsEditor_ToolStripButton_CodeFolding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_CodeFolding.Image = global::Gemini.Properties.Resources.fold;
            this.scriptsEditor_ToolStripButton_CodeFolding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_CodeFolding.Name = "scriptsEditor_ToolStripButton_CodeFolding";
            this.scriptsEditor_ToolStripButton_CodeFolding.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_CodeFolding.Text = "Developper Code";
            this.scriptsEditor_ToolStripButton_CodeFolding.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_CodeFolding_Click);
            // 
            // scriptsEditor_ToolStripButton_LineHighlight
            // 
            this.scriptsEditor_ToolStripButton_LineHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_LineHighlight.Image = global::Gemini.Properties.Resources.highlight;
            this.scriptsEditor_ToolStripButton_LineHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_LineHighlight.Name = "scriptsEditor_ToolStripButton_LineHighlight";
            this.scriptsEditor_ToolStripButton_LineHighlight.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_LineHighlight.Text = "Surligneur";
            this.scriptsEditor_ToolStripButton_LineHighlight.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_LineHighlight_Click);
            // 
            // scriptsEditor_ToolStripButton_HighlightColor
            // 
            this.scriptsEditor_ToolStripButton_HighlightColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_HighlightColor.Image = global::Gemini.Properties.Resources.Color_wheel;
            this.scriptsEditor_ToolStripButton_HighlightColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_HighlightColor.Name = "scriptsEditor_ToolStripButton_HighlightColor";
            this.scriptsEditor_ToolStripButton_HighlightColor.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_HighlightColor.Text = "Sélectionner Couleur";
            this.scriptsEditor_ToolStripButton_HighlightColor.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_HighlightColor_Click);
            // 
            // scriptsEditor_ToolStripButton_IncrementalSearch
            // 
            this.scriptsEditor_ToolStripButton_IncrementalSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_IncrementalSearch.Image = global::Gemini.Properties.Resources.find2;
            this.scriptsEditor_ToolStripButton_IncrementalSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_IncrementalSearch.Name = "scriptsEditor_ToolStripButton_IncrementalSearch";
            this.scriptsEditor_ToolStripButton_IncrementalSearch.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_IncrementalSearch.Text = "Recherche Incrémentielle (Ctrl+I)";
            this.scriptsEditor_ToolStripButton_IncrementalSearch.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_IncrementalSearch_Click);
            // 
            // scriptsEditor_ToolStripButton_Find
            // 
            this.scriptsEditor_ToolStripButton_Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_Find.Image = global::Gemini.Properties.Resources.find;
            this.scriptsEditor_ToolStripButton_Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_Find.Name = "scriptsEditor_ToolStripButton_Find";
            this.scriptsEditor_ToolStripButton_Find.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_Find.Text = "Rechercher (Ctrl+F)";
            this.scriptsEditor_ToolStripButton_Find.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Find_Click);
            // 
            // scriptsEditor_ToolStripButton_Replace
            // 
            this.scriptsEditor_ToolStripButton_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_Replace.Image = global::Gemini.Properties.Resources.replace;
            this.scriptsEditor_ToolStripButton_Replace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_Replace.Name = "scriptsEditor_ToolStripButton_Replace";
            this.scriptsEditor_ToolStripButton_Replace.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_Replace.Text = "Remplacer (Ctrl+H)";
            this.scriptsEditor_ToolStripButton_Replace.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Replace_Click);
            // 
            // scriptsEditor_ToolStripButton_GoToLine
            // 
            this.scriptsEditor_ToolStripButton_GoToLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_GoToLine.Image = global::Gemini.Properties.Resources.go_to;
            this.scriptsEditor_ToolStripButton_GoToLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_GoToLine.Name = "scriptsEditor_ToolStripButton_GoToLine";
            this.scriptsEditor_ToolStripButton_GoToLine.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_GoToLine.Text = "Aller à la ligne (Ctrl+G)";
            this.scriptsEditor_ToolStripButton_GoToLine.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_GoToLine_Click);
            // 
            // scriptsEditor_ToolStripButton_Comment
            // 
            this.scriptsEditor_ToolStripButton_Comment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_Comment.Image = global::Gemini.Properties.Resources.comment;
            this.scriptsEditor_ToolStripButton_Comment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_Comment.Name = "scriptsEditor_ToolStripButton_Comment";
            this.scriptsEditor_ToolStripButton_Comment.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_Comment.Text = "Basculer commentaire (Ctrl+Q)";
            this.scriptsEditor_ToolStripButton_Comment.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ToggleComment_Click);
            // 
            // scriptsEditor_ToolStripButton_StructureScript
            // 
            this.scriptsEditor_ToolStripButton_StructureScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_StructureScript.Image = global::Gemini.Properties.Resources.outline;
            this.scriptsEditor_ToolStripButton_StructureScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_StructureScript.Name = "scriptsEditor_ToolStripButton_StructureScript";
            this.scriptsEditor_ToolStripButton_StructureScript.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_StructureScript.Text = "Structure Script";
            this.scriptsEditor_ToolStripButton_StructureScript.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_StructureScriptCurrent_Click);
            // 
            // scriptsEditor_ToolStripButton_RemoveEmptyLines
            // 
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.Image = global::Gemini.Properties.Resources.emptyspace;
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.Name = "scriptsEditor_ToolStripButton_RemoveEmptyLines";
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.Text = "Remove Empty Lines";
            this.scriptsEditor_ToolStripButton_RemoveEmptyLines.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent_Click);
            // 
            // scriptsEditor_ToolStripButton_Run
            // 
            this.scriptsEditor_ToolStripButton_Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_Run.Image = global::Gemini.Properties.Resources.play;
            this.scriptsEditor_ToolStripButton_Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_Run.Name = "scriptsEditor_ToolStripButton_Run";
            this.scriptsEditor_ToolStripButton_Run.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.scriptsEditor_ToolStripButton_Run.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_Run.Text = "Lancer le jeu (F12)";
            this.scriptsEditor_ToolStripButton_Run.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Run_Click);
            // 
            // scriptsEditor_ToolStripButton_Debug
            // 
            this.scriptsEditor_ToolStripButton_Debug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_Debug.Image = global::Gemini.Properties.Resources.Debug;
            this.scriptsEditor_ToolStripButton_Debug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_Debug.Name = "scriptsEditor_ToolStripButton_Debug";
            this.scriptsEditor_ToolStripButton_Debug.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.scriptsEditor_ToolStripButton_Debug.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_Debug.Text = "Mode Debug";
            this.scriptsEditor_ToolStripButton_Debug.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Debug_Click);
            // 
            // scriptsEditor_ToolStripButton_ProjectFolder
            // 
            this.scriptsEditor_ToolStripButton_ProjectFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_ProjectFolder.Image = global::Gemini.Properties.Resources.Folder_Open;
            this.scriptsEditor_ToolStripButton_ProjectFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_ProjectFolder.Name = "scriptsEditor_ToolStripButton_ProjectFolder";
            this.scriptsEditor_ToolStripButton_ProjectFolder.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.scriptsEditor_ToolStripButton_ProjectFolder.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_ProjectFolder.Text = "Dossier du projet";
            this.scriptsEditor_ToolStripButton_ProjectFolder.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ProjectFolder_Click);
            // 
            // scriptsEditor_ToolStripButton_CloseProject
            // 
            this.scriptsEditor_ToolStripButton_CloseProject.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.scriptsEditor_ToolStripButton_CloseProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scriptsEditor_ToolStripButton_CloseProject.Image = global::Gemini.Properties.Resources.CloseProject;
            this.scriptsEditor_ToolStripButton_CloseProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scriptsEditor_ToolStripButton_CloseProject.Name = "scriptsEditor_ToolStripButton_CloseProject";
            this.scriptsEditor_ToolStripButton_CloseProject.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.scriptsEditor_ToolStripButton_CloseProject.Size = new System.Drawing.Size(23, 22);
            this.scriptsEditor_ToolStripButton_CloseProject.Text = "Fermer le projet";
            this.scriptsEditor_ToolStripButton_CloseProject.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_CloseProject_Click);
            // 
            // scriptsEditor_ContextMenuStrip
            // 
            this.scriptsEditor_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsEditor_ToolStripMenuItem_Undo,
            this.scriptsEditor_ToolStripMenuItem_Redo,
            toolStripSeparator15,
            this.scriptsEditor_ToolStripMenuItem_Cut,
            this.scriptsEditor_ToolStripMenuItem_Copy,
            this.scriptsEditor_ToolStripMenuItem_Paste,
            this.scriptsEditor_ToolStripMenuItem_Delete,
            this.scriptsEditor_ToolStripMenuItem_SelectAll,
            toolStripSeparator14,
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch,
            this.scriptsEditor_ToolStripMenuItem_Find,
            this.scriptsEditor_ToolStripMenuItem_FindNext,
            this.scriptsEditor_ToolStripMenuItem_FindPrevious,
            this.scriptsEditor_ToolStripMenuItem_Replace,
            this.scriptsEditor_ToolStripMenuItem_GoToLine,
            toolStripSeparator13,
            this.scriptsEditor_ToolStripMenuItem_Comment,
            toolStripSeparator12,
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete});
            this.scriptsEditor_ContextMenuStrip.Name = "scriptsEditor_ContextMenuStrip";
            this.scriptsEditor_ContextMenuStrip.Size = new System.Drawing.Size(246, 358);
            this.scriptsEditor_ContextMenuStrip.Opened += new System.EventHandler(this.mainMenu_ToolStripMenuItem_DropDownOpening);
            // 
            // scriptsEditor_ToolStripMenuItem_Undo
            // 
            this.scriptsEditor_ToolStripMenuItem_Undo.Image = global::Gemini.Properties.Resources.undo;
            this.scriptsEditor_ToolStripMenuItem_Undo.Name = "scriptsEditor_ToolStripMenuItem_Undo";
            this.scriptsEditor_ToolStripMenuItem_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.scriptsEditor_ToolStripMenuItem_Undo.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Undo.Text = "Précèdant";
            this.scriptsEditor_ToolStripMenuItem_Undo.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Undo_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Redo
            // 
            this.scriptsEditor_ToolStripMenuItem_Redo.Image = global::Gemini.Properties.Resources.redo;
            this.scriptsEditor_ToolStripMenuItem_Redo.Name = "scriptsEditor_ToolStripMenuItem_Redo";
            this.scriptsEditor_ToolStripMenuItem_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.scriptsEditor_ToolStripMenuItem_Redo.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Redo.Text = "Suivant";
            this.scriptsEditor_ToolStripMenuItem_Redo.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Redo_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Cut
            // 
            this.scriptsEditor_ToolStripMenuItem_Cut.Image = global::Gemini.Properties.Resources.cut;
            this.scriptsEditor_ToolStripMenuItem_Cut.Name = "scriptsEditor_ToolStripMenuItem_Cut";
            this.scriptsEditor_ToolStripMenuItem_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.scriptsEditor_ToolStripMenuItem_Cut.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Cut.Text = "Couper";
            this.scriptsEditor_ToolStripMenuItem_Cut.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Cut_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Copy
            // 
            this.scriptsEditor_ToolStripMenuItem_Copy.Image = global::Gemini.Properties.Resources.copy;
            this.scriptsEditor_ToolStripMenuItem_Copy.Name = "scriptsEditor_ToolStripMenuItem_Copy";
            this.scriptsEditor_ToolStripMenuItem_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.scriptsEditor_ToolStripMenuItem_Copy.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Copy.Text = "Copier";
            this.scriptsEditor_ToolStripMenuItem_Copy.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Copy_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Paste
            // 
            this.scriptsEditor_ToolStripMenuItem_Paste.Image = global::Gemini.Properties.Resources.paste;
            this.scriptsEditor_ToolStripMenuItem_Paste.Name = "scriptsEditor_ToolStripMenuItem_Paste";
            this.scriptsEditor_ToolStripMenuItem_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.scriptsEditor_ToolStripMenuItem_Paste.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Paste.Text = "Coller";
            this.scriptsEditor_ToolStripMenuItem_Paste.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Paste_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Delete
            // 
            this.scriptsEditor_ToolStripMenuItem_Delete.Image = global::Gemini.Properties.Resources.delete2;
            this.scriptsEditor_ToolStripMenuItem_Delete.Name = "scriptsEditor_ToolStripMenuItem_Delete";
            this.scriptsEditor_ToolStripMenuItem_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.scriptsEditor_ToolStripMenuItem_Delete.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Delete.Text = "Supprimer";
            this.scriptsEditor_ToolStripMenuItem_Delete.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Delete_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_SelectAll
            // 
            this.scriptsEditor_ToolStripMenuItem_SelectAll.Image = global::Gemini.Properties.Resources.select_all;
            this.scriptsEditor_ToolStripMenuItem_SelectAll.Name = "scriptsEditor_ToolStripMenuItem_SelectAll";
            this.scriptsEditor_ToolStripMenuItem_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.scriptsEditor_ToolStripMenuItem_SelectAll.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_SelectAll.Text = "Tous Séléctionner";
            this.scriptsEditor_ToolStripMenuItem_SelectAll.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_SelectAll_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_IncrementalSearch
            // 
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.Image = global::Gemini.Properties.Resources.find2;
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.Name = "scriptsEditor_ToolStripMenuItem_IncrementalSearch";
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.Text = "Recherche Incrémentielle";
            this.scriptsEditor_ToolStripMenuItem_IncrementalSearch.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_IncrementalSearch_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Find
            // 
            this.scriptsEditor_ToolStripMenuItem_Find.Image = global::Gemini.Properties.Resources.find;
            this.scriptsEditor_ToolStripMenuItem_Find.Name = "scriptsEditor_ToolStripMenuItem_Find";
            this.scriptsEditor_ToolStripMenuItem_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.scriptsEditor_ToolStripMenuItem_Find.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Find.Text = "Rechercher...";
            this.scriptsEditor_ToolStripMenuItem_Find.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Find_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_FindNext
            // 
            this.scriptsEditor_ToolStripMenuItem_FindNext.Image = global::Gemini.Properties.Resources.next;
            this.scriptsEditor_ToolStripMenuItem_FindNext.Name = "scriptsEditor_ToolStripMenuItem_FindNext";
            this.scriptsEditor_ToolStripMenuItem_FindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.scriptsEditor_ToolStripMenuItem_FindNext.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_FindNext.Text = "Rechercher Suivant...";
            this.scriptsEditor_ToolStripMenuItem_FindNext.Click += new System.EventHandler(this.scriptsEditor_ToolStripMenuItem_FindNext_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_FindPrevious
            // 
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.Image = global::Gemini.Properties.Resources.previous;
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.Name = "scriptsEditor_ToolStripMenuItem_FindPrevious";
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.Text = "Rechercher Précèdant...";
            this.scriptsEditor_ToolStripMenuItem_FindPrevious.Click += new System.EventHandler(this.scriptsEditor_ToolStripMenuItem_FindPrevious_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Replace
            // 
            this.scriptsEditor_ToolStripMenuItem_Replace.Image = global::Gemini.Properties.Resources.replace;
            this.scriptsEditor_ToolStripMenuItem_Replace.Name = "scriptsEditor_ToolStripMenuItem_Replace";
            this.scriptsEditor_ToolStripMenuItem_Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.scriptsEditor_ToolStripMenuItem_Replace.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Replace.Text = "Remplacer...";
            this.scriptsEditor_ToolStripMenuItem_Replace.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_Replace_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_GoToLine
            // 
            this.scriptsEditor_ToolStripMenuItem_GoToLine.Image = global::Gemini.Properties.Resources.go_to;
            this.scriptsEditor_ToolStripMenuItem_GoToLine.Name = "scriptsEditor_ToolStripMenuItem_GoToLine";
            this.scriptsEditor_ToolStripMenuItem_GoToLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.scriptsEditor_ToolStripMenuItem_GoToLine.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_GoToLine.Text = "Aller A...";
            this.scriptsEditor_ToolStripMenuItem_GoToLine.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_GoToLine_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_Comment
            // 
            this.scriptsEditor_ToolStripMenuItem_Comment.Image = global::Gemini.Properties.Resources.comment;
            this.scriptsEditor_ToolStripMenuItem_Comment.Name = "scriptsEditor_ToolStripMenuItem_Comment";
            this.scriptsEditor_ToolStripMenuItem_Comment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.scriptsEditor_ToolStripMenuItem_Comment.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_Comment.Text = "Commenter";
            this.scriptsEditor_ToolStripMenuItem_Comment.Click += new System.EventHandler(this.mainMenu_ToolStripMenuItem_ToggleComment_Click);
            // 
            // scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete
            // 
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Image = global::Gemini.Properties.Resources.text_complete;
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Name = "scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete";
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Size = new System.Drawing.Size(245, 22);
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Text = "Ajouter à Auto-Complete";
            this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete.Click += new System.EventHandler(this.scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // splitContainer_EditorSearches
            // 
            this.splitContainer_EditorSearches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer_EditorSearches.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_EditorSearches.Location = new System.Drawing.Point(218, 27);
            this.splitContainer_EditorSearches.Name = "splitContainer_EditorSearches";
            this.splitContainer_EditorSearches.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_EditorSearches.Panel1
            // 
            this.splitContainer_EditorSearches.Panel1.Controls.Add(this.scriptsEditor_GroupBox);
            this.splitContainer_EditorSearches.Panel1MinSize = 200;
            // 
            // splitContainer_EditorSearches.Panel2
            // 
            this.splitContainer_EditorSearches.Panel2.Controls.Add(this.searches_GroupBox);
            this.splitContainer_EditorSearches.Panel2MinSize = 0;
            this.splitContainer_EditorSearches.Size = new System.Drawing.Size(554, 523);
            this.splitContainer_EditorSearches.SplitterDistance = 312;
            this.splitContainer_EditorSearches.SplitterWidth = 8;
            this.splitContainer_EditorSearches.TabIndex = 3;
            // 
            // searches_GroupBox
            // 
            this.searches_GroupBox.Controls.Add(this.searches_TabControl);
            this.searches_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searches_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.searches_GroupBox.Name = "searches_GroupBox";
            this.searches_GroupBox.Size = new System.Drawing.Size(554, 203);
            this.searches_GroupBox.TabIndex = 0;
            this.searches_GroupBox.TabStop = false;
            this.searches_GroupBox.Text = "Recherches";
            // 
            // searches_TabControl
            // 
            this.searches_TabControl.AllowDrop = true;
            this.searches_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searches_TabControl.Location = new System.Drawing.Point(3, 16);
            this.searches_TabControl.Name = "searches_TabControl";
            this.searches_TabControl.SelectedIndex = 0;
            this.searches_TabControl.Size = new System.Drawing.Size(548, 184);
            this.searches_TabControl.TabIndex = 0;
            this.searches_TabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.searches_TabControl_ControlRemoved);
            // 
            // GeminiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.splitContainer_EditorSearches);
            this.Controls.Add(this.scriptsList_GroupBox);
            this.Controls.Add(this.mainMenu_MenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu_MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GeminiForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gemini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeminiForm_Closing);
            this.Load += new System.EventHandler(this.GeminiForm_OnLoad);
            this.mainMenu_MenuStrip.ResumeLayout(false);
            this.mainMenu_MenuStrip.PerformLayout();
            this.scriptsList_GroupBox.ResumeLayout(false);
            this.scriptsList_GroupBox.PerformLayout();
            this.scriptsList_ToolStrip.ResumeLayout(false);
            this.scriptsList_ToolStrip.PerformLayout();
            this.scriptsList_ContextMenuStrip.ResumeLayout(false);
            this.scriptsEditor_GroupBox.ResumeLayout(false);
            this.scriptsEditor_GroupBox.PerformLayout();
            this.scriptsEditor_StatusStrip.ResumeLayout(false);
            this.scriptsEditor_StatusStrip.PerformLayout();
            this.scriptsEditor_ToolStrip.ResumeLayout(false);
            this.scriptsEditor_ToolStrip.PerformLayout();
            this.scriptsEditor_ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.splitContainer_EditorSearches.Panel1.ResumeLayout(false);
            this.splitContainer_EditorSearches.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_EditorSearches)).EndInit();
            this.splitContainer_EditorSearches.ResumeLayout(false);
            this.searches_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Settings;
        private System.Windows.Forms.GroupBox scriptsList_GroupBox;
        private System.Windows.Forms.Label scriptsList_Label_Name;
        private System.Windows.Forms.TextBox scriptsList_TextBox_Name;
        private System.Windows.Forms.ListBox scriptsList_ListBox;
        private System.Windows.Forms.GroupBox scriptsEditor_GroupBox;
        private System.Windows.Forms.ContextMenuStrip scriptsList_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Insert;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_MoveUp;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_MoveDown;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_BatchSearch;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_SaveProject;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ImportScripts;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStrip scriptsEditor_ToolStrip;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_Comment;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_Run;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_AutoComplete;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_AutoIndent;
		private System.Windows.Forms.StatusStrip scriptsEditor_StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel scriptsEditor_ToolStripStatusLabel_Characters;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_StylesConfig;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_NewProject;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_NewProjectRMXP;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_NewProjectRMVX;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_About;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoComplete;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_IndentGuides;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoIndent;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_LineHighlight;
		private System.Windows.Forms.ToolStripStatusLabel scriptsEditor_ToolStripStatusLabel_Filler;
		private System.Windows.Forms.ToolStripStatusLabel scriptsEditor_ToolStripStatusLabel_Position;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_AutoCompleteConfig;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_SaveProject;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_CloseProject;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_StyleConfig;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_IncrementalSearch;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_Find;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_GoToLine;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_IndentGuides;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoCompleteConfig;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_LineHighlight;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_HighlightColor;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_HighlightColor;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_SpecialChars;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_OpenProject;
		private System.Windows.Forms.ContextMenuStrip scriptsEditor_ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Undo;
        private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Redo;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Cut;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Copy;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Delete;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Find;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_IncrementalSearch;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_FindNext;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_FindPrevious;
        private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Replace;
        private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_Comment;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_GoToLine;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_Replace;
		private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_StructureScript;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ExportScripts;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ExportScriptsText;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ExportScriptsRuby;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_CheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AboutGemini;
		private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_AddWordToAutoComplete;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_VersionHistory;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_CodeFolding;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_ProjectFolder;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_NewProjectRMVXAce;
        private System.Windows.Forms.ToolStripMenuItem scriptsEditor_ToolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_Debug;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_CloseProject;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_SaveSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ClearSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Game;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Run;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Debug;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ProjectFolder;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_CodeFolding;
        private System.Windows.Forms.ToolStripButton scriptsEditor_ToolStripButton_RemoveEmptyLines;
        private System.Windows.Forms.ToolStripMenuItem scriptsList_ToolStripMenuItem_Open;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.SplitContainer splitContainer_EditorSearches;
        private AdvancedTabControl scriptsEditor_TabControl;
        private System.Windows.Forms.GroupBox searches_GroupBox;
        private AdvancedTabControl searches_TabControl;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ExportScriptsRMData;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_OpenRecentProject;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoOpenProject;
        private System.Windows.Forms.ToolStrip scriptsList_ToolStrip;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_ImportScripts;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_Insert;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_MoveUp;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_MoveDown;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_Delete;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoSaveSettings;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_Open;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_IncrementalSearch;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Find;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Replace;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_GoToLine;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_BatchComment;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_ToggleComment;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Comment;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_UnComment;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_StructureScript;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_StructureScriptCurrent;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_StructureScriptOpen;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_StructureScriptAll;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_RemoveEmptyLines;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_RemoveEmptyLinesCurrent;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_RemoveEmptyLinesOpen;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_RemoveEmptyLinesAll;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Undo;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Redo;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Paste;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_BatchSearch;
        private System.Windows.Forms.ToolStripButton scriptsList_ToolStripButton_BatchSearch;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_AutoCheckUpdates;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStripMenuItem_RunF12;
    }
}

