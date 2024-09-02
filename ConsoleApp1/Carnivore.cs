using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Carnivore
    {
        public abstract int Power { get; set; }
        public abstract void Eat(Herbivore herbivore);
    }
}
