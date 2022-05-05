using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список всех контактов, привязанный к интерфейсу
        /// </summary>
        private BindingList<Contact> _contacts;

        /// <summary>
        /// Файл проекта с контактами
        /// </summary>
        private readonly Project _project = ProjectManager.Current.LoadProject();

        private Contact _selectedContact = new Contact();


        
        /// <summary>
        /// Выбранный контакт
        /// </summary>
        private Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                UpdateData();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UpdateContactsList();
            CheckItemsCount();
            UpdateBirthdays();
        }

        /// <summary>
        /// Обновление списка контактов
        /// </summary>
        private void UpdateContactsList()
        {
            _contacts = new BindingList<Contact>(_project.FindSorted(FindTextBox.Text));
            SelectedContact = _contacts.FirstOrDefault();
            ContactsListBox.DataSource = _contacts;
            ContactsListBox.DisplayMember = nameof(Contact.LastName);
            ContactsListBox.Invalidate();
            UpdateData();
            UpdateState();
        }

        /// <summary>
        /// Обновление полей
        /// </summary>
        private void UpdateData()
        {
            SurnameTextBox.Text = SelectedContact?.LastName ?? "";
            NameTextBox.Text = SelectedContact?.FirstName ?? "";
            BirthdayDateTimePicker.Value = SelectedContact?.DateOfBirth ?? DateTime.Today;
            EmailTextBox.Text = SelectedContact?.Email?? "";
            PhoneMaskedTextBox.Text = SelectedContact?.PhoneNumber.Number.ToString("+0 (000) 000-00-00") ??
                                      "";
            VkTextBox.Text = SelectedContact?.VkId ?? "";
        }

        private void UpdateBirthdays()
        {
            List<string> birthdays = _project
                .GetBirthdays(DateTime.Today)
                .Select(i => i.LastName)
                .ToList();

            if (birthdays.Count > 0)
            {
                for (int i = 0; i < birthdays.Count-1; i++)
                    BdayListLabel.Text += " " + birthdays[i] + ",";
                BdayListLabel.Text += " " + birthdays[birthdays.Count - 1] + '.';
                BirthdayPanel.Visible = true;
            }
        }

        /// <summary>
        /// Обновление выбранного контакта и активности кнопок
        /// </summary>
        private void UpdateState()
        {
            var index = ContactsListBox.SelectedIndex;
            RemoveButton.Enabled = index > -1 && _contacts.Any();
            EditButton.Enabled = index > -1 && _contacts.Any();
            RemoveContactToolStripMenuItem.Enabled = index > -1 && _contacts.Any();
            EditContactToolStripMenuItem.Enabled = index > -1 && _contacts.Any();
        }

        /// <summary>
        /// Предупреждение при удалении
        /// </summary>
        /// <returns></returns>
        private bool UserWantsToDelete()
        {
            if (SelectedContact == null)
                return false;
            var text = "Do you really want to remove this contact: " + SelectedContact.LastName + "?";
            var result = MessageBox.Show(text, @"Remove Contact", MessageBoxButtons.OKCancel);
            return result == DialogResult.OK;
        }

        /// <summary>
        /// Удаление выбранного контакта
        /// </summary>
        private void RemoveContact()
        {
            var index = ContactsListBox.SelectedIndex;
            var item = _contacts[index];
            _project.Contacts.Remove(item);
            UpdateContactsList();
            SelectedContact = index > -1 ? (Contact)ContactsListBox.SelectedItem : null;
            UpdateState();
            SaveProject(_project);
        }

        /// <summary>
        /// Создание нового контакта
        /// </summary>
        private void CreateContact()
        {
            var editForm = new EditForm(new Contact());
            Enabled = false;
            var result = editForm.ShowDialog();
            Enabled = true;
            if (result != DialogResult.OK) return;
            _project.Contacts.Add(editForm.SelectedContact);
            UpdateContactsList();
            var newContactIndex = _contacts.IndexOf(editForm.SelectedContact);
            if (newContactIndex >= 0)
            {
                ContactsListBox.SelectedIndex = newContactIndex;
                SelectedContact = _contacts[newContactIndex];
            }
            else
            {
                ContactsListBox.SelectedIndex = -1;
                SelectedContact = null;
            }

            UpdateState();
            SaveProject(_project);
        }
        
        /// <summary>
        /// Редактирование контакта
        /// </summary>
        /// <param name="contact">Контакт</param>
        private void EditContact(Contact contact)
        {
            if (contact == null) CreateContact();
            var index = ContactsListBox.SelectedIndex;
            var editForm = new EditForm(contact);
            Enabled = false;
            var result = editForm.ShowDialog();
            Enabled = true;
            if (result != DialogResult.OK) return;
            UpdateContactsList();
            UpdateState();
            ContactsListBox.SelectedIndex = index;
            SaveProject(_project);
        }

        /// <summary>
        /// Отключение кнопок, если список пуст
        /// </summary>
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
        
        /// <summary>
        /// Открытие формы
        /// </summary>
        private void OnAboutItemClicked(object sender, EventArgs e)
        {
           new AboutForm().Show();
        }

        /// <summary>
        /// Добавить контакт
        /// </summary>
        private void OnAddContactItemClicked(object sender, EventArgs e)
        {
            CreateContact();
        }

        /// <summary>
        /// Добавить контакт
        /// </summary>
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            CreateContact();
        }

        /// <summary>
        /// Меняет выбранный контакт, если он выбран на интерфейсе
        /// </summary>
        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ContactsListBox.SelectedIndex;
            SelectedContact = index > -1 ? (Contact)ContactsListBox.SelectedItem : null;
            UpdateState();
        }

        /// <summary>
        /// Удаление контакта
        /// </summary>
        private void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex < 0)
                return;
            if (UserWantsToDelete())
                RemoveContact();
        }

        /// <summary>
        /// Редактирование контакта
        /// </summary>
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex < 0)
                return;
            EditContact(SelectedContact);
        }

        /// <summary>
        /// Редактирование контакта
        /// </summary>
        private void OnEditItemClicked(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex < 0)
                return;
            EditContact(SelectedContact);
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void OnExitItemClicked(object sender, EventArgs e)
        {
            SaveProject(_project);
            Close();
        }

        /// <summary>
        /// Удаление программы
        /// </summary>
        private void OnRemoveContactItemClicked(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex < 0)
                return;
            if (UserWantsToDelete())
                RemoveContact();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProject(_project);
        }

        /// <summary>
        /// Сохранение проекта
        /// </summary>
        /// <param name="project">Проект</param>
        private void SaveProject(Project project)
        {
            ProjectManager.Current.SaveProject(project);
        }
        
        /// <summary>
        /// Обработчик события нажатия кнопки Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Contacts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (ContactsListBox.SelectedIndex < 0)
                    return;
                if (UserWantsToDelete())
                    RemoveContact();
            }
        }

        private void OnQueryChanged(object sender, EventArgs e)
        {
            UpdateContactsList();
        }
    }
}