//9. Write a C# Sharp program to delete an element at the desired position from an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA_R_B.ARRAY
{
    internal class array9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Sort in descending order
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("\nArray in descending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
