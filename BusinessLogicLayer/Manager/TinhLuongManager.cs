using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Reponsitories;
using DataAccessLayer.Entity;

namespace BusinessLogicLayer.Manager
{
    public class TinhLuongManager
    {
        private TinhLuongReponsitories  process;

        public TinhLuongManager()
        {
            process = new TinhLuongReponsitories();
        }
        public DataTable LayDuLieuDSLuong(TinhLuongEntity entity, ref string error)
        {
            return process.LayDuLieuDSLuong(entity, ref error);
        }
        public bool TinhLuong(TinhLuongEntity Entity, ref string error)
        {
            return process.TinhLuong(Entity, ref error);
        }
        public bool ktraLuongNV(TinhLuongEntity Entity, ref string error)
        {
            return process.ktraLuongNV(Entity, ref error);
        }
        public bool ktraLuongThangNV(TinhLuongEntity Entity, ref string error)
        {
            return process.ktraLuongThangNV(Entity, ref error);
        }
        
    }
}
