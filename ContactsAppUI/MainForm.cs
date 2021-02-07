using System;
using System.ComponentModel;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private BindingList<Contact> _contacts = new BindingList<Contact>();

        private Contact _selectedContact = new Contact();

        private Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                UpdateData();
            }
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

        public MainForm()
        {
            InitializeComponent();
            ContactsListBox.DataSource = _contacts;
            ContactsListBox.DisplayMember = nameof(Contact.LastName);
            
        }
        
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new AboutForm().Show();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditForm().Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact()
            {
                Email = "f@k.u",
                BirthDate = DateTime.Today - TimeSpan.FromDays(2),
                FirstName = "Иван",
                LastName = "Иванов",
                PhoneNumber = new PhoneNumber()
                {
                    Number = 71111111111
                },
                VkId = "aaa"
            };
            
            _contacts.Add(newContact);
            ContactsListBox.Invalidate();
        }

        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox) sender).SelectedIndex;
            SelectedContact = _contacts[index];

        }
    }
}