using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    abstract class Animal
    {
        public AnimalsProduct Product { get; }
        public abstract FeedType FeedType { get;}
        public Animal(AnimalsProduct product) => Product = product;

        //The animal ate and voiced
        public void Eat(AnimalFeed animalsFood) => Voice();
        //Each animal in its own way walks
        abstract public void Walk();
        //Every animal has its own voice
        abstract public void Voice();
        //Each animal gives its product
        abstract public AnimalsProduct ProduceProduct();
        //Visitor
        public abstract void Accept(Farmer farmer, ActionType action);
    }

    class Cow : Animal
    {
        public Cow() : base(new Milk(5, "Milk")) { }
        
        public override FeedType FeedType { get; } = FeedType.FeedForCattle;

        override public void Walk() => Console.WriteLine("Cow Walk - Top-top!");

        override public void Voice() => Console.WriteLine("Cow say: Muuuuuuu!");

        override public AnimalsProduct ProduceProduct() => Product;

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
    }

    class Sheep : Animal
    {
        public Sheep() : base(new Wool(10, "Wool")) { }

        public override FeedType FeedType { get; } = FeedType.FeedForCattle;

        override public void Walk() => Console.WriteLine("Sheep Walk- Prig-skok!");

        override public void Voice() => Console.WriteLine("Sheep sey: Beeeeee!");

        override public AnimalsProduct ProduceProduct() => Product;

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
}

    class Chicken : Animal
    {
        public Chicken() : base(new Eggs(1, "Eggs")) { }

        public override FeedType FeedType { get; } = FeedType.FeedForFowl;

        override public void Walk() => Console.WriteLine("Chicken Walk - Cok-cok!");

        override public void Voice() => Console.WriteLine("Chicken sey: Ku-ka-re-ku!");

        override public AnimalsProduct ProduceProduct() => Product;

        override public void Accept(Farmer farmer, ActionType action) => farmer.ActionsWithAnimals(this, action);
    }
}
