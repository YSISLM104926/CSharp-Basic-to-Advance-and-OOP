﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram
{
    class program2
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        public static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}
