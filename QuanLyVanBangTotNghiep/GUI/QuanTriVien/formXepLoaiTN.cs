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
    public partial class formXepLoaiTN : Form
    {
        public formXepLoaiTN()
        {
            InitializeComponent();
        }

        private void formXepLoaiTN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_XepLoai._dm_XepLoai' table. You can move, or remove it, as needed.
            this.dm_XepLoaiTableAdapter.Fill(this.dm_XepLoai._dm_XepLoai);

        }
    }
}
