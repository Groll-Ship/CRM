using data.Models;
using System;
using System.Collections.Generic;

namespace busines
{
    public class AdminManager: UserManager
    {
        HRManager _hrManager;
        public AdminManager()
        {
            _hrManager = new HRManager();
        }

        #region GET 

        public IEnumerable<IEntity> GetAll<T>(params IEntity[] entity) where T: new ()
        {
            return _storage.GetAll<T>(entity);
        }

        #endregion

        #region CREAT 

        public bool CreatLead(object obj, Group group, Status status, Course course)
        {
            return _hrManager.AddLead(obj, group, status, course);
        }

        public bool CreatTeacher(object obj)
        {
            return _hrManager.AddTeacher(obj);
        }

        public bool CreatHR(Object obj)
        {
            var dictionary = DeserializeObjectTodictionary(obj);
            Teacher teacher = new Teacher()
            {
                FName = (dictionary.ContainsKey("FName")) ? dictionary["FName"] : "",
                SName = (dictionary.ContainsKey("SName")) ? dictionary["SName"] : "",
            };
            return _storage.Add(teacher);
        }
        #endregion

        #region UPDATE 



        #endregion

        #region DELETE

        public bool DeleteCourse(Course course) { return _storage.Delete(course); }
        public bool DeleteGroup(Group group) { return _storage.Delete(group); }
        public bool DeleteHR(HR hr) { return _storage.Delete(hr); }
        public bool DeleteLead(Lead lead) { return _storage.Delete(lead); }
        public bool DeleteSkill(Skills skill) { return _storage.Delete(skill); }

        /// <summary>
        /// Delete lead skill by lead ID and skill ID
        /// </summary>
        /// <param name="leadId">Lead ID</param>
        /// <param name="skillId">Skill ID</param>
        /// <returns></returns>
        public bool DeleteLeadSkill(Lead lead, Skills skill)
        {
            SkillsLead skillsLead = new SkillsLead() { Lead = lead, LeadId = lead.Id, Skill = skill, SkillsId = skill.Id };
            return _storage.Delete(skillsLead); 
        }

        public bool DeleteStatus(Status status) { return _storage.Delete(status); }
        public bool DeleteTeacher(Teacher teacher) { return _storage.Delete(teacher); }

        #endregion
        

    }
}
