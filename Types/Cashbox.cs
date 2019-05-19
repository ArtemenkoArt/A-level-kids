using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class Cashbox
    {
        private decimal budget;
        private decimal saving;

        public void Add(decimal sum) => budget += sum;
        public void Sub(decimal sum) => budget -= sum;
        public decimal Sum() => budget;

        public void SavingAdd(decimal sum) => saving += sum;
        public void SavingSub(decimal sum) => saving -= sum;
        public decimal SavingSum() => saving;
    }
}
