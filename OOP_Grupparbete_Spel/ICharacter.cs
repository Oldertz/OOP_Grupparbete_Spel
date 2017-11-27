using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    interface ICharacter
    {
        string Name { get; set; }
        int HitChance { get; set; }
        int HitPoints { get; set; }
    }
}