using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using QuanLyVanBangTotNghiep.BLL;
using System.Net.Http.Headers;
namespace QuanLyVanBangTotNghiep.GUI
{
    public partial class DangNhap : Form
    {
        private NguoiDung_BLL nguoiDung_BLL = new NguoiDung_BLL();
        public DangNhap()
        {
            InitializeComponent();
        }

       
        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textMatKhau.UseSystemPasswordChar = !checkHienThiMK.Checked;

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = textTenDangNhap.Text.Trim();
            string matKhau = textMatKhau.Text.Trim();

            string loaiNguoiDung = nguoiDung_BLL.KiemTra(tenDangNhap, matKhau);
            if (loaiNguoiDung == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            if (loaiNguoiDung == "qtv")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                new QuanTriVien().ShowDialog();
            }
            else if (loaiNguoiDung == "bpql")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                new BoPhanQuanLy().ShowDialog();
            }
            else if (loaiNguoiDung == "bpd")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                new BoPhanDuyet().ShowDialog();
            }
            this.Show();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
