﻿using CClassLibrary.Data;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassLibrary.Repository
{
    public class NewsRepository
    {
        CDBHelper db = new CDBHelper();

        public int Add(List<News> list)
        {
            return 0;
        }

        public int Add(News item)
        {
            return 0;

        }

        public int Update(News item)
        {
            return 0;
        }


        public int Delete()
        {
            return 0;

        }



        public List<News> Select()
        {
            return new List<News>();
        }
    }
}
