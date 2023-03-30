using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    abstract public class Component
    {
        private string name;
        private double price;
        private int quantity;
        private ComponentType type;

        public Component(string name, double price, int quantity, ComponentType type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public double Price
        {
            get => this.price; 
            set => this.price = value;
        }

        public int Quantity
        {
            get => this.quantity; 
            set => this.quantity = value;
        }

        public ComponentType Type
        {
            get => this.type;
        }

        public override string ToString()
        {
            string toReturn = type + "|" + name + "|" + price + " lei|" + quantity + " bucati";
            return toReturn;
        }
    }
}
