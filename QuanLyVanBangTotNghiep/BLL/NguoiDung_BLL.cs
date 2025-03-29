using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep.DAL;
namespace QuanLyVanBangTotNghiep.BLL
{
    public class NguoiDung_BLL
    {
        private NguoiDung_DAL nguoiDung_DAL=new NguoiDung_DAL();    
        public string KiemTra (string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                return null;
            }
            return nguoiDung_DAL.DangNhap(tenDangNhap, matKhau);
        }

    }
}
