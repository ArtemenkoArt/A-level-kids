using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class Stock
    {
        List<AnimalsFeed> animalsFeed = new List<AnimalsFeed>();
        List<AnimalsProduct> animalsProduct = new List<AnimalsProduct>();
        int MaxQtyFeed { get; }
        int MaxQtyProduct { get; }

        public Stock(int maxQtyFeed, int maxQtyProduct)
        {
            this.MaxQtyFeed = maxQtyFeed;
            this.MaxQtyProduct = maxQtyProduct;
        }

        public void FeedAdd(AnimalsFeed feed) => animalsFeed.Add(feed);
        public void FeedRemove(AnimalsFeed feed) => animalsFeed.Remove(feed);

        public void ProductAdd(AnimalsProduct product) => animalsProduct.Add(product);
        public void ProductRemove(AnimalsFeed product) => animalsProduct.Remove(product);

        public void ProductSell()
        {
            decimal sold = 0;
            foreach (AnimalsProduct products in animalsProduct)
            {
                Console.WriteLine($"Sell {products.name}: 1 * {products.GetPrice()} $");
                sold += products.GetPrice();
            }
            //10% of revenue set aside for the car
            decimal toCar = (sold / 100) * 10;
            decimal toBudget = sold - ((sold / 100) * 10);
            MoneyAdd(toBudget);
            moneyToBuyCar += toCar;
            Console.WriteLine("");
            Console.WriteLine($"Total sold: {sold}$, {toBudget}$ in the budget, {toCar}$ to buy car.");
            Console.WriteLine($"Total in budget: {MoneySum()}$, Total to car {moneyToBuyCar}$.");
            animalsProduct.Clear();
        }
    }
}
