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
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public String[] Operands { get; set; }

        public Difficulty(string level, int minValue, int maxValue, String[] operands)
        {
            Level = level;
            MinValue = minValue;
            MaxValue = maxValue;
            Operands = operands;
        }
    }

    public class Easy : Difficulty
    {
        public Easy() : base("Easy", 0, 10, new string[] { "+", "-", })
        {
        }      
    }

    public class Normal : Difficulty
    {
        public Normal() : base("Normal", 0, 100, new string[] { "+", "-", "*" })
        {
        }
    }

    public class Hard : Difficulty
    {
        public Hard() : base("Hard", -100, 1000, new string[] { "+", "-", "*", "/" })
        {
        }
    }

}
