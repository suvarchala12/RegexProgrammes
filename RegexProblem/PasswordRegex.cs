using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class PasswordRegexRule3
    {
        public static string PASS_REGEX_RULE3 = "^[A-Z]{1}[A-Z a-z]{6,}[0-9]{1,}$";

        public bool ValidatePasswordRule3(string password)
        {
            return Regex.IsMatch(password, PASS_REGEX_RULE3);
        }
    }
}