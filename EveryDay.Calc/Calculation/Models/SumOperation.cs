using EveryDay.Calc.Calculation.Interfaces;
using System.Linq;

namespace EveryDay.Calc.Calculation.Models
{
    public class SumOperation : IOperation
    {
        public double[] Input { get; set; }

        public string Name
        {
            get { return "Sum"; }
        }

        public double? GetResult()
        {
            return Input.Sum();
        }
    }
}
