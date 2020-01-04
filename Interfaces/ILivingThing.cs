using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface ILivingThing
    {
        int Health { get; set; }
        bool IsAlive { get; set; }
    }
}
