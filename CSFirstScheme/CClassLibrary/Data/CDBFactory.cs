using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassLibrary.Data
{
    public class CDBFactory
    {
        public static string ExcelConnString = ConfigurationManager.ConnectionStrings["ExcelConnection"].ToString();

       
    }
}
