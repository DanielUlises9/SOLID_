using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BlueTeam : Human
    {
        public override int Health() => 90;
        public override bool IsAlive() => base.IsAlive();
        public override int Damage() => 5;
    }
}
