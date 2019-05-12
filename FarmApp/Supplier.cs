using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public class Supplier : IHuman
    {
        public FoodStack Food => FoodStack.HumansFood;
        public List<AnimalProduct> ProductChest { get; set; }
        public List<Farm> FarmsPartner { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private decimal _cash = 5000;
        public decimal Cash
        {
            get => _cash;
            set
            {
                if (value < 0)
                {
                    _cash = 0;
                    throw new Exception("No money, bro!");
                }
                else
                {
                    _cash = value;
                }
            }
        }

        public Supplier(string name, int age, Farm farm)
        {
            Name = name;
            Age = age;
            FarmsPartner = new List<Farm>();
            FarmsPartner.Add(farm);
            ProductChest = new List<AnimalProduct>();
        }

        public void AddFarmContact(Farm farm) => FarmsPartner.Add(farm);

        public void DeleteFarmContact(Farm farm) => FarmsPartner.Remove(farm);

        public void BuySomeAnimalProduct(AnimalProductsEnum products) => ProductChest.Add(null);

        public void Eat(Food food)
        {
            Console.WriteLine($"{Name} ate {food.Name}");
        }

        public void GetSomeProduct(AnimalProductsEnum product, Farm farm) => farm.
        

        public Food GetFood(FoodStack food, ref decimal cash)
        {
            switch (food)
            {
                case FoodStack.HensFood:
                    Cash += HensFood.Price;
                    cash -= HensFood.Price;
                    return new HensFood();

                case FoodStack.CowsFood:
                    Cash += CowsFood.Price;
                    cash -= CowsFood.Price;
                    return new CowsFood();

                case FoodStack.SheepsFood:
                    Cash += SheepsFood.Price;
                    cash -= SheepsFood.Price;
                    return new SheepsFood();

                case FoodStack.HumansFood:
                    Cash += HumansFood.Price;
                    cash -= HumansFood.Price;
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
