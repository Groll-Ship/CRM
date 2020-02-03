using busines;
using busines.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace CRMTest.stab
{
    public class StabStorage
    {
        object _user;
        public StabStorage(object user)
        {
            _user = user;
        }

        public IEnumerable<IEntity> GetAll<T>(params object[] arg) where T : new()
        {
            T proverka = new T();
            if (proverka is Group) { return new List<Group>() { new Group() { TeacherId = 1, NameGroup = "C#001" } }; }
            if (proverka is Lead) { return new List<Lead>() { new Lead() { NameGroup = "C#001", Group = new Group() { TeacherId = 1 } } }; }
            if (proverka is HistoryGroup) { return new List<HistoryGroup> { new HistoryGroup { GroupName = "C#001" } }; }
            if (proverka is History) { return new List<History> { new History { LeadId = 1 } }; }
            if (proverka is Log) { return new List<Log> { new Log { LeadId = 1, Lead = new Lead { NameGroup = "C#001" } } }; }
            if (proverka is SkillsLead) { return new List<SkillsLead> { new SkillsLead { LeadId = 1 } }; }
            if (proverka is Skills) { return new List<Skills> { new Skills() }; }
            return new List<IEntity>();
        }
        public bool Update(IEntity obj)
        {
            return true;
        }
        internal bool Delete(IEntity obj)
        {
            return true;
        }
        public bool Add(IEntity obj) 
        {
            return true;
        }

        
    }
}
