using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class PasswordRegexRule2
    {
        public static string PASS_REGEX_RULE2 = "^[A-Z]{1}[A-Z a-z]{7,}$";

        public bool ValidatePasswordRule2(string password)
        {
            return Regex.IsMatch(password, PASS_REGEX_RULE2);
        }
    }
}