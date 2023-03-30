using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    public class HardDrive : Component
    {
        private int capacity;
        private int rotationsPerMinute; // rpm

        HardDrive(int capacity, int rotationsPerMinute, string name, double price, int quantity, ComponentType type) : base(name, price, quantity, type)
        {
            this.capacity = capacity;
            this.rotationsPerMinute = rotationsPerMinute;
        }

        public int Capacity
        {
            get => this.capacity;
            set => this.capacity = value;
        }

        public int RotationsPerMinute
        {
            get => this.rotationsPerMinute;
            set => this.rotationsPerMinute = value;
        }

        public override string ToString()
        {
            string toReturn = capacity + " GB|" + rotationsPerMinute + " RPM|" + base.ToString();
            return toReturn;
        }
    }
}
