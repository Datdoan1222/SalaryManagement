using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
    public class TinhLuongReponsitories
    {
        private Database DB = new Database();
        public DataTable LayDuLieuDSLuong(TinhLuongEntity Entity, ref string error)
        {
            
            try
            {
                string sql = @"
                                        SELECT 
                                                L.MaNhanVien,
                                                NV.TenNhanVien,
                                                CV.TenChucVu,
                                                L.Thang,
                                                L.TongKhauTru,
                                                L.TongTroCap,
                                                L.TongLuong
                                            FROM 
                                                Luong L
                                            INNER JOIN 
                                                NhanVien NV ON L.MaNhanVien = NV.MaNhanVien
                                            INNER JOIN 
                                                ChucVu CV ON L.MaChucVu = CV.MaChucVu
                                            INNER JOIN 
                                                LuongCoBan LC ON L.MaLuongCoBan = LC.MaLuongCoBan
                                            Where NV.MaNhanVien = @MaNhanVien;

                                ";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                                                new SqlParameter("@Thang", Entity.Thang)
                                                                                );
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        
            public bool ktraLuongThangNV(TinhLuongEntity Entity, ref string error)
        {
            string sql = @"

                                                       SELECT TOP 1 1 FROM Luong WHERE Luong.Thang = @Thang;
                    ";


            try
            {

                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                                                new SqlParameter("@Thang", Entity.Thang));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
        public bool ktraLuongNV(TinhLuongEntity Entity, ref string error)
        {
            string sql = @"

                                                       SELECT TOP 1 1 FROM Luong WHERE Luong.MaNhanVien = @MaNhanVien;
                    ";

            
            try
            {

                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                                                new SqlParameter("@Thang", Entity.Thang));
                return rs;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
        }
        public bool TinhLuong(TinhLuongEntity Entity, ref string error)
        {
            string sql = @"


                                                        DECLARE @TongLuong DECIMAL(18, 2);
                                                        DECLARE @TongKhauTru DECIMAL(18, 2);
                                                        DECLARE @TongTroCap DECIMAL(18, 2);
                                                        DECLARE @LuongCoBan DECIMAL(18, 2);
                                                        DECLARE @HeSoLuong DECIMAL(18, 2);
                                                        DECLARE @MaChucVu INT;
                                                        DECLARE @MaLuongCoBan INT;

                                                        -- Tính toán trợ cấp và khấu trừ
                                                        SELECT 
                                                            @TongTroCap = ISNULL(SUM(TC.SoTien), 0)
                                                        FROM 
                                                            TroCap TC
                                                        WHERE 
                                                            TC.MaNhanVien = @MaNhanVien
                                                        AND 
                                                            MONTH(TC.NgayCap) = @Thang;

                                                        SELECT 
                                                            @TongKhauTru = ISNULL(SUM(KT.SoTien), 0)
                                                        FROM 
                                                            KhauTru KT
                                                        WHERE 
                                                            KT.MaNhanVien = @MaNhanVien
                                                        AND 
                                                            MONTH(KT.NgayKhauTru) = @Thang;

                                                        -- Tính toán lương cho nhân viên
                                                        SELECT 
                                                            @LuongCoBan = LCB.LuongCoBan,
                                                            @HeSoLuong = CV.HeSoLuong,
                                                            @MaChucVu = NV.MaChucVu,
                                                            @MaLuongCoBan = LCB.MaLuongCoBan
                                                        FROM NhanVien NV
                                                        INNER JOIN ChucVu CV ON NV.MaChucVu = CV.MaChucVu
                                                        INNER JOIN LuongCoBan LCB ON NV.MaNhanVien = LCB.MaNhanVien
                                                        WHERE NV.MaNhanVien = @MaNhanVien;

                                                        -- Tính tổng lương
                                                        SET @TongLuong = (@LuongCoBan * @HeSoLuong) + @TongTroCap - @TongKhauTru;

                                                        -- Chèn dữ liệu vào bảng Luong
                                                        IF NOT EXISTS (
                                                            SELECT 1
                                                            FROM Luong
                                                            WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang
                                                        )
                                                        BEGIN
                                                            -- Chèn dữ liệu vào bảng Luong
                                                            INSERT INTO Luong (MaNhanVien, MaChucVu, MaLuongCoBan, Thang, TongKhauTru, TongTroCap, TongLuong)
                                                            VALUES (@MaNhanVien, @MaChucVu, @MaLuongCoBan, @Thang, @TongKhauTru, @TongTroCap, @TongLuong);
                                                        END
                                                        ELSE
                                                        BEGIN
                                                            -- Cập nhật dữ liệu nếu đã tồn tại
                                                            PRINT 'Dữ liệu đã tồn tại';
                                                            UPDATE Luong
                                                            SET TongKhauTru = @TongKhauTru,
                                                                TongTroCap = @TongTroCap,
                                                                TongLuong = @TongLuong
                                                            WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang;
                                                        END
                        ";
            try
            {

                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                                                new SqlParameter("@Thang", Entity.Thang));
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
