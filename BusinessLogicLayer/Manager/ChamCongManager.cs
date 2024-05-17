using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Reponsitories;
using DataAccessLayer.Entity;
using System.Data;
using DataAccessLayer.Entity;

namespace BusinessLogicLayer.Manager
{
    public class ChamCongManager
    {
        private ChamCongReponsitories process;

        public ChamCongManager()
        {
            process = new ChamCongReponsitories();
        }
        public DataTable LayDuLieuDSChamCong(string manhanvien, ref string error)
        {
            return process.LayDuLieuDSChamCong(manhanvien, ref error);
        }
        public bool ChamCong(ChamCongEntity Entity, ref string error)
        {
            if (string.IsNullOrEmpty(Entity.MaNhanVien) == true)
            {
                error = "Bạn Chưa Đăng Nhập";
                return false;
            }
            if (string.IsNullOrEmpty(Entity.TrangThai) == true)
            {
                error = "Phai nhap Trang Thai";
                return false;
            }
            return process.ChamCong(Entity, ref error);
        }
    }
}
