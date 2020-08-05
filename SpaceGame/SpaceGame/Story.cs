using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    class Story
    {
        string userName;
        public void Run()
        {
            Console.WriteLine("Welcome to Get Rich or Die Trying\n---------------------------------\n\nPlease enter your characters name : ");
            userName = Console.ReadLine();
            Console.WriteLine($"\nHello {userName}, are you ready to get money or die trying? \n\nThe object of this game is to accumulate wealth as fast and efficiently as possible.\n");
            Console.WriteLine("You have 42 years to obtain your fortune by traveling from planet to planet selling and acquiring goods");
            Console.ReadLine();
            Console.WriteLine("Please select a ship to start off your journey \n1. StarFighter (Speed : Warp 3, Capacity: 1000lbs)\n2. SalvageHauler (Speed : Warp 2, Capacity: 2500lbs)\n3. Frigate (Speed : Warp 1, Capacity: 5000lbs)\n");
        }
    }
}
