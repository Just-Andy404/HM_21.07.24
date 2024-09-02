using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnimalWorld
    {
        private readonly List<Herbivore> herbivores = new List<Herbivore>();
        private readonly List<Carnivore> carnivores = new List<Carnivore>();

        public AnimalWorld(Continent continent)
        {
            herbivores.Add(continent.CreateHerbivore());
            carnivores.Add(continent.CreateCarnivore());
        }

        public void MealsHerbivores()
        {
            foreach (var herbivore in herbivores)
            {
                if (herbivore.Life)
                {
                    herbivore.EatGrass();
                    Console.WriteLine($"{herbivore.GetType().Name} весит {herbivore.Weight} кг после кормежки.");
                }
            }
        }

        public void NutritionCarnivores()
        {
            foreach (var carnivore in carnivores)
            {
                foreach (var herbivore in herbivores)
                {
                    if (herbivore.Life)
                    {
                        carnivore.Eat(herbivore);
                        Console.WriteLine($"{carnivore.GetType().Name} имеет силу {carnivore.Power} после охоты.");
                    }
                }
            }
        }
    }
}
