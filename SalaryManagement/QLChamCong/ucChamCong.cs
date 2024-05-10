using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;


namespace SalaryManagement.QLChamCong
{
    public partial class ucChamCong : UserControl
    {
        private ChamCongManager CCManager = null;
        private DataTable DSChamCong = null;
        private string error = "";
        private string manhanvien = "";
        private string machamcong = "";
        private ChamCongEntity DSCCDuocChon = new ChamCongEntity();
        public ucChamCong()
        {
            InitializeComponent();
            CCManager = new ChamCongManager();
            LayDuLieuDSChamCong();
        }
        private void LayDuLieuDSChamCong()
        {
            try
            {
                var data = CCManager.LayDuLieuDSChamCong(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSChamCong = data;
                    dgDSChamCong.DataSource = DSChamCong;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
