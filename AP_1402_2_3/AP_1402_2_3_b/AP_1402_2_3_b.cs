using System;
using System.Runtime.InteropServices;

namespace project
{
    class Test
    {
        public static void Main()
        {
            double X=Convert.ToDouble(Console.ReadLine());
            double Y=Convert.ToDouble(Console.ReadLine());

            calc(X, Y);
        }
        private static void calc(double X, double Y) { 
        double z=Math.Sqrt(Math.Abs(X)+Math.Pow(Y, 2));
            Console.WriteLine(z);
        }
    }
}