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

        internal IEnumerable<T> Delete<T, N>(N indentity) where T : new()
        {
            return new List<T>
            {
                new T() { }
            };
        }

        internal IEnumerable<T> Creat<T>() where T : new()
        {
            return new List<T>
            {
                new T() { }
            };
        }

        internal bool Update<T>(T indentity) where T : new()
        {
            return true;
        }


        //public IEnumerable<T> GetAll<T>(params object[] arg) where T : new()
        //{
        //    T proverka = new T();
        //    if(proverka is data.Models.Group) { return new List<T>() { new T() {TeacherId = 1 } }; }
        //    return new List<T>
        //    {
        //        new T() { }
        //    };
        //}
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
