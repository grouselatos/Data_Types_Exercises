using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter, letter1, letter2;

            Console.Write("Input letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{letter2} {letter1} {letter}");

            Console.ReadKey();
        }
    }
}
