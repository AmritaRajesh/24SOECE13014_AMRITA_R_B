﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA_R_B.BHOMI_MAM
{
    internal class pra6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;
            Console.Write("Enter Number 1: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.Write("Enter Number 2: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.Write("Enter Number 3: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            result = Sum(a, b, c);
            Console.WriteLine($"Sum: {result}");
            Console.Read();
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
