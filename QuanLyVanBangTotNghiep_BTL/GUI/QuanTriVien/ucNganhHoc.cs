using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucNganhHoc : UserControl
    {
        int opt = -1;
        QuanLyVanBangTotNghiepEntities db = new QuanLyVanBangTotNghiepEntities();
        public ucNganhHoc()
        {
            InitializeComponent();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaNganh.Clear();
            textTenNganh.Clear();
            textMaNganh.Focus();
            opt= 1;    
        }
        public void HienThiDuLieu()
        {
            dgNganhHoc.DataSource = db.chon_nganhhoc();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucNganhHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
