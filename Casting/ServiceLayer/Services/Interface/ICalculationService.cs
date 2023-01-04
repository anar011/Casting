
using System.Collections.Generic;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface ICalculationService
    {
        double Calculate(double num1, double num2, string operation);

    }
}
