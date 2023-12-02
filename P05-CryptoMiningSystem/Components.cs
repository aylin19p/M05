using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_CryptoMiningSystem
{
    public class Components
    {
        private string model;
        private double price;
        private int generation;

        protected Components(string model, double price, int generation, int lifeWorkingHours)
        {
            Model = model;
            Price = price;
            Generation = generation;
            LifeWorkingHours = lifeWorkingHours;
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                model = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price<=0 || price > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }
                price = value;
            }
        }
        public virtual int Generation
        {
            get { return generation; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                generation = value;
            }
        }
        public int LifeWorkingHours { get; set; }
    }
}
