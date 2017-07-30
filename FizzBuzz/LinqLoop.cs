using System;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class LinqLoop
    {
        public static double Loop(int maxLoop)
        {
            DateTime start = DateTime.Now;
            StringBuilder message = new StringBuilder();
            Enumerable.Range(1, maxLoop)
                .ToList()
                .ForEach(i => message.Append((i % 15 == 0)
                    ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : i.ToString()).AppendLine());

            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            return duration;

        }
    }
}