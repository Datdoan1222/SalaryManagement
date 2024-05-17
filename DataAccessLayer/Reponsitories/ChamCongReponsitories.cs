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
        public DataTable LayDuLieuDSChamCong(string manhanvien, ref string error)
        {
            
            try
            {
                string sql = @"SELECT 
                                        n.MaNhanVien,
                                        n.TenNhanVien,
                                        CASE 
                                            WHEN c.CheckIn IS NOT NULL AND c.CheckOut IS NULL THEN 'Check In'
                                            WHEN c.CheckIn IS NOT NULL AND c.CheckOut IS NOT NULL THEN 'Check Out'
                                            ELSE 'Check Out'
                                        END AS [Trạng Thái],
                                        COALESCE(c.CheckIn, c.CheckOut) AS [Thời Gian]
                                    FROM 
                                        ChamCong c
                                    JOIN 
                                        NhanVien n ON c.MaNhanVien = n.MaNhanVien

                                WHERE n.TenNhanVien like @MaNhanVien;
                                ";

                return DB.GetDataFromDB(sql, CommandType.Text, ref error,new SqlParameter("@MaNhanVien", manhanvien));
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public bool ChamCong(ChamCongEntity Entity, ref string error)
        {
            string sql = "";
            try
            {
                if(Entity.TrangThai == "Check In")
                {
                    sql = " insert into ChamCong(MaNhanVien,CheckIn) " +
                             " values(@MaNhanVien,  @CheckIn)";
                }else
                {
                    sql = " insert into ChamCong(MaNhanVien,CheckOut) " +
                             " values(@MaNhanVien, @CheckOut)";
                }
                
                var rs = DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter("@MaNhanVien", Entity.MaNhanVien),
                                                       new SqlParameter("@CheckIn", Entity.CheckIn),
                                                       new SqlParameter("@CheckOut", Entity.CheckOut));
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
