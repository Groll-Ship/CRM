using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Models
{
    public class Lead 
    {
        public int IdLead  { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public DateTime DateBirthday { get; set; }
        public DateTime DateRegistration { get; set; }
        public int Numder { get; set; }
        public string EMail { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string  GroupeName { get; set; }
        [ForeignKey("GroupeName")]
        public Groupe  Groupe { get; set; }
        public int StatusId { get; set; }
        public Status  Status{ get; set; }
        public bool  AccessStatus{ get; set; }
    }
}
