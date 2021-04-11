using DIP.Model;
using System.Configuration;

namespace DIP.Factory
{
    class DbProductFactory
    {

        public static DbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
      
    }
}
