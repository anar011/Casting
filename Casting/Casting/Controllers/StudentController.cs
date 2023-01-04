using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Controllers
{
    public class StudentController
    {
        public readonly IStudentService _service;
        

        public StudentController()
        {
            _service = new StudentService();
        }
            

        public void GetStudentCount()
        {
            Console.WriteLine(_service.GetStudentCount ());
        }

        public void GetStudentsAverageByAge()
        {
            Console.WriteLine(_service.GetStudentsAverageByAge());
        }

        static void GetStudentsFilteredByEmail()
        {
            Console.WriteLine(.GetStudentsFilteredByEmail());
        }




    }
}
