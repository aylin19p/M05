﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ParkingSystem
{
    public class BusParkingSpot : ParkingSpot
    {
        public BusParkingSpot(int id, bool occupied, double price) : base(id, occupied, "bus", price)
        {
        }
    }
}
