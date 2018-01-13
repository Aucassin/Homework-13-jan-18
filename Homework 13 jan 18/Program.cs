using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13_jan_18
{
    static class ConvertTemp
    {
        public static double FtoK(double temperature)
        {
            return (temperature + 459.67) * 5 / 9;
        }
        public static double KtoF(double temperature)
        {
            return (temperature * 9 / 5) - 459.67;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double mytemperature = double.Parse(Console.ReadLine());
            Console.WriteLine(ConvertTemp.FtoK(mytemperature));
            Console.WriteLine(ConvertTemp.KtoF(mytemperature));
        }
    }
}
