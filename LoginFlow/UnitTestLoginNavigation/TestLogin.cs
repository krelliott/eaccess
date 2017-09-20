using LoginNavigation;
using System;
using NUnit.Framework;

namespace UnitTestLoginNavigation
{
    [TestFixture]
    public class TestLoginCredentials
    {

		User user;

		[SetUp]
		public void UserCreation()
		{
			user = new User()
			{
				Username = "Craftlogic",
				Password = "P@ssw0rd"
			};
		}

		[Test]
        public void TestUserName()
        {
            Assert.AreEqual("Craftlogic", user.Username);
        }

		[Test]
		public void TestUserNameFail()
		{
			Assert.AreEqual("NotCraftlogic", user.Username);
		}

		[Test]
		public void TestPassword()
		{
			Assert.AreEqual("P@ssw0rd", user.Password);
		}

		[Test]
		public void TestPasswordFail()
		{
			Assert.AreEqual("NotP@ssw0rd", user.Password);
		}

		[Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}
