using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Grupparbete_Spel
{
    class PanzarTank : Tank
    {
        public PanzarTank() 
            : base("PanzarTank", 3000, new Range(300, 500), 70)
        {
        }

        
    }
}
