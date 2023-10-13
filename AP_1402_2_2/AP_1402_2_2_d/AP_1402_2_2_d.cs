using System;

class Program
{
    static void Main()
    {
        Console.Write("Adad Aval Ra Vared Konid :\n");
        int num_1 = int.Parse(Console.ReadLine());

        Console.Write("Adad Dovom Ra Vared Kpnid :\n");
        int num_2 = int.Parse(Console.ReadLine());

        Console.Write("Adad Sevom Ra Vared Konid :\n");
        int num_3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Adad Haye Beyne " + num_1 + " Va " + num_2 + " Ke Majmoo Arghameshan Barabar " + num_3 + " Ast :\n");
        for (int i = num_1; i <= num_2; i++)
        {
            int sum = 0;
            int temp = i;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum == num_3)
            {
                Console.WriteLine(i);
            }
        }
    }
}