using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
    public class Pair
    {
        public Pair(int first = 5, int second = 3)
        {
            First = first;
            Second = second;
        }

        private int First { get; set; }
        private int Second { get; set; }

        public bool IsFirstPairMore(Pair pair)
        {
            return First > pair.First || First == pair.First && Second > pair.Second;
        }

        public void SetParams(int first, int second)
        {
            First = first;
            Second = second;
        }

        public void SetParams(int first)
        {
            First = first;
        }

        public void SetParams(double second)
        {
            Second = Convert.ToInt32(second);
        }
    }
}
