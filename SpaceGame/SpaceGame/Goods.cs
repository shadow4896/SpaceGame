using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    public enum TradingGoods { food, Androids, Oil, Entertainment, Weapons };

    class Goods
    {
        decimal goldCoins;
        int capacity;
        string load;

        public TradingGoods goodsType;

        List<Load> loads;

        public void AddLoad(Load toAdd)
            // if the load does not exceed the capacity of the ship, add it.

            var currrentLoad = GetCurrentLoad();
            if (currentLoad + toAdd.weight <= capacity)
            {
                loads.Add(toAdd);
            } 
           // if the load does exceed the cpacity of the ship, throw a "ThruckOverload" exception
           else
           {
internal class Load
    {
    }
}

        public void RemoveLoad(Load load)
        {
            throw new NotImplementedException();
        }


    }
}
