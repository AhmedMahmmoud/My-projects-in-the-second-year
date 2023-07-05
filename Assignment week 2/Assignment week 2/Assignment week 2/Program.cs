using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_week_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array that it consists of 4 rows and 3 columns");
            
            int[,] array_2d = Readmethod();
            int[] ArrayRows = Sum_Row(array_2d);
            int[] ArrayCols = Sum_cols(array_2d);

            int index = ArrayCols[2];
            ArrayCols[2] = ArrayRows[2];
            ArrayRows[2] = index;

            Console.WriteLine(" after swap ArrayRow is ");
            Print1dArray(ArrayRows);
            Console.WriteLine(" afetr swap ArrayCols is ");
            Print1dArray(ArrayCols);

            for (int i = 0; i < 4; i++)
            {
                ArrayRows[i] = ArrayRows[i] * 2;
            }
            Console.WriteLine("  after maximize the values in ArrayRow by 2");
            Print1dArray(ArrayRows);
            Print_Average_Max(ArrayCols);
            Console.ReadKey();
        }
        static int[,] Readmethod()
        {
            int x = 0;
            int[,] array_2d = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    Console.WriteLine("Enter the value of row {0} and coloumn {1}", i + 1, z + 1);
                    x = int.Parse(Console.ReadLine());
                    array_2d[i, z] = x;
                }
            }
            return array_2d;
        }
        static int[] Sum_Row(int[,] array_2d)
        {

            int[] ArrayRow = new int[4];
            int x = 0;
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    x = array_2d[i, z];
                    sum += x;
                }
                ArrayRow[i] = sum;
            }
            Console.WriteLine(" summation ArrayRow is ");
            for (int v = 0; v < 4; v++)
            {
                Console.WriteLine(ArrayRow[v]);
            }
            return ArrayRow;
        }
        static int[] Sum_cols(int[,] array_2d)
        {
            int x = 0;
            int sum = 0;
            int[] ArrayCols = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    x = array_2d[z, i];
                    sum += x;

                }
                ArrayCols[i] = sum;
            }
            Console.WriteLine(" summation ArrayCols is ");
            for (int n = 0; n < 3; n++)
            {
                Console.WriteLine(ArrayCols[n]);
            }
            return ArrayCols;
        }
        static void Print1dArray(int[] swap)
        {
            for (int i = 0; i < swap.Length; i++)
            {
                Console.WriteLine(swap[i]);
            }
        }
        static void Print_Average_Max(int[] ArrayCols)
        {
            int sum = 0;
            int x = 0;
            int average = 0;
            int max = ArrayCols[0];
            for (int i = 0; i < 3; i++)
            {
                x = ArrayCols[i];
                sum += x;
                if (i > 0)
                {
                    if (ArrayCols[i] > ArrayCols[i] - 1)
                    {
                        max = ArrayCols[i];
                    }
                }
            }
            average = sum / 3;
            Console.WriteLine("Average is {0}", average);
            Console.WriteLine("Max number is {0}", max);
        }
    }
}