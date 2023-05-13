using System;

namespace myVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 13;

            Console.WriteLine(-1 + 4 * myVar);

            Console.WriteLine((35 + 5) % myVar);

            Console.WriteLine(14 + -4 * 6 / 12);

            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2);

            if (myVar < myVar * myVar)

                Console.WriteLine("myVar is greater than 4");


        }
    }
}