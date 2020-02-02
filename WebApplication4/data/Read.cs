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

        public List<IEntity> Execute<T>() where T :  IEntity, new()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<IEntity> listObject = new List<IEntity>();
                T obj = new T();
                
                if (obj is Lead)
                {
                    var listObjectTmp = db.Leads.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Course)
                {
                    var listObjectTmp = db.Courses.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is History)
                {
                    var listObjectTmp = db.Historys.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is HistoryGroup)
                {
                    var listObjectTmp = db.HistoryGroups.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is HR)
                {
                    var listObjectTmp = db.HRs.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Log)
                {
                    var listObjectTmp = db.Logs.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Skills)
                {
                    var listObjectTmp = db.Skills.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Status)
                {
                    var listObjectTmp = db.Statuss.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is SkillsLead)
                {
                    var listObjectTmp = db.SkillsLeads.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Teachers)
                {
                    var listObjectTmp = db.Teacherss.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                else if (obj is Group)
                {
                    var listObjectTmp = db.Groups.ToList();
                    foreach (var item in listObjectTmp)
                    {
                        listObject.Add(item);
                    }
                }
                return listObject;
            }
        }

        

    }
}
