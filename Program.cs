using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    public enum ActionType
    {
        Feed,
        Walk,
        Collect
    }

    public enum FeedType
    {
        FeedForFowl,    //Chicken
        FeedForCattle   //Cow, Sheep
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Build a new farm
            Farm farm = new Farm(100);
            
            //Primary seller
            Seller seller = new Seller();
            
            //Get farmer
            IvanIvanovich ivanIvanovich = new IvanIvanovich(farm);
            
            //Get animals
            farm.Add(new Cow());
            farm.Add(new Chicken());
            farm.Add(new Sheep());

            bool exit = false;

            while (!exit) {
                //Getting food for animals
                foreach (Animal animal in farm.animals.Distinct()) {
                    farm.feedStock.ToBuy(seller, farm.cashbox, animal.FeedType, 1);
                }

                //Walk, feed, collect eggs, milk and wool
                Console.WriteLine($"WALKING:");
                farm.ActionsWithAnimals(ivanIvanovich, ActionType.Walk);
                Console.WriteLine($"{Environment.NewLine}FEEDING:");
                farm.ActionsWithAnimals(ivanIvanovich, ActionType.Feed);
                farm.ActionsWithAnimals(ivanIvanovich, ActionType.Collect);

                //Change farmer statuses
                ivanIvanovich.ChangeStatus(1, 1, 1);
                ivanIvanovich.PrintStatus();
                //Print product
                farm.productStock.Print(farm.cashbox);
                Console.WriteLine($"{Environment.NewLine}To sell products enter: S");

                // Fermer is Hunger
                if (ivanIvanovich.Hunger < 20) 
                {
                    Console.WriteLine("The farmer is hungry, he needs to be fed. To feed enter: F");
                }

                // Farmer is sleepy
                if (ivanIvanovich.Sleep < 20)
                {
                    Console.WriteLine("The farmer is sleepy, he needs to sleep. To sleep enter: G");
                }

                // Farmer is tired
                if (ivanIvanovich.Tired < 20)
                {
                    Console.WriteLine("The farmer is tired, he needs to rest. To relax enter: R");
                }

                Console.WriteLine("To exit enter: Q");
                string result = Console.ReadLine();

                //Sell ​​all that collected
                if (result == "s" || result == "S")
                    {
                        farm.productStock.ToSell(farm.cashbox);
                    }
                else if ((ivanIvanovich.Hunger < 20) & (result == "f" || result == "F"))
                {
                    ivanIvanovich.GoEat();
                }
                else if ((ivanIvanovich.Sleep < 20) & (result == "g" || result == "G"))
                {
                    ivanIvanovich.GoSleep();
                }
                else if ((ivanIvanovich.Tired < 20) & (result == "r" || result == "R"))
                {
                    ivanIvanovich.GoRelax();
                }
                else if(result == "q" || result == "Q")
                {
                    break;
                }
                Console.Clear();
            }
            
        }
    }
}
