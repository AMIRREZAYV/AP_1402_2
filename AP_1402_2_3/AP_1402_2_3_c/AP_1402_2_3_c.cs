using System;
namespace orpject
{
    class Test
    {
        public static void Main()
        {
            double X=Convert.ToDouble(Console.ReadLine());

            double y = calc(X);
            Console.WriteLine(y);
        }
        private static double calc(double X)
        {
            double y = Math.Pow(X,2)+4*X-5;
            return y;
        }
    }
}