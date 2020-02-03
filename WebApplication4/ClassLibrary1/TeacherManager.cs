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
        
        Teacher _teacher;
        public TeacherManager(Teacher teacher)
        {
            _teacher = teacher;
            _storage = new StabStorage(this);

        }

        public IEnumerable<Group> GetGroups() {
            IEnumerable<IEntity> groupsprimari = _storage.GetAll<Group>(_teacher);
            List<Group> groups = (List<Group>)groupsprimari;
            return groups;
        }

        public IEnumerable<Lead> GetAllLeads() { return (List<Lead>)_storage.GetAll<Lead>(_teacher); }
        public IEnumerable<HistoryGroup> GetHistoryGroup(Group group) { return (List<HistoryGroup>)_storage.GetAll<HistoryGroup>(group); }
        public IEnumerable<Lead> GetLeadsGroup(Group group) { return (List<Lead>)_storage.GetAll<Lead>(group); }
        public IEnumerable<History> GetHistory(Lead lead) { return (List<History>)_storage.GetAll<History>(lead); }
        public IEnumerable<Log> GetLogLead(Lead lead) { return (List<Log>)_storage.GetAll<Log>(lead); }
        public IEnumerable<Log> GetLogGrop(Group group) { return (List<Log>)_storage.GetAll<Log>(group); }
        public IEnumerable<SkillsLead> GetSkillsLead(Lead lead) { return (List<SkillsLead>)_storage.GetAll<SkillsLead>(lead); }
        public IEnumerable<Skills> GetSkills() { return (List<Skills>)_storage.GetAll<Skills>(); }
        public bool ChangeAccessStatusOfLead(Lead lead, bool accessStatus) { lead.AccessStatus = accessStatus; return _storage.Update(lead); }
        public void AddSkillsForlead(Lead lead, params Skills[] skills)
        {
            for (int i = 0; i < skills.Length; i++)
            {
                SkillsLead skillsLead = new SkillsLead(){
                    Lead = lead,
                    LeadId = lead.Id,
                    Skill = skills[i],
                    SkillsId = skills[i].Id
                };
                _storage.Add(skillsLead);
            }

        }
        public void AddAttendance(List<Lead> leads, DateTime dateTime)
        {
            foreach (Lead item in leads)
            {
                Log log = new Log() { 
                    LeadId = item.Id, 
                    Lead = item, 
                    Date = dateTime 
                };
                _storage.Add(log);
            }
        }
        public void AddCommentToLead(Lead lead, string comment)
        {
            History history = new History() { 
                LeadId = lead.Id, Lead = lead, 
                HistoryText = DateTime.Now.ToString() + " " + comment 
            };
            _storage.Add(history);
        }
        public void AddCommentToAllLeadGroupe(Group group, string comment)
        {
            List<Lead> leds = (List<Lead>)_storage.GetAll<Lead>(group);
            foreach(Lead item in leds){
                History history = new History(){
                    LeadId = item.Id,
                    Lead = item,
                    HistoryText = DateTime.Now.ToString() + " " + comment
                };
                _storage.Add(history);
            }
        }
        public void AddHistoryGroup(Group group, string comment)
        {
            HistoryGroup historyGroup = new HistoryGroup{
                Group = group,
                GroupName = group.NameGroup,
                HistoryText = DateTime.Now.ToString() + " " + comment
            };
            _storage.Add(historyGroup);
        }

    }
}   
