using System;
using System.ComponentModel.DataAnnotations;

namespace data.Models
{
    public class Group : IEntity
    {
        [Key]
        public string NameGroup { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string StartDate { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public string Log { get; set; }
    }
}
