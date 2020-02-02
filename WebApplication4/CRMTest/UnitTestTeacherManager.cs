using busines;
using busines.Interface;
using data.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CRMTest
{
    class UnitTestTeacherManager
    {
        TeacherManager teacherManager;
        Teachers teacher;
        [SetUp]
        public void SetUp()
        {
            teacher = new Teachers() { Id = 1, FName = "Bob", SName = "Cmith" };
            teacherManager = new TeacherManager(teacher);
        }

        [Test]
        public void TestGetGroups()
        {
            IList<Group> listresult = teacherManager.GetGroups().ToList();
            int idresult = listresult[0].TeacherId;

            Assert.AreEqual(idresult, teacher.Id);
        }
        //[Test]
        //public void TestGetAllLeads()
        //{
        //    IList<Lead> listresult = teacherManager.GetAllLeads().ToList();
        //    Assert.IsTrue(listresult[0] is Lead);
        //}
    }
}
