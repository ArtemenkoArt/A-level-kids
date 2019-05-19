using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class ProductStock
    {
        List<AnimalsProduct> animalsProduct = new List<AnimalsProduct>();

        //add to the list quantity of feed
        public void Add(AnimalsProduct product, int qty) {
            for (int i = 0; i < qty; i++)
                animalsProduct.Add(product);
        }

        //remove quantity of feed from the list
        public void Remove(AnimalsProduct product, int qty) {
            for (int i = 0; i < qty; i++)
                if (animalsProduct.Find(x => x ==product) != null)
                    animalsProduct.Remove(product);
        }

        //Calculate the quantity of products in stock
        public int GetQty(AnimalsProduct product) {
            return animalsProduct.FindAll(x => x == product).Count();
        }

        //Sell ​​all stocks of products, put some money in saving, put the rest in budget
        public void ToSell(Cashbox cashbox) {
            decimal sold = 0;
            foreach (AnimalsProduct product in animalsProduct.Distinct()) {
                int prodQty = GetQty(product);
                decimal prodPrice = product.GetPrice();
                decimal prodAmount = prodQty * prodPrice;
                //Console.WriteLine($"Sell {product.name}: {prodQty} * {prodPrice} = {prodAmount} $");
                sold += prodQty * prodPrice;
            }
            //10% of revenue set aside for the car
            decimal toCar = (sold / 100) * 10;
            decimal toBudget = sold - ((sold / 100) * 10);
            cashbox.Add(toBudget);
            cashbox.SavingAdd(toCar);
            animalsProduct.Clear();
        }

        public void PrintLine(string name, int qty, decimal amt) {
            string lineName = Convert.ToString(name).PadRight(20);
            string lineQty = Convert.ToString(qty).PadLeft(4);
            string lineAmt = string.Format("{0:0.00}", amt).PadLeft(8);
            Console.WriteLine($"|{lineName} | {lineQty} | {lineAmt} |");
        }

        //Display information about products in stock
        public void Print(Cashbox cashbox) {
            //Console.Clear();
            decimal total = 0;
            Console.WriteLine($"{Environment.NewLine}{new string('-',12)}PRODUCTS IN STOCK{new string('-', 12)}");
            var ls = animalsProduct.Distinct();
            foreach (AnimalsProduct product in animalsProduct.Distinct()) {
                int qty = GetQty(product);
                decimal amt = qty * product.GetPrice();
                PrintLine(product.name, qty, amt);
                total += amt;
            }
            Console.WriteLine(new string('-',41));
            Console.WriteLine($"Total in stock: {total}$");
            if (cashbox.Sum() <= 25)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Total in budget: {cashbox.Sum()}$, Total to car {cashbox.SavingSum()}$.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
