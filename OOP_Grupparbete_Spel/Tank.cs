using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    abstract class Tank : ICharacter
    {
        private readonly Random _random = new Random(); //Kan flyttas till egen randomklass

        public Tank(string name, int hitPoints, Range damageRange, int hitChance)
        {
            Name = name;
            HitPoints = hitPoints;
            HitChance = hitChance;
            DamageRange = damageRange;
        }

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int HitPoints { get; set; }
        public Range DamageRange { get; private set; }
        private bool IsDefending { get; set; }

        public bool IsAlive
        {
            get { return HitPoints > 0; }
        }

        public void Defend()
        {
            Console.WriteLine("The {0} defends", Name);
            IsDefending = true;
        }
        public void Heal(int amount)
        {
            Console.WriteLine("The {0} repairs himslef!", Name);
            IsDefending = false;
            HitPoints += amount;
            Console.WriteLine("The repair heals himself for {0} points", amount);
        }

        public void Hit(int amount)
        {
            int receivedDamage = IsDefending ? (amount / 2) : amount;
            HitPoints -= receivedDamage;
            Console.WriteLine("The {0} loses {1}hp", Name, receivedDamage);
        }
        public void Attack(Tank target)
        {
            Console.WriteLine("The {0} attacks!", Name);
            IsDefending = false;

            if (HitChance <= _random.Next(0, 100))
            {
                Console.WriteLine("{0} missed!", Name);
                return;
            }

            target.Hit(_random.Next(DamageRange.Min, DamageRange.Max));
        }
    }
}
