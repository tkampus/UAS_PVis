using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUAS_Apotek
{
    class Detail_Transaksi
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        static MySqlConnection conn;
        private MySqlCommand cmd;

        public int id_detail { set; get; }
        public String id_transaksi { set; get; }
        public int id_barang { set; get; }
        public int jumlah_item { set; get; }
        public int harga_jual { set; get; }
        public int subtotal { set; get; }
        public int total_belanja { set; get; }

        public Detail_Transaksi()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public void insert()
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO detail_transaksi(id_transaksi,id_barang,jumlah_item,harga_jual,subtotal) " +
                        "VALUES (@id_transaksi,@id_barang,@jumlah_item,@harga_jual,@subtotal)", conn))
            {
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
                cmd.Parameters.AddWithValue("@id_barang", id_barang);
                cmd.Parameters.AddWithValue("@jumlah_item", jumlah_item);
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable SelectDetail(String id_transaksi)
        {
            conn = new MySqlConnection(conString);
            MySqlCommand cmd;
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id_transaksi != "")
            {
                cmd.CommandText = "SELECT a.id_transaksi,a.jumlah_item,a.harga_jual,a.subtotal,b.nama_barang " +
                    "FROM detail_transaksi a JOIN databarang b ON a.id_barang=b.id_barang WHERE a.id_transaksi=@id_transaksi";
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
        }
    }
}
