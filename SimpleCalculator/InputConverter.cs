using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string textInput)
        {
            double convertedNumber;
            if (!double.TryParse(textInput, out convertedNumber))
            {
                throw new ArgumentException("Numeric value expected");
            }
                 return convertedNumber;
            
        }

    }
}
