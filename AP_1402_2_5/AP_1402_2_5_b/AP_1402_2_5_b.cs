using System;
namespace prj
{
    class Circle
    {
        double pi = 3.14;
        private double r;

        public double R
        {
            get { return r; }
            set { if (value > 0)
                {
                    r = value;
                } 
            }
        }
        public Circle() { }
        public Circle(double R)
        {
            r=R;
        }
        public double S()
        {
            double Res = pi * Math.Pow(r,2);
            return Res;
        }
        public double A()
        {
            double Res = 2 * pi * r;
            return Res;
        }
    }
    class Test
    {
        public static void Main()
        {
            Circle C = new Circle(12);
            double a = C.A();
            double s = C.S();

            Console.WriteLine(a);
            Console.WriteLine(s);
        }
    }
}