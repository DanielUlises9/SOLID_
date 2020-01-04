using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BlueTeam bt = new BlueTeam();
            RedTeam rt = new RedTeam();

            FieldOfCombat foc = new FieldOfCombat(rt,bt);

        }
    }
}
