using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MIdTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ShoppingCart = new List<Product>();



            while (true)
            {
                Console.WriteLine("Welcome to MALOMART! Please select a category from below to buy items, and checkout when you are done!\n\n" +
                                  "1.) SWORDS\n2.) SHIELDS\n3.) POTIONS\n4.) CONSUMABLES\n5.) MASKS\n\n6.) CHECKOUT!");

                int choice = Validator.GetNumber("\nPlease enter in the number for your choice!", 1, 5);

                switch(choice)
                {
                    case 1:
                        //sword add method
                        ItemMenu("swords", ShoppingCart);
                        break;
                    case 2:
                        //shield add method
                        ItemMenu("shields", ShoppingCart);
                        break;
                    case 3:
                        //potion add method
                        ItemMenu("potions", ShoppingCart);
                        break;
                    case 4:
                        //consumables add method
                        ItemMenu("consumables", ShoppingCart);
                        break;
                    case 5:
                        //masks add method
                        ItemMenu("masks", ShoppingCart);
                        break;
                    case 6:
                        //checkout
                        Console.WriteLine("CHECKING OUT!");//------+++
                        break;
                }

                int cartKeeper = 0;

                foreach (Product product in ShoppingCart)
                {
                    cartKeeper += product.Price;
                }

                Console.WriteLine("Current cost of cart: {0}", cartKeeper);
                
            }


        }



        static void ItemMenu(string category, List<Product> ShoppingCart)
        {
            Console.Clear();

            Console.WriteLine("You are viewing the {0} currently...\n\n", category);

            //stores the folder name, same as the category name
            string path = @"C:\Users\tbroughton\source\repos\MIdTerm\assets\" + category;

            //list to store all fo the items we instantiate

            List<Product> itemList = new List<Product>();




            //loops through each file, instantiates an object with the values in the text file
            foreach (var file in Directory.EnumerateFiles(path, "*.txt"))
            {
                StreamReader fileReader = new StreamReader(file);

                List<string> objectStorer = new List<string>();

                string lineSaver;

                while((lineSaver = fileReader.ReadLine()) != null)
                {
                    objectStorer.Add(lineSaver);
                }


                //adds the new object to the item list

                #region
                switch (category)
                {
                    case "swords":

                        Swords newSword = new Swords();
                        newSword.Name = objectStorer[0];
                        newSword.Category = objectStorer[1];
                        newSword.Description = objectStorer[2];
                        newSword.Price = Convert.ToInt32(objectStorer[3]);
                        newSword.Damage = objectStorer[4];

                        itemList.Add(newSword);

                        break;
                    case "shields":

                        Shields newShield = new Shields();
                        newShield.Name = objectStorer[0];
                        newShield.Category = objectStorer[1];
                        newShield.Description = objectStorer[2];
                        newShield.Price = Convert.ToInt32(objectStorer[3]);
                        newShield.Effect = objectStorer[4];

                        itemList.Add(newShield);

                        break;
                    case "potions":

                        Potions newPotion = new Potions();
                        newPotion.Name = objectStorer[0];
                        newPotion.Category = objectStorer[1];
                        newPotion.Description = objectStorer[2];
                        newPotion.Price = Convert.ToInt32(objectStorer[3]);
                        newPotion.Ingrediants = objectStorer[4];
                        newPotion.Effects = objectStorer[5];


                        itemList.Add(newPotion);

                        break;
                    case "consumables":

                        Consumables newConsumable = new Consumables();
                        newConsumable.Name = objectStorer[0];
                        newConsumable.Category = objectStorer[1];
                        newConsumable.Description = objectStorer[2];
                        newConsumable.Price = Convert.ToInt32(objectStorer[3]);
                        newConsumable.NeededContainer = objectStorer[4];
                        newConsumable.Additional = objectStorer[5];

                        itemList.Add(newConsumable);

                        break;
                    case "masks":

                        Masks newMask = new Masks();
                        newMask.Name = objectStorer[0];
                        newMask.Category = objectStorer[1];
                        newMask.Description = objectStorer[2];
                        newMask.Price = Convert.ToInt32(objectStorer[3]);
                        newMask.Effects = objectStorer[4];
                        newMask.Rumors = objectStorer[5];

                        itemList.Add(newMask);

                        break;
                }
                #endregion

            }

            //displays the list of items

            int counter = -1;
            int indexer = 0;

            #region
            switch (category)
            {
                case "swords":

                    foreach (var item in itemList)
                    {
                        counter++;
                        indexer++;

                        var newItem = item as Swords;

                        Console.Write(indexer + " - - ");
                        Console.WriteLine(newItem.ToString());
                        Console.WriteLine(newItem.Description);
                        Console.WriteLine("Damage: " + newItem.Damage);
                        Console.WriteLine("price: {0} Rupees \n\n", itemList[counter].Price);
                    }

                    break;
                case "shields":

                    foreach (var item in itemList)
                    {
                        counter++;
                        indexer++;

                        var newItem = item as Shields;

                        Console.Write(indexer + " - - ");
                        Console.WriteLine(newItem.ToString());
                        Console.WriteLine(newItem.Description);
                        Console.WriteLine("Effect: " + newItem.Effect);
                        Console.WriteLine("price: {0} Rupees \n\n", itemList[counter].Price);
                    }

                    break;
                case "potions":

                    foreach (var item in itemList)
                    {
                        counter++;
                        indexer++;

                        var newItem = item as Potions;

                        Console.Write(indexer + " - - ");
                        Console.WriteLine(newItem.ToString());
                        Console.WriteLine(newItem.Description);
                        Console.WriteLine("Ingredients: " + newItem.Ingrediants);
                        Console.WriteLine("Effects: " + newItem.Effects);
                        Console.WriteLine("price: {0} Rupees \n\n", itemList[counter].Price);
                    }

                    break;
                case "consumables":

                    foreach (var item in itemList)
                    {
                        counter++;
                        indexer++;

                        var newItem = item as Consumables;

                        Console.Write(indexer + " - - ");
                        Console.WriteLine(newItem.ToString());
                        Console.WriteLine(newItem.Description);
                        Console.WriteLine("Container: " + newItem.NeededContainer);
                        Console.WriteLine("Other uses: " + newItem.Additional);
                        Console.WriteLine("price: {0} Rupees \n\n", itemList[counter].Price);
                    }

                    break;
                case "masks":

                    foreach (var item in itemList)
                    {
                        counter++;
                        indexer++;

                        var newItem = item as Masks;

                        Console.Write(indexer + " - - ");
                        Console.WriteLine(newItem.ToString());
                        Console.WriteLine(newItem.Description);
                        Console.WriteLine("Effects: " + newItem.Effects);
                        Console.WriteLine("Rumors: " + newItem.Rumors);
                        Console.WriteLine("price: {0} Rupees \n\n", itemList[counter].Price);
                    }

                    break;
            }
            #endregion


            int choice = Validator.GetNumber("Please enter the number of the item you would like", 1, itemList.Count);

            Console.Clear();

            Console.WriteLine("How many {0}s would you like?", itemList[choice-1].ToString());

            int amount = Validator.GetNumber("Please enter the amount you would like to buy (1 -99)", 1, 99);

            Console.WriteLine("{0} will cost {1} rupees, would you like to add to cart?", amount, (itemList[choice - 1].Price * amount));

            bool answer = Validator.GetAnyCaseChar("Press 'y' for 'y'es, anything else for NO!", 'y','Y');

            if(answer)
            {
                for (int i = 0; i < amount; i++)
                {
                    ShoppingCart.Add(itemList[choice - 1]);
                }

                Console.Clear();

                Console.WriteLine("Items added!");
            }
            else
            {
                Console.Clear();

                Console.WriteLine("NO items added!");
            }


            Console.ReadKey(true);
            Console.Clear();


        }


























    }
}
