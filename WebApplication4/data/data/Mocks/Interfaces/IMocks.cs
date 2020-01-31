using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Mocks
{
    public interface IMocks<T>
    {
        public IEnumerable<T> Objects { get; }
        public void AddLead(T p);
        public void UpdateLead(int id, T p);
        public IEnumerable<T> DeleteLead(int id);
        public IEnumerable<T> GetAllLeads();
        public T GetLeadById(int id);
    }
}
