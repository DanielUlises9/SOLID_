using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BlueTeam bt = new BlueTeam(100,5,true);
            RedTeam rt = new RedTeam(90,7,true);

            FieldOfCombat foc = new FieldOfCombat(rt,bt);

            Console.WriteLine(bt.Health);
            Console.WriteLine(rt.Health);

        }
    }
}
