using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        private int result = 0;

        public int Result {
            get {
                return result;
            }
        }

        // http://osherove.com/tdd-kata-1/

        public void Add(string numbers)
        {
            result += int.Parse(numbers);
        }
    }
}
