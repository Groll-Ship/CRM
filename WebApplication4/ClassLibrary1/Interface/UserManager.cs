using CRMTest.stab;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines.Interface
{
    public abstract class UserManager
    {
        protected StabStorage _storage;

        virtual public IEnumerable<T> Get<T>() where T: new()
        {
           return  _storage.GetAll<T>();           
        }

        virtual public IEnumerable<T> Creat<T>() where T : new()
        {
            return _storage.Creat<T>();
        }

        virtual public IEnumerable<T> Update<T, N, TWhere>(N indentity, TWhere objWhere) where T : new()
        {
            return _storage.Update<T, N, TWhere>(indentity, objWhere);
        }

    }
}
