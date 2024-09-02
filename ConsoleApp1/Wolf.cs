using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Wolf : Carnivore
    {
        public override int Power { get; set; }
        public Wolf()
        {
            Power = 150;
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
