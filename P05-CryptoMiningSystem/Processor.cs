using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_CryptoMiningSystem
{
    public class Processor: Components
    {
        public Processor(string model, double price, int generation, int mineMultiplier) : base(model, price, generation, generation * 100)
        {
           MineMultiplier = mineMultiplier;
        }
        public int MineMultiplier { get; set; }
        public override int Generation
        {
            get { return base.Generation; }
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"{this.GetType().Name} generation cannot be more than 9!");
                }
                base.Generation = value;
            }
        }
        public void LowPerformanceProcessor(string model, double price, int generation)
        {
            MineMultiplier = 2;
        }
        public void HighPerformanceProcessor(string model, double price, int generation)
        {
            MineMultiplier = 8;
        }
    }
}
