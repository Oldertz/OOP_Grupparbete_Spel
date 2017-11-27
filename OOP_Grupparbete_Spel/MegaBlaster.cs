using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    class MegaBlaster : Tank
    {
        public MegaBlaster() 
            : base("MegaBlaster", 2000, new Range(400, 600), 50)
        {
        }

        //Skriv ut parametrar för tnaken
    }
}
