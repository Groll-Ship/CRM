using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data
{
    public class Delete : ICommand
    {
        public ApplicationContext db { get; set; }

        public List<IEntity> Execute<T>(int ID) where T : IEntity, new()
        {
            using (ApplicationContext db = new ApplicationContext())
            {                
                T obj = new T();

                if (obj is Lead)
                {
                    Lead lead = db.Leads.Find(ID);
                    if (lead != null)
                    {
                        db.Leads.Remove(lead);
                        db.SaveChanges();
                    }
                }
                else if (obj is Course)
                {
                    Course course = db.Courses.Find(ID);
                    if (course != null)
                    {
                        db.Courses.Remove(course);
                        db.SaveChanges();
                    }
                }
                else if (obj is History)
                {
                    History hist = db.Historys.Find(ID);
                    if (hist != null)
                    {
                        db.Historys.Remove(hist);
                        db.SaveChanges();
                    }
                }
                else if (obj is HistoryGroup)
                {
                    HistoryGroup hist = db.HistoryGroups.Find(ID);
                    if (hist != null)
                    {
                        db.HistoryGroups.Remove(hist);
                        db.SaveChanges();
                    }
                }
                else if (obj is HR)
                {
                    HR hr = db.HRs.Find(ID);
                    if (hr != null)
                    {
                        db.HRs.Remove(hr);
                        db.SaveChanges();
                    }
                }
                else if (obj is Log)
                {
                    Log log = db.Logs.Find(ID);
                    if (log != null)
                    {
                        db.Logs.Remove(log);
                        db.SaveChanges();
                    }
                }
                else if (obj is Skills)
                {
                    Skills skill = db.Skills.Find(ID);
                    if (skill != null)
                    {
                        db.Skills.Remove(skill);
                        db.SaveChanges();
                    }
                }
                else if (obj is Status)
                {
                    Status status = db.Statuss.Find(ID);
                    if (status != null)
                    {
                        db.Statuss.Remove(status);
                        db.SaveChanges();
                    }
                }
                else if (obj is SkillsLead)
                {
                    SkillsLead skill = db.SkillsLeads.Find(ID);
                    if (skill != null)
                    {
                        db.SkillsLeads.Remove(skill);
                        db.SaveChanges();
                    }
                }
                else if (obj is Teachers)
                {
                    Teachers teacher = db.Teacherss.Find(ID);
                    if (teacher != null)
                    {
                        db.Teacherss.Remove(teacher);
                        db.SaveChanges();
                    }
                }
                else if (obj is Group)
                {
                    Group group = db.Groups.Find(ID);
                    if (group != null)
                    {
                        db.Groups.Remove(group);
                        db.SaveChanges();
                    }
                }
            }
            return new List<IEntity>();
        }
    }
}
