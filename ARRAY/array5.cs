using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA_R_B.ARRAY
{
    internal class array5
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

            int duplicateCount = 0;

            // Count duplicate elements
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicateCount++;
                        break; // Avoid counting same element multiple times
                    }
                }
            }
            Console.WriteLine("\nTotal number of duplicate elements: " + duplicateCount);
        }
    }
}
