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
    public class GraphicsCard : Component
    {
        private int videoMemory;
        private int bitrate;

        public GraphicsCard(int videoMemory, int bitrate, string name, double price, ComponentType type):base(name, price, type)
        {
            this.videoMemory = videoMemory;
            this.bitrate = bitrate;
        }

        public int VideoMemory
        {
            get => this.videoMemory;
            set => this.videoMemory = value;
        }

        public int Bitrate
        {
            get => this.bitrate;
            set => this.bitrate = value;
        }

        public override string ToString()
        {
            string toReturn = videoMemory + " " + bitrate + " " + base.ToString();
            return toReturn;
        }

        public void Serialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }
        public static GraphicsCard Deserialize(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            GraphicsCard graphicsCard = (GraphicsCard)formatter.Deserialize(file);
            file.Close();
            return graphicsCard;
        }
    }
}
