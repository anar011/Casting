using ServiceLayer.Services;
using ServiceLayer.Services.Interface;

namespace Casting.Controllers
{
    public class CalculateController
    {
        public void Calculate()
        {
            ICalculationService service = new CalculationService();
            {
                var result = service.Calculate(3, 9, "+");

                Console.WriteLine(result);

              
            }

        }



    }
}
