using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _number;

        [SetUp]
        public void InitPhoneNumber()
        {
            _number = new PhoneNumber();
        }

        [TestCase(71234567891, "Корректное значение",
            TestName = "Позитивный тест геттера номера телефона")]
        public void TestPhoneNumberGet_CorrectValue(long correctNumber, string message)
        {
            var expected = correctNumber;
            _number.Number = expected;
            var actual = _number.Number;
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(null, "null недопустим",
            TestName = "Присвоение null в качестве почты")]
        [TestCase(712345678910,
            "Слишком длинный номер телефона",
            TestName = "Присвоение номера телефона длиной более 11 знаков")]
        [TestCase(712345678,
            "Слишком короткий номер телефона",
            TestName = "Присвоение номера телефона длиной менее 11 знаков")]
        [TestCase(81234567891,
            "В начале стоит не 7",
            TestName = "Присвоение номера телефона, начинающегося не с 7")]
        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _number.Number = wrongNumber; },
                message);
        }
        
    }
}