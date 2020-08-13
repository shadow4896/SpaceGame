using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SpaceGame
{
    class Story
    {
        string userName;

        List<Planet> planets = new List<Planet>();

        public Story()
        {
            Planet mars = new Planet("Mars", 0, 5, new List<Goods> { new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(mars);

            Planet earth = new Planet("Earth", 0, 0, new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(earth);

            Planet venus = new Planet("Venus", 5, 0, new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(venus);

            Planet jupiter = new Planet("Jupiter", 7, 0, new List<Goods>
                                                              {new Goods("Food", 5, 20),
                                                               new Goods("Android", 20, 50),
                                                               new Goods("Weapons", 100, 100),
                                                               new Goods("Entertainment", 10, 5),
                                                               new Goods("Oil", 100, 200)});

            planets.Add(jupiter);

            Planet alphaProxima1 = new Planet("Alpha Proxima 1", 0, 4, new List<Goods>
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
            Console.WriteLine($"\nHello {userName}, are you ready to get rich or die trying? \n\nThe object of this game is to accumulate wealth as fast and efficiently as possible.\n");
            Console.WriteLine("You are 18 years old and have 42 years to obtain your fortune by traveling from planet to \nplanet selling and acquiring goods.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please select a ship to start off your journey \n\n1. StarFighter (Speed : Warp 3, Capacity: 1000lbs)\n2. SalvageHauler (Speed : Warp 2, Capacity: 2500lbs)\n3. Frigate (Speed : Warp 1, Capacity: 5000lbs)\n");

            Player player;

            {
                var ship = ShipChoice();
                player = new Player(ship.currentPlanet, ship);
            }

            Console.Clear();


            Console.WriteLine($"In order to make money, you must first sell and trade goods.  \n{userName}, select your initial inventory of goods.  Keep in mind, your ship has a max capacity.");
            Console.ReadLine();

            Supply(player.ship);
            
            Location(player);

            Console.Clear();
            Console.WriteLine($"You are now {player.age:f2}");
            Console.WriteLine($"Welcome to {player.location.name}! ");
            Console.WriteLine("Sell your ship inventory and get back to earth to restock.  \nProblem is, they might not want what you have.  Please select goods to trade or sell.");
            Console.WriteLine("\n\n1. Food\n2. Andriod\n3. Weapons\n4. Entertainment\n5. Oil");
        }
        private Ship ShipChoice()
        {
            var key = Console.ReadKey().Key;
            var ship = new Ship(planets[1]);

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
                            good.cost = 5;
                            good.weight = 20;
                            break;
                        case ConsoleKey.D2:
                            good.name = "andriods";
                            good.cost = 20;
                            good.weight = 50;
                            break;
                        case ConsoleKey.D3:
                            good.name = "weapon crates?";
                            good.cost = 100;
                            good.weight = 100;
                            break;
                        case ConsoleKey.D4:
                            good.name = "entertainment";
                            good.cost = 10;
                            good.weight = 5;
                            break;
                        case ConsoleKey.D5:
                            good.name = "barrels of oil";
                            good.cost = 100;
                            good.weight = 200;
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

        public void Location(Player player)
        {
            bool done;

            do
            {
                done = true;
                Console.Clear();

                Console.WriteLine(" Where would you like your first destination to be?  Please select wisely, your life depends on it!!\n1. Mars\n2. Venus\n3. Jupiter\n4. Alpha Proximal 1\n5. Earth ");
                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nMars it is!");
                        player.TravelTo(planets[0]);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nVenus it is!");
                        player.TravelTo(planets[2]);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nJupiter it is!");
                        player.TravelTo(planets[3]);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nAlpha Proximal 1 it is!");
                        player.TravelTo(planets[4]);
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\nEarth it is!");
                        player.TravelTo(planets[1]);
                        break;
                    default:
                        done = false;
                        break;
                }
            } while (!done);

            AnyKey();
        }


        //public void PrintLocationAndDistances()
        //{
        //    for (int i = 0; i < location.Count; ++i)
        //    {
        //        Planet destination = location[i];
        //        var distance = player.location.DistanceTo(otherPlanet);
        //        Console.Write($"-");
        //    }
        //}
    }
}