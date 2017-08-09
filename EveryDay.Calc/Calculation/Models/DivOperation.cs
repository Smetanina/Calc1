using EveryDay.Calc.Calculation.Interfaces;
using System.Linq;

namespace EveryDay.Calc.Calculation.Models
{
    public class DivOperation : IOperation
    {
        public double[] Input { get; set; }

        public string Name
        {
            get { return "Div"; }
        }

        public double? GetResult()
        {
            return Input[0] / Input [1];
        }
    }
}
