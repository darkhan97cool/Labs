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
            int a, b;
            Console.WriteLine("Please enter inputs...");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                    }
                    if(cnt==1)
                    {
                        Console.WriteLine(i);
                        Console.Write(" "); 
                }
            }
            Console.ReadKey();
                
          }           
            
     }
}

