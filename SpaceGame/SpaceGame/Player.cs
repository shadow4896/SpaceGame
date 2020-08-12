using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SpaceGame
{
    class Player
    {
        public double age = 18;
        public decimal gold;

        public Planet location;

        public Ship ship;

        public Player(Planet location, Ship ship)
        {
            this.location = location;
            this.ship = ship;
            gold = 100M;
        }

        public void TravelTo(Planet otherPlanet)
        {
            var warp = ship.speed;

            var distance = location.DistanceTo(otherPlanet);
            var speed = Planet.WarpToLightYearsPer(warp);
            
            age += distance / speed;

            location = otherPlanet;

            ship.TravelTo(otherPlanet);
        }
    
         


       
        
    }
}