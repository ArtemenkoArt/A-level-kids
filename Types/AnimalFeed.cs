using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    abstract class AnimalFeed {
        public abstract decimal Price { get; }
        public abstract FeedType FeedType { get; }
    }

    //Cow, Sheep
    class Hay : AnimalFeed {
        public override decimal Price { get; } = 10;
        public override FeedType FeedType => FeedType.FeedForCattle;
    }

    //Chicken
    class Corn : AnimalFeed {
        public override decimal Price { get; } = 2;
        public override FeedType FeedType => FeedType.FeedForFowl;
    }

}
