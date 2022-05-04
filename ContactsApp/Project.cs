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
    }
}