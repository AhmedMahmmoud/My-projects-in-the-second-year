using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size=int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" Enter the value of array  ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number to check in array or not");
            int givennumber = int.Parse(Console.ReadLine());
            bool searchFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == givennumber)
                {
                    Console.WriteLine($"The element { givennumber } is found at index {i} ");
                    searchFound = true;
                }
            }
            if (!searchFound)
                Console.WriteLine("This number does not exist in array");
            Console.ReadKey();
        }
    }

}

