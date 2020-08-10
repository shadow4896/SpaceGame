using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class Story
    {
        string userName;

        List<Planet> planets = new List<Planet>();

        public Story()
        {
            Planet mars = new Planet("Mars", new List<Goods> { new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(mars);

            Planet earth = new Planet("Earth", new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(earth);

            Planet venus = new Planet("Venus", new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(venus);

            Planet jupiter = new Planet("Jupiter", new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(jupiter);

            Planet alphaProxima1 = new Planet("Alpha Proxima 1", new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(alphaProxima1);
        }

        public void Run()
        {

            Console.WriteLine("Welcome to Get Rich or Die Trying\n---------------------------------\n\nPlease enter your characters name : ");
            userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nHello {userName}, are you ready to get money or die trying? \n\nThe object of this game is to accumulate wealth as fast and efficiently as possible.\n");
            Console.WriteLine("You are 18 years old and have 42 years to obtain your fortune by traveling from planet to planet selling and acquiring goods.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please select a ship to start off your journey \n\n1. StarFighter (Speed : Warp 3, Capacity: 1000lbs)\n2. SalvageHauler (Speed : Warp 2, Capacity: 2500lbs)\n3. Frigate (Speed : Warp 1, Capacity: 5000lbs)\n");

            var ship = ShipChoice();
            Console.Clear();


            Console.WriteLine($"In order to make money, you must first sell and trade goods.  {userName}, select your initial inventory of goods.  Keep in mind, your ship has a max capacity.");
            Console.ReadLine();

            Supply(ship);
        }
        private Ship ShipChoice()
        {
            var key = Console.ReadKey().Key;
            var ship = new Ship();

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nStarFigher it is, I guess speed and not capacity is your thing!");
                    ship.spaceShips = SpaceShips.StarFighter;
                    ship.capacity = 1000;
                    ship.speed = 3;
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\nSalvageHauler it is, average ship for an average person!");
                    ship.spaceShips = SpaceShips.SalvageHauler;
                    ship.capacity = 2500;
                    ship.speed = 2;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\nFrigate it is, slow and steady wins the race!!!!");
                    ship.spaceShips = SpaceShips.Frigate;
                    ship.capacity = 5000;
                    ship.speed = 1;
                    break;
                case ConsoleKey.Q:
                    break;
            }

            AnyKey();

            return ship;
        }

        private void AnyKey()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey(true);
        }

        public void Supply(Ship ship)
        {
            bool doneTrading = false;

            // While we're not done trading
            while (!doneTrading)
            {
                Console.Clear();
                Console.WriteLine($"Available capacity: {ship.capacity - ship.productsInHold()}lbs");
                Console.WriteLine("Select from the following choices:\n\n1. Food\n2. Andriod\n3. Weapons\n4. Entertainment\n5. Oil\n6. Done trading");

                // Loop in either case until the user enters valid input
                // Accept an item to buy
                bool done = false;
                int chosenItem = 0;
                int numToBuy = 0;

                Goods good = new Goods();

                while (!done)
                {
                    var key = Console.ReadKey().Key;
                    Console.WriteLine();

                    done = true;

                    switch (key)
                    {
                        case ConsoleKey.D1:
                            good.name = "pallets of food";
                            good.cost = 3;
                            good.weight = 5;
                            break;
                        case ConsoleKey.D2:
                            good.name = "andriods";
                            good.cost = 1;
                            good.weight = 1;
                            break;
                        case ConsoleKey.D3:
                            good.name = "weapon crates?";
                            good.cost = 1;
                            good.weight = 1;
                            break;
                        case ConsoleKey.D4:
                            good.name = "entertainment";
                            good.cost = 1;
                            good.weight = 1;
                            break;
                        case ConsoleKey.D5:
                            good.name = "barrels of oil";
                            good.cost = 1;
                            good.weight = 1;
                            break;
                        case ConsoleKey.D6:
                            doneTrading = true;
                            break;
                        default:
                            done = false;
                            break;
                    }

                    if (!done && !doneTrading)
                    {
                        Console.WriteLine("\nInvalid choice. Try again.");
                    }
                }

                if (doneTrading) continue;

                // Accept a # of the chosen item to purchase
                done = false;

                while (!done)
                {
                    Console.Write($"How many {good.name}? ");

                    try
                    {
                        numToBuy = int.Parse(Console.ReadLine());

                        if (good.weight * numToBuy + ship.productsInHold() > ship.capacity)
                        {
                            Console.WriteLine($"Puchasing that many {good.name} will overload your ship. Try buying less.");
                            continue;
                        }

                        done = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                // We have a valid item to purchase and a valid quantity of that item.
                Console.WriteLine($"Purchasing {numToBuy} of item {chosenItem}");

                // Add the item to the inventory
                ship.hold.Add((good, numToBuy));
            }
        }
    }
}