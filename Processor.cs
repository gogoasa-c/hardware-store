using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    [Serializable]
    public class Processor : Component
    {
        private int cores;
        private float frequency;

        public Processor(int cores, float frequency, string name, double price, ComponentType type):base(name, price, type)
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
            string toReturn = this.cores + " " + this.frequency + " " + base.ToString();
            return toReturn;
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
