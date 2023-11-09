using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            double w = Convert.ToDouble(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            double Result = calc(w, l, h);
            Console.WriteLine(Result);
        }

        private static double calc(double w, double l, double h)
        {
            double vol =w*l*h;
            return vol;
        }
       
    }
}