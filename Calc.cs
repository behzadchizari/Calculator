using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double First { get; set; }
        public double Second { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
        public List<string> History{ get; set; }

        void AddHistory()
        {
            var his = First.ToString() + Operation + Second.ToString() + " = " + Result.ToString()+"\n";
            History.Add(his);
        }
    }
}
