using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveryDay.Calc.Calculation.Interface
{
    public interface IOperation
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get;}

        /// <summary>
        /// входные параметры
        /// </summary>
        double[] Input { get; set; }

        /// <summary>
        /// Получить результат
        /// </summary>
        /// <returns>Результат операции</returns>
        double? GetResult();
    }
}
