using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new AboutForm().Show();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditForm().Show();
        }
    }
}