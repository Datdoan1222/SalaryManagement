using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
    public class NhanVien_PhongBanReponsitories
    {
        private Database DB = new Database();
        public DataTable LayDuLieuDSPhongBan(ref string error)
        {
            try
            {
                string sql = " select MaPhongBan, TenPhongBan from PhongBan";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public DataTable LayDuLieuDSNV(ref string error)
        {
            try
            {
                string sql = @"select MaNhanVien, HoTen, PhongBan.TenPhongBan from NhanVien
                                INNER JOIN PhongBan ON NhanVien.MaPhongBan = PhongBan.MaPhongBan";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public DataTable LayDuLieuDSNV_PB(string maPhongBan,ref string error)
        {
            try
            {
                string sql = string.Format(@"SELECT 
                                        SP.MaSanPham,
                                        SP.TenSanPham,
                                        BGT.DonGia,
                                        DVT.TenDVT
                                    FROM 
                                        BangGiaChiTiet AS BGT
                                    INNER JOIN 
                                        SanPham AS SP ON BGT.MaSanPham = SP.MaSanPham
                                    INNER JOIN 
                                        DonViTinh AS DVT ON SP.MaDVT = DVT.MaDVT
                                    WHERE 
                                        BGT.MaBangGia = '{0}';", maPhongBan);
                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        // xoa PhongBan
        public bool XoaPhongBan(string maphongban, ref string error)
        {
            try
            {
                string sql = " delete from PhongBan where MaBangGia like @MaPhongBan";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error,
                                        new SqlParameter("@MaPhongBan", maphongban));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
        // Them Phong Ban
        public bool ThemPhongBan(PhongBanEntity phongban, ref string error)
        {
            try
            {
                string sql = " ";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@TenBangGia", phongban.TenPhongBan)
                                       );
                return rs;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }// Them NhanVien
        public bool ThemNhanVien(NhanVienEntity nhanvien, ref string error)
        {
            try
            {
                string sql = " ";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@TenNhanVien", nhanvien.TenNhanVien)
                                       );
                return rs;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        // xoa Nhan Vien_PB theo phòng ban
        public bool XoaNhanVien_PB(string maphongban, string manhanvien, ref string error)
        {
            try
            {
                string sql = @" ";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error,
                                        new SqlParameter("@MaPhongBan", maphongban),
                                        new SqlParameter("@MaNhanVien", manhanvien));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
        // Xóa 1 nhân viên
        public bool XoaNhanVien( string manhanvien, ref string error)
        {
            try
            {
                string sql = " delete from NhanVien where MaNhanVien like @MaNhanVien";
        var rs = DB.ProcessData(sql, CommandType.Text, ref error,
                                new SqlParameter("@MaNhanVien", manhanvien));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
    }
}
