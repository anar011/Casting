using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Controllers
{
   public class EmployeeController 
   {
        static Employee[] GetEmployee()
        {
            Employee employee1 = new Employee
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Birthday = new DateTime(1995,10,10),
                Salary = 500


            };
            Employee employee2 = new Employee
            {
                Name = "Samir",
                Surname = "Hesenli",
                Birthday = new DateTime(1996, 09, 9),
                Salary = 600


            };



            Employee employee3 = new Employee
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Birthday = new DateTime(1998, 5, 5),
                Salary = 600


            };


            Employee employee4 = new Employee
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Birthday = new DateTime(1997, 8, 8),
                Salary = 900


            };

            Employee employee5 = new Employee
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Birthday = new DateTime(1999, 6, 66),
                Salary = 900


            };

            Employee[] employee = { employee1, employee2, employee3, employee4, employee5 };

            return employee;

        }

        var startDate = new DateTime(1996, 01, 01);

        var endDate = new DateTime(2000, 11, 11);


        static void GetEmployeeByBirthday(DateTime start, DateTime end)
        {
            var employee = GetEmployee();

            foreach(var Employee in employee)
            {
                if(employee.Birthday > start && employee.Birthday < end)
                {
                    
                }

            }





        }











    }





}

