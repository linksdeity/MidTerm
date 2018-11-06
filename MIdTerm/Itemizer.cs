using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTerm
{
    public static class Itemizer
    {
        public static string CountDuplicates(List<Product> ShoppingCart)
        {

            List<Product> checkoutList = new List<Product>();

            List<int> numberOf = new List<int>();

            List<int> prices = new List<int>();

            int counter = 0;



            foreach(Product product in ShoppingCart)
            {
                counter = 0;

                if(!checkoutList.Contains(product))
                {
                    checkoutList.Add(product);

                    foreach(Product thisproduct in ShoppingCart)
                    {
                        if(product == thisproduct)
                        {
                            counter++;
                        }
                    }

                    numberOf.Add(counter);

                    prices.Add(product.Price * counter);

                }
            }


            string values = "";
            counter = 0;

            foreach(Product product in checkoutList)
            {
                values += product.Name;
                values += " x " + numberOf[counter];
                values += " - - - " + prices[counter] + " Rupees\n\n";

                counter++;
            }

            return values;

        }

        public static int GetTotal(List<Product> ShoppingCart)
        {
            int total = 0;

            foreach(Product product in ShoppingCart)
            {
                total += product.Price;
            }

            return total;

        }

    }
}
