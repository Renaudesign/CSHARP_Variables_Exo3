using System;

namespace CSHARP_Variables_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1;
            string value2;

            Console.WriteLine("Choose a value");
            value1 = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", value1);

            Console.WriteLine("Choose another value");
            value2 = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", value2);
        }
    }
}
