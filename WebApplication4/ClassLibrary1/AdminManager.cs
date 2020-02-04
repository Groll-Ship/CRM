using busines.Interface;
using data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace busines
{
    public class AdminManager: UserManager
    {

        #region GET 

        public IEnumerable<IEntity> GetAll<T>(params IEntity[] entity) where T: new ()
        {
            return _storage.GetAll<T>(entity);
        }

        #endregion

        #region CREAT 

        public bool CreatLead(object obj, Group group, Status status, Course course)
        {
            
            string str = obj.ToString();
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(str);

            Lead lead = new Lead(){
                FName = (dictionary.ContainsKey("FName")) ? dictionary["FName"] : "",
                SName = (dictionary.ContainsKey("SName")) ? dictionary["SName"] : "",
                DateBirthday = (dictionary.ContainsKey("DateBirthday")) ? dictionary["DateBirthday"] : "",
                DateRegistration = DateTime.Now.ToString(),
                Numder = (dictionary.ContainsKey("Numder")) ? StringToInt(dictionary["Numder"]) : 0,
                EMail = (dictionary.ContainsKey("EMail")) ? dictionary["EMail"] : "",
                AccessStatus = false,
                //NameGroup = group.NameGroup,
                Group = group,
                //CourseId = course.Id,
                Course = course,
                //StatusId = status.Id,
                Status = status,
            };
            _storage.Add(lead);

            History history = new History(){
                Lead = lead,
                HistoryText = DateTime.Now.ToString() + "  Студент зарегестрирован.",
            };
            _storage.Add(history);

            return true;
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
        private int StringToInt(string str)
        {
            return int.TryParse(str, out int number) ? number : 0;
        }

    }
}
