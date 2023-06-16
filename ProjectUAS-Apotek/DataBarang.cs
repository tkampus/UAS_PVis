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
    class DataBarang : Connection
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        static MySqlConnection conn; //mengimport
        static MySqlCommand cmd;

        public int id_barang { get; set; }
        public String nama_barang { get; set; }
        public String perusahaan { get; set; }
        public int harga_beli { get; set; }
        public int harga_jual { get; set; }
        public int stock { get; set; }
        public String exp { get; set; }

        public DataBarang() //di dalam konstruktor ada dua objek yaitu conn dan cmd
        {
            conn = new MySqlConnection(conString); //menghubungkan ke db localhost
            cmd = new MySqlCommand(); //utk menuliskan perintah sql (delete, insert, dll)
        }

        public static DataTable SelectAll()//jadikan method static, mendapatkan data dari database dg format datatable
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable(); // pembuatan objek datatable sebagai tempat penampungan data
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM databarang", conn)) //proses pembuatan sql commant, set objek conn utk menghubungkan ke database di localhost
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
        public static DataTable SelectNamaHarga()
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT nama_barang AS nama, harga_jual AS harga FROM databarang", conn))
            {
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
            }
            return dt;
        }

        public string insert()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO databarang (nama_barang,perusahaan,harga_beli,harga_jual,stock,exp) " +
                "VALUES (@nama_barang,@perusahaan,@harga_beli,@harga_jual,@stock,@exp)", conn))
            {
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                cmd.Parameters.AddWithValue("@nama_barang", this.nama_barang);
                cmd.Parameters.AddWithValue("@perusahaan", this.perusahaan);
                cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
                cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
                cmd.Parameters.AddWithValue("@stock", this.stock);
                cmd.Parameters.AddWithValue("@exp", this.exp);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public string Update()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("UPDATE databarang SET nama_barang=@nama_barang," + 
                "perusahaan=@perusahaan,harga_beli=@harga_beli,harga_jual=@harga_jual,stock=@stock,exp=@exp WHERE id_barang=@id_barang", conn))
            {
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                cmd.Parameters.AddWithValue("@nama_barang", this.nama_barang);
                cmd.Parameters.AddWithValue("@perusahaan", this.perusahaan);
                cmd.Parameters.AddWithValue("@harga_beli", this.harga_beli);
                cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
                cmd.Parameters.AddWithValue("@stock", this.stock);
                cmd.Parameters.AddWithValue("@exp", this.exp);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public string Delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM databarang WHERE id_barang=@id_barang ", conn))
            {
                cmd.Parameters.AddWithValue("@id_barang", this.id_barang);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public static DataTable Select(String nama_barang)
        {
            DataTable dt = new DataTable();
            conn = new MySqlConnection(conString);
            cmd = conn.CreateCommand();
            if (nama_barang != "")
            {
                cmd.CommandText = "SELECT * FROM databarang WHERE nama_barang like @nama_barang";
                cmd.Parameters.AddWithValue("@nama_barang" , "%" + nama_barang + "%");
            }
            else cmd.CommandText = "SELECT * FROM databarang";
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                String s = cmd.CommandText;
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
