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
        private string manhanvien = ClsCHHeThong.TenDayDu;
        private string machamcong = "";
        private ChamCongEntity DSCCDuocChon = new ChamCongEntity();
        private DateTime currentDate = DateTime.Now;
        public ucChamCong()
        {
            InitializeComponent();
            CCManager = new ChamCongManager();
            LayDuLieuDSChamCong(manhanvien);
            getDatetime();

        }
        private void getDatetime()
        {
            lblDatetime.Text = currentDate.ToString("HH:mm:ss");
            string formattedDate = string.Format
                ("Ngày {0}, Tháng {1}, Năm {2}", currentDate.Day, currentDate.Month, currentDate.Year);
            lblDate.Text = formattedDate;
        }
        private void LayDuLieuDSChamCong(string manhanvien)
        {
            try
            {
                var data = CCManager.LayDuLieuDSChamCong(manhanvien,ref error);
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

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            DSCCDuocChon.MaNhanVien = ClsCHHeThong.ID.ToString();
            DSCCDuocChon.TrangThai = cbxTrangThai.Text;
            DSCCDuocChon.CheckIn = currentDate;
            DSCCDuocChon.CheckOut = currentDate;
            bool ketqua = CCManager.ChamCong(DSCCDuocChon, ref error);
            if (ketqua == true)
            {
                MessageBox.Show( cbxTrangThai.Text + " Thành Công");
            }
            else
            {
                MessageBox.Show("Loi: " + error);
                Console.WriteLine(error);
            }
            LayDuLieuDSChamCong(manhanvien);
        }

        private void dgDSChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDSChamCong.Rows[e.RowIndex];
                //DSCCDuocChon.TrangThai = selectedRow.Cells["MaNhanVien"].Value.ToString();
                LayDuLieuDSChamCong(manhanvien);
            }
        }
    }
}
