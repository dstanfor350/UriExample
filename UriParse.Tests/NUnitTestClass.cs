using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUT = UriParseLib;

namespace UriParse.nUnit
{
    [TestFixture]
    class NUnitTestClass
    {
        [TestCase]
        public void RetGetEndPointPath()
        {
            // arrange
            Uri LoginAPI = new Uri("http://www.jukka.com/prod/api/account/login");
            var glp = new SUT.APIPaySystem.APIPayLoad(LoginAPI);

            // act
            var path = glp.GetEndPointPath();

            // assert
            Assert.IsTrue(string.Equals(path, "/prod/api/account/login", StringComparison.OrdinalIgnoreCase));
        }

        [TestCase]
        public void RetGetLocalPath()
        {
            // arrange
            Uri LoginAPI = new Uri("http://www.jukka.com/prod/api/account/login");
            var glp = new SUT.APIPaySystem.APIPayLoad(LoginAPI);

            // act
            var path = glp.GetEndPointPath();

            // assert
            Assert.IsTrue(string.Equals(path, "/prod/api/account/login", StringComparison.OrdinalIgnoreCase));
        }

        [TestCase]
        public void RetGetPathSegments()
        {
            // arrange
            Uri LoginAPI = new Uri("http://www.jukka.com/prod/api/account/login");
            var glp = new SUT.APIPaySystem.APIPayLoad(LoginAPI);

            // act
            var path = glp.GetPathSegments();

            // assert
            List<string> Segments = new List<string> { "prod", "api", "account", "login" };
            CollectionAssert.AreEqual(path, Segments);
        }

    }
}
