using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Mianterm:");
            double x =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Payanter:");
            double y =Convert.ToDouble(Console.ReadLine());

            double Result =calc(x,y);
            Console.WriteLine(Result);

        }
        private static double calc(double x, double y)
        {
            double N = 0.35 * x + 0.65 * y;
            return N;
        }
    }
}