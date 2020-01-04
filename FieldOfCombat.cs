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
        public FieldOfCombat(RedTeam rt, BlueTeam bt)
        {
            this.bt = bt;
            this.rt = rt;
            rn = new Random(DateTime.Now.Second);
            
        }
        

    }
}
