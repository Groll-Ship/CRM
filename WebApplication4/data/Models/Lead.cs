using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Models
{
    public class Lead: IEntity
    {
        [Key]
        public int Id { get; set; }

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
        public string NameGroup { get; set; }
        [ForeignKey("NameGroup")]
        public Group Group { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public virtual ICollection<History> History { get; set; }

       
    }
}
