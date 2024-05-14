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
    public class ChamCongReponsitories
    {
        private Database DB = new Database();
        public DataTable LayDuLieuDSChamCong(ref string error)
        {
            try
            {
                string sql = @"SELECT NhanVien.HoTen, ChamCong.MaNhanVien, ChamCong.TrangThai, ChamCong.ThoiGian
                                FROM NhanVien
                                INNER JOIN ChamCong ON NhanVien.MaNhanVien = ChamCong.MaNhanVien;";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public bool ChamCong(ChamCongEntity Entity, ref string error)
        {

            try
            {
                string sql = " insert into ChamCong(MaNhanVien,TrangThai,ThoiGian) " +
                             " values(@MaNhanVien,  @TrangThai, @ThoiGian)";
                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                       new SqlParameter("@TrangThai", Entity.TrangThai),
                                                       new SqlParameter("@ThoiGian", Entity.ThoiGian));
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
