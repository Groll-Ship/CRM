using busines;
using busines.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using data.Models;

namespace CRMTest.stab
{
    public class StabStorage
    {
        object _user;
        public StabStorage(object user)
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

        internal bool Delete<T, N>(N indentity) where T : new()
        {
            return true;
        }

        internal bool Delete<T, N1, N2>(N1 indentity1, N2 indentity2) where T : new()
        {
            return true;
        }
        internal T Creat<T>() where T : new()
        {
            return new T();
        }

        internal T Update<T, N>(N indentity, Dictionary<string, object> ObjParams) where T : new()
        {
            throw new NotImplementedException();
        }
        
        internal IEnumerable<T> Update<T, N, TWhere>(N indentity, TWhere ObjWhere) where T : new()
        {
            throw new NotImplementedException();
        }

        internal bool Update<T>(T indentity) where T : new()
        {
            return true;
        }
        
        public IEnumerable<IEntity> GetAll<T>(params object[] arg) where T : new()
        {
            T proverka = new T();
            if (proverka is data.Models.Group) { return new List<data.Models.Group>() { new data.Models.Group() { TeacherId = 1 } }; }
            return new List<IEntity>();
        }


        internal bool Add<T, N, WAdded>(N indentity, params WAdded[] added) where T : new() where N : new() 
        {
            return true;
        }
        
    }
}
