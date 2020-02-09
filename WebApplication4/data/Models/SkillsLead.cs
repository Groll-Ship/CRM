using System;
using System.Collections.Generic;


namespace data.Models
{
    public class SkillsLead : IEntity
    {
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        public List<int> SkillsId { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
