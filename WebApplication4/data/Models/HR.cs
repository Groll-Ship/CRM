using System;
using System.ComponentModel.DataAnnotations;

namespace data.Models
{
    public class HR
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
    }
}
