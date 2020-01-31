using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Mocks
{
    public class LeadMock : IMocks<Lead>
    {
        private static List<Lead> _leads = new List<Lead>
        {
            new Lead {
                        IdLead = 1,
                        FName = "ADAM",
                        SName = "BOJIY",
                        DateBirthday = "12",
                        DateRegistration = "12",
                        Numder = 5000,
                        EMail = "c@a",
                        IdCourse = 1,
                        GroupeName = "c1",
                        IdStatus = 5000,
                        AccessStatus = true
            },
              new Lead {
                        IdLead = 1,
                        FName = "ADAM",
                        SName = "BOJIY",
                        DateBirthday = "12",
                        DateRegistration = "12",
                        Numder = 5000,
                        EMail = "c@a",
                        IdCourse = 1,
                        GroupeName = "c1",
                        IdStatus = 5000,
                        AccessStatus = true
              }
        };



        public IEnumerable<Lead> Objects
        {
            get
            {
                return _leads;
            }
        }

        public void AddLead(Lead p)
        {
            _leads.Add(p);
        }

        public IEnumerable<Lead> DeleteLead(int id)
        {

            Lead p = null;
            foreach (var item in _leads)
            {
                if (item.IdLead == id)
                {
                    p = item;
                }
            }

            if (p != null)
            {
                _leads.Remove(p);
            }
            return _leads;
        }

        public IEnumerable<Lead> GetAllLeads()
        {
            return _leads;
        }

        public Lead GetLeadById(int id)
        {
            foreach (var item in _leads)
            {

                if (item.IdLead == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateLead(int id, Lead p)
        {
            foreach (var item in _leads)
            {
                if (item.IdLead == id)
                {
                    item.FName = p.FName;
                    item.SName = p.SName;
                    item.DateBirthday = p.DateBirthday;
                    item.DateRegistration = p.DateRegistration;
                    item.Numder = p.Numder;
                    item.EMail = p.EMail;
                    item.IdCourse = p.IdCourse;
                    item.GroupeName = p.GroupeName;
                    item.IdStatus = p.IdStatus;
                }
            }
        }
    }
}
