using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const float Pi = 3.14f;
            float number = 1.2f;
            decimal number2 = 1.2m;
            byte number3 = 255;
            Console.WriteLine(number3+1);
            number3 += 1;
            Console.WriteLine(number3);
        }
    }
}
