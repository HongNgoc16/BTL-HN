using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVanBangTotNghiep
{
    public partial class formSinhVien : Form
    {
        public formSinhVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void formSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_SinhVien._dm_SinhVien' table. You can move, or remove it, as needed.
            this.dm_SinhVienTableAdapter.Fill(this.dm_SinhVien._dm_SinhVien);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
