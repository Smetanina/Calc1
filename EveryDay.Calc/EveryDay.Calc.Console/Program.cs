using EveryDay.Calc.Calculation;
using SConsole = System.Console;

namespace EveryDay.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = args[0];
            
            var x = Str2Int(args[1]);

            var y = Str2Int(args[2]);

            var calc = new Calculator();

            double result = 0.0;

            if (oper.ToLower() == "sum")
            {
                result = calc.Sum(x, y);
            }
            else if (oper.ToLower()  == "div")
                {
                    result = calc.Div(x, y);
                }
            else if (oper.ToLower() == "squa")
                {
                    result = calc.Squa(x);
                
                }
            else if (oper.ToUpper() == "MYSQRT")
            {
                result = calc.MySqrt(x);
            }
            else if (oper.ToLower() == "mult")
            {
                result = calc.Mult(x, y);
            }
            else if (oper.ToLower() == "subt")
            {
                result = calc.Subt(x, y);
            }
            else
            {
                SConsole.WriteLine("Нет такой операции");
            }
            
            SConsole.WriteLine(result.ToString());

            SConsole.ReadKey();
        }


        private static int Str2Int(string str)
        {
            int result;

            if(!int.TryParse(str, out result)){
                SConsole.WriteLine("Не удалось преобразовать \"{0}\" в число", str);
            }
            return result;
        }
    }
}
