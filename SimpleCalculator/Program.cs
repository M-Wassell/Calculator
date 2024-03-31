using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            
            {InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstInput = inputConverter.ConvertInputToNumber(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondInput = inputConverter.ConvertInputToNumber(Console.ReadLine());

            double result = calculatorEngine.Calculate(firstInput, operation, secondInput);

            Console.Write(result); 
            
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }



    }
}
