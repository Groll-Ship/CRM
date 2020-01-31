using System;
using System.Collections.Generic;
using System.Text;

namespace data.Models
{
    public class Log
    {
        public DateTime Date { get; set; }
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
    }
}
