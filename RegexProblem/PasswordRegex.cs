using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class PasswordRegexRule4
    {
        public static string PASS_REGEX_RULE4 = @"^[A-Z]{1}[A-Z a-z]{7,}[/\!//\*//\@//\#//\$//\%//\^//\&//\+//\=/]{1}[0-9]{1,}$";

        public bool ValidatePasswordRule4(string password)
        {
            return Regex.IsMatch(password, PASS_REGEX_RULE4);
        }
    }
}