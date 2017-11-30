using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    class Game
    {
        private const int _displayWidth = 42;

        public void Start()
        {
            PanzarTank PT = new PanzarTank();
            MegaBlaster MB = new MegaBlaster();
            Console.WriteLine("You are facing a MEGABLASTER!");
            Console.ReadKey();
            Console.Clear();

            do
            {
                DisplayBattle(PT, MB);

                switch (GetChoice())
                {
                    case BattleChoice.Attack:
                        PT.Attack(MB);
                        break;
                    case BattleChoice.Defend:
                        PT.Defend();
                        break;
                    case BattleChoice.Heal:
                        PT.Heal(400);
                        break;
                    default:
                        Console.WriteLine("MegaBlaster took a cheap shot!");
                        break;
                }

                if (MB.IsAlive)
                    MB.Attack(PT);

                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
            }
            while (PT.IsAlive && MB.IsAlive);

            DisplayBattleResult(PT);
            Console.ReadLine();
        }

        private void DisplayBattleResult(PanzarTank PT)
        {
            if (PT.IsAlive)
                Console.WriteLine("You are victorious!");
            else
                Console.WriteLine("You have been defeated :(");
        }

        private void DisplayBattle(PanzarTank PT, MegaBlaster MB)
        {
            Console.WriteLine(new String('*', _displayWidth));
            Console.WriteLine("{0} has {1}hp and the {2} has {3}hp",
                PT.Name, PT.HitPoints, MB.Name, MB.HitPoints);
            Console.WriteLine(new String('*', _displayWidth));
        }

        private void DisplayChoices()
        {
            Console.WriteLine(new String('-', _displayWidth));
            Console.WriteLine("Please Choose an action:");
            Console.WriteLine("(A)ttack");
            Console.WriteLine("(D)efend");
            Console.WriteLine("(H)eal");
            Console.WriteLine("(F)lee");
            Console.WriteLine(new String('-', _displayWidth));
        }
        
        private BattleChoice GetChoice()
        {
            DisplayChoices();
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.A:
                    return BattleChoice.Attack;
                case ConsoleKey.H:
                    return BattleChoice.Heal;
                case ConsoleKey.D:
                    return BattleChoice.Defend;
                default:
                    return BattleChoice.Wait;
            }
        }
    }
}
