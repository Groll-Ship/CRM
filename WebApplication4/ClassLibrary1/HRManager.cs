using busines.Interface;
using CRMTest.stab;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines
{
    public class HRManager: UserManager
    {
        public HRManager()
        {
            _storage = new StabStorage(this);
        }
    }
}
