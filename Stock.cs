using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    // singleton class, since we'll only ever have one stock
    public sealed class Stock // cannot inherit this class, but can instantiate it
    {
        private static Stock instance = null;
        private Dictionary<Component, int> componentStock; // nume component + cantitate aferenta
        private double totalValue;

        private Stock()
        {
            componentStock = new Dictionary<Component, int>();
        }

        public static Stock Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Stock();
                }
                return instance;
            }
        }

        public double TotalValue
        {
            get
            {
                totalValue = 0;
                foreach (Component component in componentStock.Keys.ToList())
                {
                    totalValue += component.Quantity * component.Price;
                }
                return totalValue;
            }
        }

        public override string ToString()
        {
            string toReturn = "";
            foreach(Component component in componentStock.Keys.ToList())
            {
                toReturn += component.ToString() + " " + componentStock[component] + "\n";
            }
            return toReturn;
        }
    }
}
