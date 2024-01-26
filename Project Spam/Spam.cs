using System;
namespace project
{
    class Spam
    {
        private string[] words;

        public string[] Words
        {
            get { return words; }
            set { words = value; }
        }
        public Spam() { }
        public Spam(string kalame)
        {
            words = kalame.Split(' ');
        }

        public int Erors()
        {
            int temp = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (spams(words[i]))
                {
                    temp++;
                }
            }
            return temp;
        }
        public bool spams(string word)
        {
            bool Harfbozorg = false;
            bool Biseda = true;
            bool Alamat = false;
            bool Tekrari = false;

            int bozorg = 0;
            char harfghabl = ' ';
            int tekrari = 0;

            for (int z = 0; z < word.Length; z++)
            {

                for (int j = z + 1; j < word.Length; j++)
                {
                   if (word[z] == word[j])
                   {
                       tekrari++;
                   }
                   if (tekrari >= 3)
                   {
                       Tekrari = true;
                       break;
                   }

                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                char a = word[i];
                if (char.IsUpper(a))
                {
                    bozorg++;
                }
                if ("aeiou".Contains(char.ToLower(a)))
                {
                    Biseda = false;
                }
                if (!char.IsLetter(a))
                {
                    Alamat = true;
                }
                harfghabl = a;
            }
            Harfbozorg = bozorg >= 2;
            return Harfbozorg || Biseda || Alamat || Tekrari;
        }
    }
    
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Yek jomle vared konid:");
            string kalame = Console.ReadLine();
            Spam sp=new Spam(kalame);
            int eror = sp.Erors();
            Console.WriteLine("Tedade Kalamat Spam = " +eror);

        }
    }
}