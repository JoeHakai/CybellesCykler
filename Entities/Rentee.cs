using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Rentee
    {
        private string name;
        private string address;
        private string phoneNumber;
        private DateTime registerDate;
        private int id;

        public Rentee(string name, string address, string phoneNumber, DateTime registerDate, int id)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.registerDate = registerDate;
            this.id = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
