using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF
{
     public class CalculatorViewModel
    {
        private int? FirstNumber;
        private int? SecondNumber;
        private string UserChosenMathOperator;
        private int Output;
        private List<string> Operators = new List<string>()
        {
        "Addition",
        "Subtraction",
        "Multiplication",
        "Division",
        "Exponential"
        };

        public CalculatorViewModel()
        {

        }


        public List<string> _operators
        {
            get
            {
                return Operators;
            }
        }
        public int? _firstNumber
        {
            get
            {
                return FirstNumber;
            }
            set
            {
                FirstNumber = value;
            }
        }
        public int? _secondNumber
        {
            get
            {
                return SecondNumber;
            }
            set
            {
                SecondNumber = value;
            }
        }
        public int _output
        {
            get
            {
                return Output;
            }
            set
            {
                Output = value;
            }
        }
        public string _userChosenMathOperator
        {
            get
            {
                return UserChosenMathOperator;
            }
            set
            {
                UserChosenMathOperator = value;
            }
        }
        public string _OutputToString
        {
            get
            {
                return Output.ToString();
            }
        }



    }
}
