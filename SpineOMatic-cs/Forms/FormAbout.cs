using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpineOMatic_cs
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            TitleLabel.Text = Program.PROGRAM_NAME + " v" + Program.PROGRAM_VER;
            DescriptionLabel.Text = Program.ABOUT_DESCRIPTION;
        }

        private void FormAbout_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void FormAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
            {
                CloseForm();
            }
        }

        private void CloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            FormAbout_Click(sender, e);
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {
            FormAbout_Click(sender, e);
        }
    }
}
