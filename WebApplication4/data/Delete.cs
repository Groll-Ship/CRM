using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data
{
    public class Delete : ICommand
    {
        public ApplicationContext db { get; set; }

        public void Execute(IEntity obj)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (obj is Lead)
                {
                    Lead lead = (Lead)obj;
                    if (lead != null)
                    {
                        db.Leads.Remove(lead);
                        db.SaveChanges();
                    }
                }
                else if (obj is Course)
                {
                    Course course = (Course)obj;
                    if (course != null)
                    {
                        db.Courses.Remove(course);
                        db.SaveChanges();
                    }
                }
                else if (obj is History)
                {
                    History hist = (History)obj;
                    if (hist != null)
                    {
                        db.Historys.Remove(hist);
                        db.SaveChanges();
                    }
                }
                else if (obj is HistoryGroup)
                {
                    HistoryGroup hist = (HistoryGroup)obj;
                    if (hist != null)
                    {
                        db.HistoryGroups.Remove(hist);
                        db.SaveChanges();
                    }
                }
                else if (obj is HR)
                {
                    HR hr = (HR)obj;
                    if (hr != null)
                    {
                        db.HRs.Remove(hr);
                        db.SaveChanges();
                    }
                }
                else if (obj is Log)
                {
                    Log log = (Log)obj;
                    if (log != null)
                    {
                        db.Logs.Remove(log);
                        db.SaveChanges();
                    }
                }
                else if (obj is Skills)
                {
                    Skills skill = (Skills)obj;
                    if (skill != null)
                    {
                        db.Skills.Remove(skill);
                        db.SaveChanges();
                    }
                }
                else if (obj is Status)
                {
                    Status status = (Status)obj;
                    if (status != null)
                    {
                        db.Statuss.Remove(status);
                        db.SaveChanges();
                    }
                }
                else if (obj is SkillsLead)
                {
                    SkillsLead skill = (SkillsLead)obj;
                    if (skill != null)
                    {
                        db.SkillsLeads.Remove(skill);
                        db.SaveChanges();
                    }
                }
                else if (obj is Teacher)
                {
                    Teacher teacher = (Teacher)obj;
                    if (teacher != null)
                    {
                        db.Teacherss.Remove(teacher);
                        db.SaveChanges();
                    }
                }
                else if (obj is Group)
                {
                    Group group = (Group)obj;
                    if (group != null)
                    {
                        db.Groups.Remove(group);
                        db.SaveChanges();
                    }
                }
            }
            
        }
    }
}
