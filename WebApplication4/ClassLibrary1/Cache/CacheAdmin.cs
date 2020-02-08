using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace busines.Cache
{
    public class CacheAdmin
    {
        private List<Lead> leads;
        public List<Lead> Leads  {  get { if (flagActual) { return leads; } else { Set(); return leads; } }set { leads = value; } }
        public List<Course> Courses { get; set; } 
        public List<Group> Groups { get; set; }
        public List<History> Histories { get; set; }
        public List<HistoryGroup> HistoryGroups { get; set; }
        public List<HR> HRs { get; set; }
        public List<Log> Logs { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Skills> Skills { get; set; }
        public List<SkillsLead> SkillsLeads { get; set; }
        public List<Status> Statuses { get; set; }

        private static bool flagActual;
        public DateTime TimeActual { get; set; }
      

        public CacheAdmin()
        {
            this.Set();
            CheckActualAsync();
            PablisherChangesInBD pablisher = PablisherChangesInBD.GetPablisher();
            pablisher.Event += this.ReadChange;
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
            Logs = (List<Log>)_storage.GetAll<Log>();
            Teachers = (List<Teacher>)_storage.GetAll<Teacher>();
            Skills = (List<Skills>)_storage.GetAll<Skills>();
            SkillsLeads = (List<SkillsLead>)_storage.GetAll<SkillsLead>();
            Statuses = (List<Status>)_storage.GetAll<Status>();
            flagActual = true;
        }

        public void ReadChange(IEntity _entity){ flagActual = false;  }
        private async void CheckActualAsync()
        {
            await Task.Run(() => Checked());
        }
        private Task Checked()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (flagActual == false)
                    Set();
            }
        }
    }
}
