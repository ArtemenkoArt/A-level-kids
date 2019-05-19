using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    abstract class Farmer //Visitor
    {
        public abstract int Hunger { get; internal set; }
        public abstract int Sleep { get; internal set; }
        public abstract int Tired { get; internal set; }

        public abstract void ActionsWithAnimals(Animal animal, ActionType action);
    }

    class IvanIvanovich : Farmer
    {
        readonly Farm farm;
        public override int Hunger { get; internal set; } = 100;
        public override int Sleep { get; internal set; } = 100;
        public override int Tired { get; internal set; } = 100;

        public void ChangeStatus(int h, int s, int r)
        {
            Hunger -= h;
            Sleep -= s;
            Tired -= r;
        }

        public void GoSleep() => Sleep = 100;

        public void GoEat() => Hunger = 100;

        public void GoRelax() => Tired = 100;

        public void PrintStatus()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Environment.NewLine}Fermer status: Hunger: {Hunger}, Sleep: {Sleep}, Tired: {Tired}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public IvanIvanovich(Farm farm) => this.farm = farm;

        public override void ActionsWithAnimals(Animal animal, ActionType action)
        {
            switch (action)
            {
                //get a random amount of products
                case ActionType.Collect: { 
                        Random random = new Random();
                        int qty = random.Next(1, 4);
                        farm.productStock.Add(animal.ProduceProduct(), qty);
                        break; }
                //Get the type of animal feed, remove the feed from the feedStock, feed the animal
                case ActionType.Feed: {
                        var feed = farm.feedStock.GetFeedByType(animal.FeedType);
                        farm.feedStock.Remove(feed, 1);
                        animal.Eat(feed);
                        break; }
                //Walking an animal
                case ActionType.Walk: { animal.Walk(); break; }
                default: { break; }
            }

        }
    }
}
