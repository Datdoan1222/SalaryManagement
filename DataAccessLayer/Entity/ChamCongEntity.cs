using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class ChamCongEntity
    {
        public string MaChamCong { get; set; }
        public string MaNhanVien { get; set; }
        public string TrangThai { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
