using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DictionaryFunRV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             What will the application do?
            ● Display a list of at least 8 item names and prices.                                            Done.
            ● Ask the user to enter an item name                                                             Done.
            ○ If that item exists, display that item and price and add that item and its price to
            the user’s order.                                                                                Done.
            ○ If that item doesn’t exist, display an error and re-prompt the user. (Display the
            menu again if you’d like.)                                                                       Done.
            ● Ask if they want to add another. Repeat if they do. (User can enter an item more than
            once; we’re not taking quantity at this point.)                                                  Done.
            ● When they’re done adding items, display a list of all items ordered with prices in
            columns.                                                                                         Done.  
            ● Display the average price of items ordered.                                                    Done.


            Build Specifications/Grading Points
            ● Application uses a Dictionary <string, double> to keep track of the menu of items. You
            can code it with literals. (2 points for instantiation & initialization)                         Done.
            ● Application uses parallel ArrayLists (one of strings, one of doubles) to store the items
            ordered and their prices. (2 point for setting up empty lists)                                   Done.
            ● Application takes item name input and: 
            ○ Responds if that item doesn’t exist (1 point)                                                  Done.
            ○ Adds its name and price to the relevant ArrayLists if it does (1 point)                        Done.
            ● Application asks user if they want to quit or continue, and loops appropriately (1 point)      Done.
            ● Application displays list of items with their prices (2 points)                                Done.
            ● Application displays correct average for list (1 point)                                        Done.
            */
            //Menu Dictionary, Two Array lists for other things.



            //Dictionary and Two Arrays created.
            Dictionary<string, double> menu = new Dictionary<string, double>();
            ArrayList itemName = new ArrayList();
            ArrayList itemPrice = new ArrayList();

            //Dictionary string menu items with their double prices displayed.
            menu["Apple  "] = 1.99;
            menu["Orange "] = 0.99;
            menu["Grape  "] = 2.99;
            menu["Mango  "] = 1.99;
            menu["Lime   "] = 3.99;
            menu["Kiwi   "] = 3.55;
            menu["Lemon  "] = 2.25;
            menu["Lychee "] = 4.99;

            //Setting up for the total and the average.
            double cartTotal = 0.00;
            double cartAverage = 0.00;

            //Loop to run while the program is going.
            bool running = true;
            while (running)
            {
                bool stillRunning = true;
                while (stillRunning)
                {
                
                    //Header.
                Console.WriteLine("Welcome to the grocery store! We have groceries!");
                Console.WriteLine("Item  | Price");
                Console.WriteLine("=============");

                //Display the menu.
                foreach (KeyValuePair<string, double> item in menu)
                {
                    Console.WriteLine($"{item.Key} ${item.Value}");
                }

                //Footer to the menu, items added to cart will display below.
                Console.WriteLine("");
                Console.WriteLine("Currently in Cart:");

                //Shows the items and prices of objects currently in the string and double listarrays.
                for (int i = 0; i < itemName.Count; i++)
                {
                    Console.WriteLine($"{itemName[i]}  ${itemPrice[i]}");
                }

                //Instructions for the user.
                Console.WriteLine("");
                Console.WriteLine("What would you like to purchase?"); 
                Console.WriteLine("Type an item from the menu to add to your cart.");
                Console.WriteLine("");

                    
                    //Get input from user.
                    string answer = Console.ReadLine();
                    string lowerAnswer = answer.ToLower();

                    //If tree for adding strings or double values to their respective arraylists if the corresponding answer.ToLower() was typed in.
                    if (lowerAnswer == "apple")
                    {
                        itemName.Add("Apple");
                        itemPrice.Add(1.99);

                        Console.Clear();
                        Console.WriteLine("An apple was added to your cart for the price of $1.99.");
                        Console.WriteLine("");
                        
                    }
                    else if (lowerAnswer == "orange")
                    {
                        itemName.Add("Orange");
                        itemPrice.Add(0.99);

                        Console.Clear();
                        Console.WriteLine("An orange was added to your cart for the price of $0.99.");
                        Console.WriteLine("");
                        
                    }
                    else if (lowerAnswer == "grape")
                    {
                        itemName.Add("Grape Bundle");
                        itemPrice.Add(2.99);

                        Console.Clear();
                        Console.WriteLine("A grape bundle was added to your cart for the price of $2.99.");
                        Console.WriteLine("");
                        
                    }
                    else if (lowerAnswer == "mango")
                    {
                        itemName.Add("Mango");
                        itemPrice.Add(1.99);

                        Console.Clear();
                        Console.WriteLine("A mango was added to your cart for the price of $1.99.");
                        Console.WriteLine("");
                        
                    }
                    else if (lowerAnswer == "lime")
                    {
                        itemName.Add("Lime");
                        itemPrice.Add(3.99);

                        Console.Clear();
                        Console.WriteLine("A lime was added to your cart for the price of $3.99.");
                        Console.WriteLine("");
                        
                    }
                    else if (lowerAnswer == "kiwi")
                    {
                        itemName.Add("Kiwi");
                        itemPrice.Add(3.55);

                        Console.Clear();
                        Console.WriteLine("A kiwi was added to your cart for the price of $3.55.");
                        Console.WriteLine("");
                    }
                    else if (lowerAnswer == "lemon")
                    {
                        itemName.Add("Lemon");
                        itemPrice.Add(2.25);

                        Console.Clear();
                        Console.WriteLine("A lemon was added to your cart for the price of $2.25.");
                        Console.WriteLine("");
                    }
                    else if (lowerAnswer == "lychee")
                    {
                        itemName.Add("Lychee");
                        itemPrice.Add(4.99);

                        Console.Clear();
                        Console.WriteLine("A lychee was added to your cart for the price of $4.99.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, seems like we're out of stock on that one.");
                        Console.WriteLine("");
                        continue;
                    }

                    bool endRunning = true;
                    while (endRunning) {
                        Console.WriteLine("Would you like to continue shopping? (Y/N)");
                        string stillAnswer = Console.ReadLine();
                        string lowerStillAnswer = stillAnswer.ToLower();

                        if (lowerStillAnswer == "yes" || lowerStillAnswer == "y")
                        {
                            Console.Clear();
                            running = true;
                            break;
                        }
                        else if (lowerStillAnswer == "no" || lowerStillAnswer == "n")
                        {
                            Console.Clear();
                            for (int i = 0; i < itemName.Count; i++)
                            {
                                Console.WriteLine($"{itemName[i]}  ${itemPrice[i]}");
                                cartTotal += (double)itemPrice[i];
                                cartAverage = cartTotal / itemName.Count;
                            }

                            Console.WriteLine("");
                            Console.WriteLine($"Total owed: ${cartTotal:N2}");
                            Console.WriteLine($"The average price per item is: ${cartAverage:N2}");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("Press enter to finish the program.");
                            Console.ReadLine();
                            running = false;
                            stillRunning = false;
                            endRunning = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                }
            }
        }
    }

