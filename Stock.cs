using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    public class Stock
    {
        private Dictionary<Component, int> componentStock; // nume component + cantitate aferenta
        private double totalValue;

        public Stock()
        {
            componentStock = new Dictionary<Component, int>();
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
        

    }
}
