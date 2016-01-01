using System.Web;
using System.Configuration;
using Xunit;

namespace BugRepro.Tests
{
    public class BugReproSpec
    {
        [Fact]
        public void Test()
        {
            // The first call works as expected and reads the value correctly from config.
            Assert.Equal("1234", ConfigurationManager.AppSettings["Test1"]);

            // If you were to comment out the UrlEncode the test would pass, for some reason the config
            // is no longer there after calling UrlEncode.
            HttpUtility.UrlEncode("foo$");
            
            // The second call does not work as expected and null is returned unless we comment
            // out the UrlEncode above.
            Assert.Equal("4321", ConfigurationManager.AppSettings["Test2"]);
        }
    }
}
