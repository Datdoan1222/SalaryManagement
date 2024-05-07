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
    public partial class AddNhanVien : Form
    {
        private NhanVien_PhongBanManager nvpbManager;
        private DataTable dataNhanVien = null;
        private string error = "";
        private string maNhanVien = "";
        private string maPhongBan = "";
        private NhanVienEntity NVDuocChon = new NhanVienEntity();
        public AddNhanVien()
        {
            InitializeComponent();
            nvpbManager = new NhanVien_PhongBanManager();

        }
       
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVienEntity nvEntity = new NhanVienEntity();
            nvEntity.TenNhanVien = txbTenNV.Text;
            nvEntity.NgaySinh = txtNgaySinh.Text;
            nvEntity.MaPhongBan = cbxChucVu.Text;
            nvEntity.NgaySinh = txtNgaySinh.Text;
            nvEntity.DiaChi = txtDiaChi.Text;
            bool ketqua = nvpbManager.ThemNhanVien(nvEntity, ref error);
            if (ketqua == true)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Loi: " + error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
