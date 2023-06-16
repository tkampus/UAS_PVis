
namespace ProjectUAS_Apotek
{
    partial class FormLaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLaporan = new System.Windows.Forms.Label();
            this.dateTimePickerTanggaldari = new System.Windows.Forms.DateTimePicker();
            this.labelTanggaldari = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalsampai = new System.Windows.Forms.DateTimePicker();
            this.labelTanggalsampai = new System.Windows.Forms.Label();
            this.labelTotalPendapatan = new System.Windows.Forms.Label();
            this.textBoxTotalPendapatan = new System.Windows.Forms.TextBox();
            this.dataGridViewLaporan = new System.Windows.Forms.DataGridView();
            this.buttonLihat = new System.Windows.Forms.Button();
            this.id_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_belanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLaporan
            // 
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.BackColor = System.Drawing.Color.Transparent;
            this.labelLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(508, 9);
            this.labelLaporan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(149, 39);
            this.labelLaporan.TabIndex = 21;
            this.labelLaporan.Text = "Laporan";
            // 
            // dateTimePickerTanggaldari
            // 
            this.dateTimePickerTanggaldari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTanggaldari.Location = new System.Drawing.Point(232, 100);
            this.dateTimePickerTanggaldari.Name = "dateTimePickerTanggaldari";
            this.dateTimePickerTanggaldari.Size = new System.Drawing.Size(124, 22);
            this.dateTimePickerTanggaldari.TabIndex = 37;
            // 
            // labelTanggaldari
            // 
            this.labelTanggaldari.AutoSize = true;
            this.labelTanggaldari.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggaldari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggaldari.Location = new System.Drawing.Point(116, 105);
            this.labelTanggaldari.Name = "labelTanggaldari";
            this.labelTanggaldari.Size = new System.Drawing.Size(104, 16);
            this.labelTanggaldari.TabIndex = 36;
            this.labelTanggaldari.Text = "Tanggal : dari";
            // 
            // dateTimePickerTanggalsampai
            // 
            this.dateTimePickerTanggalsampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTanggalsampai.Location = new System.Drawing.Point(427, 100);
            this.dateTimePickerTanggalsampai.Name = "dateTimePickerTanggalsampai";
            this.dateTimePickerTanggalsampai.Size = new System.Drawing.Size(119, 22);
            this.dateTimePickerTanggalsampai.TabIndex = 38;
            // 
            // labelTanggalsampai
            // 
            this.labelTanggalsampai.AutoSize = true;
            this.labelTanggalsampai.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggalsampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalsampai.Location = new System.Drawing.Point(362, 105);
            this.labelTanggalsampai.Name = "labelTanggalsampai";
            this.labelTanggalsampai.Size = new System.Drawing.Size(58, 16);
            this.labelTanggalsampai.TabIndex = 39;
            this.labelTanggalsampai.Text = "sampai";
            // 
            // labelTotalPendapatan
            // 
            this.labelTotalPendapatan.AutoSize = true;
            this.labelTotalPendapatan.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPendapatan.Location = new System.Drawing.Point(727, 145);
            this.labelTotalPendapatan.Name = "labelTotalPendapatan";
            this.labelTotalPendapatan.Size = new System.Drawing.Size(139, 16);
            this.labelTotalPendapatan.TabIndex = 40;
            this.labelTotalPendapatan.Text = "Total Pendapatan :";
            this.labelTotalPendapatan.Visible = false;
            // 
            // textBoxTotalPendapatan
            // 
            this.textBoxTotalPendapatan.Location = new System.Drawing.Point(898, 142);
            this.textBoxTotalPendapatan.Name = "textBoxTotalPendapatan";
            this.textBoxTotalPendapatan.Size = new System.Drawing.Size(163, 22);
            this.textBoxTotalPendapatan.TabIndex = 41;
            this.textBoxTotalPendapatan.Visible = false;
            // 
            // dataGridViewLaporan
            // 
            this.dataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_transaksi,
            this.waktu_transaksi,
            this.total_belanja});
            this.dataGridViewLaporan.Location = new System.Drawing.Point(118, 181);
            this.dataGridViewLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLaporan.Name = "dataGridViewLaporan";
            this.dataGridViewLaporan.RowHeadersWidth = 51;
            this.dataGridViewLaporan.Size = new System.Drawing.Size(943, 297);
            this.dataGridViewLaporan.TabIndex = 42;
            // 
            // buttonLihat
            // 
            this.buttonLihat.Location = new System.Drawing.Point(562, 99);
            this.buttonLihat.Name = "buttonLihat";
            this.buttonLihat.Size = new System.Drawing.Size(75, 23);
            this.buttonLihat.TabIndex = 44;
            this.buttonLihat.Text = "Lihat";
            this.buttonLihat.UseVisualStyleBackColor = true;
            this.buttonLihat.Click += new System.EventHandler(this.buttonLihat_Click);
            // 
            // id_transaksi
            // 
            this.id_transaksi.DataPropertyName = "id_transaksi";
            this.id_transaksi.HeaderText = "ID Transaksi";
            this.id_transaksi.MinimumWidth = 6;
            this.id_transaksi.Name = "id_transaksi";
            this.id_transaksi.Width = 300;
            // 
            // waktu_transaksi
            // 
            this.waktu_transaksi.DataPropertyName = "waktu_transaksi";
            this.waktu_transaksi.HeaderText = "Waktu Transaksi";
            this.waktu_transaksi.MinimumWidth = 6;
            this.waktu_transaksi.Name = "waktu_transaksi";
            this.waktu_transaksi.Width = 200;
            // 
            // total_belanja
            // 
            this.total_belanja.DataPropertyName = "total_belanja";
            this.total_belanja.HeaderText = "Total Belanja";
            this.total_belanja.MinimumWidth = 6;
            this.total_belanja.Name = "total_belanja";
            this.total_belanja.Width = 200;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1179, 590);
            this.Controls.Add(this.buttonLihat);
            this.Controls.Add(this.dataGridViewLaporan);
            this.Controls.Add(this.textBoxTotalPendapatan);
            this.Controls.Add(this.labelTotalPendapatan);
            this.Controls.Add(this.labelTanggalsampai);
            this.Controls.Add(this.dateTimePickerTanggalsampai);
            this.Controls.Add(this.dateTimePickerTanggaldari);
            this.Controls.Add(this.labelTanggaldari);
            this.Controls.Add(this.labelLaporan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLaporan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggaldari;
        private System.Windows.Forms.Label labelTanggaldari;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalsampai;
        private System.Windows.Forms.Label labelTanggalsampai;
        private System.Windows.Forms.Label labelTotalPendapatan;
        private System.Windows.Forms.TextBox textBoxTotalPendapatan;
        private System.Windows.Forms.DataGridView dataGridViewLaporan;
        private System.Windows.Forms.Button buttonLihat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_belanja;
    }
}