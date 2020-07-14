using System;
using System.Collections;
using System.Collections.Generic;

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


            Dictionary<string, double> menu = new Dictionary<string, double>();
            ArrayList itemName = new ArrayList();
            ArrayList itemPrice = new ArrayList();

            menu["Apple  "] = 1.99;
            menu["Orange "] = 0.99;
            menu["Grape  "] = 2.99;
            menu["Mango  "] = 1.99;
            menu["Lime   "] = 3.99;
            menu["Kiwi   "] = 3.55;
            menu["Lemon  "] = 2.25;
            menu["Lychee "] = 4.99;
            double cartTotal = 0.00;
            double cartAverage = 0.00;

            bool running = true;
            while (running)
            {
                Console.WriteLine("Item  | Price");
                Console.WriteLine("=============");
                foreach (KeyValuePair<string, double> item in menu)
                {
                    Console.WriteLine($"{item.Key} ${item.Value}");
                }
                
                Console.WriteLine("");
                Console.WriteLine("Currently in Cart:");

                for (int i = 0; i < itemName.Count; i++)
                {
                    Console.WriteLine($"{itemName[i]}  ${itemPrice[i]}");
                }

                for (int j = 0; j < itemPrice.Count; j++)
                {
                    
                }
                    //Shopping List?

                    Console.WriteLine("");
                    Console.WriteLine("What would you like to purchase? (Type DONE when ready to check out.)");
                    string answer = Console.ReadLine();
                    string lowerAnswer = answer.ToLower();

                    if (lowerAnswer == "apple")
                    {
                        itemName.Add("Apple");
                        itemPrice.Add(1.99);
                        Console.Clear();
                    }
                    else if (lowerAnswer == "orange")
                    {
                    itemName.Add("Orange");
                    itemPrice.Add(0.99);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "grape")
                    {
                    itemName.Add("Grape Bundle");
                    itemPrice.Add(2.99);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "mango")
                    {
                    itemName.Add("Mango");
                    itemPrice.Add(1.99);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "lime")
                    {
                    itemName.Add("Lime");
                    itemPrice.Add(3.99);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "kiwi")
                    {
                    itemName.Add("Kiwi");
                    itemPrice.Add(3.55);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "lemon")
                    {
                    itemName.Add("Lemon");
                    itemPrice.Add(2.25);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "lychee")
                    {
                    itemName.Add("Lychee");
                    itemPrice.Add(4.99);
                    Console.Clear();
                    }
                    else if (lowerAnswer == "done")
                    {
                    Console.Clear();
                    for (int i = 0; i < itemName.Count; i++)
                    {
                        Console.WriteLine($"{itemName[i]}  ${itemPrice[i]}");
                        cartTotal += (double)itemPrice[i];
                        cartAverage = cartTotal / itemName.Count;

                    }

                    bool runningEnd = true;
                    while (runningEnd)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Total owed: ${cartTotal:N2}");
                        Console.WriteLine($"The average price per item is: ${cartAverage:N2}");

                        Console.WriteLine("");
                        Console.WriteLine("Would you like to continue shopping? (Y/N)");
                        string again = Console.ReadLine();
                        string lowerAgain = again.ToLower();
                        if (lowerAgain == "no" || lowerAgain == "n")
                        {
                            running = false;
                            break;//kill code
                        }
                        else if(lowerAgain == "yes" || lowerAgain == "y")
                        {
                            Console.Clear();
                            break;//works to head back to cart.
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sorry, I didn't quite catch that. (Y/N)");
                            continue;
                        }
                    }  
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, seems like we're out of stock on that one.");
                        Console.WriteLine("");
                        continue;
                    }
                }

                //forloop sum for price average

            }
        }
    }

