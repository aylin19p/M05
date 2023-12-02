using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ParkingSystem
{
    public class ParkingSpot
    {
        private double price;
        private List<ParkingInterval> parkingIntervals;

        public ParkingSpot(int id, bool occupied, string type, double price)
        {
            Id = id;
            Occupied = occupied;
            Type = type;
            Price = price;
            parkingIntervals = new List<ParkingInterval>();
        }

        public int Id { get; set; }
        public bool Occupied { get; set; }
        public string Type { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Parking price cannot be less or equal to 0!");
                }
                price = value;
            }
        }
        public IReadOnlyList<ParkingInterval> ParkingIntervals
        {
            get { return parkingIntervals; }
        }

        public void AddInterval(ParkingInterval interval)
        {
           parkingIntervals.Add(interval);
        }

        public override string ToString()
        {
            return $"> Parking Spot {Id} {Environment.NewLine}> Occupied: {Occupied} {Environment.NewLine}> Type: {Type}{Environment.NewLine}> Price per hour: {Price} BGN";
        }
    }
}
