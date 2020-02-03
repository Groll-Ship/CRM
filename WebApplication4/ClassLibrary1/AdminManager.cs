using busines.Interface;
using data.Models;
using System.Collections.Generic;

namespace busines
{
    public class AdminManager: UserManager
    {
        #region GET 



        #endregion

        #region CREAT 

        //creat HR
        
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
