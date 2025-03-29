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
    public partial class formKhoaHoc : Form
    {
        public formKhoaHoc()
        {
            InitializeComponent();
        }

        private void formKhoaHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_KhoaHoc._dm_KhoaHoc' table. You can move, or remove it, as needed.
            this.dm_KhoaHocTableAdapter.Fill(this.dm_KhoaHoc._dm_KhoaHoc);

        }
    }
}
