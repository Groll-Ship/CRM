using busines;
using busines.Interface;
using data.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CRMTest
{
    [TestFixture(typeof(AdminManager))]
    //[TestFixture(typeof(HRManager))]
    //[TestFixture(typeof(TeacherManager))]
    public class Tests<TUser> where TUser : UserManager, new()
    {
        UserManager user;

        [SetUp]
        public void Setup()
        {
            this.user = new TUser();
        }

        [Test]
        [TestCase<Lead>()]
        public void TestGet<T>() where T : new()
        {
            List<T> listObj = user.Get<T>().ToList();
            Assert.AreEqual(listObj[0], new Lead());

        }
    }
}