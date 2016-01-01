using System.Web;
using System.Configuration;

namespace BugRepro.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = ConfigurationManager.AppSettings["Test1"];
            if (value1 != "1234")
                throw new System.Exception("Could not load Test1 config value.");

            // Has no affect to the console app, works regardless.
            HttpUtility.UrlEncode("foo$");

            var value2 = ConfigurationManager.AppSettings["Test2"];
            if (value2 != "4321")
                throw new System.Exception("Could not load Test2 config value.");

            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("Console Tests Pass!!!!!!");
            System.Console.ResetColor();
        }
    }
}
