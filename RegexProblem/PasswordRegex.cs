using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class FirstNameRegex
    {
        public static string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRSTNAME_REGEX);
        }
    }
}