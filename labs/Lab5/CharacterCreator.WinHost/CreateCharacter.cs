/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class CreateCharacter : Form
    {
        public CreateCharacter ()
        {
            InitializeComponent();
        }
        public Character Character { get; set; }
        protected override void OnFormClosing ( FormClosingEventArgs e )
        {
            base.OnFormClosing(e);
        }
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            if (Character != null)
                LoadCharacter(Character);
        }
        private void LoadCharacter ( Character character )
        {
            NameBox.Text = character.Name;
            ProfessionComboBox.SelectedItem = character.Profession;
            RaceComboBox.SelectedItem = character.Race;
            BiographyBox.Text = character.Biography;
            StrengthBox.Text = character.Strength.ToString();
            IntelligenceBox.Text = character.Intelligence.ToString();
            AgilityBox.Text = character.Agility.ToString();
            ConstitutionBox.Text = character.Constitution.ToString();
            CharismaBox.Text = character.Charisma.ToString();
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            };
            var character = SaveCharacter();

            var errors = ObjectValidator.TryValidate(character);
            if (errors.Count > 0)
            {
                MessageBox.Show(this, errors[0].ErrorMessage, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            };

            
            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }
        private Character SaveCharacter ()
        {
            var character = new Character();
            character.Name = NameBox.Text;
            character.Profession = ProfessionComboBox.SelectedItem as string;
            character.Race = RaceComboBox.SelectedItem as string;
            character.Biography = BiographyBox.Text;
            character.Strength = GetInt32(StrengthBox);
            character.Intelligence = GetInt32(IntelligenceBox);
            character.Agility = GetInt32(AgilityBox);
            character.Constitution = GetInt32(ConstitutionBox);
            character.Charisma = GetInt32(CharismaBox);
            return character;
        }
        private int GetInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }
        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                ErrorProvider.SetError(control, "Name is required");
                e.Cancel = true;
            } else
            {
                ErrorProvider.SetError(control, "");
            };
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            var Profession = control.SelectedItem as string;

            if (String.IsNullOrEmpty(Profession))
            {
                ErrorProvider.SetError(control, "Profession is required");
                e.Cancel = true;
            } else
            {
                ErrorProvider.SetError(control, "");
            };
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            var Race = control.SelectedItem as string;

            if (String.IsNullOrEmpty(Race))
            {
                ErrorProvider.SetError(control, "Race is required");
                e.Cancel = true;
            } else
            {
                ErrorProvider.SetError(control, "");
            };
        }
        private void OnValidatingStats ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetInt32(control);
            if (value < 0 || value > 100)
            {
                ErrorProvider.SetError(control, "Attribute must be within 0 - 100");
                e.Cancel = true;
            } else
            {
                ErrorProvider.SetError(control, "");
            };
        }
    }
}
