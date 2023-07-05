using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EO_elements_in_array
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("array element :");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            findevenodd(arr);
        }
        public static void findevenodd(int[] arr)
        {
            int evencount = 0, oddcount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("{0} is even number ", arr[i]);
                    evencount++;
                }
                else
                {
                    Console.WriteLine("{0} is odd number ", arr[i]);
                    oddcount++;
                }
            }
            Console.WriteLine("The number of even number ={0}", evencount);
            Console.WriteLine("The number of odd number ={0}", oddcount);

            Console.ReadKey();
        }
    }
}
