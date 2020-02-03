using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data
{
    public class Create :ICommand
    {
        public ApplicationContext db { get; set; }

        public void Execute<T>(IEntity newObject) where T : IEntity, new()
        {
            using (ApplicationContext db = new ApplicationContext())
            {                
                if (newObject is Lead)
                {
                    Lead lead = new Lead();
                    if (lead != null)
                    {
                        lead = (Lead)newObject;
                        db.Leads.Add(lead);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Course)
                {
                    Course course = new Course();
                    if (course != null)
                    {
                        course = (Course)newObject;
                        db.Courses.Add(course);
                        db.SaveChanges();
                    }
                }
                else if (newObject is History)
                {
                    History hist = new History();
                    if (hist != null)
                    {
                        hist = (History)newObject;
                        db.Historys.Add(hist);
                        db.SaveChanges();
                    }
                }
                else if (newObject is HistoryGroup)
                {
                    HistoryGroup hist = new HistoryGroup();
                    if (hist != null)
                    {
                        hist = (HistoryGroup)newObject;
                        db.HistoryGroups.Add(hist);
                        db.SaveChanges();
                    }
                }
                else if (newObject is HR)
                {
                    HR hr = new HR();
                    if (hr != null)
                    {
                        hr = (HR)newObject;
                        db.HRs.Add(hr);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Log)
                {
                    Log log = new Log();
                    if (log != null)
                    {
                        log = (Log)newObject;
                        db.Logs.Add(log);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Skills)
                {
                    Skills skills = new Skills();
                    if (skills != null)
                    {
                        skills = (Skills)newObject;
                        db.Skills.Add(skills);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Status)
                {
                    Status status = new Status();
                    if (status != null)
                    {
                        status = (Status)newObject;
                        db.Statuss.Add(status);
                        db.SaveChanges();
                    }
                }
                else if (newObject is SkillsLead)
                {
                    SkillsLead skills = new SkillsLead();
                    if (skills != null)
                    {
                        skills = (SkillsLead)newObject;
                        db.SkillsLeads.Add(skills);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Teachers)
                {
                    Teachers teacher = new Teachers();
                    if (teacher != null)
                    {
                        teacher = (Teachers)newObject;
                        db.Teacherss.Add(teacher);
                        db.SaveChanges();
                    }
                }
                else if (newObject is Group)
                {
                    Group group = new Group();
                    if (group != null)
                    {
                        group = (Group)newObject;
                        db.Groups.Add(group);
                        db.SaveChanges();
                    }
                }
            }
            
        }
    }
}
