using System;

namespace data.Models
{
    public class History
    {
        public int IdLead  { get; set; }
        public string HistoryText { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
