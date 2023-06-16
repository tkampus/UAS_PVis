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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = textBoxUsername.Text;
            user.password = textBoxPassword.Text;
            if (user.validasi())
            {
                FormMenu frmMenu = new FormMenu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User gagal login");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
