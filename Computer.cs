﻿using System;

namespace hardware_store
{
    [Serializable]
    class Computer
    {
        private Processor processor;
        private GraphicsCard graphicsCard;
        private RamMemory ramMemory;
        private HardDrive hardDrive;
        public Computer(Processor processor, GraphicsCard graphicsCard, RamMemory ramMemory, HardDrive hardDrive)
        {
            this.processor = processor;
            this.graphicsCard = graphicsCard;
            this.ramMemory = ramMemory;
            this.hardDrive = hardDrive;
        }
        public Processor Processor
        {
            get => this.processor;
            set => this.processor = value;
        }
        public GraphicsCard GraphicsCard
        {
            get => this.graphicsCard;
            set => this.graphicsCard = value;
        }
        public RamMemory RamMemory
        {
            get => this.ramMemory;
            set => this.ramMemory = value;
        }
        public HardDrive HardDrive
        {
            get => this.hardDrive;
            set => this.hardDrive = value;
        }
        public override string ToString()
        {
            string toReturn = processor.ToString() + " " + graphicsCard.ToString() + " " + ramMemory.ToString() + " " + hardDrive.ToString();
            return toReturn;
        }

        public double getPrice()
        {
            return this.RamMemory.Price + this.HardDrive.Price + this.Processor.Price + this.GraphicsCard.Price;
        }

    }
}
