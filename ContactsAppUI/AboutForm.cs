using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            VersionLabel.Text = "v. " + Application.ProductVersion;
        }
    }
}