using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    class Range
    {
        public Range(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Min { get; private set; }
        public int Max { get; private set; }
    }
}
