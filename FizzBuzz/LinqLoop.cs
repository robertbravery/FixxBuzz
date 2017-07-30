using System;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class LinqLoop
    {
        public static double Loop(int maxLoop)
        {
            var message = new StringBuilder();
            var start = DateTime.Now;
            Enumerable.Range(1, maxLoop)
                .ToList()
                .ForEach(i => message.Append((i % 15 == 0)
                    ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : i.ToString()).AppendLine());

            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            return duration;

        }
    }
}