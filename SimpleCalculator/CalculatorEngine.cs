using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class CalculatorEngine
    {
        public double Calculate(double firstInput, string operation, double secondInput) 
        {
            double result;

            switch(operation.ToLower())
            {
                case "+":
                    result = firstInput + secondInput;
                break;

                    case "-":
                    result = firstInput - secondInput;
                    break;

                    case "*":
                    result = firstInput * secondInput;
                        break;

                    case "/":
                    result = firstInput / secondInput;
                    break;

                default:
                    throw new InvalidProgramException("Please insert a valid operation --> +, -, *, /");

            }
             return result;
        }
    }
}
