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
    public partial class formChuyenNganh : Form
    {
        public formChuyenNganh()
        {
            InitializeComponent();
        }

        private void formChuyenNganh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_ChuyenNganh._dm_ChuyenNganh' table. You can move, or remove it, as needed.
            this.dm_ChuyenNganhTableAdapter.Fill(this.dm_ChuyenNganh._dm_ChuyenNganh);

        }
    }
}
