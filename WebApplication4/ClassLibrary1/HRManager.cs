using busines.Interface;
using data.Models;
using System.Collections.Generic;

namespace busines
{
    public class HRManager: UserManager
    {
        #region GET

        /// <summary>
        /// Get list of all courses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> GetCourses() { return _storage.GetAll<Course>(); }

        /// <summary>
        /// Get all teacher courses 
        /// </summary>
        /// <param name="id">Teacher ID</param>
        /// <returns></returns>
        public IEnumerable<Course> GetTeacherCourses(int id) { return (List<Course>)_storage.GetAll<Course>(id); }

        /// <summary>
        /// Get list of all groups
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Group> GetGroups() { return _storage.GetAll<Group>(); }

        /// <summary>
        /// Get all teacher groups
        /// </summary>
        /// <param name="id">Teacher ID</param>
        /// <returns></returns>
        public IEnumerable<Course> GetTeacherGroups(int id) { return (List<Course>)_storage.GetAll<Course>(id); }

        /// <summary>
        /// Get list of groups for one course
        /// </summary>
        /// <param name="id">Course ID</param>
        /// <returns></returns>
        public IEnumerable<Course> GetCourseGroups(int id) { return (List<Course>)_storage.GetAll<Course>(id); }

        /// <summary>
        /// Get all HR
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HR> GetHR() { return _storage.GetAll<HR>(); }

        /// <summary>
        /// Get all active leads or not 
        /// </summary>
        /// <param name="accessStatus">AccessStatus == true if Leads is active else AccessStatus == false </param>
        /// <returns></returns>
        public IEnumerable<Lead> GetLeads(bool accessStatus) { return (List<Lead>)_storage.GetAll<Lead>(accessStatus); }

        /// <summary>
        /// Get list of leads by status ID
        /// </summary>
        /// <param name="id">status ID</param>
        /// <returns></returns>
        public IEnumerable<Lead> GetLeadsByStatusId(int id) { return (List<Lead>)_storage.GetAll<Lead>(id); }

        /// <summary>
        /// Get all leads from one group
        /// </summary>
        /// <param name="name">group name</param>
        /// <returns></returns>
        public IEnumerable<Lead> GetLeadsByGroupName(string name) { return (List<Lead>)_storage.GetAll<Lead>(name); }

        /// <summary>
        /// Get all teachers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Teacher> GetTeachers() { return _storage.GetAll<Teacher>(); }

        /// <summary>
        /// Get all lead history 
        /// </summary>
        /// <param name="id">Lead ID</param>
        /// <returns></returns>
        public IEnumerable<History> GetHistoryByLeadID(int id) { return (List<History>)_storage.GetAll<History>(id); }

        /// <summary>
        /// Get all group history
        /// </summary>
        /// <param name="name">Group Name</param>
        /// <returns></returns>
        public IEnumerable<HistoryGroup> GetHistoryByGroupName(string name) { return (List<HistoryGroup>)_storage.GetAll<HistoryGroup>(name); }

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
        public Group CreatGroup() { return _storage.Creat<Group>(); }

        /// <summary>
        /// Creat new lead
        /// </summary>
        /// <returns>new created lead</returns>
        public Lead CreatLead() { return _storage.Creat<Lead>(); }

        /// <summary>
        /// Creat new teacher
        /// </summary>
        /// <returns>new created lead</returns>
        public Teacher CreatTeacher() { return _storage.Creat<Teacher>(); }

        #endregion

        #region UPDATE

        //public Course UpdateCourseParamsByID(int id, Dictionary<string, object> courseParams) { return _storage.Update<Course, int>(id, courseParams); }

        /// <summary>
        /// Update Group parametersby group name
        /// </summary>
        /// <param name="name">Group name</param>
        /// <param name="objParams">Dictionary of group model property and set of group parameters</param>
        /// <returns></returns>
        public Group UpdateGroupParamsByName(string name, Dictionary<string, object> objParams) { return _storage.Update<Group, string>(name, objParams); }
        
        /// <summary>
        /// Update lead parameters by lead ID
        /// </summary>
        /// <param name="id">Lead ID</param>
        /// <param name="leadParams">Dictionary of lead model property and set of lead parameters</param>
        /// <returns></returns>
        public Lead UpdateLeadParamsByID(int id, Dictionary<string, object> objParams) { return _storage.Update<Lead, int>(id, objParams); }

        /// <summary>
        /// Update teacher parameters by teacher ID
        /// </summary>
        /// <param name="id">teacher ID</param>
        /// <param name="leadParams">Dictionary of teacher model property and set of teacher parameters</param>
        /// <returns></returns>
        public Teacher UpdateTeacherParamsByID(int id, Dictionary<string, object> objParams) { return _storage.Update<Teacher, int>(id, objParams); }

        #endregion

    }
}
