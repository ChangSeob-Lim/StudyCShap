﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Chap07_02
{
    class A
    {

    }
    class B : A
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A c = new B();
            B d = (B)new A();
        }
    }
}
