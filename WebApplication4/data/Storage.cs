using data.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace data
{
    public class Storage
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
                for (int i = 0; i < leads.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(leads[i].Id) ||
                            obj[j].Equals(leads[i].FName) ||
                            obj[j].Equals(leads[i].SName) ||
                            obj[j].Equals(leads[i].DateBirthday) ||
                            obj[j].Equals(leads[i].DateRegistration) ||
                            obj[j].Equals(leads[i].EMail) ||
                            obj[j].Equals(leads[i].Numder) ||
                            obj[j].Equals(leads[i].CourseId) ||
                            obj[j].Equals(leads[i].NameGroup) ||
                            obj[j].Equals(leads[i].StatusId))
                        { continue; }
                        else
                        {
                            leads.RemoveAt(i);
                        }
                    }
                }
                return leads;
            }

            else if (temp is Course)
            {
                List<Course> courses = (List<Course>)listprimari;
                for (int i = 0; i < courses.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(courses[i].Id) ||
                            obj[j].Equals(courses[i].Name) ||
                            obj[j].Equals(courses[i].CourseInfo))
                        { continue; }
                        else courses.RemoveAt(i);
                    }
                }
                return courses;
            }

            else if (temp is Group)
            {
                List<Group> groups = (List<Group>)listprimari;
                for (int i = 0; i < groups.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(groups[i].NameGroup) ||
                            obj[j].Equals(groups[i].CourseId) ||
                            obj[j].Equals(groups[i].StartDate) ||
                            obj[j].Equals(groups[i].TeacherId) ||
                            obj[j].Equals(groups[i].Log))
                        { continue; }
                        else groups.RemoveAt(i);
                    }
                }
                return groups;
            }

            else if (temp is History)
            {
                List<History> stories = (List<History>)listprimari;
                for (int i = 0; i < stories.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(stories[i].Lead) ||
                            obj[j].Equals(stories[i].HistoryText))
                        { continue; }
                        else stories.RemoveAt(i);
                    }

                }
                return stories;
            }

            else if (temp is Skills)
            {
                List<Skills> skills = (List<Skills>)listprimari;
                for (int i = 0; i < skills.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(skills[i].Id) ||
                            obj[j].Equals(skills[i].NameSkills))
                        { continue; }
                        else skills.RemoveAt(i);
                    }
                }
                return skills;
            }
            else if (temp is SkillsLead)
            {
                List<SkillsLead> skillsLeads = (List<SkillsLead>)listprimari;
                for (int i = 0; i < skillsLeads.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(skillsLeads[i].LeadId) ||
                            obj[j].Equals(skillsLeads[i].SkillsId))
                        { continue; }
                        else skillsLeads.RemoveAt(i);
                    }
                }
                return skillsLeads;
            }
            else if (temp is Teacher)
            {
                List<Teacher> teachers = (List<Teacher>)listprimari;
                for (int i = 0; i < teachers.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(teachers[i].Id) || 
                            obj[j].Equals(teachers[i].FName) || 
                            obj[j].Equals(teachers[i].SName))
                            { continue; }
                        else teachers.RemoveAt(i);
                    }
                }
                return teachers;
            }
            else if (temp is Status)
            {
                List<Status> statuses = (List<Status>)listprimari;
                for (int i = 0; i < statuses.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(statuses[i].Id) ||
                            obj[j].Equals(statuses[i].Name))
                        { continue; }
                        else statuses.RemoveAt(i);
                    }
                }
                return statuses;
            }
            else if (temp is HR)
            {
                List<HR> hRs = (List<HR>)listprimari;
                for (int i = 0; i < hRs.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(hRs[i].Id) ||
                            obj[j].Equals(hRs[i].FName) ||
                            obj[j].Equals(hRs[i].SName))
                        { continue; }
                        else hRs.RemoveAt(i);
                    }
                }
                return hRs;
            }
            else if (temp is HistoryGroup)
            {
                List<HistoryGroup> historyGroups = (List<HistoryGroup>)listprimari;
                for (int i = 0; i < historyGroups.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(historyGroups[i].GroupName) || 
                            obj[j].Equals(historyGroups[i].HistoryText))
                            { continue; }   
                    }
                }
                return historyGroups;
            }
            else if (temp is Log)
            {
                List<Log> logs = (List<Log>)listprimari;
                for (int i = 0; i < logs.Count; i++)
                {
                    for (int j = 0; j < obj.Length; j++)
                    {
                        if (obj[j].Equals(logs[i].LeadId) ||
                            obj[j].Equals(logs[i].Date))
                        { continue; }
                    }
                }
                return logs;
            }
            return null;

        }


        public bool Update(IEntity obj)
        {
            Update crudCommand = new Update();
            crudCommand.Execute(obj);
            return true;
        }
        public bool Delete(IEntity obj)
        {
            Delete crudCommand = new Delete();
            IEnumerable<IEntity> listprimari;
            

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
                    leadHistory.Course = null; //////////////////////////////
                    Update(leadHistory);
                }


                listprimari = GetAll<Group>(temp.Id);
                foreach (Group leadGroup in listprimari)
                {
                    leadGroup.Teacher = null; ///////////
                    Update(leadGroup);
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
                    leadGroup.Teacher = null; //////////////
                    Update(leadGroup);
                }
                crudCommand.Execute(obj);
                return true;
            }
            else if (obj is Group)
            {
                Group temp = obj as Group;

                listprimari = GetAll<Lead>(temp.NameGroup);
                foreach (Lead leadGroup in listprimari)
                {
                    leadGroup.NameGroup = null;
                    Update(leadGroup);
                }

                listprimari = GetAll<HistoryGroup>(temp.NameGroup);
                foreach (HistoryGroup groupHistory in listprimari)
                {
                    crudCommand.Execute(groupHistory);
                }
                

                crudCommand.Execute(obj); 
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
