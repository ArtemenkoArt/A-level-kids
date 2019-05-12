using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public DateTime DateofBirthday { get; set; }
        public abstract FoodStack Food { get; }

        public abstract void MakeSomeNoise();
        public abstract void Eat(Food food);
        public abstract AnimalProduct GetThisAnimalProduct();
    }

    public class Cow : Animal
    {
        public override FoodStack Food => FoodStack.CowsFood;

        public override void Eat(Food food)
        {
            Console.WriteLine($"Cow ate {food.Name}");
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Mooo");
        }

        public override AnimalProduct GetThisAnimalProduct()
        {
            return new CowsProductMilk(10.0m);
        }
    }

    public class Hen : Animal
    {
        public override FoodStack Food => FoodStack.HensFood;

        public override void Eat(Food food)
        {
            Console.WriteLine($"Hen ate {food.Name}");
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Cock-A-Doodle-Doo!");
        }

        public override AnimalProduct GetThisAnimalProduct()
        {
            return new HensProductEggs(5.5m);
        }
    }

    public class Sheep : Animal
    {
        public override FoodStack Food => FoodStack.SheepsFood;

        public override void Eat(Food food)
        {
            Console.WriteLine($"Sheep ate {food.Name}");
        }

        public override void MakeSomeNoise()
        {
            Console.WriteLine("Mooo");
        }

        public override AnimalProduct GetThisAnimalProduct()
        {
            return new SheepsProductWool(3.45m);
        }
    }
}
