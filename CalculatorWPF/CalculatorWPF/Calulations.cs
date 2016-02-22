using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalculatorWPF
{
    public class Calulations
    {
        public int CalculateOutput(int firstNumber, int secondNumber, string sign)
        {
            switch (sign)
            {
                case "Addition":
                    return (firstNumber + secondNumber);
                case "Subtraction":
                    return (firstNumber - secondNumber);
                case "Multiplication":
                    try
                    {
                        return (firstNumber * secondNumber);
                    }
                    catch(OverflowException)
                    {
                        MessageBox.Show("Overflow Error output is too large.");
                        return 0;
                    }
                case "Division":
                    if (secondNumber == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return (firstNumber / secondNumber);
                    }
                case "Exponential":
                    try
                    {
                        return Convert.ToInt32(Math.Pow(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)));
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Overflow Error output is too large.");
                        return 0;
                    }
                default:
                    return 0;

            }
        }
    }
}
