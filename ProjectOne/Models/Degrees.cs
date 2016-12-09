//Joshua Bean, Section 2, Group 14, Last Modified: December 8th, 2016, BYU IS FAQ Page
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    [Table("Degrees")]
    public class Degrees
    {
        [Key]
        public int DegreeID { get; set; }

        [Required(ErrorMessage="Please enter in a name for the degree")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter in a name for the coordinator")]
        public String Coordinator { get; set; }

        [Required(ErrorMessage = "Please enter in the coordinator title")]
        public String CoordinatorTitle { get; set;}

        [Required(ErrorMessage = "Please enter in the coordinator office address")]
        public String CoordinatorOffice { get; set; }

        [Required(ErrorMessage = "Please enter coordinator's PhD Education")]
        public String PhDEducation { get; set; }

        [Required(ErrorMessage="Please enter in coordinator's Bachelors Education")]
        public String BachelorsEducation { get; set; }

        [Required(ErrorMessage = "Please enter in the path to the Coordinator Picture")]
        public String CoordinatorPicture { get; set; }
    }
}