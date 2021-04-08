
namespace CharacterCreator.WinHost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.editCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(282, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "MainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.ShortcutKeyDisplayString = "Alt + F4";
            this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileExit.Size = new System.Drawing.Size(177, 26);
            this.fileExit.Text = "&Exit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "&Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.ShortcutKeyDisplayString = "F1";
            this.HelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpAbout.Size = new System.Drawing.Size(157, 26);
            this.HelpAbout.Text = "About";
            this.HelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacter,
            this.editCharacter,
            this.deleteCharacter});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem3.Text = "&Character";
            // 
            // newCharacter
            // 
            this.newCharacter.Name = "newCharacter";
            this.newCharacter.ShortcutKeyDisplayString = "Ctrl + N";
            this.newCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCharacter.Size = new System.Drawing.Size(250, 26);
            this.newCharacter.Text = "New Character";
            this.newCharacter.Click += new System.EventHandler(this.OnCharacterAdd);
            // 
            // editCharacter
            // 
            this.editCharacter.Name = "editCharacter";
            this.editCharacter.ShortcutKeyDisplayString = "Ctrl + O";
            this.editCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.editCharacter.Size = new System.Drawing.Size(250, 26);
            this.editCharacter.Text = "Edit Character";
            this.editCharacter.Click += new System.EventHandler(this.OnCharacterEdit);
            // 
            // deleteCharacter
            // 
            this.deleteCharacter.Name = "deleteCharacter";
            this.deleteCharacter.ShortcutKeyDisplayString = "del";
            this.deleteCharacter.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteCharacter.Size = new System.Drawing.Size(250, 26);
            this.deleteCharacter.Text = "Delete Character";
            this.deleteCharacter.Click += new System.EventHandler(this.OnCharacterDelete);
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 20;
            this.DisplayListBox.Location = new System.Drawing.Point(0, 28);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(282, 375);
            this.DisplayListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 403);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creator";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newCharacter;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.ToolStripMenuItem editCharacter;
        private System.Windows.Forms.ToolStripMenuItem deleteCharacter;
    }
}

