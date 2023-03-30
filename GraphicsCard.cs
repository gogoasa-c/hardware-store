using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardware_store
{
    public class GraphicsCard : Component
    {
        private int videoMemory;
        private int bitrate;

        GraphicsCard(int videoMemory, int bitrate, string name, double price, int quantity, ComponentType type):base(name, price, quantity, type)
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
            string toReturn = videoMemory + " GB|" + bitrate + " biti|"; base.ToString();
            return toReturn;
        }
    }
}
