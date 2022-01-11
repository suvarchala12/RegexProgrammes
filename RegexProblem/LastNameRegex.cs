using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class LastNameRegex
    {
        public static string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LASTNAME_REGEX);
        }
    }
}