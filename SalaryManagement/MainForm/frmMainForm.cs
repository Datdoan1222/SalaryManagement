using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagement.QLKhauTru_PhuCap;
using SalaryManagement.QLQuyTrinhDuyetLuong;
using SalaryManagement.QLNhanVien_PhongBan;
using SalaryManagement.QLCaiDatLuong;
using SalaryManagement.QLBaoCao_ThongKe;
namespace SalaryManagement.MainForm
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            this.Text = "Nguoi dung: " + ClsCHHeThong.TenDangNhap + " dang nhap luc: " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy");
        }
        public frmMainForm(string TenDangNhap)
        {
            InitializeComponent();
            this.Text = "Nguoi dung: " + TenDangNhap + " dang nhap luc: " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy");
        }
        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// Nhân Viên Và Phòng Ban
        private ucQLNhanVien_PhongBan ucQLNV;
        private void btnMenuNV_PB_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucQLNV) == false)
            {
                ucQLNV = new ucQLNhanVien_PhongBan();
                ucQLNV.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLNV);
                ucQLNV.BringToFront();
            }
            else
            {
                ucQLNV.BringToFront();
            }
        }

        // Khấu Trừ và Phụ cấp
        private ucQLKhauTru_PhuCap ucQLKT_PC;

        private void btnMenuKTvaPC_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucQLKT_PC) == false)
            {
                ucQLKT_PC = new ucQLKhauTru_PhuCap();
                ucQLKT_PC.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLKT_PC);
                ucQLKT_PC.BringToFront();
            }
            else
            {
                ucQLKT_PC.BringToFront();
            }
        }

        // Lương Tháng
        private ucQTDLuongThang ucQTDL;
        private void btnMenuLuongThang_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucQTDL) == false)
            {
                ucQTDL = new ucQTDLuongThang();
                ucQTDL.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQTDL);
                ucQTDL.BringToFront();
            }
            else
            {
                ucQTDL.BringToFront();
            }
        }
        // Cài Đặt Lương
        private ucCaiDatLuong ucCDLuong;
        private void btnCaiDatLuong_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucCDLuong) == false)
            {
                ucCDLuong = new ucCaiDatLuong();
                ucCDLuong.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucCDLuong);
                ucCDLuong.BringToFront();
            }
            else
            {
                ucCDLuong.BringToFront();
            }
        }

        // Báo Cáo và Thống Kê
        private ucBaoCao_ThongKe ucBCTK;

        private void btnMenuBCTK_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucBCTK) == false)
            {
                ucBCTK = new ucBaoCao_ThongKe();
                ucBCTK.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucBCTK);
                ucBCTK.BringToFront();
            }
            else
            {
                ucBCTK.BringToFront();
            }
        }
    }
}
