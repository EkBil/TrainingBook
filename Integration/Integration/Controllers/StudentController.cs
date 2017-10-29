using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Integration.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class StudentController : ApiController
    {
        public static List<Student> _listStudent = new List<Student>
        {
            new Student{Id = 1, Name = "Bilal" },
            new Student{Id = 2, Name = "Koko"}
        };

        public Student GetFromId(int id)
        {
            return _listStudent.Find(x => x.Id == id);
        }

        public List<Student> Get()
        {
            return _listStudent;
        }

    }
}
