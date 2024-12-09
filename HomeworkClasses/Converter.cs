using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1.HomeworkClasses
{
    public class Converter
    {
        public string DecimalToBinary(int decimalNumber)
        {
            // TODO: convert decimal number to binary code using recursion
            if (decimalNumber < 0) return "the number is negative";
            if (decimalNumber == 0) return "0";
            string Binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                Binary = remainder.ToString() + Binary;
                decimalNumber /= 2;
            }
            return Binary;
            throw new NotImplementedException();
        }
    }
}
