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
                _selectedContact = value ?? new Contact();
                UpdateData();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ContactsListBox.DataSource = _contacts;
            ContactsListBox.DisplayMember = nameof(Contact.LastName);
            CheckItemsCount();
            _contacts.ListChanged += Contacts_ListChanged;
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
        
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new AboutForm().Show();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact(new Contact(), true);
            
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
            //SelectedContact = newContact;
            ContactsListBox.Invalidate();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            if (index == -1) return;
            SelectedContact = _contacts[index];
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string text = "Do you really want to remove this contact: " + SelectedContact.LastName + "?";
            DialogResult result = MessageBox.Show(text, "Remove Contact", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int index = ContactsListBox.SelectedIndex;
                _contacts.RemoveAt(index);
                ContactsListBox.Invalidate();
            }

            //index = ContactsListBox.SelectedIndex;
            //SelectedContact = index > -1 ? (Contact)ContactsListBox.SelectedItem : null;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact(SelectedContact, false);
        }

        private void EditContact(Contact contact, bool isNew)
        {
            var editForm = new EditForm(contact);
            Enabled = false;
            DialogResult result = editForm.ShowDialog();
            Enabled = true;
            if (result != DialogResult.OK) return;
            if (isNew)
            {
                _contacts.Add(editForm.SelectedContact);
                //SelectedContact = _contacts[_contacts.IndexOf(editForm.SelectedContact)];
            }
            else
            {
                int index = _contacts.IndexOf((Contact)ContactsListBox.SelectedItem);
                _contacts[index] = editForm.SelectedContact;
                //SelectedContact = _contacts[index];
            }     
            ContactsListBox.Invalidate();
        }

        private void CheckItemsCount()
        {
            if (ContactsListBox.Items.Count == 0)
            {
                EditButton.Enabled = false;
                RemoveButton.Enabled = false;
            }
            else
            {
                EditButton.Enabled = true;
                RemoveButton.Enabled = true;
            }
        }
        
        private void Contacts_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckItemsCount();
            ContactsListBox.DataSource = _contacts;
            int index = ContactsListBox.SelectedIndex;
            SelectedContact = index > -1 ? (Contact)ContactsListBox.SelectedItem : null;
            
        }
    }
}