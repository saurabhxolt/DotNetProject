using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quosten2.Models
{
    public class Student
    {
        [Key]
         public int StudentId { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        [Required]
        [Range(1,100,ErrorMessage ="The{0} must be between {1} and {2}")]
        public int JavaMarks { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "The{0} must be between {1} and {2}")]
        public int DotNetMarks { get; set; }
    }
}