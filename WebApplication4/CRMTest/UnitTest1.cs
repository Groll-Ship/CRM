using busines;
using busines.Interface;
using data.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CRMTest
{
    [TestFixture(typeof(AdminManager))]
    [TestFixture(typeof(HRManager))]
    //[TestFixture(typeof(TeacherManager))]
    public class Tests<TUser> where TUser : UserManager, new()
    {
        UserManager user;

        [SetUp]
        public void Setup()
        {
            this.user = new TUser();
        }

        [GenericTestCase(typeof(Lead))]
        [GenericTestCase(typeof(Teachers))]
        [GenericTestCase(typeof(Admin))]
        [GenericTestCase(typeof(Course))]
        [GenericTestCase(typeof(Group))]
        [GenericTestCase(typeof(History))]
        [GenericTestCase(typeof(Status))]
        [GenericTestCase(typeof(Skills))]
        public void TestGet<U>() where U: new ()
        {            
            List<U> listObj = user.Get<U>().ToList();
            Assert.IsTrue(listObj[0] is U);
        }
    }
}