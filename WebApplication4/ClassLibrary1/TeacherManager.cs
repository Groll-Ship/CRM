﻿using busines.Interface;
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
        //public bool AddSkillsForlead(Lead lead, params Skills[] skills)
        //{
         //   for (int i = 0; i < skills.Length; i++)
        //        _storage.Add<SkillsLead, Lead, Skills>(lead, skills[i]);
        //}
        //public void AddAttendance(List<Lead> leads, DateTime dateTime)
        //{
        //    foreach (Lead item in leads)
        //    {
        //        _storage.Add<Log, Lead, DateTime>(item, dateTime);
        //    }
        //}
        //public void AddCommentToLead(Lead lead, string comment)
        //{
        //    History history = new History() {LeadId = lead.Id, Lead = lead, HistoryText = DateTime.Now.ToString() + " " + comment };
        //    _storage.Add(history);
        //}
        //public void AddCommentToAllLeadGroupe(Group group, string comment)
        //{
        //    _storage.Add<History, Group, string>(group, DateTime.Now.ToString() + " " + comment);
        //}
        //public void AddHistoryGroup(Group group, string comment)
        //{
        //    _storage.Add<HistoryGroup, Group, string>(group, DateTime.Now.ToString() + " " + comment);
        //}

    }
}   
