using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDemoAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public String FirstName { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public String LastName { get; set; }

        public int Age { get; set; }
    }
}
