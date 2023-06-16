using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUAS_Apotek
{
    class Laporan
    {
        //protected static String conString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        //static MySqlConnection conn;
        //private MySqlCommand cmd;

        public String id_laporan { get; set; }
        public String id_transaksi { get; set; }
        public DateTime waktu_transaksi { get; set; }
        public int total_belanja { get; set; }
    }
}
