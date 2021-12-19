using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregrysMetod
{
    class Program
    {


        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            double result = Sum(2.4, 5.6);
            //int result = Sum(2, 3);
            Console.WriteLine(result);
        }
    }
}
