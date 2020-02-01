using busines;
using busines.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMTest.stab
{
    public class StabStorage
    {
        UserManager _user;
        public StabStorage(UserManager user)
        {
            _user = user;
        }
        public IEnumerable<T> GetAll<T>() where T: new()
        { 
            return new List<T>
            {
                new T() { }
            };
        }

        internal IEnumerable<T> Delete<T, N>(N indentity) where T : new()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<T> Creat<T>() where T : new()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<T> Update<T, N, TWhere>(N indentity, TWhere ObjWhere) where T : new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(int idTeacher) where T : new()
        {
            return new List<T>
            {
                new T() { }
            };
        }

    }
}
