using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DataController
    {
        private DbHandler Handler;

        public DataController(string connectionString)
        {
            this.connectionString = Handler.connectionString;
        }

        public GetEntities(string entity)
        {
            
        }
    }
}
