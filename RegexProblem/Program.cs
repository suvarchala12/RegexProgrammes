
namespace RegexPatternMatching
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
            FirstNameRegex pattern = new FirstNameRegex();
            Console.WriteLine(pattern.validateFirstName("Svc"));
        }
    }
}