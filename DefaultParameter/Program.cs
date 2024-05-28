using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram
{
    class DefaultParameter
    {
        static void MyMethod(string fname, int age = 41)
        {
            Console.WriteLine(fname + " is " + age);
        }
        public static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny");
            MyMethod("Anja", 31);
        }
    }
}
