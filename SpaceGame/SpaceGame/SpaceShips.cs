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

        public List<(Goods good, int quantity)> hold = new List<(Goods good, int quantity)>();

        public int productsInHold() => hold.Select(g => g.good.weight * g.quantity).Sum();
    }
  }