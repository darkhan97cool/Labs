using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrComplex
{
    class Program
    {
        /// <summary>
        /// Here, I can enter just one number but 
        /// I want enter set of numbers then find prime numbers from there.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter input...");
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=1;i <= a; i++)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2)
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
