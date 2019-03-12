using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2RegistrationForm.Models
{
    public class Student
{
        [Required(ErrorMessage = "Please enter your name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Please choose if you are graduated or not")]
        public bool? hasGraduate { get; set; }
    }
}
