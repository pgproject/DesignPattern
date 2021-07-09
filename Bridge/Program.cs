﻿using System;
using Autofac;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));
            using (var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
                circle.Draw();
                circle.Resize(2.0f);
                circle.Draw();
            }
        }
    }
}