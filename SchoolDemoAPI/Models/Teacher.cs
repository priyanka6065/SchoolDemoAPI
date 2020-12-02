using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemoAPI.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Column(TypeName ="varchar(50)")]
        public String FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String LastName { get; set; }

        public String Qualification { get; set; }

        public int Salary { get; set; }
    }
}
