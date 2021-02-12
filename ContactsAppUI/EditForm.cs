using System;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        public Contact SelectedContact { get; set; } = new Contact();

        public EditForm(Contact contact)
        {
            InitializeComponent();
            SelectedContact = contact;
            UpdateData();
        }

        private void UpdateData()
        {
            SurnameTextBox.Text = SelectedContact.LastName;
            NameTextBox.Text = SelectedContact.FirstName;
            BirthdayDateTimePicker.Value = SelectedContact.BirthDate;
            EmailTextBox.Text = SelectedContact.Email;
            PhoneMaskedTextBox.Text = SelectedContact.PhoneNumber.Number.ToString("+0 (000) 000-00-00");
            VkTextBox.Text = SelectedContact.VkId;
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.LastName = SurnameTextBox.Text;
            //     OkButton.Enabled = true;
            // }
            // catch (Exception exception)
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.FirstName = NameTextBox.Text;
            //     OkButton.Enabled = true;
            // }
            // catch
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.BirthDate = BirthdayDateTimePicker.Value;
            //     OkButton.Enabled = false;
            // }
            // catch
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.PhoneNumber.Number = PhoneConverter.Unmask(PhoneMaskedTextBox.Text);
            // }
            // catch
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.Email = EmailTextBox.Text;
            //     OkButton.Enabled = true;
            // }
            // catch
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            // try
            // {
            //     SelectedContact.VkId = VkTextBox.Text;
            //     OkButton.Enabled = true;
            // }
            // catch
            // {
            //     OkButton.Enabled = false;
            // }
        }

        private void CheckFields()
        {
            try
            {
                SelectedContact.LastName = SurnameTextBox.Text;
                SelectedContact.FirstName = NameTextBox.Text;
                SelectedContact.BirthDate = BirthdayDateTimePicker.Value;
                SelectedContact.PhoneNumber.Number = PhoneConverter.Unmask(PhoneMaskedTextBox.Text);
                SelectedContact.Email = EmailTextBox.Text;
                SelectedContact.VkId = VkTextBox.Text;
                OkButton.Enabled = true;
            }
            catch (Exception e)
            {
                OkButton.Enabled = false;
            }
            
        }
    }
}