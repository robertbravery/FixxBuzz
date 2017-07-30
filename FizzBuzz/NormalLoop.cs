using System;
using System.Text;

namespace FizzBuzz
{
    public class NormalLoop
    {
        public static double Loop(int maxLoop)
        {
            var message = new StringBuilder();
            var start = DateTime.Now;
            for (int i = 0; i < maxLoop; i++)
            {
                var s = string.Empty;
                if (i % (15) == 0) message.Append("FizzBuzz");
                else if (i % 3 == 0) message.Append("Fizz");
                else if (i % 5 == 0) message.Append("Buzz").AppendLine();
                else message.Append(i.ToString());
            }
            var duration = start.Subtract(DateTime.Now).Duration().TotalMilliseconds;
            return duration;
        }
    }
}