using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            string number;
            number = Console.ReadLine();
            n = int.Parse(number);
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 3 == 0 && num[i] % 5 != 0)
                {
                    Console.WriteLine(num[i]);
                }

            }
        }
    }
}
