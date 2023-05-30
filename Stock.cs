using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    // singleton class, since we'll only ever have one stock
    [Serializable]
    public sealed class Stock // cannot inherit this class, but can instantiate it
    {
        private static Stock instance = null;
        private Dictionary<Component, int> componentStock; // nume component + cantitate aferenta
        private double totalValue;

        public Stock()
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

        public List<Component> Keys
        {
            get => componentStock.Keys.ToList();
        }

        public int GetValue(Component key)
        {
            if (componentStock.ContainsKey(key))
            {
                return componentStock[key];
            }
            return -1;
        }

        public void AddToStock(Component c)
        {
            if(componentStock.ContainsKey(c))
            {
                componentStock[c]++;
                return;
            }
            componentStock.Add(c, 1);
        }

        public void AddMultipleToStock(Component c, int quantity)
        {
            if (componentStock.ContainsKey(c))
            {
                componentStock[c] += quantity;
                return;
            }
            componentStock.Add(c, quantity);
        }

        public void RemoveFromStock(Component c, int quantity)
        {
            if (!componentStock.ContainsKey(c))
            {
                return;
            }
            if (componentStock[c] < quantity)
            {
                return;
            }
            componentStock[c] -= quantity;
            
        }

        public int GetQuantity(Component c)
        {
            if (!componentStock.ContainsKey(c))
            {
                return -1;
            }
            return componentStock[c];
        }

        public void setQuantity(Component c, int quantity)
        {
            if (!componentStock.ContainsKey(c))
            {
                return;
            }
            componentStock[c] = quantity;
        }

        public void Delete(string itemToDelete)
        {
            foreach(Component c in componentStock.Keys)
            {
                if(c.Name == itemToDelete)
                {
                    componentStock.Remove(c);
                    return;
                }
            }
        }

        public double TotalValue
        {
            get
            {
                totalValue = 0;
                foreach (Component component in componentStock.Keys.ToList())
                {
                    totalValue += componentStock[component] * component.Price;
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

        public void Serialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }

        public void Deserialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Stock stock = (Stock)formatter.Deserialize(file);
            this.componentStock = stock.componentStock;
            file.Close();
        }
    }
}
