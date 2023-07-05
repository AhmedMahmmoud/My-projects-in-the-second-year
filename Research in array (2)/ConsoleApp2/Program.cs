using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int [size];
            Console.WriteLine("Enter the array values");
            for (int i = 0; i < arr.Length; i++)
            { 
             arr[i]= int.Parse(Console.ReadLine());           
            }

            int J = -1;
            Console.WriteLine("Enter the value to search it in array or not ");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (X == arr[i])
                {
                    J = i;
                    break;
                }
            }
            if (J == -1)
                Console.WriteLine(" The element not found");
            else
                Console.WriteLine(" The element is found at index " + J);

            Console.ReadLine();
        }

    }
}
