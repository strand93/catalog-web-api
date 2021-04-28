using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogWebApi.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string LocalConnectionString { get
            {
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
            } 
        }

        public string CloudConnectionString { get
            {
                return $"mongodb+srv://{User}:{Password}@alexdevelopment.3pekc.mongodb.net/Catalog?retryWrites=true&w=majority";
            } 
        }
    }
}
