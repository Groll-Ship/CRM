using System;


namespace data.Models
{
    public class SkillsLead
    {
        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        public int SkillsId { get; set; }
        public Skills Skill { get; set; }
    }
}
