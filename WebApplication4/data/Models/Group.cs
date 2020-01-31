using System;
using System.ComponentModel.DataAnnotations;

namespace data.Models
{
    public class Group
    {
        [Key]
        public string GroupName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string StartDate { get; set; }
        public int TeacherId { get; set; }
        public Teachers Teachers { get; set; }
        public string Log { get; set; }
    }
}
