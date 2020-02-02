using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data
{
    public class Update : ICommand
    {
        public ApplicationContext db { get; set; }

        public void Execute<T>(IEntity objForUpdate, int ID) where T : IEntity, new()
        {
            using (ApplicationContext db = new ApplicationContext())
            {       

                if (objForUpdate is Lead)
                {
                    Lead lead = db.Leads.Find(ID);
                    if (lead != null)
                    {
                        lead = (Lead)objForUpdate;
                        db.Leads.Update(lead);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Course)
                {
                    Course course = db.Courses.Find(ID);
                    if (course != null)
                    {
                        course = (Course)objForUpdate;
                        db.Courses.Update(course);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is History)
                {
                    History hist = db.Historys.Find(ID);
                    if (hist != null)
                    {
                        hist = (History)objForUpdate;
                        db.Historys.Update(hist);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is HistoryGroup)
                {
                    HistoryGroup hist = db.HistoryGroups.Find(ID);
                    if (hist != null)
                    {
                        hist = (HistoryGroup)objForUpdate;
                        db.HistoryGroups.Update(hist);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is HR)
                {
                    HR hr = db.HRs.Find(ID);
                    if (hr != null)
                    {
                        hr = (HR)objForUpdate;
                        db.HRs.Update(hr);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Log)
                {
                    Log log = db.Logs.Find(ID);
                    if (log != null)
                    {
                        log = (Log)objForUpdate;
                        db.Logs.Update(log);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Skills)
                {
                    Skills skills = db.Skills.Find(ID);
                    if (skills != null)
                    {
                        skills = (Skills)objForUpdate;
                        db.Skills.Update(skills);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Status)
                {
                    Status status = db.Statuss.Find(ID);
                    if (status != null)
                    {
                        status = (Status)objForUpdate;
                        db.Statuss.Update(status);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is SkillsLead)
                {
                    SkillsLead skills = db.SkillsLeads.Find(ID);
                    if (skills != null)
                    {
                        skills = (SkillsLead)objForUpdate;
                        db.SkillsLeads.Update(skills);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Teachers)
                {
                    Teachers teacher = db.Teacherss.Find(ID);
                    if (teacher != null)
                    {
                        teacher = (Teachers)objForUpdate;
                        db.Teacherss.Update(teacher);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Group)
                {
                    Group group = db.Groups.Find(ID);
                    if (group != null)
                    {
                        group = (Group)objForUpdate;
                        db.Groups.Update(group);
                        db.SaveChanges();
                    }
                }

            }
            //return ?
        }
    }
}
