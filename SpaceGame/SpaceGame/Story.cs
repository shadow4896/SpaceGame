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
            Console.WriteLine($"\nHello {userName}, are you ready to get money or die trying? \n\nThe object of this game is to accumulate wealth as fast and efficiently as possible.\n");
            Console.WriteLine("You have 42 years to obtain your fortune by traveling from planet to planet selling and acquiring goods");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please select a ship to start off your journey \n1. StarFighter (Speed : Warp 3, Capacity: 1000lbs)\n2. SalvageHauler (Speed : Warp 2, Capacity: 2500lbs)\n3. Frigate (Speed : Warp 1, Capacity: 5000lbs)\n");
        }
        private bool GetUserInput(ConsoleKey key)
        {
                        
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("StarFigher it is");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("SalvageHauler it is");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Frigate it is");
                    break;
                case ConsoleKey.Q:
                    return true;
            }
            return false;
        }

    }






   
        
    
}
