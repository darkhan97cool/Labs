using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter input");
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=2;i <= a; i++)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 1)
            {
                Console.WriteLine("Entered number is Prime");
            }
            else
            {
                Console.WriteLine("Entered number is Complex");
            }           
            Console.ReadKey();
        }
    }
}
