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
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < leads.Count; j++)
                    {
                        if (obj[i].Equals(leads[j].Id) ||
                            obj[i].Equals(leads[j].FName) ||
                            obj[i].Equals(leads[j].SName) ||
                            obj[i].Equals(leads[j].DateBirthday) ||
                            obj[i].Equals(leads[j].DateRegistration) ||
                            obj[i].Equals(leads[j].EMail) ||
                            obj[i].Equals(leads[j].Numder) ||
                            obj[i].Equals(leads[j].CourseId) ||
                            obj[i].Equals(leads[j].NameGroup) ||
                            obj[i].Equals(leads[j].StatusId))
                        { continue; }
                        else
                        {
                            leads.RemoveAt(j);
                        }
                    }
                }
                return leads;
            }

            else if (temp is Course)
            {
                List<Course> courses = (List<Course>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < courses.Count; j++)
                    {
                        if (obj[i].Equals(courses[j].Id) ||
                            obj[i].Equals(courses[j].Name) ||
                            obj[i].Equals(courses[j].CourseInfo))
                        { continue; }
                        else courses.RemoveAt(j);
                    }
                }
                return courses;
            }

            else if (temp is Group)
            {
                List<Group> groups = (List<Group>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < groups.Count; j++)
                    {
                        if (obj[i].Equals(groups[j].NameGroup) ||
                            obj[i].Equals(groups[j].CourseId) ||
                            obj[i].Equals(groups[j].StartDate) ||
                            obj[i].Equals(groups[j].TeacherId) ||
                            obj[i].Equals(groups[j].Log))
                        { continue; }
                        else groups.RemoveAt(j);
                    }
                }
                return groups;
            }

            else if (temp is History)
            {
                List<History> stories = (List<History>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < stories.Count; j++)
                    {
                        if (obj[i].Equals(stories[j].Id))
                        { continue; }
                        else stories.RemoveAt(j);
                    }

                }
                return stories;
            }

            else if (temp is Skills)
            {
                List<Skills> skills = (List<Skills>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < skills.Count; j++)
                    {
                        if (obj[i].Equals(skills[j].Id))
                        { continue; }
                        else skills.RemoveAt(j);
                    }
                }
                return skills;
            }
            else if (temp is SkillsLead)
            {
                List<SkillsLead> skillsLeads = (List<SkillsLead>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j <skillsLeads.Count; j++)
                    {
                        if (obj[i].Equals(skillsLeads[j].LeadId) ||
                            obj[i].Equals(skillsLeads[j].SkillsId))
                        { continue; }
                        else skillsLeads.RemoveAt(j);
                    }
                }
                return skillsLeads;
            }
            else if (temp is Teacher)
            {
                List<Teacher> teachers = (List<Teacher>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < teachers.Count; j++)
                    {
                        if (obj[i].Equals(teachers[j].Id) || 
                            obj[i].Equals(teachers[j].FName) || 
                            obj[i].Equals(teachers[j].SName))
                            { continue; }
                        else teachers.RemoveAt(j);
                    }
                }
                return teachers;
            }
            else if (temp is Status)
            {
                List<Status> statuses = (List<Status>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < statuses.Count; j++)
                    {
                        if (obj[i].Equals(statuses[j].Id) ||
                            obj[i].Equals(statuses[j].Name))
                        { continue; }
                        else statuses.RemoveAt(j);
                    }
                }
                return statuses;
            }
            else if (temp is HR)
            {
                List<HR> hRs = (List<HR>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < hRs.Count; j++)
                    {
                        if (obj[i].Equals(hRs[j].Id) ||
                            obj[i].Equals(hRs[j].FName) ||
                            obj[i].Equals(hRs[j].SName))
                        { continue; }
                        else hRs.RemoveAt(j);
                    }
                }
                return hRs;
            }
            else if (temp is HistoryGroup)
            {
                List<HistoryGroup> historyGroups = (List<HistoryGroup>)listprimari;
                for (int i = 0; i < obj.Length; i++)
                {
                    for (int j = 0; j < historyGroups.Count; j++)
                    {
                        if (obj[i].Equals(historyGroups[j].GroupName))
                            { continue; }   
                    }
                }
            }

        }


        public bool Update(IEntity obj)
        {
            Update crudCommand = new Update();
            crudCommand.Execute(obj);
            return true;
        }
        internal bool Delete(IEntity obj)
        {
            Delete crudCommand = new Delete();
            IEnumerable<IEntity> listprimari;
            //Delete _del = new Delete();

            if (obj is Lead)
            {
                Lead tempLead = obj as Lead;

                listprimari = GetAll<History>(tempLead.Id);
                foreach(History leadHistory in listprimari)
                {
                    crudCommand.Execute(leadHistory);
                }

                listprimari = GetAll<SkillsLead>(tempLead.Id);
                foreach (SkillsLead leadSkills in listprimari)
                {
                    crudCommand.Execute(leadSkills);
                }

                listprimari = GetAll<Log>(tempLead.Id);
                foreach (Log leadLog in listprimari)
                {
                    crudCommand.Execute(leadLog);
                }

                crudCommand.Execute(obj);

                return true;

            }
            else if (obj is Course)
            {
                Course temp = obj as Course;
                
                listprimari = GetAll<Lead>(temp.Id);
                foreach (Lead leadHistory in listprimari)
                {
                    crudCommand.Execute(leadHistory);
                }


                listprimari = GetAll<Group>(temp.Id);
                foreach (Group leadGroup in listprimari)
                {
                    crudCommand.Execute(leadGroup);
                }
                
                crudCommand.Execute(obj);
                return true;
            }
            else if (obj is History ||
                     obj is HistoryGroup || 
                     obj is HR || obj is Log || 
                     obj is Status || 
                     obj is SkillsLead )
            {
                crudCommand.Execute(obj);
                return true;
            }
            else if (obj is Skills)
            {
                Skills temp = obj as Skills;
                listprimari = GetAll<SkillsLead>(temp.Id);
                foreach (SkillsLead leadSkills in listprimari)
                {
                    crudCommand.Execute(leadSkills);
                }
                crudCommand.Execute(obj);
                return true;
            }
            else if (obj is Teacher)
            {
                Teacher temp = obj as Teacher;

                listprimari = GetAll<Group>(temp.Id);
                foreach (Group leadGroup in listprimari)
                {
                    crudCommand.Execute(leadGroup);
                }
                crudCommand.Execute(obj);
                return true;
            }
            else if (obj is Group)
            {
                Group temp = obj as Group;

                listprimari = GetAll<Lead>(temp.Id);
                foreach (Lead leadGroup in listprimari)
                {
                    leadGroup.NameGroup = null;
                    Update(leadGroup);
                }

                listprimari = GetAll<HistoryGroup>(temp.Id);
                foreach (HistoryGroup groupHistory in listprimari)
                {
                    crudCommand.Execute(groupHistory);
                }
                

                crudCommand.Execute(obj); // та же проблема что и выше, ключ не int
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
