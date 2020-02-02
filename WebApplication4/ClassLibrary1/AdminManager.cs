using busines.Interface;
using CRMTest.stab;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines
{
    public class AdminManager: UserManager
    {
        public AdminManager()
        {
            _storage = new StabStorage(this);

            public IEnumerable<T> Delete<T, N>(N indentity) where T : new()
            {
                return _storage.Delete<T, N>(indentity);
            }
        }
    }
    }
