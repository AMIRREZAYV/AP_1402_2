using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            int x=Convert.ToInt32(Console.ReadLine());
            if (x%2 ==0)
            {
                Even(x);
            }
            else
            {
                Odd(x);
            }
        }
        private static void Even(int x)
        {
            int sum = 0;
            int mul = 1;
            for (int i = 2;i < x; i+=2)
            {
                sum += i;
                mul *= i;


            }
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("mul = " + mul);
        }
        private static void Odd(int x)
        {
            int sum = 0;
            int mul = 1;
            for(int i = 1; i < x; i += 2)
            {
                sum += i;
                mul *= i;

            }
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("mul = " + mul);
        }
       
    }
}