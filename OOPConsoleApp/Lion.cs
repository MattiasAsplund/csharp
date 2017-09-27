using System;

namespace OOPConsoleApp
{
    internal class Lion : Animal
    {
        public Lion()
        {
        }
        internal override void Eat()
        {
            base.Eat();
            Console.WriteLine("Hunting prey.");
        }
    }
}