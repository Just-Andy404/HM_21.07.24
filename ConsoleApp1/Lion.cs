using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lion : Carnivore
    {
        public override int Power { get; set; }
        public Lion()
        {
            Power = 100;
        }
        public override void Eat(Herbivore herbivore)
        {
            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
            }
            else
            {
                Power -= 10;
            }
        }
    }
}
