using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bike
    {
        private decimal pricePerDay;
        private string bikeDescription;
        private BikeKind kind;
        private int id;

        public Bike(decimal pricePerDay, string bikeDescription, BikeKind kind, int id)
        {
            this.pricePerDay = pricePerDay;
            this.bikeDescription = bikeDescription;
            this.kind = kind;
            this.id = id;
        }
    }
}
