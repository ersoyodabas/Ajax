using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Class { get; set; }

        public static List<Student> StudentList = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Neslihan",
                Surname = "Yağmur",
                Age =22,
                School = "İstanbul Üniv.",
                Class = "11-A"
            },
            new Student
            {
                Id = 2,
                Name = "Kemal",
                Surname = "Türk",
                Age = 23,
                School = "Çorum Üniv.",
                Class = "12-C"
            }
        };

    }
}