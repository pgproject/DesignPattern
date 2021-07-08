﻿using System;
using System.Threading.Tasks;

namespace PerThreadSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1: " + PerThread.Instance.Id);
            });
            
            var t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2: " + PerThread.Instance.Id);
                Console.WriteLine("t2: " + PerThread.Instance.Id);
            });
            Task.WaitAll(t1, t2);
        }
    }
}