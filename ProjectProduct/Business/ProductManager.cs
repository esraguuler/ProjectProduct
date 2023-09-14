using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager
    {

        Repository<Product> repoproduct = new Repository<Product>();

        public List<Product> GetAll()
        {
            return repoproduct.List();
        }

        public List<Product> GetByName(string p)
        {
            return repoproduct.List(x => x.ProductName == p);
        }

    }
}
