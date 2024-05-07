using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Entity;
using BusinessLogicLayer.Manager;

namespace SalaryManagement.QLNhanVien_PhongBan
{
    public partial class AddPhongBan : Form
    {
        private NhanVien_PhongBanManager nvpbManager;
        private string error = "";
        public AddPhongBan()
        {
            InitializeComponent();
            nvpbManager = new NhanVien_PhongBanManager();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            NhanVienEntity nvEntity = new NhanVienEntity();
            PhongBanEntity pbEntity = new PhongBanEntity();
            pbEntity.TenPhongBan = txbTenPB.Text;
            bool ketqua = nvpbManager.ThemPhongBan(pbEntity, ref error);
            if (ketqua == true)
            {
                MessageBox.Show("Them thanh cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("Loi: " + error);
            }
        }
    }
}
