using System.Web;
using System.Configuration;

namespace BugRepro.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Has no affect to the console app, works regardless.
            HttpUtility.UrlEncode("foo$");

            var value = ConfigurationManager.AppSettings["Test"];
            if (string.IsNullOrEmpty(value))
                throw new System.Exception("Could not load config value.");

            System.Console.WriteLine(value);
        }
    }
}
