using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bison : Herbivore
    {
        public override double Weight { get; set; }
        public override bool Life { get; set; }
        public Bison()
        {
            Weight = 150;
            Life = true;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }
}
