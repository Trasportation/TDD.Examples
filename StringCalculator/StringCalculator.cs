using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    // http://osherove.com/tdd-kata-1/

    public class StringCalculator
    {
        private int result = 0;
        private string separators = ",;\n";
        public int MaxValueToSum { get; set; }

        public StringCalculator()
        {
            MaxValueToSum = 1000;
        }

        public int Result {
            get {
                return result;
            }
        }

        public void Add(string numbers)
        {
            StringBuilder sberror = new StringBuilder();

            foreach (var num in numbers.Split(separators.ToArray()))
            {
                var nc = convertNumber(num);
                if (nc < 0)
                {
                    if (sberror.Length > 0) sberror.Append(", ");
                    sberror.Append(nc);
                }
                else if (nc > MaxValueToSum) { }
                else
                {
                    result += convertNumber(num);
                }
            }

            if (sberror.Length > 0)
            {
                throw new Exception("Negative number is not allowed: " + sberror.ToString());
            }
        }

        private int convertNumber(string n)
        {
            var ln = int.Parse(n);
            return ln;
        }

    }
}
