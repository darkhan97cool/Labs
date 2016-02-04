using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class Student
    {
        public string fullname;
        public string ID;
        public double GPA;
        public Student(string _fullname, string _ID, double _GPA)
        {
            this.fullname = fullname;
            this.ID = ID;
            this.GPA = GPA;
        }
        public override string ToString()
        {
            return "Student's full name is: " + fullname + "ID : " + ID + "GPA : " + GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Yersultan Darkhan", "15BD02048", 3, 87);
            Console.WriteLine(a);
        }
    }
}