using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double? First { get; set; }
        public double? Second { get; set; }
        public double? Result { get; set; }
        public string Operation { get; set; }
        public List<string> History { get;  }
        public Calc()
        {
            First = null;
            Second = null;
            Result = null;
            Operation = null;
        }
        private void AddHistory()
        {
            if (First != null && Second != null && Result != null && Operation != null)
            {
                var his = First.ToString() + " "  + Operation + " "  + Second.ToString() + " = " + Result.ToString() + "\n";
                History.Add(his);
            }
        }
        public void Operate()
        {
            switch (Operation)
            {
                case "+":
                    Result = First + Second;
                    break;
                case "-":
                    Result = First - Second;
                    break;
                case "×":
                    Result = First * Second;
                    break;
                case "÷":
                    Result = First / Second;
                    break;
                default:
                    break;
            }
            //AddHistory();
        }

    }
}
