using busines.Interface;
using CRMTest.stab;
using data.Models;
using System;
using System.Collections.Generic;

namespace busines
{
    public class HRManager: UserManager
    {
        public HRManager() 
        {
            _storage = new StabStorage(this);
        }

        #region GET

        /// <summary>
        /// Get list of all courses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> GetCourses() 
        {
            return (List<Course>)_storage.GetAll<Course>(); 
        }

        /// <summary>
        /// Get all teacher courses 
        /// </summary>
        /// <param name="teacher">Object Teacher</param>
        /// <returns></returns>
        public IEnumerable<Course> GetTeacherCourses(Teacher teacher) 
        {
            //TeacherManager _teacher = new TeacherManager(teacher);
            //return _teacher.GetCourses();
            return (List<Course>)_storage.GetAll<Course>(teacher);
        }

        /// <summary>
        /// Get list of all groups
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Group> GetGroups() 
        {
            return (List<Group>)_storage.GetAll<Group>(); 
        }

        /// <summary>
        /// Get all teacher groups
        /// </summary>
        /// <param name="teacher">Object Teacher</param>
        /// <returns></returns>
        public IEnumerable<Group> GetTeacherGroups(Teacher teacher)  
        {
            TeacherManager _teacher = new TeacherManager(teacher);
            return _teacher.GetGroups();
        }

        /// <summary>
        /// Get list of groups for one course
        /// </summary>
        /// <param name="course">Object Course</param>
        /// <returns></returns>
        public IEnumerable<Group> GetGroupsForCourse(Course course) 
        {
            return (List<Group>)_storage.GetAll<Group>(course); 
        }

        /// <summary>
        /// Get all HR
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HR> GetHRs() 
        { 
            return (List<HR>)_storage.GetAll<HR>(); 
        }

        /// <summary>
        /// Get all leads by status
        /// </summary>
        /// <param name="status">Object Status</param>
        /// <returns></returns>
        public IEnumerable<Lead> GetLeads(Status status) 
        { 
            return (List<Lead>)_storage.GetAll<Lead>(status); 
        }

        /// <summary>
        /// Get all leads from one group
        /// </summary>
        /// <param name="group">Object Group</param>
        /// <returns></returns>
        public IEnumerable<Lead> GetLeadsForGroup(Group group) 
        { 
            return (List<Lead>)_storage.GetAll<Lead>(group); 
        }

        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Teacher> GetTeachers()
        { 
            return (List<Teacher>)_storage.GetAll<Teacher>(); 
        }

        /// <summary>
        /// Get all lead history 
        /// </summary>
        /// <param name="lead">Object Lead</param>
        /// <returns></returns>
        public IEnumerable<History> GetLeadHistory(Lead lead) 
        { 
            return (List<History>)_storage.GetAll<History>(lead); 
        }

        /// <summary>
        /// Get all group history
        /// </summary>
        /// <param name="group">Object Group</param>
        /// <returns></returns>
        public IEnumerable<HistoryGroup> GetGroupHistory(Group group) 
        { 
            return (List<HistoryGroup>)_storage.GetAll<HistoryGroup>(group); 
        }

        #endregion

        #region CREAT

        /// <summary>
        /// Creat new course
        /// </summary>
        /// <returns>new created course</returns>
        //public Course CreatCourse() { return _storage.Creat<Course>(); }

        /// <summary>
        /// Creat new group
        /// </summary>
        /// <returns>new created group</returns>
        public bool AddGroup(Group group) 
        {
            return _storage.Add(group); 
        }


        /// <summary>
        /// Creat new lead
        /// </summary>
        /// <returns>new created lead</returns>
        public bool AddLead(Lead lead) 
        { 
            return _storage.Add(lead); 
        }

        /// <summary>
        /// Creat new teacher
        /// </summary>
        /// <returns>new created lead</returns>
        public bool AddTeacher(Teacher teacher) 
        { 
            return _storage.Add(teacher); 
        }

        /// <summary>
        /// Add comment to lead
        /// </summary>
        /// <param name="lead">Lead object</param>
        /// <param name="comment">Comment object</param>
        public bool AddCommentToLead(Lead lead, string comment)
        {
            History history = new History()
            {
                LeadId = lead.Id,
                Lead = lead,
                HistoryText = DateTime.Now.ToString() + " " + comment
            };
            return _storage.Add(history);
        }

        #endregion

        #region UPDATE


        /// <summary>
        /// Change group for lead
        /// </summary>
        /// <param name="lead">Lead object</param>
        /// <param name="group">Group object</param>
        public bool ChangeLeadGroup(Lead lead, Group group)
        {
            lead.Group = group;
            return UpdateLead(lead);
        }

        /// <summary>
        ///  Change course for lead
        /// </summary>
        /// <param name="lead">Lead object</param>
        /// <param name="course">Course object</param>
        /// <returns></returns>
        public bool ChangeLeadCourse(Lead lead, Course course)
        {
            lead.Course = course;
            return UpdateLead(lead);
        }

        /// <summary>
        /// Change status for lead
        /// </summary>
        /// <param name="lead">Lead object</param>
        /// <param name="status">Status object</param>
        /// <returns></returns>
        public bool ChangeLeadStatus(Lead lead, Status status)
        {
            lead.Status = status;
            return UpdateLead(lead);
        }

        /// <summary>
        /// Add group to course
        /// </summary>
        /// <param name="group">Group object</param>
        /// <param name="course">Course object</param>
        /// <returns></returns>
        public bool AddGroupToCourse(Group group, Course course)
        {
            group.Course = course;
            return UpdateGroup(group);
        }

        /// <summary>
        /// Change teacher for group
        /// </summary>
        /// <param name="group">Group object</param>
        /// <param name="teacher">Teacher object</param>
        /// <returns></returns>
        public bool ChangeGroupTeacher(Group group, Teacher teacher)
        {
            group.Teacher = teacher;
            return UpdateGroup(group);
        }

        #endregion


        /// <summary>
        /// Update Group parametersby group name
        /// </summary>
        ///  <returns></returns>
        private bool UpdateGroup(Group group)
        {
            return _storage.Update(group);
        }

        /// <summary>
        /// Update lead
        /// </summary>
        /// <returns></returns>
        private bool UpdateLead(Lead lead)
        {
            return _storage.Update(lead);
        }

        /// <summary>
        /// Update teacher
        /// </summary>
        /// <returns></returns>
        private bool UpdateTeacher(Teacher teacher)
        {
            return _storage.Update(teacher);
        }
    }
}
