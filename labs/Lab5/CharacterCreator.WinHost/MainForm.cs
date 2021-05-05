/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            _roster.GetAll();
            UpdateUI();
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

                try
                {
                    _roster.Add(form.Character);
                    break;
                } catch (ArgumentException ex)
                {
                    DisplayError("Add Failed", "You didn't pass the args right");
                } catch (Exception ex)
                {
                    DisplayError("Add Failed", ex.Message);
                };
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

                try
                {
                    _roster.Update(character.Id, form.Character);
                    break;
                } catch (Exception ex)
                {
                    DisplayError("Add Failed", ex.Message);
                };
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
            try
            {
                _roster.Delete(character.Id);
            } catch (Exception ex)
            {
                DisplayError("Delete Failed", ex.Message);
            };
            UpdateUI();
        }
        private void UpdateUI ()
        {
            DisplayListBox.DisplayMember = "Title";

            try
            {
                var characters = from m in _roster.GetAll()
                                 select m;

                DisplayListBox.DataSource = characters.ToArray();
            } catch (Exception e)
            {
                DisplayError("Error retrieving characters", e.Message);

                DisplayListBox.DataSource = new Character[0];
            };

        }
        private Character GetSelectedCharacter ()
        {
            return DisplayListBox.SelectedItem as Character;
        }
        private void DisplayError ( string title, string message )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private readonly ICharacterRoster _roster = new SqlServer.SqlServerCharacterRoster(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CharacterDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
