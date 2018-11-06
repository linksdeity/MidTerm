using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTerm
{
    public static class Payment
    {

        //display sub total and grand total (keep these in local vars) and ask how they would like to pay

        public static void CheckingOut(int grandTotal, List<Product> ShoppingCart)
        {
            Console.Clear();

            Console.WriteLine("Your total is: " + grandTotal + " Rupees");

            Console.WriteLine("Please select a payment method from bellow...\n\n");

            char selection = Validator.GetAnyCaseChar("press 'r' to pay with Rupees\npress 'c' to pay with " +
                                                      "card\npress 'b' to pay with bank/check number", new char[] { 'r', 'c', 'b' }, new char[] { 'R', 'C', 'B' });


            //1.Rupees 2.Card 3.Check
            //switch statement that determines each
            switch (selection)
            {
                case 'r':
                    PayRupees(grandTotal, ShoppingCart);
                    break;
                case 'c':
                    PayCard(grandTotal, ShoppingCart);
                    break;
                case 'b':
                    PayCheck(grandTotal, ShoppingCart);
                    break;
            }
        }


        //Rupees
        //ask for a total tendered
        //produce an amount to be given as change
        //store RUPEES as payment method, as well as money tenderd and given as change
        public static void PayRupees(int grandTotal, List<Product> ShoppingCart)
        {
            Console.Clear();

            Console.WriteLine(grandTotal + " Rupees due...");
            Console.WriteLine("Now paying in RUPEES\n\n");

            int amount = Validator.GetNumber("How many Rupees are being paid? (We will not break large amounts more than twice the total) ", grandTotal, (grandTotal * 2));

            int change = (amount - grandTotal);

            if (change >= 1)
            {
                Console.WriteLine("\n - - - After this transaction, you will receive {0} Rupees in change - - - \n", change );
            }


            bool pay = Validator.GetAnyCaseChar("\nPress 'p' to confirm this payment, anything else to go back!", 'p', 'P');

            if (pay)
            {
                Receipt.PrintReceipt(grandTotal, ShoppingCart, amount, change);
            }
            else
            {
                Console.Clear();
                return;
            }

        }


        //Card
        //ask for and validate card number
        //ask for and validate security code
        //ask for and validate expiration
        //store CARD as payment method, and store last 4 digits
        public static void PayCard(int grandTotal, List<Product> ShoppingCart)
        {
            Console.Clear();

            Console.WriteLine(grandTotal + " Rupees due...");
            Console.WriteLine("Now paying with CARD\n\n");

            string cardNumber = Validator.GetString("Please enter a valid card number (####-####-####-####)", @"^(?:\d[ -]*?){13,16}$");

            string expiration = Validator.GetString("Please enter a valid expiration date (month/year as ##/####)", @"^0[1-9]|1[012]/20[1-9][0-9]$");

            string cvv = Validator.GetString("Please enter a valid 3 or 4 number CVV code", @"[0-9]{3,4}");

            bool pay = Validator.GetAnyCaseChar("\nPress 'p' to confirm this payment, anything else to go back!", 'p', 'P');

            if (pay)
            {
                Receipt.PrintReceipt(grandTotal, ShoppingCart, cardNumber, expiration);
            }
            else
            {
                Console.Clear();
                return;
            }

        }


        //check
        //ask for routing number
        //ask for account number
        //save CHECK as payment method and store account number
        public static void PayCheck(int grandTotal, List<Product> ShoppingCart)
        {

            Console.Clear();

            Console.WriteLine(grandTotal + " Rupees due...");
            Console.WriteLine("Now paying with BANK / CHECK\n\n");

            string checkNumber = Validator.GetString("Please enter a valid 9-digit check/routing number (#########)", @"[0-9]{9}");

            bool pay = Validator.GetAnyCaseChar("\nPress 'p' to confirm this payment, anything else to go back!", 'p', 'P');

            if (pay)
            {
                Receipt.PrintReceipt(grandTotal, ShoppingCart, checkNumber);
            }
            else
            {
                Console.Clear();
                return;
            }
        }


        //call receipt class to display receipt




    }
}
