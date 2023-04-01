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
    abstract public class Component
    {
        private string name;
        private double price;
        private ComponentType type;

        public Component(string name, double price, ComponentType type)
        {
            this.name = name;
            this.price = price;
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


        public ComponentType Type
        {
            get => this.type;
        }

        public override string ToString()
        {
            string toReturn = type + " " + name + " " + price + " ";
            return toReturn;
        }


        public void Serialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            // check the type of the component and serialize it
            switch (this.type)
            {
                case ComponentType.GraphicsCard:
                    formatter.Serialize(file, (GraphicsCard)this);
                    break;
                case ComponentType.Processor:
                    formatter.Serialize(file, (Processor)this);
                    break;
                case ComponentType.RAM:
                    formatter.Serialize(file, (RamMemory)this);
                    break;
                case ComponentType.HardDrive:
                    formatter.Serialize(file, (HardDrive)this);
                    break;
            }
            file.Close();
        }

        public static Component Deserialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Component component = (Component)formatter.Deserialize(file);
            file.Close();
            return component;
        }
    }
}
