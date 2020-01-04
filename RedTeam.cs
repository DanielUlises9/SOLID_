using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RedTeam : Human
    {
        public override int Health() => base.Health();
        public override bool IsAlive() => base.IsAlive();
        public override int Damage() => 3;
    }
}
