using System;

namespace Uppgift3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett ord: ");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv ett annat ord: ");
            string ord2 = Console.ReadLine();
            Console.WriteLine("Skriv ett tredje ord: ");
            string ord3 = Console.ReadLine();

            if (ord1.CompareTo(ord2) < 0 && ord1.CompareTo(ord3) < 0)
            {
                Console.WriteLine("\"" + ord1 + "\" kommer före \"" + ord2 + "\" och \"" + ord3 + "\" i bokstavsordning");
            }

            else if (ord2.CompareTo(ord1) < 0 && ord2.CompareTo(ord3) < 0)
            {
                Console.WriteLine("\"" + ord2 + "\" kommer före \"" + ord1 + "\" och \"" + ord3 + "\" i bokstavsordning");
            }

            else
            {
                Console.WriteLine("\"" + ord3 + "\" kommer före \"" + ord1 + "\" och \"" + ord2 + "\" i bokstavsordning");
            }
        }
    }
}