using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Wildebeest : Herbivore
    {
        public override double Weight { get; set; }
        public override bool Life { get; set; }
        public Wildebeest()
        {
            Weight = 75;
            Life = true;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }
}
