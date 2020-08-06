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

            ShipChoice();
            Console.Clear();


            Console.WriteLine($"In order to make money, you must first sell and trade goods.  {userName}, select your initial inventory of goods.  Keep in mind, your ship has a max capacity.");
            Console.ReadLine();

            Console.WriteLine("Select from the following choices:\n\n1. Food\n2. Andriod\n3. Weapons\n4. Entertainment\n5. Oil");
            Supply();
        }
        private ConsoleKey ShipChoice()
        {
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nStarFigher it is, I guess speed and not capacity is your thing!");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\nSalvageHauler it is, average ship for an average person!");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\nFrigate it is, slow and steady wins the race!!!!");
                    break;
                case ConsoleKey.Q:
                    break;
            }
            return Console.ReadKey().Key;
        }

        public ConsoleKey Supply()
        {
            var key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("How many pallets of food?");
                    Console.WriteLine();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\nFrigate it is, slow and steady wins the race!!!!\nIn order to make money, you must first sell and trade goods.  Please select your initial inventory of goods.  Keep in mind, your ship has a max capacity of 5000 lbs");
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
            }
            return Console.ReadKey().Key;
        }
    }
}