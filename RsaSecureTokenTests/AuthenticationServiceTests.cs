using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace RsaSecureToken.Tests
{
    [TestClass()]
    public class AuthenticationServiceTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var target = new AuthenticationService(new FakeProfile(), new FakeRsaToken());

            var actual = target.IsValid("joey", "91000000");

            //always failed
            Assert.IsTrue(actual);
        }
    }

    public class FakeProfile : IProfile
    {
        public string GetPassword(string account)
        {
            if (account == "joey")
            {
                return "91";
            }
            return null;
        }
    }

    public class FakeRsaToken : IToken
    {
        public string GetRandom(string account)
        {
            return "000000";
        }
    }
}
