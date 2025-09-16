using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA_R_B.BHOMI_MAM
{
    internal class pra9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string toggleCaseName = ToggleCase(name);
            Console.WriteLine($"Toggle Case Name: {toggleCaseName}");
            Console.ReadLine();
        }
        static string ToggleCase(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    result.Append(char.ToLower(c));
                }
                else if (char.IsLower(c))
                {
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(c); // Keep non-alphabetic characters unchanged
                }
            }
            return result.ToString();
        }
    }
}
