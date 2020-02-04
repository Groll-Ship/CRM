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
            foreach (Group item in listresult)
                Assert.AreEqual(teacher.Id, item.TeacherId);
        }
        [Test]
        public void TestGetAllLeads()
        {
            List<Lead> listresult = teacherManager.GetAllLeads().ToList();
            foreach (Lead item in listresult)
                Assert.AreEqual(teacher.Id, item.Group.TeacherId);
        }
        [Test]
        public void TestGetHistoryGroup()
        {
            Group group = new Group() { NameGroup = "C#001" };
            List<HistoryGroup> listresult = teacherManager.GetHistoryGroup(group).ToList();
            foreach (HistoryGroup item in listresult)
                Assert.AreEqual(group.NameGroup, item.GroupName);
        }
        [Test]
        public void TestGetLeadsGroup()
        {
            Group group = new Group() { NameGroup = "C#001" };
            List<Lead> listresult = teacherManager.GetLeadsGroup(group).ToList();
            foreach (Lead item in listresult)
                Assert.AreEqual(group.NameGroup, item.NameGroup);
        }
        [Test]
        public void TestGetHistory()
        {
            Lead lead = new Lead() { Id = 1 };
            List<History> listresalt = teacherManager.GetHistory(lead).ToList();
            foreach (History item in listresalt)
                Assert.AreEqual(lead.Id, item.LeadId);
        }
        [Test]
        public void TestGetLogLead()
        {
            Lead lead = new Lead() { Id = 1 };
            List<Log> listresult = teacherManager.GetLogLead(lead).ToList();
            foreach (Log item in listresult)
                Assert.AreEqual(lead.Id, item.LeadId);
        }
        [Test]
        public void TestGetLogGroup()
        {
            Group group = new Group() { NameGroup = "C#001" };
            List<Log> listresult = teacherManager.GetLogGroup(group).ToList();
            foreach (Log item in listresult)
                Assert.AreEqual(group.NameGroup, item.Lead.NameGroup);
        }
        [Test]
        public void TestGetSkillsLead()
        {
            Lead lead = new Lead() { Id = 1 };
            List<SkillsLead> listresult = teacherManager.GetSkillsLead(lead).ToList();
            foreach (SkillsLead item in listresult)
                Assert.AreEqual(lead.Id, item.LeadId);
        }
        [Test]
        public void TestGetSkills()
        {
            List<Skills> listresult = teacherManager.GetSkills().ToList();
            foreach (Skills item in listresult)
                Assert.IsInstanceOf(typeof(Skills), item);
        }
        [TestCase(true, ExpectedResult = true)]
        public bool TestChangeAccessStatusOfLead(bool accessStatus)
        {
            Lead lead = new Lead();
            return teacherManager.ChangeAccessStatusOfLead(lead, accessStatus);
        }
        //[TestCase()]
        //public bool TestAddSkillsForlead(params Skills[] skills)
        //{
        //    Lead lead = new Lead();
        //    return teacherManager.AddSkillsForlead(lead, skills);
        //}
    }
}
