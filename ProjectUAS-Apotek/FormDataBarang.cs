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
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            loadDataBarang();
        }

        private void loadDataBarang()
        {
            DataTable dt = new DataTable(); //dt(nama objek)
            dt = DataBarang.SelectAll(); //memilih semua data pada table DataBarang dan ditampung di objek dt
            //dataGridViewPengguna.AutoGenerateColumns = false;
            dataGridViewDataBarang.DataSource = dt; //dt dijadikan sebagai DataSource, dt sebagai sumber datagridview
            //dataGridViewDataBarang.Columns["id_barang"].Visible = false; //masih eror, ketika menu data barang diklik form data barangnya malah tidak muncul
            dataGridViewDataBarang.RowHeadersVisible = false;
            dataGridViewDataBarang.Show(); //datagridview ditampilkan
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            loadDataBarang();
        }

        private void dataGridViewDataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBarang databarang = new DataBarang();
            int selectedrowindex = dataGridViewDataBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDataBarang.Rows[selectedrowindex];
            textBoxIdBarang.Text = Convert.ToString(selectedRow.Cells["id_barang"].Value);
            textBoxNamaBarang.Text = Convert.ToString(selectedRow.Cells["nama_barang"].Value);
            textBoxPerusahaan.Text = Convert.ToString(selectedRow.Cells["perusahaan"].Value);
            textBoxHargaBeli.Text = Convert.ToString(selectedRow.Cells["harga_beli"].Value);
            textBoxHargaJual.Text = Convert.ToString(selectedRow.Cells["harga_jual"].Value);
            textBoxStock.Text = Convert.ToString(selectedRow.Cells["stock"].Value);
            dateTimePickerExp.Value = Convert.ToDateTime(selectedRow.Cells["exp"].Value);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            DataBarang databarang = new DataBarang();
            databarang.nama_barang = textBoxNamaBarang.Text;
            databarang.perusahaan = textBoxPerusahaan.Text;
            databarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
            databarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
            databarang.stock = Convert.ToInt32(textBoxStock.Text);
            //databarang.exp = dateTimePickerExp.Value.ToString("yyyyMMdd");
            databarang.exp = Convert.ToDateTime(dateTimePickerExp.Value).ToString("yyyy-MM-dd");

            String response = databarang.insert();
            if (response == null)
            {
                MessageBox.Show("Tambah barang berhasil");
                textBoxNamaBarang.Text = "";
                textBoxPerusahaan.Text = "";
                textBoxHargaBeli.Text = "";
                textBoxHargaJual.Text = "";
                textBoxStock.Text = "";
                dateTimePickerExp.Text = "";
            }
            else
            {
                MessageBox.Show("Tambah barang gagal. Error: " + response);
            }
            loadDataBarang();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            DataBarang databarang = new DataBarang();
            DataTable dt = new DataTable();
            dt = DataBarang.Select(textBoxCari.Text);
            dataGridViewDataBarang.AutoGenerateColumns = false;
            dataGridViewDataBarang.DataSource = dt;
            dataGridViewDataBarang.Columns["id_barang"].Visible = true;
            dataGridViewDataBarang.RowHeadersVisible = false;
            dataGridViewDataBarang.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            DataBarang databarang = new DataBarang(); 
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            databarang.nama_barang = textBoxNamaBarang.Text;
            DialogResult result = MessageBox.Show("Yakin ubah data barang " + databarang.nama_barang + " ?", "Ubah Data Barang", buttons);
            if (result == DialogResult.Yes)
            {
                databarang.id_barang = Convert.ToInt32(textBoxIdBarang.Text);
                databarang.nama_barang = textBoxNamaBarang.Text;
                databarang.perusahaan = textBoxPerusahaan.Text;
                databarang.harga_beli = Convert.ToInt32(textBoxHargaBeli.Text);
                databarang.harga_jual = Convert.ToInt32(textBoxHargaJual.Text);
                databarang.stock = Convert.ToInt32(textBoxStock.Text);
                databarang.exp = dateTimePickerExp.Value.ToString("yyyy-MM-dd");
                String response = databarang.Update();
                if (response == null)
                {
                    MessageBox.Show("Ubah data barang berhasil");
                    textBoxNamaBarang.Text = "";
                    textBoxPerusahaan.Text = "";
                    textBoxHargaBeli.Text = "";
                    textBoxHargaJual.Text = "";
                    textBoxStock.Text = "";
                    dateTimePickerExp.Text = "";
                }
                else
                {
                    MessageBox.Show("Ubah data barang gagal. Error: " + response);
                }
                loadDataBarang();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DataBarang databarang = new DataBarang();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            databarang.nama_barang = textBoxNamaBarang.Text;
            String id = textBoxIdBarang.Text;
                if (id != null) 
                    {
                        databarang.id_barang = 1*Convert.ToInt32(id);
                    }
                else { databarang.id_barang = 1; }
            databarang.id_barang = Convert.ToInt32(textBoxIdBarang.Text);
            DialogResult result = MessageBox.Show("Yakin hapus data barang " + databarang.nama_barang + databarang.id_barang + " ?", "Hapus Data Barang", buttons);
            //String response = databarang.Update();
            if (result == DialogResult.Yes)
            {
                string response;
                
                response = databarang.Delete();
                if (response == null) MessageBox.Show("Sukses");
                else MessageBox.Show(response);
                textBoxNamaBarang.Text = "";
                textBoxPerusahaan.Text = "";
                textBoxHargaBeli.Text = "";
                textBoxHargaJual.Text = "";
                textBoxStock.Text = "";
                dateTimePickerExp.Text = "";
                loadDataBarang();
            }

            else
            {
                //MessageBox.Show("Hapus data barang gagal. Error: " + response);
            }
            
        }

        private void textBoxIdBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDataBarang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBarang databarang = new DataBarang();
            int selectedrowindex = dataGridViewDataBarang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDataBarang.Rows[selectedrowindex];
            textBoxIdBarang.Text = Convert.ToString(selectedRow.Cells["id_barang"].Value);
            textBoxNamaBarang.Text = Convert.ToString(selectedRow.Cells["nama_barang"].Value);
            textBoxPerusahaan.Text = Convert.ToString(selectedRow.Cells["perusahaan"].Value);
            textBoxHargaBeli.Text = Convert.ToString(selectedRow.Cells["harga_beli"].Value);
            textBoxHargaJual.Text = Convert.ToString(selectedRow.Cells["harga_jual"].Value);
            textBoxStock.Text = Convert.ToString(selectedRow.Cells["stock"].Value);
            dateTimePickerExp.Value = Convert.ToDateTime(selectedRow.Cells["exp"].Value);
        }
    }
}
