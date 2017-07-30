using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static List<double> forLoop = new List<double>();
        static List<double> forLoop1 = new List<double>();
        static List<double> linqLoop = new List<double>();
            
        static void Main(string[] args)
        {
            for (int k = 0; k < 100; k++)
            {
                // For loop Variable
               ForLoop1();

                // For loop 
                NormalLoop();

                //Linq
                LinqLoop();
            }
            Console.WriteLine($"Loop 1 average time: {forLoop1.Average()} ms, Total time {forLoop1.Sum()/1000} s");
            Console.WriteLine($"Avery time for loop: {forLoop.Average()} ms, Total time {forLoop.Sum() / 1000} s");
            Console.WriteLine($"Avery time for linq: {linqLoop.Average()} ms, Total time {linqLoop.Sum() / 1000} s");
            Console.ReadLine();
        }

        private static void ForLoop1()
        {
            var duration = ForLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for normal 'for Loop': {duration}");
            forLoop1.Add(duration);
        }

        private static void NormalLoop()
        {
            var duration = FizzBuzz.NormalLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for normal Loop: {duration}");
            forLoop.Add(duration);
        }

        private static void LinqLoop()
        {
            var duration = FizzBuzz.LinqLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for Linq: {duration}");
            linqLoop.Add(duration);
        }
    }
}
