using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_CryptoMiningSystem
{
    public class User
    {
        private string name;
        private double money;
        private int stars;

        public User(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                name = value;
            }
        }
        public int Stars
        {
            get 
            {
                stars = (int)Money / 100;
                return stars; 
            }
            set
            {
                stars = value;
            }
        }
        public double Money
        {
            get { return money; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }
                money = value;
            }
        }
        public Computer Computer { get; set; }
        public decimal Profits { get; set; }
    }
}
