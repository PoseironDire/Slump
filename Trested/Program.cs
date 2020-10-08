using System;

namespace Trested
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            Random secondgenerator = new Random();

            //Random between the numbers 50-100 twice
            /*
            while (true)
            {
                int epic = generator.Next(50, 101);
                int epic2 = secondgenerator.Next(50, 101);

                Console.WriteLine("1st: " + epic);
                Console.WriteLine("2st: " + epic2);

                Console.ReadLine();
            }
            */

            //Random between 2 numbers 0-100 divided by 2

            while (true)
            {
                int epic = generator.Next(101);
                int epic2 = secondgenerator.Next(101);

                int sum = (epic + epic2) / 2;

                Console.WriteLine(sum);

                Console.ReadLine();
            }

        }
    }
}
