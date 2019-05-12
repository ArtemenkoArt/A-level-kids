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
    }

    public class HensFood : Food
    {
        public override string Name => "Food for hens";
    }

    public class SheepsFood : Food
    {
        public override string Name => "Food for sheeps";
    }

    public class HumansFood : Food
    {
        public override string Name => "Food for humans";
    }
}
