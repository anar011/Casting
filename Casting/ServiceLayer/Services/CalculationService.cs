using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using ServiceLayer.Services.Interface;


namespace ServiceLayer.Services
{
    public class CalculationService : ICalculationService
    {
        public double Calculate(double num1, double num2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result;

                case "-":
                    result = num1 - num2;
                    return result;
                case "*":
                    result = num1 * num2;
                    return result;
                case "/":
                    result = num1 / num2;
                    return result;

            }

            return default;

        }
    }
}
