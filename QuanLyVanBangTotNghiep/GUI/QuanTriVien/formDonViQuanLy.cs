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
    public partial class formDonViQuanLy : Form
    {
        public formDonViQuanLy()
        {
            InitializeComponent();
        }

        private void formDonViQuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dm_DonViQuanLy._dm_DonViQuanLy' table. You can move, or remove it, as needed.
            this.dm_DonViQuanLyTableAdapter.Fill(this.dm_DonViQuanLy._dm_DonViQuanLy);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
