using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess4.Models
{
    public class Student
    {
       public Student()
        {
            this.StudentName = "default";
        }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}
