/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox();

            form.ShowDialog();
        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CreateCharacter();
            do
            {
                if (form.ShowDialog(this) == DialogResult.Cancel)
                    return;

                _roster.Add(form.Character, out var error);
                if (String.IsNullOrEmpty(error))
                    break;
                DisplayError("Add Failed", error);
            } while (true);
            UpdateUI();
        }
        private void OnCharacterEdit ( object sender, EventArgs e )
        {

            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CreateCharacter();
            form.Character = character;

            do
            {
                if (form.ShowDialog(this) == DialogResult.Cancel)
                    return;

                _roster.Update(character.Id, form.Character, out var error);
                if (String.IsNullOrEmpty(error))
                    break;
                DisplayError("Add Failed", error);
            } while (true);

            UpdateUI();

        }
        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;
            var result = MessageBox.Show(this, $"Are you sure you want to delete '{character.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            _roster.Delete(character.Id, out var error);
            UpdateUI();
        }
        private void UpdateUI ()
        {
            var binding = new BindingSource();
            binding.DataSource = _roster.GetAll();

            DisplayListBox.DataSource = binding;
            DisplayListBox.DisplayMember = nameof(Character.Name);

        }
        private Character GetSelectedCharacter ()
        {
            return DisplayListBox.SelectedItem as Character;
        }
        private void DisplayError ( string title, string message )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private readonly Memory.MemoryCharacterRoster _roster = new Memory.MemoryCharacterRoster();
    }
}
