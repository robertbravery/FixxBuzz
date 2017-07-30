using System;
using System.Text;

namespace FizzBuzz
{
    public class ForLoop
    {
        public static double Loop(int maxLoop)
        {
            var message = new StringBuilder();
            var start = DateTime.Now;
            for (var i = 0; i < maxLoop; i++)
            {
                var s = string.Empty;
                if (i % 3 == 0) s = "Fizz:";
                if (i % 5 == 0) s += "Buzz:";
                if (s.Length == 0) s = i.ToString();
                message.Append(s).AppendLine();
            }
            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            return duration;
        }
    }
}