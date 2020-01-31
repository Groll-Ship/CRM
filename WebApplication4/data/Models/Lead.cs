using System;

namespace data.Models
{
    public class Lead 
    {
        public int IdLead  { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string DateBirthday { get; set; }
        public string DateRegistration { get; set; }
        public int Numder { get; set; }
        public string EMail { get; set; }
        public int  IdCourse{ get; set; }
        public string  GroupeName{ get; set; }
        public int  IdStatus{ get; set; }
        public bool  AccessStatus{ get; set; }
    }
}
