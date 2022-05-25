using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Data
    {
        public void Rifat()
        {
            Console.WriteLine("Hi , this is Rifat");
        }

        internal void Rifff()
        {
            Console.WriteLine("Hi , this is Rifff");
        }

        private void Ratul()
        {
            Console.WriteLine("Hi , this is Rifff");
        }

        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);
        }

        public void CircleArea(double radious)
        {
            double area;
            area=3.1416 *radious * radious;
            Console.WriteLine("Area of the circle is "+ area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi from Dotnet...");

            Data obj = new Data();
            obj.Rifff();

            string name;
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Ok, your name is " + name);

            int a, b;
            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            obj.Add(a,b);

            double radius;
            Console.WriteLine("Enter a radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            obj.CircleArea(radius);
        }
    }
}
