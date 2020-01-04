using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Human : ILivingThing , IAtack
    {
        public abstract int Health { get; set; }
        public abstract bool IsAlive { get; set; }
        public abstract int Damage { get; set; }

    }
}
