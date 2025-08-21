using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp
{
    public class Project : IEquatable<Project>
    {
        /// <summary>
        /// Список всех контактов
        /// </summary>
        public List<Contact> Contacts { get; } = new List<Contact>();
        

        /// <summary>
        /// Поиск контактов по фамилии
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Возвращает отсортированный по фамилиям в алфавитном порядке список контактов, чья фамилия
        /// начинается с заданной строки</returns>
        public List<Contact> FindSorted(string query) => Contacts
            .Where(i => i.LastName.StartsWith(query))
            .OrderBy(j => j.LastName)
            .ToList();

        /// <summary>
        /// Поиск именинников
        /// </summary>
        /// <param name="date">Дата рождения</param>
        /// <returns>Возвращает список контактов, у которых в указанную дату день рождения</returns>
        public List<Contact> GetBirthdays(DateTime date) => Contacts
            .Where(i => i.DateOfBirth.Day == date.Day && i.DateOfBirth.Month == date.Month)
            .OrderBy(j => j.LastName)
            .ToList();

        #region IEquatable

        public bool Equals(Project other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Contacts.SequenceEqual(other.Contacts);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Project)obj);
        }

        public override int GetHashCode()
        {
            return (Contacts != null ? Contacts.GetHashCode() : 0);
        }
        
        #endregion
    }
}