using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Randomizer
    {
        Random rn;

        public Randomizer(int today)
        {
            rn = new Random(today);
        }

        public int GetRandom(int _rangeOne , int rangeTwo)
        {
            return rn.Next(_rangeOne,rangeTwo+1);
        }
    }
}
