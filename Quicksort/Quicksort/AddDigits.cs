using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    public class AddDigitsSolution
    {
        public int AddDigits(int num)
        {
            if (num < 10) return num;
            string numbers = num.ToString();
            int addedDigits = 0;
            foreach (char c in numbers)
            {
                addedDigits += (int)Char.GetNumericValue(c);
            }

            if (addedDigits < 10) return addedDigits;
            else
                return AddDigits(addedDigits);
        }
    }
}
