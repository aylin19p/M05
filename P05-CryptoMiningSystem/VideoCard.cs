using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_CryptoMiningSystem
{
    public class VideoCard: Components
    {
        private int ram;
        public VideoCard(string model, double price, int generation, int ram) : base(model, price, generation, ram * generation * 10)
        {
           Ram = ram;
        }
        public int Ram
        {
            get { return ram; }
            private set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException($"{GetType().Name} ram cannot less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }
        public virtual int MinedMoneyPerHour
        {
            get
            {
                return Ram * Generation / 10;
            }
        }
    }
}
