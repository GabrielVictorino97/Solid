using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Model
{
    class SQLServerProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"SqlServer: Exibindo dados do produto {id}";
        }
    }
}
