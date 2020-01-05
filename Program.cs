using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bt = new BlueTeam(1, 1, true);
            LotsOfHumans loh = new LotsOfHumans();

            loh.GenerateHumans(1,bt);
        }
    }
}
