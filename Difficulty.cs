using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Difficulty
    {
        public string Level { get; set; }
        public Double MinValue { get; set; }
        public Double MaxValue { get; set; }
        public String[] operands { get; set; }

        public Difficulty(string level, Double minValue, Double maxValue)
        {
            Level = level;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsValidSolution(Double solution)
        {
            return true;
        }
    }

    public class Easy : Difficulty
    {
        public Easy() : base("Easy", 0, 10)
        {
            operands = new string[] { "+", "-",  };
        }
        
        public bool isValidSolution(Double solution)
        {
            return solution >= 0;
        }
    }

    public class Normal : Difficulty
    {
        public Normal() : base("Normal", 0, 100)
        {
            operands = new string[] { "+", "-", "*"};
        }
        
        public bool isValidSolution(Double solution)
        {
            return true;
        }
    }

    public class Hard : Difficulty
    {
        public Hard() : base("Hard", -100, 1000)
        {
            operands = new string[] { "+", "-", "*", "/" };
        }

        public bool isValidSolution(Double solution)
        {
            return true;
        }
    }

}
