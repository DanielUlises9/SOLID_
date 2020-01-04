using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FieldOfCombat
    {
        private Random rn;
        private BlueTeam bt;
        private RedTeam rt;
        private int random;
        public FieldOfCombat(RedTeam rt, BlueTeam bt)
        {
            this.bt = bt;
            this.rt = rt;
            rn = new Random(DateTime.Now.Second);
        }
        public void Fight()
        {
            while(bt.IsAlive && rt.IsAlive)
            {
                if (rn.Next(0,2)  == 1)
                    bt.GetDamage(rt.Damage);
                else
                    rt.GetDamage(bt.Damage);
            }
        }
        

    }
}
