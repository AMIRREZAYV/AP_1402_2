using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Do Adad Vared Konid:");
            int num_1 =Convert.ToInt32(Console.ReadLine());
            int num_2 =Convert.ToInt32(Console.ReadLine());

            int bmm = BMM (num_1, num_2);
            int kmm = KMM (num_1, num_2);

            Console.WriteLine("BMM is :" + bmm +"  " +"KMM is :" +kmm);

        }

        private static int BMM(int num_1, int num_2)
        {
            int bmm;
            while (num_2 != 0)
            {
                int temp = num_2;
                num_2 = num_1 % num_2;
                num_1 = temp;
            }
            bmm = num_1;
            return bmm; 
        }
        private static int KMM(int num_1, int num_2)
        {
            int kmm;
            
            kmm = (num_1 * num_2) / BMM(num_1, num_2);
            return kmm;
        }
    }
}