using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    public class Processor : Component
    {
        private int cores;
        private float frequency;

        Processor(int cores, float frequency, string name, double price, int quantity, ComponentType type):base(name, price, quantity, type)
        {
            this.cores = cores;
            this.frequency = frequency;
        }

        public int Cores
        {
            get => this.cores;
            set => this.cores = value;
        }

        public float Frequency
        {
            get => this.frequency;
            set => this.frequency = value;
        }

        public override string ToString()
        {
            string toReturn = this.cores + " nuclee|" + this.frequency + " GHz|" + base.ToString();
            return toReturn;
        }
    }
}
