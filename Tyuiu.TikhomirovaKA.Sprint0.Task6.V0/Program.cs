using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TikhomirovaKA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayments = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arrayments));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arrayments));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arrayments));
            Console.ReadKey();
        }
    }
}
