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
    public class HardDrive : Component
    {
        private int capacity;
        private int rotationsPerMinute; // rpm

        public HardDrive(int capacity, int rotationsPerMinute, string name, double price, int quantity, ComponentType type) : base(name, price, quantity, type)
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
            string toReturn = capacity + " " + rotationsPerMinute + " " + base.ToString();
            return toReturn;
        }

        public void Serialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }

        public HardDrive Deserialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            HardDrive hdd = (HardDrive)formatter.Deserialize(file);
            file.Close();
            return hdd;
        }

    }
}
