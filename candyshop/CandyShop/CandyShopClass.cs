using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    public class CandyShopClass
    {
        List<Candies> storage = new List<Candies>();
        public int sugar;
        public int income;

        public CandyShopClass(int sugar, int income)
        {
            this.sugar = sugar;
            this.income = income;
        }
    }
}
