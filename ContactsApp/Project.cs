using System.Collections.Generic;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// Список всех контактов
        /// </summary>
        public List<Contact> Contacts { get; } = new List<Contact>();
    }
}