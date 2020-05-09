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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Text = Program.PROGRAM_NAME + " " + Program.PROGRAM_VER;
            this.aboutToolStripMenuItem.Text = "About " + Program.PROGRAM_NAME;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Check Save
            Application.Exit();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormOptions();
            this.Enabled = false;
            DialogResult d = f.ShowDialog();
            this.Enabled = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAbout();
            this.Enabled = false;
            DialogResult d = f.ShowDialog();
            this.Enabled = true;
        }

        private void DocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Launch Website
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FocusSearchBar();
        }

        private void FocusSearchBar()
        {
            this.SearchBox.Focus();
        }

        //literally copypasta'd from
        //https://stackoverflow.com/questions/1226726/how-do-i-capture-the-enter-key-in-a-windows-forms-combobox
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((this.ActiveControl == this.SearchBox) && (keyData == Keys.Return))
            {
                String fixedBarcode = this.SearchBox.Text.Trim().Replace("+", "%2B");
                Util.Lookup.callAlma(fixedBarcode);
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
