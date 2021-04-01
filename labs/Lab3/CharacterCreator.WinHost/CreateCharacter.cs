﻿using System;
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
    public partial class CreateCharacter : Form
    {
        public CreateCharacter ()
        {
            InitializeComponent();
        }
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }
        private Character SaveCharacter ()
        {
            var character = new Character();
            character.Name = NameLabel.Text;
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
                _errors.SetError(control, "Name is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            var Profession = control.SelectedItem as string;

            if (String.IsNullOrEmpty(Profession))
            {
                _errors.SetError(control, "Profession is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            var Race = control.SelectedItem as string;

            if (String.IsNullOrEmpty(Race))
            {
                _errors.SetError(control, "Race is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
        private void OnValidatingStats ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetInt32(control);
            if (value < 0 || value > 100)
            {
                _errors.SetError(control, "Attribute must be within 0 - 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }
    }
}
