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

        [Required(ErrorMessage = "Please enter in a degree ID")]
        public int DegreeID { get; set; }

        [Required(ErrorMessage = "Please enter in a user ID")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter in a question")]
        public String Question { get; set; }

        [Required(ErrorMessage = "Please enter in an answer")]
        public String Answer { get; set; }
    }
}