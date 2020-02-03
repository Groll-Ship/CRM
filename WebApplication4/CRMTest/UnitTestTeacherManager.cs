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
        Teacher teacher;
        [SetUp]
        public void SetUp()
        {
            teacher = new Teacher() { Id = 1, FName = "Bob", SName = "Cmith" };
            teacherManager = new TeacherManager(teacher);
        }

        [Test]
        public void TestGetGroups()
        {
            List<Group> listresult = teacherManager.GetGroups().ToList();
            foreach(Group item in listresult)
            {
                Assert.AreEqual(teacher.Id, item.TeacherId);
            }
        }
        [Test]
        public void TestGetAllLeads()
        {
            List<Lead> listresult = teacherManager.GetAllLeads().ToList();
            foreach(Lead item in listresult)
            {
                Assert.AreEqual(teacher.Id, item.Group.TeacherId);
            }
        }
        [Test]
        public void TestGetHistoryGroup()
        {
            Group group = new Group() { NameGroup = "C#001"};
            List<HistoryGroup> listresult = teacherManager.GetHistoryGroup(group).ToList();
            foreach(HistoryGroup item in listresult)
            {
                Assert.AreEqual(group.NameGroup, item.GroupName);
            }
        }
        [Test]
        public void TestGetLeadsGroup()
        {
            Group group = new Group() { NameGroup = "C#001" };
            List<Lead> listresult = teacherManager.GetLeadsGroup(group).ToList();
            foreach(Lead item in listresult)
            {
                Assert.AreEqual(group.NameGroup, item.NameGroup);
            }
        }
    }
}
