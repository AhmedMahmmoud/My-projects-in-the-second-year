using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research_in_array
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 70, -30, -22, 41, 40 };

            int J = -1;
            Console.WriteLine("enter the value to research it in array or not ");
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
                Console.WriteLine(" the element not found");
            else
                Console.WriteLine(" the element is found at index " + J);

            Console.ReadLine();
        }

    }
}
