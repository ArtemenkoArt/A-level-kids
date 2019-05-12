using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    abstract class Animals
    {
        private AnimalsFeed favoriteFood;
        public AnimalsFeed FavoriteFood() => favoriteFood;
        public Animals(AnimalsFeed food) => favoriteFood = food;

        //The animal ate and voiced
        public void Eat(AnimalsFeed animalsFood) => Voice();
        //Each animal in its own way walks
        abstract public void Walk();
        //Every animal has its own voice
        abstract public void Voice();
        //Each animal gives its product
        abstract public AnimalsProducts ProduceProduct();
        //Visitor
        public abstract void Accept(Farmer farmer, ActionType action);
    }

    class Cow : Animals, IAnimals
    {
        public Cow(AnimalsFeed food) : base(food) { }

        override public void Walk() => Console.WriteLine("Cow Walk - Top-top!");

        override public void Voice() => Console.WriteLine("Cow say: Muuuuuuu!");

        override public AnimalsProducts ProduceProduct() => new Milk(5, "Milk");

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
    }

    class Sheep : Animals, IAnimals
    {
        public Sheep(AnimalsFeed food) : base(food) { }

        override public void Walk() => Console.WriteLine("Sheep Walk- Prig-skok!");

        override public void Voice() => Console.WriteLine("Sheep sey: Beeeeee!");

        override public AnimalsProducts ProduceProduct() => new Wool(10, "Wool");

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
}

    class Chicken : Animals, IAnimals
    {
        public Chicken(AnimalsFeed food) : base(food) { }

        override public void Walk() => Console.WriteLine("Chicken Walk - Cok-cok!");

        override public void Voice() => Console.WriteLine("Chicken sey: Ku-ka-re-ku!");

        override public AnimalsProducts ProduceProduct() => new Eggs(1, "Eggs");

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
    }
}
