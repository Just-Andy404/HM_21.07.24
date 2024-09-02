using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld africa = new AnimalWorld(new Africa());
            AnimalWorld northAmerica = new AnimalWorld(new NorthAmerica());

            Console.WriteLine("Africa:");
            africa.MealsHerbivores();
            africa.NutritionCarnivores();

            Console.WriteLine("NorthAmerica:");
            northAmerica.MealsHerbivores();
            northAmerica.NutritionCarnivores();
            Console.ReadLine();
        }
    }
}
