using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;
using System.Data;

namespace BusinessLogicLayer.Manager
{
    public class NhanVien_PhongBanManager
    {
        private NhanVien_PhongBanReponsitories process;
        private PhongBanReponsitories PBprocess;

        public NhanVien_PhongBanManager()
        {
            process = new NhanVien_PhongBanReponsitories();
        }

        // LayDuLieuDSPB
        public DataTable LayDuLieuDSPhongBan(ref string error)
        {
            return process.LayDuLieuDSPhongBan(ref error);
        }
      

        // LayDuLieuDSNV theo Phòng ban

        public DataTable LayDuLieuDSNV_PB(string maPhongBan,ref string error)
        {
            return process.LayDuLieuDSNV_PB(maPhongBan,ref error);
        }
        //LayDuLieuDSNV 
        public DataTable LayDuLieuDSNV( ref string error)
        {
            return process.LayDuLieuDSNV( ref error);
        }
        // Xoa PhongBan
        public bool XoaPhongBan(string mabanggia, ref string error)
        {
            if (string.IsNullOrEmpty(mabanggia) == true)
            {
                error = "Ma Phong Ban chua co gia tri! khong the xoa";
                return false;
            }
            return process.XoaPhongBan(mabanggia, ref error);
        }
        // Them Phong Ban
        public bool ThemPhongBan(PhongBanEntity banggia, ref string error)
        {
            return process.ThemPhongBan(banggia, ref error);
        }
        // ThemNhanVien
        public bool ThemNhanVien(NhanVienEntity nhanvien, ref string error)
        {
            return process.ThemNhanVien(nhanvien, ref error);
        }

        // Xoa NhanVien
        public bool XoaNhanVien(string maNhanVien, ref string error)
        {
            if (string.IsNullOrEmpty(maNhanVien) == true)
            {
                error = "Ma Nhan Vien chua co gia tri! khong the xoa";
                return false;
            }
            return process.XoaNhanVien(maNhanVien, ref error);
        }
        // Xóa Nhân Viên ra khỏi phòng ban (Xuống chức)
        public bool XoaNhanVien_PB(string maPhongBan,string maNhanVien, ref string error)
        {
            if (string.IsNullOrEmpty(maNhanVien) == true)
            {
                error = "Ma bang gia chua co gia tri! khong the xoa";
                return false;
            }
            return process.XoaNhanVien_PB(maPhongBan,maNhanVien, ref error);
        }
    }
}
