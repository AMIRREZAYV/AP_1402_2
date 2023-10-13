using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            Console.Write("X Ra Vared Konid :\n");
            int x = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Pasokh Ebarat :\n");
            int a = Math.Abs (x);
            double b = Math.Sqrt(a);
            double c = Math.Sqrt(a + b);
            double d = Math.Sqrt(a + c);
            Console.WriteLine(d);
        }
    }
}