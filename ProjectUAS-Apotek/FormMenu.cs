using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_Apotek
{
    public partial class FormMenu : Form
    {
        //User user;
        //protected String conString = ConfigurationManager.ConnectionStrings["dbcashier"].ConnectionString;
        //MySqlConnection conn;
        //MySqlCommand cmd;
        public FormMenu()
        {
            InitializeComponent();
            //conn = new MySqlConnection(conString);
            //cmd = new MySqlCommand();
        }
        public void container(object _form, String text)
        {
            panelKonten.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.AutoScroll = true;
            panelKonten.Controls.Add(fm);
            panelKonten.Tag = fm;
            fm.Show();
            lblActiveMenu.Text = text;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            container(new FormHome(), "Home");
        }

        private void tbldaftar_Click(object sender, EventArgs e)
        {
            container(new FormDataBarang(), "Data Barang");
        }

        private void tbltransaksi_Click(object sender, EventArgs e)
        {
            container(new FormTransaksi(), "Transaksi");
        }

        private void tbllaporan_Click(object sender, EventArgs e)
        {
            container(new FormLaporan(), "Laporan");
        }

        private void btlout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
