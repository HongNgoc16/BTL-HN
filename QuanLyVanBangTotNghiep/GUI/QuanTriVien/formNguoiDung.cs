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
    public partial class formNguoiDung : Form
    {
        public formNguoiDung()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_NguoiDung._dm_NguoiDung' table. You can move, or remove it, as needed.
            this.dm_NguoiDungTableAdapter.Fill(this.dm_NguoiDung._dm_NguoiDung);

        }
    }
}
