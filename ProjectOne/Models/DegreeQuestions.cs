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
        public int DegreeID { get; set; }
        public int UserID { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
    }
}