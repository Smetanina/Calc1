using EveryDay.Calc.Calculation;
using EveryDay.Calc.Calculation.Interfaces;
using EveryDay.Calc.Calculation.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using SConsole = System.Console;
using System.IO;

namespace EveryDay.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = args[0].ToLower();

            var x = Str2Int(args[1]);

            var y = Str2Int(args[2]);

            var calc = new Calculator(LoadOperations());

            var result = calc.Calc(oper, new[] { x, y });

            SConsole.WriteLine(result.ToString());

            SConsole.ReadKey();
        }

        private static IEnumerable<IOperation> LoadOperations()
        {
            var opers = new List<IOperation>();

            var typeOperation = typeof(IOperation);

            // найти все dll, которые находятся рядом с нашим exe
            var dlls = Directory.GetFiles(Environment.CurrentDirectory, "*.dll");

            // перебираем
            foreach (var dll in dlls)
            {
                // загружаем сборку из файла
                var assembly = Assembly.LoadFrom(dll);
                // получаем типы/классы/интерфейсы из сброрки
                var types = assembly.GetTypes();

                // перебираем типы
                foreach (var type in types)
                {
                    var interfaces = type.GetInterfaces();
                    // если тип реализует наш интерфейс 
                    if (interfaces.Contains(typeOperation))
                    {
                        // пытаемся создать экземпляр
                        var instance = Activator.CreateInstance(type) as IOperation;
                        if (instance != null)
                        {
                            // добавляем в список операций
                            opers.Add(instance);
                        }
                    }
                }
            }

            return opers;
        }

        private static double Str2Int(string str)
        {
            double result;

            if (!double.TryParse(str, out result))
            {
                SConsole.WriteLine("Не удалось преобразовать \"{0}\" в число", str);
            }
            return result;
        }
    }
}
