﻿using System;
using static System.Console;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(1.0f, Math.PI / 2);
            WriteLine(point);
        }
    }
}