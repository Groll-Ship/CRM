using busines;
using data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRMTest
{
    class UnitTestHRManager
    {
        HRManager hrManager;
        Teacher teacher;
        Course course;
        Status status;
        Group group;
        Lead lead;

        static string[] objCases = new string[] { "course", "group", "hr", "lead", "teacher" };

        static object[] CourseCases = new object[] 
        {
            new Course()  { Id = 1, Name = "C#", CourseInfo = "C# Information" },
            new Course()  { Id = 2, Name = "Web", CourseInfo = "Web Information" },
            new Course()  { Id = 3, Name = "QA", CourseInfo = "QA Information" },
        };
        static object[] GroupCases = new object[] 
        {
            new Group() { TeacherId = 1, NameGroup = "C#001" },
        };
        static object[] HRCases = new object[]
        {
            new HR()  { Id = 1,FName = "HR Name", SName = "HR Second Name"  },
            new HR()  { Id = 2,FName = "HR2 Name", SName = "HR2 Second Name" },
        };
        static object[] LeadCases = new object[]
        {
            new Lead() { NameGroup = "C#001", Group = new Group() { TeacherId = 1 } }
        };
        static object[] TeacherCases = new object[]
        {
            new Teacher()  { Id = 1, FName = "Teacher Name", SName = "Teacher Second Name"},
            new Teacher()  { Id = 2, FName = "Teacher2 Name", SName = "Teacher2 Second Name" },

        };
        static object[] LeadHistoryCases = new object[]
        {
            new History { LeadId = 1 }
        };
        static object[] GroupHistoryCases = new object[]
        {
            new HistoryGroup { GroupName = "C#001" }
        };

        [SetUp]
        public void SetUp()
        {
            teacher = new Teacher() { Id = 1, FName = "Bob", SName = "Cmith" };
            hrManager = new HRManager();
            course = new Course() { Id = 1, Name = "C#", CourseInfo = "C# Information" };
            status = new Status() { Id = 1, Name = "New" };
            group = new Group() { TeacherId = 1, NameGroup = "C#001" };
            lead = new Lead() { NameGroup = "C#001", Group = new Group() { TeacherId = 1 } };
        }
        #region Not NULL
        [Test, TestCaseSource("objCases")]
        public void TestNotNullGetObj(string objName)
        {
            if (objName == "course")
            {
                List<Course> result = hrManager.GetCourses().ToList();
                Assert.That(result, Is.All.Not.Null);
            }
            else if (objName == "group")
            {
                List<Group> result = hrManager.GetGroups().ToList();
                Assert.That(result, Is.All.Not.Null);
            }
            else if (objName == "lead")
            {
                List<Lead> result = hrManager.GetLeads(status).ToList();
                Assert.That(result, Is.All.Not.Null);
            }
            else if (objName == "hr")
            {
                List<HR> result = hrManager.GetHRs().ToList();
                Assert.That(result, Is.All.Not.Null);
            }
            else if (objName == "teacher")
            {
                List<Teacher> result = hrManager.GetTeachers().ToList();
                Assert.That(result, Is.All.Not.Null);
            }
        }

        [Test]
        public void TestNotNullGetGroupsForCourse()
        {
            List<Group> result = hrManager.GetGroupsForCourse(course).ToList();
            Assert.That(result, Is.All.Not.Null);
        }

        [Test, TestCaseSource("objCases")]
        public void TestNotNullGetTeacherObj(string objName)
        {
            if (objName == "course")
            {
                List<Course> result = hrManager.GetTeacherCourses(teacher).ToList();
                Assert.That(result, Is.All.Not.Null);
            }
            else if (objName == "group")
            {
                List<Group> result = hrManager.GetTeacherGroups(teacher).ToList();
                Assert.That(result, Is.All.Not.Null);
            }
        }

        #endregion

        #region Not EMPTY

        [Test, TestCaseSource("objCases")]
        public void TestNotEmptyGetObj(string objName)
        {
            if (objName == "course")
            {
                List<Course> result = hrManager.GetCourses().ToList();
                Assert.That(result, Is.Not.Empty);
            }
            else if (objName == "group")
            {
                List<Group> result = hrManager.GetGroups().ToList();
                Assert.That(result, Is.Not.Empty);
            }
            else if (objName == "hr")
            {
                List<HR> result = hrManager.GetHRs().ToList();
                Assert.That(result, Is.Not.Empty);
            }
            else if (objName == "teacher")
            {
                List<Teacher> result = hrManager.GetTeachers().ToList();
                Assert.That(result, Is.Not.Empty);
            }
            Assert.IsTrue(true);
        }

        #endregion

        #region Check TYPE
        
        [Test, TestCaseSource("objCases")]
        public void TestTypeGetObj(string objName)
        {
            if (objName == "course")
            {
                List<Course> result = hrManager.GetCourses().ToList();
                Assert.That(result, Is.All.TypeOf(typeof(Course)));
            }
            else if (objName == "group")
            {
                List<Group> result = hrManager.GetGroups().ToList();
                Assert.That(result, Is.All.TypeOf(typeof(Group)));
            }
            else if (objName == "lead")
            {
                List<Lead> result = hrManager.GetLeads(status).ToList();
                Assert.That(result, Is.All.TypeOf(typeof(Lead)));
            }
            else if (objName == "hr")
            {
                List<HR> result = hrManager.GetHRs().ToList();
                Assert.That(result, Is.All.TypeOf(typeof(HR)));
            }
            else if (objName == "teacher")
            {
                List<Teacher> result = hrManager.GetTeachers().ToList();
                Assert.That(result, Is.All.TypeOf(typeof(Teacher)));
            }
        }


        #endregion

        #region Check Unique

        [Test]
        public void TestUniqueGetCourses()
        {
            List<Course> result = hrManager.GetCourses().ToList(); 
            Assert.That(result, Is.Unique);
        }

        [Test, TestCaseSource("objCases")]
        public void TestUniqueGetObj(string objName)
        {
            if (objName == "course")
            {
                List<Course> result = hrManager.GetCourses().ToList();
                Assert.That(result, Is.Unique);
            }
            else if (objName == "group")
            {
                List<Group> result = hrManager.GetGroups().ToList();
                Assert.That(result, Is.Unique);
            }
            else if (objName == "lead")
            {
                List<Lead> result = hrManager.GetLeads(status).ToList();
                Assert.That(result, Is.Unique);
            }
            else if (objName == "hr")
            {
                List<HR> result = hrManager.GetHRs().ToList();
                Assert.That(result, Is.Unique);
            }
            else if (objName == "teacher")
            {
                List<Teacher> result = hrManager.GetTeachers().ToList();
                Assert.That(result, Is.Unique);
            }
        }
        #endregion

        #region Check Object Items
        [Test, TestCaseSource("CourseCases")]
        public void TestMembersGetCourses(Course c)
        {
            List<Course> result = hrManager.GetCourses().ToList();
            bool testResult = false;
            foreach (var course in result)
            {
                if (course.Name != c.Name) continue;
                if (course.Id != c.Id) continue;
                if (course.CourseInfo != c.CourseInfo) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("CourseCases")]
        public void TestMembersGetTeacherCourses(Course c)
        {
            List<Course> result = hrManager.GetTeacherCourses(teacher).ToList();
            bool testResult = false;
            foreach (var course in result)
            {
                if (course.Name != c.Name) continue;
                if (course.Id != c.Id) continue;
                if (course.CourseInfo != c.CourseInfo) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("GroupCases")]
        public void TestMembersGetGroups(Group g)
        {
            List<Group> result = hrManager.GetGroups().ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.NameGroup != g.NameGroup) continue;
                if (item.TeacherId != g.TeacherId) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("GroupCases")]
        public void TestMembersGetTeacherGroups(Group g)
        {
            List<Group> result = hrManager.GetTeacherGroups(teacher).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.NameGroup != g.NameGroup) continue;
                if (item.TeacherId != g.TeacherId) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("GroupCases")]
        public void TestMembersGetGroupsForCourse(Group g)
        {
            List<Group> result = hrManager.GetGroupsForCourse(course).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.NameGroup != g.NameGroup ) continue;
                if (item.TeacherId != g.TeacherId ) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("HRCases")]
        public void TestMembersGetHR(HR hr)
        {
            List<HR> result = hrManager.GetHRs().ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.Id != hr.Id) continue;
                if (item.SName != hr.SName) continue;
                if (item.FName != hr.FName) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("LeadCases")]
        public void TestMembersGetLeads(Lead l)
        {
            List<Lead> result = hrManager.GetLeads(status).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.NameGroup != l.NameGroup) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("LeadCases")]
        public void TestMembersGetLeadsForGroup(Lead l)
        {
            List<Lead> result = hrManager.GetLeadsForGroup(group).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.NameGroup != l.NameGroup) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("TeacherCases")]
        public void TestMembersGetTeachers(Teacher t)
        {
            List<Teacher> result = hrManager.GetTeachers().ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.Id != t.Id) continue;
                if (item.FName != t.FName) continue;
                if (item.SName != t.SName) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("LeadHistoryCases")]
        public void TestMembersGetLeadHistory(History h)
        {
            List<History> result = hrManager.GetLeadHistory(lead).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.LeadId != h.LeadId) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        [Test, TestCaseSource("GroupHistoryCases")]
        public void TestMembersGetGroupHistory(HistoryGroup h)
        {
            List<HistoryGroup> result = hrManager.GetGroupHistory(group).ToList();
            bool testResult = false;
            foreach (var item in result)
            {
                if (item.GroupName != h.GroupName) continue;
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }

        #endregion


    }
}
