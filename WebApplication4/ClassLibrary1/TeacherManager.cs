using busines.Interface;
using CRMTest.stab;
using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace busines
{
    public class TeacherManager: UserManager
    {
        
        Teachers _teacher;
        public TeacherManager(Teachers teacher)
        {
            _teacher = teacher;
            _storage = new StabStorage(this);

        }

        public IEnumerable<Group> GetGroups() {
            IEnumerable<IEntity> groupsprimari = _storage.GetAll<Group>(_teacher);
            List<Group> groups = (List<Group>)groupsprimari;
            return groups;
        }
        public IEnumerable<Lead> GetAllLeads() { return _storage.GetAll<Lead>(_teacher); }
        public IEnumerable<HistoryGroup> GetHistoryGroup(Group group) { return _storage.GetAll<HistoryGroup>(group); }
        public IEnumerable<Lead> GetLeadsGroup(Group group) { return _storage.GetAll<Lead>(group); }
        public IEnumerable<History> GetHistory(Lead lead) { return _storage.GetAll<History>(lead); }
        public IEnumerable<Log> GetLog(Lead lead) { return _storage.GetAll<Log>(lead); }
        public IEnumerable<SkillsLead> GetSkillsLead(Lead lead) { return _storage.GetAll<SkillsLead>(lead); }
        public IEnumerable<Skills> GetSkills() { return _storage.GetAll<Skills>(); }
        public void ChangeAccessStatusOfLead(Lead lead, bool accessStatus) { lead.AccessStatus = accessStatus; _storage.Update<Lead>(lead); }
        public void AddSkillsForlead(Lead lead, params Skills[] skills)
        {
            for (int i = 0; i < skills.Length; i++)
                _storage.Add<SkillsLead, Lead, Skills>(lead, skills[i]);
        }
        public void AddAttendance(List<Lead> leads, DateTime dateTime)
        {
            foreach (Lead item in leads)
            {
                _storage.Add<Log, Lead, DateTime>(item, dateTime);
            }
        }
        public void AddCommentToLead(Lead lead, string comment)
        {
            _storage.Add<History, Lead, string>(lead, DateTime.Now.ToString() + " " + comment);
        }
        public void AddCommentToAllLeadGroupe(Group group, string comment)
        {
            _storage.Add<History, Group, string>(group, DateTime.Now.ToString() + " " + comment);
        }
        public void AddHistoryGroup(Group group, string comment)
        {
            _storage.Add<HistoryGroup, Group, string>(group, DateTime.Now.ToString() + " " + comment);
        }

    }
}   
