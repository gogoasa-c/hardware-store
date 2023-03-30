using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    class RamMemory : Component
    {
        private int memory; // no. of Gb
        private int frequency; // in MHz

        RamMemory(int memory, int frequency, string name, double price, int quantity, ComponentType type):base(name, price, quantity, type)
        {
            this.memory = memory;
            this.frequency = frequency;
        }
        public int Memory
        {
            get => this.memory;
            set => this.memory = value;
        }

        public int Frequency
        {
            get => this.frequency;
            set => this.frequency = value;
        }

    }
}
