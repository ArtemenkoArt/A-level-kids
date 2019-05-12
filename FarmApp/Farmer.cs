﻿using System;
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
        private decimal _cash = 10000;
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

        public Farmer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ToScare(IEnumerable<Animal> animals)
        {
            foreach (var a in animals)
            {
                a.MakeSomeNoise();
            }
        }

        public AnimalProduct GetProduct(IEnumerable<AnimalProduct> products, AnimalProductsEnum productNeed, ref decimal cash)
        {
            AnimalProduct prod = null;
            switch (productNeed)
            {

                case AnimalProductsEnum.Eggs:
                    foreach (var p in products)  // оптимизировать эти форичи???
                    {
                        if ((p as HensProductEggs) != null)
                        {
                            prod = p;
                            break;
                        }
                    }
                    break;

                case AnimalProductsEnum.Milk:
                    foreach (var p in products) // оптимизировать эти форичи???
                    {
                        if ((p as CowsProductMilk) != null)
                        {
                            prod = p;
                            break;
                        }
                    }
                    break;

                case AnimalProductsEnum.Wool:
                    foreach (var p in products)  // оптимизировать эти форичи???
                    {
                        if ((p as SheepsProductWool) != null)
                        {
                            prod = p;
                            break;
                        }
                    }
                    break;

                default:
                    throw new Exception("This product does not exist!");
            }

            if (prod != null)
            {
                products.ToList().Remove(prod);
                Cash += prod.UnitPrice;
                cash -= prod.UnitPrice;
            }

            return prod;
        }


        public void ToFeed(IEnumerable<Animal> animals, Supplier supplier)
        {
            foreach (var a in animals)
            {
                var tmp = Cash;
                var food = supplier.GetFood(a.Food, ref tmp);
                Cash = tmp;
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
