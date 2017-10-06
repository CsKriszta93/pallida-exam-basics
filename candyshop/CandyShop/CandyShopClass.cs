using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    public class CandyShopClass
    {
        public List<Sweets> storage = new List<Sweets>();
        public int sugar;
        public int income;

        public CandyShopClass(int sugar)
        {
            this.sugar = sugar;
        }

        public int CurrentSugarAmount()
        {
            foreach (var candy in storage)
            {
                sugar -= candy.amountOfSugar;
            }
            return sugar;
        }
        
        public CreateSweets()
        {

        }

        public PrintInfo()
        {
            foreach (Sweets candy in storage)
            {
                Console.WriteLine("Inventory: {0} {1} {2} {3} {4}, Income: {5}, Sugar {6}", candy.givenAmount, candy.type,  );
            }
        }

        public int Sell(int amount)
        {
            income += 
        }

        public Raise(int raise)
        {

        }

        public BuySugar(int amount)
        {

        }
    }
}
