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

            if(ShoppingCart.Count == 0)
            {
                Console.WriteLine("\n\nYour cart is empty, press any key to return to the main menu!");
                Console.ReadKey(true);
                Console.Clear();
                return;
            }

            //give option to clear cart or move to payment
            Console.WriteLine("\nWould you like to 'c'heck out, or would you like to  go back to main 'm'enu or clear your 's'hopping cart?");

            char choice = Validator.GetAnyCaseChar("\npress 'c' to 'c'heck out\npress 's' to clear your 's'hopping cart\npress 'm' to go back to the main 'm'enu.", new char[] { 'c', 's', 'm' }, new char[] { 'C', 'S', 'M' });


            if (choice == 'c')
            {
                Payment.CheckingOut(grandTotal, ShoppingCart);
            }
            else if (choice == 'm')
            {
                Console.Clear();
                return;
            }
            else if(choice == 's')
            {
                ShoppingCart.Clear();
                Console.Clear();
                Console.WriteLine("Emptied cart, returning to main menu!");
                Console.ReadKey(true);
                Console.Clear();
                return;
            }

        }

    }
}
