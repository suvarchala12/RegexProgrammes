using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class EmailRegex
    {
        public static string EMAIL_REGEX = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2}[.][a-z]{2}$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}