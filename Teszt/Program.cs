﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,
                y = 11;



            Console.WriteLine($"1. iratás x = {x}, x++ = {x++}");
            Console.WriteLine($"2. iratás x = {x}, x++ = {x++}");
            Console.WriteLine($"3. iratás y = {y}, ++y = {++y}");
            Console.WriteLine($"4. iratás y = {x}, x++ = {++y}");
            Console.ReadKey();
        }
    }
}
