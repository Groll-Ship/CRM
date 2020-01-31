using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace data.Models
{
    public class Lead 
    {
        public int IdLead { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Second name cannot be longer than 50 characters.")]
        public string SName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DateBirthday { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DateRegistration { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Numder { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        public bool AccessStatus { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }
        public int IdStatus { get; set; }
        public int IdCourse { get; set; }

        public virtual ICollection<History> History { get; set; }
    }
}
