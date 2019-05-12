using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Supplier:IHuman
    {
        public FoodStack Food => FoodStack.HumansFood;

        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat(Food food)
        {
            Console.WriteLine($"{Name} ate {food.Name}");
        }

        public Food GetFood(FoodStack food)
        {
            switch (food)
            {
                case FoodStack.HensFood:
                    return new HensFood();
                case FoodStack.CowsFood:
                    return new CowsFood();
                case FoodStack.SheepsFood:
                    return new SheepsFood();
                case FoodStack.HumansFood:
                    return new HumansFood();
                default:
                    return null;
            }
        }

        public void Relax()
        {
            Console.WriteLine($"{Name} is relaxing now");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping now zZzz...");
        }
    }
}
