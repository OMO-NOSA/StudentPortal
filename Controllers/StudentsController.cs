using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            var students = new List<Student>
            {
                new Student
                {
                    MatricNumber = "ZED1002324",
                    FirstName = "Nosa",
                    LastName = "Omorodion",
                },

                new Student
                {
                    MatricNumber = "ZED00100",
                    FirstName = "Bayonle",
                    LastName = "Amzat",
                },

                new Student
                {
                    MatricNumber = "ZED00101",
                    FirstName = "Julius",
                    LastName = "Aghahowa",
                }
            };

            return students;
        }
    }
}