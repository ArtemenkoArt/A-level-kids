using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public class Farmer : IHuman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public FoodStack Food => FoodStack.HumansFood;


        private readonly Supplier supplier= new Supplier();

        public void ToScare(IEnumerable<Animal> animals)
        {
            foreach (var a in animals)
            {
                a.MakeSomeNoise();
            }
        }

        public void ToFeed(IEnumerable<Animal> animals)
        {
            foreach (var a in animals)
            {
                var food = supplier.GetFood(a.Food);
                a.Eat(food);
            }
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping now zZzz...");
        }

        public void Eat(Food food)
        {
            Console.WriteLine($"{Name} ate {food.Name}");
        }

        public void Relax()
        {
            Console.WriteLine($"{Name} is relaxing now");
        }
    }
}
