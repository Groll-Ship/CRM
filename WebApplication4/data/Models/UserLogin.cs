using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace data.Models
{
    public class UserLogin
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        [Required]
        public string LoginName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
