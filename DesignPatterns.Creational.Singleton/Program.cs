using System;

namespace DesignPatterns.Creational.Singleton
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(Sun.Instance);
            Console.WriteLine(Sun.Instance);
            Console.WriteLine(Sun.Instance);
            Console.WriteLine(Sun.Instance);
            Console.WriteLine(Sun.Instance);
        }
    }
}
