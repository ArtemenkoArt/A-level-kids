using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class Farm
    {
        ArrayList animals = new ArrayList();
        ArrayList animalsFeed = new ArrayList();
        ArrayList animalsProduct = new ArrayList();

        public void AnimalFeedAdd(AnimalsFeed feed) => animalsFeed.Add(feed);
        public void AnimalFeedRemove(AnimalsFeed feed) => animalsFeed.Remove(feed);

        public void AnimalProductAdd(AnimalsProducts product) => animalsProduct.Add(product);
        public void AnimalProductRemove(AnimalsFeed product) => animalsProduct.Remove(product);
        public void AnimalProductSell()
        {
            int Total = 0;
            foreach (AnimalsProducts products in animalsProduct)
            {
                Console.WriteLine($"Sell {nameof(products)}: 1 * {products.GetPrice()} $");
                Total += products.GetPrice();
            }
            Console.WriteLine($"Total: {Total} $");
        }

        public void AnimalAdd(Animals animal) => animals.Add(animal);
        public void AnimalRemove(Animals animal) => animals.Remove(animal);
        public void ActionsWithAnimals(Farmer farmer, ActionType action) //Visitor
        {
            foreach (IAnimals animal in animals)
            {
                farmer.ActionsWithAnimals(animal, action);
            }
            
        }
    }
}
