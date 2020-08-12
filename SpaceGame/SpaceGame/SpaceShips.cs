using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public enum SpaceShips { StarFighter, SalvageHauler, Frigate };

    public class Ship
    {
        public SpaceShips spaceShips;

        public int capacity;
        public int speed;

        double mileage = 0;

        public Planet currentPlanet;

        public Ship(Planet currentPlanet)
        {
            this.currentPlanet = currentPlanet;
        }

        public void TravelTo(Planet destination)
        {
            mileage += currentPlanet.DistanceTo(destination);
            currentPlanet = destination;
        }

        public List<(Goods good, int quantity)> hold = new List<(Goods good, int quantity)>();

        public int productsInHold() => hold.Select(g => g.good.weight * g.quantity).Sum();
    }
  }