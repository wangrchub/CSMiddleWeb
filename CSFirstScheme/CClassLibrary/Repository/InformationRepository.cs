using CClassLibrary.Data;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassLibrary.Repository
{
    public class InformationRepository
    {
        CDBHelper db = new CDBHelper();

        public int Add(List<Information> list)
        { 
        return 0;
        }

        public int Add(Information item)
        {
            return 0;

        }

        public int Update(Information item)
        {
            return 0;
        }


        public int Delete()
        {
            return 0;

        }



        public List<Information> Select()
        {
            List<Information> list = new List<Information>();

            return list;
        }
    }
}
