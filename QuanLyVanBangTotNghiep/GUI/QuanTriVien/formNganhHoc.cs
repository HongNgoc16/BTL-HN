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
    public partial class formNganhHoc : Form
    {
        public formNganhHoc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formNganhHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_NganhHoc._dm_NganhHoc' table. You can move, or remove it, as needed.
            this.dm_NganhHocTableAdapter.Fill(this.dm_NganhHoc._dm_NganhHoc);
            // TODO: This line of code loads data into the 'dm_NganhHoc._dm_NganhHoc' table. You can move, or remove it, as needed.
            this.dm_NganhHocTableAdapter.Fill(this.dm_NganhHoc._dm_NganhHoc);

        }
    }
}
