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

        private static void LinqLoop()
        {
            DateTime start = DateTime.Now;
            StringBuilder message = new StringBuilder();
            Enumerable.Range(1, 1000)
                .ToList()
                .ForEach(i => message.Append((i % 15 == 0)
                ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : i.ToString()).AppendLine());

            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            linqLoop.Add(duration);
            if(duration > 0) Console.WriteLine($"Time taken for Linq: {duration}");
        }

        private static void NormalLoop()
        {
            DateTime start = DateTime.Now;
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                var s = string.Empty;
                if (i % (15) == 0) message.Append("FizzBuzz");
                else if (i % 3 == 0) message.Append("Fizz");
                else if (i % 5 == 0) message.Append("Buzz").AppendLine();
                else message.Append(i.ToString());
            }
            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            forLoop.Add(duration);
            //Console.WriteLine(message.ToString());
            if (duration > 0) Console.WriteLine($"Time taken for loop: {duration}");
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
