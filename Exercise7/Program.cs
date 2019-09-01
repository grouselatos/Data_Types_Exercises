using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            const float PI = 3.1415926535f;

            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * PI * (r * r));

            Console.WriteLine(4f / 3f * PI * (r * r * r));

            Console.ReadKey();
        }
    }
}
