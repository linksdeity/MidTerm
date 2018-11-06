using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTerm
{
    public static class Receipt
    {
        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart,int amount,int change)
        {
            Console.Clear();

            Console.WriteLine("Thank you for shopping with MALOMART!\nYou have purchased the following items...\n\n");

            Console.WriteLine(Itemizer.CountDuplicates(ShoppingCart));

            Console.WriteLine("You payed with Rupees in the amount of: {0}", amount);

            int total = Itemizer.GetTotal(ShoppingCart);

            Console.WriteLine("\nTotal before tax: " + total);
            Console.WriteLine("\nGRAND TOTAL: " + grandTotal);

            Console.WriteLine("\n\nYou are receiving {0} Rupees in change", change);

            Console.WriteLine("\nPress anything to return to the main menu");
            ShoppingCart.Clear();
            Console.ReadKey(true);
            Console.Clear();

        }


        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart,string cardNumber,string expiration)
        {
            Console.Clear();

            Console.WriteLine("Thank you for shopping with MALOMART!\nYou have purchased the following items...\n\n");

            Console.WriteLine(Itemizer.CountDuplicates(ShoppingCart));

            char[] cardLastFour = new char[4];

            cardLastFour[0] = cardNumber[(cardNumber.Length - 4)];
            cardLastFour[1] = cardNumber[(cardNumber.Length - 3)];
            cardLastFour[2] = cardNumber[(cardNumber.Length - 2)];
            cardLastFour[3] = cardNumber[(cardNumber.Length - 1)];

            Console.WriteLine("You payed with a card, ending in: " + cardLastFour[0] + cardLastFour[1] + cardLastFour[2] + cardLastFour[3]);

            int total = Itemizer.GetTotal(ShoppingCart);

            Console.WriteLine("\nTotal before tax: " + total);
            Console.WriteLine("\nGRAND TOTAL: " + grandTotal);

            Console.WriteLine("\nPress anything to return to the main menu");
            ShoppingCart.Clear();
            Console.ReadKey(true);
            Console.Clear();


        }


        public static void PrintReceipt(int grandTotal, List<Product> ShoppingCart, string checkNumber)
        {
            Console.Clear();

            Console.WriteLine("Thank you for shopping with MALOMART!\nYou have purchased the following items...\n\n");

            Console.WriteLine(Itemizer.CountDuplicates(ShoppingCart));

            Console.WriteLine("You payed with a check or bank account, number: " + checkNumber);

            int total = Itemizer.GetTotal(ShoppingCart);

            Console.WriteLine("\nTtotal before tax: " + total);
            Console.WriteLine("\nGRAND TOTAL: " + grandTotal);

            Console.WriteLine("\nPress anything to return to the main menu");
            ShoppingCart.Clear();
            Console.ReadKey(true);
            Console.Clear();
        }

    }
}
