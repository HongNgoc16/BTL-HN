using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucKhoaHoc : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public ucKhoaHoc()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgKhoaHoc.DataSource = db.chon_khoahoc();
        }

        private void ucKhoaHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaKhoaHoc.Clear();
            maskedTextBoxNamBatDau.Clear();
            maskedTextBoxNamKetThuc.Clear();
            radioButtonChuaTotNghiep.Checked = false;
            radioButtonDaTotNghiep.Checked = false;
            textMaKhoaHoc.Focus();
           
            opt = 1;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ MaskedTextBox và loại bỏ khoảng trắng thừa
            string namBatDauStr = maskedTextBoxNamBatDau.Text.Trim();
            string namKetThucStr = maskedTextBoxNamKetThuc.Text.Trim();

            // Kiểm tra nếu chưa nhập đủ 4 số
            if (namBatDauStr.Length != 4 || namKetThucStr.Length != 4)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ năm bắt đầu và năm kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi chuỗi thành số nguyên
            int namBatDau, namKetThuc;
            if (!int.TryParse(namBatDauStr, out namBatDau) || !int.TryParse(namKetThucStr, out namKetThuc))
            {
                MessageBox.Show("Năm nhập vào không hợp lệ! Hãy nhập số từ 1900 đến năm hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra phạm vi hợp lệ của năm bắt đầu và năm kết thúc
            int namHienTai = DateTime.Now.Year;
            if (namBatDau < 1900 || namBatDau > namHienTai)
            {
                MessageBox.Show("Năm bắt đầu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (namKetThuc <= namBatDau)
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy trạng thái (Đã tốt nghiệp / Chưa tốt nghiệp)
            bool trangThai = radioButtonDaTotNghiep.Checked;

            // Xử lý thêm hoặc sửa khóa học
            if (opt == 1) // Nếu là thêm mới
            {
                db.them_khoahoc(textMaKhoaHoc.Text, namBatDau, namKetThuc, trangThai);
                MessageBox.Show("Thêm khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Nếu là sửa
            {
                int id = Convert.ToInt32(dgKhoaHoc[0, dgKhoaHoc.CurrentRow.Index].Value);
                db.sua_khoahoc(id, textMaKhoaHoc.Text, namBatDau, namKetThuc, trangThai);
                MessageBox.Show("Sửa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset trạng thái
            opt = -1;
            HienThiDuLieu();

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
