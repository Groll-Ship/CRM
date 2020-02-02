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

        public bool DeleteCourseById(int id) { return _storage.Delete<Course, int>(id); }
        public bool DeleteGroupByName(string name) { return _storage.Delete<Group, string>(name); }
        public bool DeleteHRById(int id) { return _storage.Delete<Admin, int>(id); }
        public bool DeleteLeadById(int id) { return _storage.Delete<Lead, int>(id); }
        public bool DeleteSkillsById(int id) { return _storage.Delete<Skills, int>(id); }

        /// <summary>
        /// Delete lead skill by lead ID and skill ID
        /// </summary>
        /// <param name="leadId">Lead ID</param>
        /// <param name="skillId">Skill ID</param>
        /// <returns></returns>
        public bool DeleteLeadSkillById(int leadId, int skillId) { return _storage.Delete<SkillsLead, int, int>(leadId, skillId); }

        public bool DeleteStatusById(int id) { return _storage.Delete<Status, int>(id); }
        public bool DeleteTeacherById(int id) { return _storage.Delete<Teachers, int>(id); }

        #endregion

    }
}
