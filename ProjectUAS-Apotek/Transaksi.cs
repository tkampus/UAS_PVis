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
    class Transaksi
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        static MySqlConnection conn;
        private MySqlCommand cmd;

        public String id_transaksi { get; set; }
        public DateTime waktu_transaksi { get; set; }
        public int total_belanja { get; set; }

        public Transaksi()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }
        public void insert()
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO transaksi(id_transaksi,waktu_transaksi,total_belanja) " +
                    "VALUES (@id_transaksi,@waktu_transaksi,@total_belanja)", conn))
            {
                cmd.Parameters.AddWithValue("@id_transaksi", this.id_transaksi);
                cmd.Parameters.AddWithValue("@waktu_transaksi", this.waktu_transaksi);
                cmd.Parameters.AddWithValue("@total_belanja", this.total_belanja);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static DataTable Select(String id_transaksi)
        {
            conn = new MySqlConnection(conString);
            MySqlCommand cmd;
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id_transaksi != "")
            {
                cmd.CommandText = "SELECT * FROM transaksi WHERE id_transaksi=@id_transaksi";
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

        public static DataTable SelectAll()//jadikan method static, mendapatkan data dari database dg format datatable
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable(); // pembuatan objek datatable sebagai tempat penampungan data
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM transaksi", conn)) //proses pembuatan sql commant, set objek conn utk menghubungkan ke database di localhost
            {
                try
                {
                    conn.Open(); //koneksi dibuka
                    MySqlDataReader rdr = cmd.ExecuteReader(); //Commandnya/perintah select dieksekusi
                    dt.Load(rdr); //datanya didapatkan dan disimpan dulu di objek reader (rdr), dari objek rdr dimasukkan lagi ke objek datatable (dt)
                    conn.Close(); //
                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
            }
            return dt;
        }

    }
}
