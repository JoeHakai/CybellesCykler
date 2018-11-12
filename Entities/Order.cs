﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        private Bike bike;
        private Rentee rentee;
        private DateTime rentDate;
        private DateTime deliveryDate;
        private int id;

        public Order(Bike bike, Rentee rentee, DateTime rentDate, DateTime deliveryDate, int id)
        {
            this.bike = bike;
            this.rentee = rentee;
            this.rentDate = rentDate;
            this.deliveryDate = deliveryDate;
            this.id = id;
        }

        public override Decimal GetPrice()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
