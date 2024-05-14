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
    public class ChamCongManager
    {
        private ChamCongReponsitories process;

        public ChamCongManager()
        {
            process = new ChamCongReponsitories();
        }
        public DataTable LayDuLieuDSChamCong(ref string error)
        {
            return process.LayDuLieuDSChamCong(ref error);
        }
    }
}
