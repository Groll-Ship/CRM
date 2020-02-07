using data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace data
{
    public class Read : ICommand
    {
        public ApplicationContext db { get; set; }

        public IEnumerable<IEntity> Execute<T>() where T :  IEntity, new()
        {
            using (ApplicationContext db = new ApplicationContext())
            {                
                T obj = new T();
                
                if (obj is Lead)
                {
                    List<Lead> listObjectTmp = db.Leads.ToList();
                    return listObjectTmp;                
                }
                else if (obj is Course)
                {
                    List<Course> listObjectTmp = db.Courses.ToList();
                    return listObjectTmp;
                }
                else if (obj is History)
                {
                    List<History> listObjectTmp = db.Historys.ToList();
                    return listObjectTmp;
                }
                else if (obj is HistoryGroup)
                {
                    List<HistoryGroup> listObjectTmp = db.HistoryGroups.ToList();
                    return listObjectTmp;
                }
                else if (obj is HR)
                {
                    List<HR> listObjectTmp = db.HRs.ToList();
                    return listObjectTmp;
                }
                else if (obj is Log)
                {
                    List<Log> listObjectTmp = db.Logs.ToList();
                    return listObjectTmp;
                }
                else if (obj is Skills)
                {
                    List<Skills> listObjectTmp = db.Skills.ToList();
                    return listObjectTmp;
                }
                else if (obj is Status)
                {
                    List<Status> listObjectTmp = db.Statuss.ToList();
                    return listObjectTmp;
                }
                else if (obj is SkillsLead)
                {
                    List<SkillsLead> listObjectTmp = db.SkillsLeads.ToList();
                    return listObjectTmp;
                }
                else if (obj is Teacher)
                {
                    List<Teacher> listObjectTmp = db.Teacherss.ToList();
                    return listObjectTmp;
                }
                else if (obj is Group)
                {
                    List<Group> listObjectTmp = db.Groups.ToList();
                    return listObjectTmp;
                }
                return null;
            }
        }

        

    }
}
