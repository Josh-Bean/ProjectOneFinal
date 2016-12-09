//Joshua Bean, Section 2, Group 14, Last Modified: December 8th, 2016, BYU IS FAQ Page
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    [Table("DegreeQuestions")]
    public class DegreeQuestions
    {
        [Key]
        public int DegreeQuestionID { get; set; }

        [Required]
        [ForeignKey("DegreeID")]
        public virtual DegreeQuestions DegreeID { get; set; }

       [Required]
       [ForeignKey("UserID")]
        public virtual Users UserID { get; set; }

        [Required(ErrorMessage = "Please enter in a question")]
        public String Question { get; set; }

        [Required(ErrorMessage = "Please enter in an answer")]
        public String Answer { get; set; }
    }
}