using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace data.Models
{
    public class HistoryGroup : IEntity
    {
        public string GroupName { get; set; }
        public Group Group { get; set; }
        public string HistoryText { get; set; }
        
    }
}
