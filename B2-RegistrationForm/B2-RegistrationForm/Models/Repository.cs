using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2RegistrationForm.Models
{
    public static class Repository
    {
        private static List<Student> _student = new List<Student>();
        public static List<Student> GetStudents()
        {
            return _student;
        }
        public static void AddStudent(Student student)
        {
            _student.Add(student);
        }
       
    }
}
