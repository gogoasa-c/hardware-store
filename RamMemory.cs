using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace hardware_store
{
    [Serializable]
    class RamMemory : Component
    {
        private int memory; // no. of Gb
        private int frequency; // in MHz

        public RamMemory(int memory, int frequency, string name, double price, int quantity, ComponentType type):base(name, price, quantity, type)
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

        public override string ToString()
        {
            return memory + " " + frequency + " " + base.ToString();
        }

        public void Serialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }

        public Processor Deserialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Processor processor = (Processor)formatter.Deserialize(file);
            file.Close();
            return processor;
        }

    }
}
