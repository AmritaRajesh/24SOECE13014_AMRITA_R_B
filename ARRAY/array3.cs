using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA_R_B.ARRAY
{
    internal class array3
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

            Array.Reverse(arr);

            Console.WriteLine("Elements in reverse order:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
