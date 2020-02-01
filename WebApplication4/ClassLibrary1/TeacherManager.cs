using busines.Interface;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines
{
    public class TeacherManager: UserManager
    {
        Teachers _teacher;
        TeacherManager(Teachers teacher)
        {
            _teacher = teacher;
        }

        public override IEnumerable<T> Get<T>()
        {
            return _storage.GetAll<T>(_teacher.Id);
        }
    }
}   
