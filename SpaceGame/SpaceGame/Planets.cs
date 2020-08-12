using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{ 
    public enum PlanetSystem { Earth, AlphaProxima1, Mars, Venus, Jupitor };

    public class Planet
    {
        public string name;

        public List<Goods> Goods = new List<Goods>();
        public int xcoord;
        public int ycoord;

        public Planet(string name, int xcoord, int ycoord, List<Goods> goods)
        {
            this.name = name;
            Goods = goods;
            this.xcoord = xcoord;
            this.ycoord = ycoord;

        }




        public double DistanceTo(Planet otherPlanet)
        {
            //Implement Pythagorean Theorem

            var left = Math.Pow(this.xcoord - otherPlanet.xcoord, 2);
            var right = Math.Pow(this.ycoord - otherPlanet.ycoord, 2);

            return Math.Sqrt(left + right);

        }



        //Warp Speed to Light Speed formula

        public static double WarpToLightYearsPer(double warp) => Math.Pow(warp, (10.0 / 3)) + Math.Pow((10 - warp), (-11.0 / 3));




    }

    
}
