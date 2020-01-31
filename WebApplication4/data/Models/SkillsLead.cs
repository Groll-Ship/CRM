using System;

namespace data.Models
{
    public class SkillsLead 
    {
        public int LeadID { get; set; }
        public Lead Lead { get; set; }
        public int SkillsID { get; set; }

        public Skills Skill { get; set; }
    }
}
