using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder
{
    internal class Program
    {
        static void GetPermutations(string str, string prefix)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(prefix); 
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    GetPermutations(rem, prefix + str[i]);
                }
            }
        }

        static void Main()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            Console.WriteLine("Все возможные перестановки:");
            GetPermutations(input, "");
        }
    }
}
