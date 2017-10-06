using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var candyShop = new CandyShopClass(300);
            var candie1 = new Candie();
            var candie2 = new Candie();
            var lollipop1 = new Lollipop();
            var lollipop2 = new Lollipop();
            candyShop.storage.Add(candie1);
            candyShop.storage.Add(candie2);
            candyShop.storage.Add(lollipop1);
            candyShop.storage.Add(lollipop2);
        }
    }
}
