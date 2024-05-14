using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
    public class KhauTru_TroCapReponsitories
    {

        private Database DB = new Database();
        public DataTable HienThiDSKTTC(string maNV, ref string error)
        {
            int maNhanVien = Convert.ToInt32(maNV);
            try
            {
                string sql = @"select KT.MaNhanVien, NV.HoTen, KT.TenKhauTru, KT.SoTienKhauTru, TroCap.TenTroCap, TroCap.SoTienTrCap

                            from KhauTru KT 
                             join NhanVien NV ON KT.MaNhanVien = NV.MaNhanVien
                             left join TroCap ON KT.MaNhanVien = TroCap.MaNhanVien

                            where KT.MaNhanVien like @MaNhanVien; ";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error,new SqlParameter("@MaNhanVien", maNhanVien));
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        //Them KHau TRu
        public bool ThemKhauTru(KhauTru_TroCapEntity KHTCEntity, ref string error)
        {
            try
            {
                string sql = @"insert into KhauTru (TenKhauTru, MaNhanVien, SoTienKhauTru)
                            Select    @TenKhauTru , NV.MaNhanVien, @SoTien
                            from NhanVien NV
                            Where NV.HoTen = @TenNhanVien;
                            ";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@TenNhanVien", KHTCEntity.TenNhanVien),
                                                                        new SqlParameter("@TenKhauTru", KHTCEntity.TenKhauTru),
                                                                        new SqlParameter("@SoTien", KHTCEntity.SoTien)
                                       );
                return rs;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

    }
    // select Bảng Khấu trừ và trợ cấp
    
}
