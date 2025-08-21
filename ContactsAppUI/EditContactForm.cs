using System;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        public Contact SelectedContact { get; }

        public EditForm(Contact contact)
        {
            InitializeComponent();
            SelectedContact = contact;
            UpdateData();
            CheckFields();
        }

        private void UpdateData()
        {
            SurnameTextBox.Text = SelectedContact.LastName;
            NameTextBox.Text = SelectedContact.FirstName;
            BirthdayDateTimePicker.Value = SelectedContact.DateOfBirth;
            EmailTextBox.Text = SelectedContact.Email;
            PhoneMaskedTextBox.Text = SelectedContact.PhoneNumber.Number.ToString("+0 (000) 000-00-00");
            VkTextBox.Text = SelectedContact.VkId;
        }
        
        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnOkButtonClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnSurnameTextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.LastName = SurnameTextBox.Text;
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void OnNameTextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.FirstName = NameTextBox.Text;
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void OnBirthdayDateChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.DateOfBirth = BirthdayDateTimePicker.Value;
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void OnPhoneTextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.PhoneNumber.Number = PhoneConverter.Unmask(PhoneMaskedTextBox.Text);
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void OnEmailTextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.Email = EmailTextBox.Text;
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void OnVkTextChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedContact.VkId = VkTextBox.Text;
                RemoveError((Control)sender);
            }
            catch (Exception exception)
            {
                SetError((Control)sender, exception.Message);
            }
        }

        private void CheckFields()
        {
            OkButton.Enabled = SelectedContact.Correct();
        }

        private void SetError(Control control, string message)
        {
            OkButton.Enabled = true;
            errorProvider.SetError(control, message);
            OkButton.Enabled = false;
        }

        private void RemoveError(Control control)
        {
            OkButton.Enabled = false;
            errorProvider.SetError(control, "");
            control.ResetForeColor();
            CheckFields();
        }
    }
}