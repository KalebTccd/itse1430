using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
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

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.Character;

            UpdateUI();
        }
        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CreateCharacter();
            form.Character = character;

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.Character;

            UpdateUI();
        }
        private void UpdateUI ()
        {
            var count = (_character != null) ? 1 : 0;
            Character[] character = new Character[count];
            if (_character != null)
                character[0] = _character;
            DisplayListBox.DataSource = character;
            DisplayListBox.DisplayMember = "Name";
        }
        private Character GetSelectedCharacter()
        {
            return DisplayListBox.SelectedItem as Character;
        }
        private Character _character;
    }
}
