using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{ 
    public enum PlanetSystem { Earth, AlphaProxima1, Mars, Venus, Jupitor };

    public class Planet
    {
        public string name;

        public List<Goods> Goods =  new List<Goods>();

        public Planet(string name, List<Goods> goods)
        {
            this.name = name;
            Goods = goods;
        }
    }
}
