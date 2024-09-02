using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Herbivore
    {
        public abstract double Weight { get; set; }
        public abstract bool Life { get; set; }
        public abstract void EatGrass();

    }
}
