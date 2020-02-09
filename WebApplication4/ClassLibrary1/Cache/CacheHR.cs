using System;
using System.Collections.Generic;
using System.Text;
using data;
using data.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace busines
{
    class CacheHR
    {
        public List<Lead> Leads { get; set; }
        public List<Course> Courses { get; set; }
        public List<Group> Groups { get; set; }
        public List<History> Histories { get; set; }
        public List<HistoryGroup> HistoryGroups { get; set; }
        public List<HR> HRs { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Skills> Skills { get; set; }
        public List<SkillsLead> SkillsLeads { get; set; }
        public List<Status> Statuses { get; set; }

        public CacheHR ()
        {
            this.Set();
        }

        private void Set()
        {
            Storage _storage = new Storage();
            Leads = (List<Lead>)_storage.GetAll<Lead>();
            Courses = (List<Course>)_storage.GetAll<Course>();
            Groups = (List<Group>)_storage.GetAll<Group>();
            Histories = (List<History>)_storage.GetAll<History>();
            HistoryGroups = (List<HistoryGroup>)_storage.GetAll<HistoryGroup>();
            HRs = (List<HR>)_storage.GetAll<HR>();
            Teachers = (List<Teacher>)_storage.GetAll<Teacher>();
            Skills = (List<Skills>)_storage.GetAll<Skills>();
            SkillsLeads = (List<SkillsLead>)_storage.GetAll<SkillsLead>();
            Statuses = (List<Status>)_storage.GetAll<Status>();

        }

    }


}
