using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTerm
{
    static public class CheckOut
    {

        public static void ReviewCart(List<Product> ShoppingCart)
        {
            Console.Clear();


            //show list of items currently in the cart
            Console.WriteLine("Your cart currently contains...\n\n");

            Console.WriteLine(Itemizer.CountDuplicates(ShoppingCart));


            //get prices with tax, subtotal and toal
            int cartKeeper = Itemizer.GetTotal(ShoppingCart);

            Console.WriteLine("\nSub total: {0}", cartKeeper);

            int grandTotal = (int)(cartKeeper + (cartKeeper * 0.06));

            Console.WriteLine("\nGrand Total: {0} (after 6% tax)", grandTotal);


            //give option to clear cart or move to payment
            Console.WriteLine("\nWould you like to check out, or go back to main menu?");

            bool answer = Validator.GetAnyCaseChar("Please enter 'y' for 'y'es, anything else to go back!", 'y','Y');

            if (answer)
            {
                Payment.CheckingOut(grandTotal, ShoppingCart);
            }
            else
            {
                Console.ReadKey(true);
                Console.Clear();
                return;
            }

        }

    }
}
