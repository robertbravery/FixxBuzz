using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private static void ForLoop1()
        {
            DateTime start = DateTime.Now;
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                var s = string.Empty;
                if (i % 3 == 0) s = "Fizz:";
                if (i % 5 == 0) s += "Buzz:";
                if (s.Length == 0) s = i.ToString();
                message.Append(s).AppendLine();
            }
            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            forLoop1.Add(duration);
            if (duration>0 ) Console.WriteLine($"Time taken for loop with variable: {duration}");
        }
    }
}
