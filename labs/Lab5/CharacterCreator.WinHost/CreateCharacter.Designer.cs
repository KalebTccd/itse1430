
namespace CharacterCreator.WinHost
{
    partial class CreateCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ProfessionLabel = new System.Windows.Forms.Label();
            this.ProfessionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RaceComboBox = new System.Windows.Forms.ComboBox();
            this.BiographyLabel = new System.Windows.Forms.Label();
            this.BiographyBox = new System.Windows.Forms.TextBox();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.StrengthBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.IntelligenceBox = new System.Windows.Forms.TextBox();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.AgilityBox = new System.Windows.Forms.TextBox();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.ConstitutionBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.CharismaBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(107, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(163, 27);
            this.NameBox.TabIndex = 1;
            this.NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // ProfessionLabel
            // 
            this.ProfessionLabel.AutoSize = true;
            this.ProfessionLabel.Location = new System.Drawing.Point(12, 42);
            this.ProfessionLabel.Name = "ProfessionLabel";
            this.ProfessionLabel.Size = new System.Drawing.Size(77, 20);
            this.ProfessionLabel.TabIndex = 2;
            this.ProfessionLabel.Text = "Profession";
            // 
            // ProfessionComboBox
            // 
            this.ProfessionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfessionComboBox.FormattingEnabled = true;
            this.ProfessionComboBox.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.ProfessionComboBox.Location = new System.Drawing.Point(107, 39);
            this.ProfessionComboBox.Name = "ProfessionComboBox";
            this.ProfessionComboBox.Size = new System.Drawing.Size(163, 28);
            this.ProfessionComboBox.TabIndex = 3;
            this.ProfessionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingProfession);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Race";
            // 
            // RaceComboBox
            // 
            this.RaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceComboBox.FormattingEnabled = true;
            this.RaceComboBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.RaceComboBox.Location = new System.Drawing.Point(107, 73);
            this.RaceComboBox.Name = "RaceComboBox";
            this.RaceComboBox.Size = new System.Drawing.Size(163, 28);
            this.RaceComboBox.TabIndex = 5;
            this.RaceComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRace);
            // 
            // BiographyLabel
            // 
            this.BiographyLabel.AutoSize = true;
            this.BiographyLabel.Location = new System.Drawing.Point(12, 110);
            this.BiographyLabel.Name = "BiographyLabel";
            this.BiographyLabel.Size = new System.Drawing.Size(77, 20);
            this.BiographyLabel.TabIndex = 6;
            this.BiographyLabel.Text = "Biography";
            // 
            // BiographyBox
            // 
            this.BiographyBox.Location = new System.Drawing.Point(107, 107);
            this.BiographyBox.Name = "BiographyBox";
            this.BiographyBox.Size = new System.Drawing.Size(163, 27);
            this.BiographyBox.TabIndex = 7;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(12, 143);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(65, 20);
            this.StrengthLabel.TabIndex = 8;
            this.StrengthLabel.Text = "Strength";
            // 
            // StrengthBox
            // 
            this.StrengthBox.Location = new System.Drawing.Point(107, 140);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.Size = new System.Drawing.Size(163, 27);
            this.StrengthBox.TabIndex = 9;
            this.StrengthBox.Tag = "";
            this.StrengthBox.Text = "50";
            this.StrengthBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(12, 176);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(86, 20);
            this.IntelligenceLabel.TabIndex = 10;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // IntelligenceBox
            // 
            this.IntelligenceBox.Location = new System.Drawing.Point(107, 173);
            this.IntelligenceBox.Name = "IntelligenceBox";
            this.IntelligenceBox.Size = new System.Drawing.Size(163, 27);
            this.IntelligenceBox.TabIndex = 11;
            this.IntelligenceBox.Text = "50";
            this.IntelligenceBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.Location = new System.Drawing.Point(12, 209);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(52, 20);
            this.AgilityLabel.TabIndex = 12;
            this.AgilityLabel.Text = "Agility";
            // 
            // AgilityBox
            // 
            this.AgilityBox.Location = new System.Drawing.Point(107, 206);
            this.AgilityBox.Name = "AgilityBox";
            this.AgilityBox.Size = new System.Drawing.Size(163, 27);
            this.AgilityBox.TabIndex = 13;
            this.AgilityBox.Text = "50";
            this.AgilityBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Location = new System.Drawing.Point(12, 242);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(89, 20);
            this.ConstitutionLabel.TabIndex = 14;
            this.ConstitutionLabel.Text = "Constitution";
            // 
            // ConstitutionBox
            // 
            this.ConstitutionBox.Location = new System.Drawing.Point(107, 239);
            this.ConstitutionBox.Name = "ConstitutionBox";
            this.ConstitutionBox.Size = new System.Drawing.Size(163, 27);
            this.ConstitutionBox.TabIndex = 15;
            this.ConstitutionBox.Text = "50";
            this.ConstitutionBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Location = new System.Drawing.Point(12, 275);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(70, 20);
            this.CharismaLabel.TabIndex = 16;
            this.CharismaLabel.Text = "Charisma";
            // 
            // CharismaBox
            // 
            this.CharismaBox.Location = new System.Drawing.Point(107, 272);
            this.CharismaBox.Name = "CharismaBox";
            this.CharismaBox.Size = new System.Drawing.Size(163, 27);
            this.CharismaBox.TabIndex = 17;
            this.CharismaBox.Text = "50";
            this.CharismaBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingStats);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(176, 373);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Location = new System.Drawing.Point(7, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(282, 414);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CharismaBox);
            this.Controls.Add(this.CharismaLabel);
            this.Controls.Add(this.ConstitutionBox);
            this.Controls.Add(this.ConstitutionLabel);
            this.Controls.Add(this.AgilityBox);
            this.Controls.Add(this.AgilityLabel);
            this.Controls.Add(this.IntelligenceBox);
            this.Controls.Add(this.IntelligenceLabel);
            this.Controls.Add(this.StrengthBox);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.BiographyBox);
            this.Controls.Add(this.BiographyLabel);
            this.Controls.Add(this.RaceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessionComboBox);
            this.Controls.Add(this.ProfessionLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "CreateCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ProfessionLabel;
        private System.Windows.Forms.ComboBox ProfessionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RaceComboBox;
        private System.Windows.Forms.Label BiographyLabel;
        private System.Windows.Forms.TextBox BiographyBox;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.TextBox StrengthBox;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.TextBox IntelligenceBox;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.TextBox AgilityBox;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.TextBox ConstitutionBox;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.TextBox CharismaBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}