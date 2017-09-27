using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // StudentDemo();
            InheritanceDemo();
            Console.ReadLine();
        }

        private static void InheritanceDemo()
        {
            Animal anAnimal = new Animal();
            Lion aLion = new Lion();
            TellAnimalToEatTwice(aLion);
        }

        private static void TellAnimalToEatTwice(Animal anAnimal)
        {
            anAnimal.Eat();
            anAnimal.Eat();
        }

        private static void StudentDemo()
        {
            var mattias = new Student();
            mattias.Name = "Mattias Asplund";
            mattias.Email = "mattias@mattiasasplund.se";
            mattias.TooTired += Mattias_TooTired;
            mattias.StudyHarder();
            mattias.StudyHarder();
            mattias.StudyHarder();
            Console.WriteLine($"Hello world to {mattias}");
        }

        private static void Mattias_TooTired(object sender, EventArgs e)
        {
            Console.WriteLine("Student needs to rest.");
        }
    }
}
