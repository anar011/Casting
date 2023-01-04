using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface IStudentService
    {
        int GetStudentCount();
        double GetStudentsAverageByAge();
        string GetStudentsFilteredByEmail();

        string GetStudentsFilteredByAddress();

        string GetStudentsListNameSurname();

        string GetStudentSameName();


    }
}
