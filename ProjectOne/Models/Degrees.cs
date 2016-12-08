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
        public String Name { get; set; }
        public String Coordinator { get; set; }
        public String CoordinatorTitle { get; set;}
        public String CoordinatorOffice { get; set; }
        public String PhDEducation { get; set; }
        public String BachelorsEducation { get; set; }
        public String CoordinatorPicture { get; set; }
    }
}