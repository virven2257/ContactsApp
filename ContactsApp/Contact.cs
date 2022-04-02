using System;

namespace ContactsApp
{
    public class Contact: ICloneable
    {
        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _lastName = "";
        
        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _firstName = "";
        
        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private PhoneNumber _phoneNumber = new PhoneNumber();
        
        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _birthDate = DateTime.Today;
        
        /// <summary>
        /// Электронная почта контакта
        /// </summary>
        private string _email = "";
        
        /// <summary>
        /// id в VK контакта
        /// </summary>
        private string _vkId = "";

        /// <summary>
        /// Максимальная длина имени, фамилии и почты контакта
        /// </summary>
        private static readonly int MaxLength = 50;
        
        /// <summary>
        /// Максимальная длина id VK контакта
        /// </summary>
        private static readonly int MaxVkLength = 15;

        /// <summary>
        /// Минимальная дата рождения контакта
        /// </summary>
        private static DateTime MinDate = new DateTime(1900, 1,1);

        /// <summary>
        /// Свойство, принимающее и возвращающее фамилию контакта
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при неверном формате фамилии</exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!TextIsCorrect(value, MaxLength))
                    throw new ArgumentException("Некорректный формат фамилии! Его длина не должна превышать " + 
                                                MaxLength + " символов."); 
                _lastName = value;
            }
        }

        /// <summary>
        /// Свойство, принимающее и возвращающее имя контакта
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при неверном формате имени</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!TextIsCorrect(value, MaxLength))
                    throw new ArgumentException("Некорректный формат имени! Его длина не должна превышать " +
                                                MaxLength + " символов.");
                _firstName = value;
            }
        }
        
        /// <summary>
        /// Свойство, принимающее и возвращающее телефон контакта
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        /// <summary>
        /// Свойство, принимающее и возвращающее дату рождения
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при некорректной указанной дате</exception>
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (!DateIsCorrect(value))
                    throw new ArgumentException("Некорректная дата рождения! Она не может быть раньше, чем "
                                                + MinDate.ToString("d") + ", или позже, чем сегодняшний день.");
                _birthDate = value;
            }
        }
        
        /// <summary>
        /// Свойство, принимающее и возвращающее электронную почту контакта
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при неверном формате почты</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!TextIsCorrect(value, MaxLength, true))
                    throw new ArgumentException("Некорректный формат почты! Его длина не должна превышать " +
                                                MaxLength + " символов.");
                _email = value;
            }
        }

        /// <summary>
        /// Свойство, принимающее и возвращающее id VK контакта
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при неверном формате id VK</exception>
        public string VkId
        {
            get => _vkId;
            set
            {
                if (!TextIsCorrect(value, MaxLength, true))
                    throw new ArgumentException("Некорректный формат ID! Его длина не должна превышать " +
                                                MaxLength + " символов.");
                _vkId = value;
            }
        }

        /// <summary>
        /// Метод, определяющий, не имеет ли строка длину более максимальной и не равна ли она null
        /// </summary>
        /// <param name="text">Проверяемый текст</param>
        /// <param name="length">Максимальная длина текста</param>
        /// <param name="canBeEmpty">Показывает, может ли текстовое поле быть пустым (но не null).</param>
        /// <returns>true, если строка подходит, false, если нет</returns>
        private static bool TextIsCorrect(string text, int length, bool canBeEmpty = false)
        {
            if (text == null)
                return false;
            var valid = true;
            if (text == "")
                valid = canBeEmpty;
            if (text.Length > length)
                valid = false;
            return valid;
        }

        /// <summary>
        /// Проверка, что дата корректна
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        private static bool DateIsCorrect(DateTime value)
        {
            return value >= MinDate && (value <= DateTime.Today);
        }

        /// <summary>
        /// Проверка правильности всех свойств контакта
        /// </summary>
        /// <returns>Корректен ли</returns>
        public bool Correct() =>
            TextIsCorrect(_firstName, MaxLength) &&
            TextIsCorrect(_lastName, MaxLength) &&
            TextIsCorrect(_email, MaxLength) &&
            TextIsCorrect(_vkId, MaxLength) &&
            DateIsCorrect(_birthDate) &&
            _phoneNumber.IsCorrect(_phoneNumber.Number);

       /// <summary>
       /// Копирование контакта
       /// </summary>
       /// <returns>Копия</returns>
        public object Clone()
        {
            return new Contact()
            {
                LastName = this.LastName,
                FirstName = this.FirstName,
                PhoneNumber = this.PhoneNumber,
                BirthDate = this.BirthDate,
                Email = this.Email,
                VkId = this.VkId
            };
        }
    }
}