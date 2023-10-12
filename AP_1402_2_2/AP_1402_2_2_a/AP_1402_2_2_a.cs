using System;
namespace project
{
    class test {

        public static void Main() {
            System.Console.Write(" 9 Adad Vared Konid : \n");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string i = Console.ReadLine();
            int num_1 = Convert.ToInt32(a);
            int num_2 = Convert.ToInt32(b);
            int num_3 = Convert.ToInt32(c);
            int num_4 = Convert.ToInt32(d);
            int num_5 = Convert.ToInt32(e);
            int num_6 = Convert.ToInt32(f);
            int num_7 = Convert.ToInt32(g);
            int num_8 = Convert.ToInt32(h);
            int num_9 = Convert.ToInt32(i);
            int determinan = num_1 * (num_5 * num_9 - num_6 * num_8) - num_2 * (num_4 * num_9 - num_6 * num_7) + num_3 * (num_4 * num_8 - num_5 * num_7);
            Console.WriteLine(determinan);




        }
    }
    
      
    }
