using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static readonly List<double> ForLoop = new List<double>();
        static readonly List<double> forLoop1 = new List<double>();
        static readonly List<double> linqLoop = new List<double>();
            
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
            Console.WriteLine($"Avery time for loop: {ForLoop.Average()} ms, Total time {ForLoop.Sum() / 1000} s");
            Console.WriteLine($"Avery time for linq: {linqLoop.Average()} ms, Total time {linqLoop.Sum() / 1000} s");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("This was the old change");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New change deployed to environment");
            Console.ReadLine();
        }

        private static void ForLoop1()
        {
            var duration = FizzBuzz.ForLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for normal 'for Loop': {duration}");
            forLoop1.Add(duration);
        }

        private static void NormalLoop()
        {
            var duration = FizzBuzz.NormalLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for normal Loop: {duration}");
            ForLoop.Add(duration);
        }

        private static void LinqLoop()
        {
            var duration = FizzBuzz.LinqLoop.Loop(1000);
            if (duration > 0) Console.WriteLine($"Time taken for Linq: {duration}");
            linqLoop.Add(duration);
        }
    }
}
