using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryManagement.QLNhanVien;
using SalaryManagement.QL
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
        private ucQLNhanVien ucQLNV;

        private void btnMenuNhanVien_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(ucQLNV) == false)
            {
                ucQLNV = new ucQLNhanVien();
                ucQLNV.Dock = DockStyle.Fill;
                pnMain.Controls.Add(ucQLNV);
                ucQLNV.BringToFront();
            }
            else
            {
                ucQLNV.BringToFront();
            }
        }
    }
}
