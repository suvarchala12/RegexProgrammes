
namespace RegexPatternMatching
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //UC3
            EmailRegex pattern3 = new EmailRegex();
            Console.WriteLine(pattern3.validateEmail("abc.xyz@bl.co.in"));

        }
    }
 
}