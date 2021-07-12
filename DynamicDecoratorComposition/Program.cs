﻿using System;

namespace DynamicDecoratorComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(1.21f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());
        }
    }
}