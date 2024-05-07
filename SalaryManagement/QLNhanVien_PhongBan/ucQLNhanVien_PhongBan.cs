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

namespace SalaryManagement.QLNhanVien_PhongBan
{
    public partial class ucQLNhanVien_PhongBan : UserControl
    {
        private NhanVien_PhongBanManager nvpbManager = null;
        private DataTable DSPhongBan = null;
        private DataTable DSNhanVien = null;
        private string error = "";
        private string maphongban = "";
        private string manhanvien = "";
        private NhanVienEntity DSNVDuocChon = new NhanVienEntity();
        private PhongBanEntity DSPBDuocChon = new PhongBanEntity();
        public ucQLNhanVien_PhongBan()
        {
            InitializeComponent();
            nvpbManager = new NhanVien_PhongBanManager();
            DSNhanVien = null;
            DSPhongBan = null;
            HienThiDSPhongBan();
        }

        private void HienThiDSPhongBan()
        {
            try
            {
                var data = nvpbManager.LayDuLieuDSPhongBan(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSPhongBan = data;
                    dgDanhSachPhongBan.DataSource = DSPhongBan;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LayDuLieuDSNV_PB(string maPhongBan)
        {
            try
            {
                var data = nvpbManager.LayDuLieuDSNV_PB(maPhongBan,ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSNhanVien = data;
                    dgDanhSachNhanVien.DataSource = DSNhanVien;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string MaPB = DSPBDuocChon.MaPhongBan;
            AddNhanVien frm = new AddNhanVien();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            LayDuLieuDSNV_PB(MaPB);
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            bool ketqua = nvpbManager.XoaNhanVien(manhanvien, ref error);
            if (ketqua == true)
            {
                HienThiDSPhongBan();
                MessageBox.Show("Xóa thành công.");
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            bool ketqua = nvpbManager.XoaPhongBan(maphongban, ref error);
            if (ketqua == true)
            {
                HienThiDSPhongBan();
                MessageBox.Show("Xóa thành công.");
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            AddPhongBan frm = new AddPhongBan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            HienThiDSPhongBan();

        }
    }
}
