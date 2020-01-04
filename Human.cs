using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Human : ILivingThing , IAtack
    {
        public virtual int Health()=>100;
        public virtual bool IsAlive() => true;
        public virtual int Damage() => 5;

    }
}
