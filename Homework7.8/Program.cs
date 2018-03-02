using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of elements in the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();

            Console.Write("Even numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 2);
                if (array[i] == 0)
                    Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Odd numbers: ");
            for (int i = 0; i < array.Length; i++)
                if (array[i] != 0)
                    Console.Write(array[i]+" ");
            
        }
    }
}
