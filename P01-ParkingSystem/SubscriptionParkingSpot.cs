using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ParkingSystem
{
    public class SubscriptionParkingSpot : ParkingSpot
    {
        private string registrationPlate;

        public SubscriptionParkingSpot(int id, bool occupied, string registrationPlate, double price) : base(id, occupied, registrationPlate, price)
        {
        }
        public string RegistrationPlate
        {
            get { return registrationPlate; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException("Registration plate can’t be null or empty!");
                }
                registrationPlate = value;
            }
        }
    }
}
