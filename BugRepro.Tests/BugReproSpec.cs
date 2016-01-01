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
            // If you were to comment out the UrlEncode the test would pass, for some reason the config
            // is no longer there after calling UrlEncode.
            HttpUtility.UrlEncode("foo$");

            var value = ConfigurationManager.AppSettings["Test"];
            Assert.Equal("1234", value);
        }
    }
}
