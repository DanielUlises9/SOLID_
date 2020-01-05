using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LotsOfHumans
    {
        private BlueTeam bt;
        private RedTeam rt;

        public LotsOfHumans()
        {
            bt = new BlueTeam();
        }
        /// <summary>
        /// Genera Humanos
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="myType"></param>
        /// <returns></returns>
        public List<Human> GenerateHumans(int amount, Object type)
        {
            List < Human > asas = new List<Human>();
            if(Equals(type.GetType(),bt.GetType()))
            {
                Console.WriteLine("they are the same");
            }
            return asas;
        }

    }
}
