using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data
{
    public class Update : ICommand
    {
        public ApplicationContext db { get; set; }

        public void Execute(IEntity objForUpdate)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                if (objForUpdate is Lead)
                {
                    
                    if (objForUpdate != null)
                    {
                        Lead lead = (Lead)objForUpdate;
                        db.Leads.Update(lead);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Course)
                {
                    
                    if (objForUpdate != null)
                    {
                        Course course = (Course)objForUpdate;
                        db.Courses.Update(course);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is History)
                {
                    
                    if (objForUpdate != null)
                    {
                        History hist = (History)objForUpdate;
                        db.Historys.Update(hist);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is HistoryGroup)
                {
                    
                    if (objForUpdate != null)
                    {
                        HistoryGroup hist = (HistoryGroup)objForUpdate;
                        db.HistoryGroups.Update(hist);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is HR)
                {
                    
                    if (objForUpdate != null)
                    {
                        HR hr = (HR)objForUpdate;
                        db.HRs.Update(hr);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Log)
                {
                    
                    if (objForUpdate != null)
                    {
                        Log log = (Log)objForUpdate;
                        db.Logs.Update(log);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Skills)
                {
                    
                    if (objForUpdate != null)
                    {
                        Skills skills = (Skills)objForUpdate;
                        db.Skills.Update(skills);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Status)
                {
                    
                    if (objForUpdate != null)
                    {
                        Status status = (Status)objForUpdate;
                        db.Statuss.Update(status);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is SkillsLead)
                {
                    
                    if (objForUpdate != null)
                    {
                        SkillsLead skills = (SkillsLead)objForUpdate;
                        db.SkillsLeads.Update(skills);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Teacher)
                {
                    
                    if (objForUpdate != null)
                    {
                        Teacher teacher = (Teacher)objForUpdate;
                        db.Teacherss.Update(teacher);
                        db.SaveChanges();
                    }
                }
                else if (objForUpdate is Group)
                {
                    
                    if (objForUpdate != null)
                    {
                        Group group = (Group)objForUpdate;
                        db.Groups.Update(group);
                        db.SaveChanges();
                    }
                }

            }
            //return ?
        }
    }
}
