using DataAccessLayer.Reponsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Reponsitories;
using System.Data;
using DataAccessLayer.Entity;

namespace BusinessLogicLayer.Manager
{    
        public class KhauTru_TroCapManager
        {
        private KhauTru_TroCapReponsitories process;

        public KhauTru_TroCapManager()
        {
            process = new KhauTru_TroCapReponsitories();
        }
        public bool ThemKhauTru(KhauTru_TroCapEntity kttc, ref string error)
        {
            return process.ThemKhauTru(kttc, ref error);
        }
        public DataTable HienThiDSKTTC(string maNVSelect,ref string error)
        {
            return process.HienThiDSKTTC(maNVSelect, ref error);
        }

    }
    
}
