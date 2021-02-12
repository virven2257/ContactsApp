using System.Text.RegularExpressions;

namespace ContactsAppUI
{
    public static class PhoneConverter
    {
        public static string Mask(long phone)
        {
            return phone == 0 ? "+7 (___) ___-__-__" : phone.ToString("+0 (000) 000-00-00");
        }

        public static long Unmask(string phone)
        {
            Regex nonDigits = new Regex(@"\D");
            string unmasked = nonDigits.Replace(phone, "");
            return long.Parse(unmasked);
        }
    }
}