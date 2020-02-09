using System;
using System.Collections.Generic;
using System.Text;
using data;
using data.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace busines.Cache
{
    class CacheTeacher
    {
        public Teacher concreatTeacher { get; set; }
        public List<Lead> Leads { get; set; }
        public List<Course> Courses { get; set; }
        public List<Group> Groups { get; set; }
        public List<History> Histories { get; set; }
        public List<HistoryGroup> HistoryGroups { get; set; }
        public List<Log> Logs { get; set; }
        public List<Skills> Skills { get; set; }
        public List<SkillsLead> SkillsLeads { get; set; }
        
        public CacheTeacher (Teacher teacher)
        {
            concreatTeacher = teacher;
            this.Set();
        }

        private void Set()
        {
            Storage _storage = new Storage();
            Groups = (List<Group>)_storage.GetAll<Group>(concreatTeacher.Id);
            Leads = (List<Lead>)_storage.GetAll<Lead>(Groups);
            Courses = (List<Course>)_storage.GetAll<Course>(Groups);
            Histories = (List<History>)_storage.GetAll<History>(Leads);
            HistoryGroups = (List<HistoryGroup>)_storage.GetAll<HistoryGroup>(Groups);
            Logs = (List<Log>)_storage.GetAll<Log>(Groups);
            Skills = (List<Skills>)_storage.GetAll<Skills>();
            SkillsLeads = (List<SkillsLead>)_storage.GetAll<SkillsLead>(Leads);
        }
    }
}
