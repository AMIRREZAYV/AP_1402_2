using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            Console.Write("Adad Aval Ra Vared Konid : \n");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adad Dovom Ra Vared Konid : \n");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adadhaye Aval Beyn Adad Adad Aval Va Dovom : \n");
            for (int i = num_1; i < num_2; i++)
            {
                bool Isprime = true;

                if (i < 2)
                {
                    Isprime = false;
                }
                if (i = 2)
                {
                    Isprime = true;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Isprime = false;
                        break;

                    }
                }
                if (Isprime)
                {

                    Console.WriteLine(i);
                }

            }

        }
    }
}
