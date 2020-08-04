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
            Console.WriteLine("Welcome to Get Rich or Die Trying \nPlease enter your characters name");
            userName = Console.ReadLine();
            Console.WriteLine($" Hello {userName}, are you ready to get money or die trying?");
            Console.WriteLine("You have 42 years to obtain your fortune by traveling from planet to planet");
        }
    }
}
