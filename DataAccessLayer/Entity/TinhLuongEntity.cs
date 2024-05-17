using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class TinhLuongEntity
    {
        public string MaLuong { get; set; }
        public int MaNhanVien { get; set; }
        public string TenChucVu { get; set; }
        public string TenPhongBan { get; set; }
        public string LuongCoBan { get; set; }
        public int Thang { get; set; }
        public string TongKhauTru { get; set; }
        public string TongTroCap { get; set; }
        public string TongLuong { get; set; }

    }
}
