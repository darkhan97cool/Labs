using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Example1
{
    class Program
    {
        /// <summary>
        /// My program to finding sum of numbers and this gonna to find out prime numbers
        /// </summary>
        static void Main(string[] args)
        {
            F3();            
            F5();
            F4();
            Console.ReadKey();
        }

        private static void F5()
        {
            // This method find max and min  numbers from input.txt! Then write to the Console.
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            string[] arr = sr.ReadLine().Split();
            int min = int.Parse(arr[0]);
            int max = int.Parse(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {

                if (min > int.Parse(arr[i]))
                {
                    min = int.Parse(arr[i]);
                }
                if (max < int.Parse(arr[i]))
                {
                    max = int.Parse(arr[i]);
                }
            }
            Console.WriteLine("Max number is " + max);
            Console.WriteLine("Min number is " + min);
            sw.Close();
            sr.Close();
            fs.Close();
        }

        private static void F4()
        {
            // This method prime  number from input.txt! Then write it to the input.txt.
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            string[] arr = sr.ReadLine().Split();
            List<int> primes = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                int cnt = 0;
                int f = int.Parse(arr[i]);
                for (int g = 2; g <= f; g++)
                {
                    if (f % g == 0)
                    {
                        cnt++;
                        if (cnt > 1)
                            break;
                    }
                    if (cnt == 1)
                    {
                        primes.Add(f);
                    }
                }
            }
            sw.WriteLine("Min Prime number is:" + primes.Min());
            sw.Close();
            sr.Close();
            fs.Close();
        }
       
        private static void F3()
        {
            // This method find sum of numbers.
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string[] arr = sr.ReadLine().Split();
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            Console.WriteLine("Sum of these numbers is {0}",sum);
            sr.Close();
            fs.Close();


        }

       
        private static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            fs.Close();
        }

        private static void F1()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello world");

            sw.Close();
            fs.Close();
        }
    }
}
