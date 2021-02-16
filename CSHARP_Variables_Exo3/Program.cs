using System;

namespace CSHARP_Variables_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a value");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered '{value1}', '{value1}' + 33 equals {value1+33}");
            float sum = value1;

            Console.WriteLine("Choose another value");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered '{value2}', '{value2++}'  + 1 equals '{value2}'");

            float division = sum / value2;
            Console.WriteLine($"{value1} divided by {value2} equals {division}");

        }
    }
}
