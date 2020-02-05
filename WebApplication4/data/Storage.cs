using data.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace data
{
    class Storage
    {

        public ICommand crudCommand;
        public IEnumerable<IEntity> GetAll<T>(params object[] obj) where T : IEntity, new() // начать с Т весь список в нем найти необходимые параметры по obj
        {
            Read crudCommand = new Read();
            T temp = new T();
            IEnumerable<IEntity> listprimari = crudCommand.Execute<T>();
            if (temp is Lead)
            {
                List<Lead> leads = (List<Lead>)listprimari;
                for(int i = 0; i<obj.Length; i++)
                {
                    for(int j = 0; j<leads.Count; j++)
                    {
                        if (obj[i].Equals(leads[j].Id) || )
                        {
                            continue;
                        }
                        else 
                        {
                            leads[]
                        }
                    } 
                    foreach(Lead item in leads)
                    {
                        
                    }
                }
                //IdCourse
                //IdStatus
                //GroupName
                
            }
            return ??
        }


        public bool Update(IEntity obj)
        {
            Update crudCommand = new Update();
            if (obj is Lead)
            {
                Lead temp = obj as Lead;
                crudCommand.Execute<Lead>(temp, temp.Id);
                return true;

            }
            else if (obj is Course)
            {
                Course temp = obj as Course;
                crudCommand.Execute<Course>(temp, temp.Id);
                return true;
            }
            else if (obj is History)
            {
                History temp = obj as History;
                crudCommand.Execute<History>(temp, temp.Id);
                return true;
            }
            else if (obj is HistoryGroup)
            {
                HistoryGroup temp = obj as HistoryGroup;
                crudCommand.Execute<HistoryGroup>(temp, temp.GroupName);
                return true;
            }
            else if (obj is HR)
            {
                HR temp = obj as HR;
                crudCommand.Execute<HR>(temp, temp.Id);
                return true;
            }
            else if (obj is Log)
            {
                Log temp = obj as Log;
                crudCommand.Execute<Log>(temp, temp.LeadId);
                return true;
            }
            else if (obj is Skills)
            {
                Skills temp = obj as Skills;
                crudCommand.Execute<Skills>(temp, temp.Id);
                return true;
            }
            else if (obj is Status)
            {
                Status temp = obj as Status;
                crudCommand.Execute<Status>(temp, temp.Id);
                return true;
            }
            else if (obj is SkillsLead)
            {
                SkillsLead temp = obj as SkillsLead;
                crudCommand.Execute<SkillsLead>(temp, temp.LeadId);
                return true;
            }
            else if (obj is Teachers)
            {
                Teachers temp = obj as Teachers;
                crudCommand.Execute<Teachers>(temp, temp.Id);
                return true;
            }
            else if (obj is Group)
            {
                Group temp = obj as Group;
                crudCommand.Execute<Group>(temp, temp.NameGroup);
                return true;
            }
            return false;
        }
        internal bool Delete(IEntity obj)
        {
            Delete crudCommand = new Delete(); 
            //Delete _del = new Delete();

            if (obj is Lead)
            {
                Lead temp = obj as Lead;
                crudCommand.Execute<History>(temp.Id);
                crudCommand.Execute<SkillsLead>(temp.Id);
                crudCommand.Execute<Log>(temp.Id);
                crudCommand.Execute<Lead>(temp.Id);
                return true;

            }
            else if (obj is Course)
            {
                Course temp = obj as Course;
                crudCommand.Execute<Lead>(temp.Id);
                crudCommand.Execute<Group>(temp.Id);
                crudCommand.Execute<Course>(temp.Id);
                return true;
            }
            else if (obj is History)
            {
                History temp = obj as History;
                crudCommand.Execute<History>(temp.Id);
                return true;
            }
            else if (obj is HistoryGroup)
            {
                HistoryGroup temp = obj as HistoryGroup;
                crudCommand.Execute<HistoryGroup>(temp.GroupName); // уточнить на счет передачи параметра
                return true;
            }
            else if (obj is HR)
            {
                HR temp = obj as HR;
                crudCommand.Execute<HR>(temp.Id);
                return true;
            }
            else if (obj is Log)
            {
                Log temp = obj as Log;
                crudCommand.Execute<Log>(temp.LeadId); // ??
                return true;
            }
            else if (obj is Skills)
            {
                Skills temp = obj as Skills;
                crudCommand.Execute<SkillsLead>(temp.Id);
                crudCommand.Execute<Skills>(temp.Id);
                return true;
            }
            else if (obj is Status)
            {
                Status temp = obj as Status;
                crudCommand.Execute<Status>(temp.Id);
                return true;
            }
            else if (obj is SkillsLead)
            {
                SkillsLead temp = obj as SkillsLead;
                crudCommand.Execute<SkillsLead>(temp.SkillsId);
                return true;
            }
            else if (obj is Teachers)
            {
                Teachers temp = obj as Teachers;
                crudCommand.Execute<Group>(temp.Id);
                crudCommand.Execute<Teachers>(temp.Id);
                return true;
            }
            else if (obj is Group)
            {
                Group temp = obj as Group;
                crudCommand.Execute<Lead>(temp.GroupName);
                crudCommand.Execute<HistoryGroup>(temp.GroupName);
                crudCommand.Execute<Group>(temp.NameGroup); // та же проблема что и выше, ключ не int
                return true;
            }
            return false;
        }
        public bool Add(IEntity obj)
        {
            Create crudCommand = new Create();
            crudCommand.Execute(obj);
            return true;

            
        }
    }
}
