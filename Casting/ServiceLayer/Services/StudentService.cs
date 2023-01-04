using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        public int GetStudentCount()
        {
            var students = GetAll();
            int count = 0;
            foreach (var item in students)
            {
                count++;
            }

            return count;

        }

        public double GetStudentsAverageByAge()
        {
            var students = GetAll();


            double sumAge = 0;           
            foreach (var item in students)
            {
                sumAge += item.Age;
            }

            return sumAge / students.Length;

        }


         public  string GetStudentsFilteredByEmail()
         {
            var students = GetAll();

            string searchText = "c";

            foreach(var item in students)
            {
                if (item.Email.ToLower().Contains(searchText.ToLower()))
                {
                    searchText = item.Email;
                }
                                                    
            }
           
            return searchText;
            
         }




        public string GetStudentsFilteredByAddress()
        {
            throw new NotImplementedException();
        }

        public string GetStudentsListNameSurname()
        {
            throw new NotImplementedException();
        }

        public string GetStudentSameName()
        {
            throw new NotImplementedException();
        }











        public Student[] GetAll()
        {
            Student student1 = new Student
            {
                Id = 1,
                Name = "Hesen",
                Surname = "Hesenli",
                Email = "hesenn@gmail.com",
                Age = 19,
                Education = "Higher",
                Address = "Ehmedli"

            };

            Student student2 = new Student
            {
                Id = 2,
                Name = "Cemil",
                Surname = "Cemilli",
                Email = "cemil@gmail.com",
                Age = 23,
                Education = "Higher",
                Address = "Xetai"

            };

            Student student3 = new Student
            {
                Id = 3,
                Name = "Cavid",
                Surname = "Cavidli",
                Email = "cavid@gmail.com",
                Age = 25,
                Education = "Higher",
                Address = "Ehmedli"

            };

            Student student4 = new Student
            {
                Id = 4,
                Name = "Qurban",
                Surname = "Qurbanli",
                Email = "qurvan@gmail.com",
                Age = 22,
                Education = "Higher",
                Address = "Ehmedli"

            };

            Student student5 = new Student
            {
                Id = 5,
                Name = "Meherrem",
                Surname = "Meherremov",
                Email = "Meherrem@gmail.com",
                Age = 26,
                Education = "Higher",
                Address = "Xetai"

            };


            Student[] students = { student1, student2, student3, student4, student5 };

            return students;    


        }

       
    }

}
