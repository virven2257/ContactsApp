using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }

        [TestCase("Иван", "Корректные данные", TestName = "Позитивный тест геттера имени")]
        public void TestFirstNameGet_CorrectValue(string correctName, string message)
        {
            var expected = correctName;
            _contact.FirstName = expected;
            var actual = _contact.FirstName;
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве имени")]
        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван-Иван",
            "Должно возникать исключение, если имя длиннее 50 символов",
            TestName = "Присвоение неправильного имени длиной больше 50 символов")]
        public void TestFirstNameSet_ArgumentException(string wrongName, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.FirstName = wrongName; },
                message);
        }

        [TestCase("Смирнов", "Корректные данные", TestName = "Позитивный тест геттера фамилии")]
        public void TestLastNameGet_CorrectValue(string correctName, string message)
        {
            var expected = correctName;
            _contact.LastName = expected;
            var actual = _contact.LastName;
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве фамилии")]
        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов",
            "Должно возникать исключение, если фамилия длиннее 50 символов",
        TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestLastNameSet_ArgumentException(string wrongLastName, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.LastName = wrongLastName; },
                message);
        }
        
        [TestCase("", "Пустая строка допустима",
            TestName = "Присвоение пустой строки в качестве почты")]
        [TestCase("email@email.email", "Корректные данные", TestName = "Позитивный тест геттера почты")]
        public void TestEmailGet_CorrectValue(string correctEmail, string message)
        {
            var expected = correctEmail;
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве почты")]
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве почты")]
        [TestCase("email@email.email+email@email.email+email@email.email+email@email.email",
            "Должно возникать исключение, если почта длиннее 50 символов",
            TestName = "Присвоение неправильной почты больше 50 символов")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Email = wrongEmail; },
                message);
        }
        
        [TestCase("", "Пустая строка допустима",
            TestName = "Присвоение пустой строки в качестве ID VK")]
        [TestCase("2359024", "Корректные данные", TestName = "Позитивный тест геттера VK")]
        public void TestVkIdGet_CorrectValue(string correctVk, string message)
        {
            var expected = correctVk;
            _contact.VkId = expected;
            var actual = _contact.VkId;
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве почты")]
        [TestCase("3333333333333333333333333333333333333333333333333",
            "Должно возникать исключение, если ID VK длиннее 15 символов",
            TestName = "Присвоение неправильного ID VK больше 15 символов")]
        public void TestVkIdSet_ArgumentException(string wrongVk, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.VkId = wrongVk; },
                message);
        }

        [TestCase(71234567891, "Корректное значение",
            TestName = "Позитивный тест геттера номера телефона")]
        public void TestPhoneNumberGet_CorrectValue(long correctNumber, string message)
        {
            var expected = new PhoneNumber(){Number = correctNumber};
            _contact.PhoneNumber = expected;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1.2000", "Присвоение допустимой даты рождения",
            TestName = "Позитивный тест даты рождения")]
        public void TestDateOfBirthGet_CorrectValue(string correctDate, string message)
        {
            var expected = DateTime.Parse(correctDate);
            _contact.DateOfBirth = expected;
            var actual = _contact.DateOfBirth;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1.1700", "Слишком давняя дата",
            TestName = "Присвоение слишком давней даты рождения")]
        [TestCase("1.1.2050", "Дата из будущего",
            TestName = "Присвоение слишком давней даты рождения")]
        public void TestDateOfBirthSet_ArgumentException(string wrongDate, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.DateOfBirth = DateTime.Parse(wrongDate); },
                message);
        }
    }
}