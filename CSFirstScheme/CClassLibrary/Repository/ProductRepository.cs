using CClassLibrary.Data;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassLibrary.Repository
{
    public class ProductRepository
    {
        CDBHelper db = new CDBHelper();

        public int Add(List<Product> list)
        {
            return 0;
        }

        public int Add(Product item)
        {
            return 0;

        }

        public int Update(Product item)
        {
            return 0;
        }


        public int Delete()
        {
            return 0;

        }



        public List<Product> Select()
        {
            return new List<Product>();
        }
    }
}
