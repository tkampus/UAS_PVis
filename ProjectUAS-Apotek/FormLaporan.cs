using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_Apotek
{
    public partial class FormLaporan : Form
    {
        //DataTable dtTransaksi;
        public FormLaporan()
        {
            InitializeComponent();
            dataGridViewLaporan.RowHeadersVisible = false;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); //dt(nama objek)
            dt = Transaksi.SelectAll();
            //dt = Transaksi.SelectAll(); //memilih semua data pada table DataBarang dan ditampung di objek dt
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewLaporan.DataSource = dt; //dt dijadikan sebagai DataSource, dt sebagai sumber datagridview
            //dataGridViewDataBarang.Columns["id_barang"].Visible = false; //masih eror, ketika menu data barang diklik form data barangnya malah tidak muncul
            dataGridViewLaporan.RowHeadersVisible = false;
            dataGridViewLaporan.Show(); //datagridview ditampilkan
        }

        private void buttonLihat_Click(object sender, EventArgs e)
        {
            //using (
                
        }
    }
}
