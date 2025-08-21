using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            VersionLabel.Text = @"v. " + Application.ProductVersion;
        }


        
        /// <summary>
        /// Обработчик события нажатия на Git. Переходит по адресу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/virven2257/ContactsApp");
        }
        
        /// <summary>
        /// Обработчик события нажатия на E-Mail. Запускает почтовый клиент.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:virven2257@gmail.com");
        }
    }
}