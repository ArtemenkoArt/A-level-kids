using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public abstract class Food
    {
        public abstract string Name { get; }
    }

    public class CowsFood : Food
    {
        public override string Name => "Food for cows";
        public static decimal Price => 3.0m;
    }

    public class HensFood : Food
    {
        public override string Name => "Food for hens";
        public static decimal Price => 2.0m;
    }

    public class SheepsFood : Food
    {
        public override string Name => "Food for sheeps";
        public static decimal Price => 1.0m;
    }

    public class HumansFood : Food
    {
        public override string Name => "Food for humans";
        public static decimal Price => 4.0m;
    }
}
