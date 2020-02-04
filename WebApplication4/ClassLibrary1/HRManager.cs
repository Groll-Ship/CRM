using busines.Interface;
using CRMTest.stab;
using data.Models;
using System.Collections.Generic;

namespace busines
{
    public class HRManager: UserManager
    {
        public HRManager() 
        {
            _storage = new StabStorage(this);
        }

        //add history to Lead? add history togroup?  add new status? update status

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

        #endregion

        #region UPDATE

        //public Course UpdateCourseParamsByID(int id, Dictionary<string, object> courseParams) { return _storage.Update<Course, int>(id, courseParams); }

        /// <summary>
        /// Update Group parametersby group name
        /// </summary>
        /// <param name="name">Group name</param>
        /// <param name="objParams">Dictionary of group model property and set of group parameters</param>
        /// <returns></returns>
        public bool UpdateGroup(Group group) 
        {
            return _storage.Update(group); 
        }

        /// <summary>
        /// Update lead parameters by lead ID
        /// </summary>
        /// <param name="id">Lead ID</param>
        /// <param name="leadParams">Dictionary of lead model property and set of lead parameters</param>
        /// <returns></returns>
        public bool UpdateLead(Lead lead)
        { 
            return _storage.Update(lead); 
        }

        /// <summary>
        /// Update teacher parameters by teacher ID
        /// </summary>
        /// <param name="id">teacher ID</param>
        /// <param name="leadParams">Dictionary of teacher model property and set of teacher parameters</param>
        /// <returns></returns>
        public bool UpdateTeacher(Teacher teacher) 
        {
            return _storage.Update(teacher); 
        }

        #endregion

    }
}
