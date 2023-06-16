using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUAS_Apotek
{
    class User : Connection //class user mewarisi class connection supaya bisa mengakses atribut conString
    {
        protected String conString = ConfigurationManager.ConnectionStrings["dbapotek"].ConnectionString;
        static MySqlConnection conn; //mengimport
        static MySqlCommand cmd;

        public int id_user { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public User() //di dalam konstruktor ada dua objek yaitu conn dan cmd
        {
            conn = new MySqlConnection(conString); //menghubungkan ke db localhost
            cmd = new MySqlCommand(); //utk menuliskan perintah sql (delete, insert, dll)
        }

        public bool validasi()
        {
            bool result = false;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username=@username AND password=md5(@password)";
            cmd.Parameters.AddWithValue("@username", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    //user = new User(Convert.ToInt16(rdr["id_user"]), rdr["username"].ToString(), rdr["password"].ToString());
                    id_user = Convert.ToInt16(rdr["id_user"]);
                    result = true;
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return result;
        }
    }
}
