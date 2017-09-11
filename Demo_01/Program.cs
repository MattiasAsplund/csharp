using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //OODemo();
            //Testing();
        }

        private static void OODemo()
        {
            var tv = new Product { Name = "Samsung 55", Price = 5000 };
            Console.WriteLine(tv);
            Console.ReadLine();
        }

        private static void Testing()
        {
            int totalAge = 0;
            for (int age = 0; age < 100; age++)
            {
                totalAge += age;
                Console.WriteLine(age);
            }
            Console.WriteLine(totalAge);
        }
    }
}
