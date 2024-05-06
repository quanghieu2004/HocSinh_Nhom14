﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DanTocDAO
    {
        private static DanTocDAO instance;

        private DanTocDAO() { }

        public static DanTocDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanTocDAO();
                return instance;
            }
            private set => instance = value;
        }

        public object DataProvider { get; private set; }

        public DataTable LayDanhSachDanToc()
        {
            string query = "SELECT * FROM DANTOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatDanToc(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "DANTOC");
        }
    }
}
