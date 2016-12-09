//Joshua Bean, Section 2, Group 14, Last Modified: December 8th, 2016, BYU IS FAQ Page
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter in an email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please enter a valid email address.")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter in a password")]
        public String Password { get; set; }

        [Required(ErrorMessage = "Please enter in a first name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please enter in a last name")]
        public String LastName { get; set; }
    }
}