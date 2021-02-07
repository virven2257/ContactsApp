using System;

namespace ContactsApp
{
    public class PhoneNumber: ICloneable, IEquatable<PhoneNumber>
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        private long _number = 70000000000;

        /// <summary>
        /// Длина номера телефона
        /// </summary>
        private const int Length = 11;

        /// <summary>
        /// Свойство, принимающее и возвращающее телефон контакта
        /// </summary>
        /// <exception cref="ArgumentException">Исключение при неверном формате номера телефона</exception>
        public long Number
        {
            get => _number;
            set
            {
                if (!IsCorrect(value))
                    throw  new ArgumentException("Неправильный формат номера! " +
                                                 "Он должен начинаться с 7 и содержать " +
                                                 Length.ToString() + " цифр.");
                _number = value;
            }
        }
        
        /// <summary>
        /// Проверка правильности введения номера
        /// </summary>
        /// <param name="phone">Номер телефона</param>
        /// <returns></returns>
        public bool IsCorrect(long phone)
        {
            return (phone <= 79999999999) && (phone >= 70000000000);
        }

        public object Clone()
        {
            return new PhoneNumber()
            {
                Number = this.Number
            };
            
        }

        public bool Equals(PhoneNumber other)
        {
            if (other != null)
                return Number == other.Number;
            return false;
        }
    }
}