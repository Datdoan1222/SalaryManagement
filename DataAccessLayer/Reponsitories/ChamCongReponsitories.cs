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
    }
}
