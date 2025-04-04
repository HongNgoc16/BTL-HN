using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL.BLL;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucNguoiDung : UserControl
    {
        private dm_NguoiDung_BLL bll = new dm_NguoiDung_BLL();
        int opt = -1;
        public ucNguoiDung()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgNguoiDung.DataSource= bll.GetChon_Nguoidung_Results();
        }
        private void ucNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cboBoxLoaiND.Items.Clear();
            cboBoxLoaiND.Items.AddRange(new string[] { "qtv", "bpql", "bpd" });
            cboBoxLoaiND.SelectedIndex = 0;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaND .Clear();
            textTenDangNhap.Clear();
            textMatKhau.Clear   ();
            cboBoxLoaiND.SelectedIndex = -1;
            textMaND.Focus();
            opt = 1;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (cboBoxLoaiND.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại người dùng!");
                return;
            }
           if (opt == 1)
            {
                bll.ThemNguoiDung(textMaND.Text, textTenDangNhap.Text, textMatKhau.Text, cboBoxLoaiND.SelectedItem.ToString());
                HienThiDuLieu();
                MessageBox.Show("Thêm người dùng thành công!");
            }
        }
    }
}
