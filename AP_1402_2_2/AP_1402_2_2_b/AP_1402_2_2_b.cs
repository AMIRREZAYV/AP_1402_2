using System;
namespace project2
{
    class test
    {
        public static void Main()
        {
            System.Console.Write(" Yek Adad 4 Raghami Vared Konid : \n");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum += num % 10 ;// یکان
            num /= 10 ;
            sum += num % 10;// دهگان
            num /= 10 ;
            sum += num % 10;// صدگان
            num /= 10 ;
            sum += num ;// هزارگان

            Console.WriteLine(sum);
        }
    }
}