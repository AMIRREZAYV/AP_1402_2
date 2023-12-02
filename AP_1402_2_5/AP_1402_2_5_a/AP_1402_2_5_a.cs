using project1;
using System;
namespace prj
{
    class Test
    {
        public static void Main()
        {
            Teacher th = new Teacher("123", "Ali", "Ahmadi", 40, 40000);
            double pay = th.Paywent();
            Console.WriteLine(pay);
        }
    }
}
namespace project1
{
    public class Teacher
    {
        private string id;
        private string name;
        private string lastname;
        private int hour;
        private int payperonehour;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Payperonehour
        {
            get { return payperonehour; }
            set
            {
                if (value > 0)
                { payperonehour = value; }
            }
        }

        public Teacher() { }
        public Teacher(string ID, string Name, string Lastname, int Hour, int Payperonehour)
        {
            id = ID;
            name = Name;
            lastname = Lastname;
            hour = Hour;
            payperonehour = Payperonehour;
        }
    
        public double Paywent()
        {
            return hour * payperonehour;
        }
    }
    
 }
