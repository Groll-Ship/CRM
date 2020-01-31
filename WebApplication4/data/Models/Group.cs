using System;

namespace data.Models
{
    public class Groupe
    {
        public string GroupeId  { get; set; }
        public int IdCourse { get; set; }
        public string StartDate { get; set; }
        public int IdTeacher { get; set; }
        public string Log { get; set; }
    }
}
