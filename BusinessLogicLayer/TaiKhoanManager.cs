using DataAccessLayer.Responsitories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TaiKhoanManager
    {
        private TaiKhoanResponsitory Process = null;
        public TaiKhoanManager()
        {
            Process = new TaiKhoanResponsitory();
        }
        public bool XoaTaiKhoan(string tendangnhap,ref string ERROR)
        {
            if(string.IsNullOrEmpty(tendangnhap)==true)
            {
                ERROR = "Chua nhap ten muon xoa!";
                return false;
            }
            return Process.XoaTaiKhoan(tendangnhap,ref ERROR);
        }

        public DataTable HienThiDanhSachTaiKhoan(ref string ERROR)
        {
            return Process.HienThiDanhSachTaiKhoan(ref ERROR);
        }
    }
}
