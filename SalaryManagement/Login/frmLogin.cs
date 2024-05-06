using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SalaryManagement.MainForm;
namespace SalaryManagement.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainForm frm = new frmMainForm();
            frm.Show();
            this.Hide();
            //string connString = "";
            //SqlConnection connect = null;
            //try
            //{
            //    //ket noi csdl
            //    connect = new SqlConnection(connString);
            //    connect.Open();
            //    //Xử lý truy van
            //    #region Xu ly du lieu
            //    string sql = "select tendaydu from TaiKhoan where TenDangNhap like '" + txbTenDN.Text + "' and MatKhau like '" + txbPassWord.Text + "'";
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connect;
            //    command.CommandText = sql;
            //    command.CommandType = CommandType.Text;
            //    object data = command.ExecuteScalar();

            //    if (data == null)
            //    {
            //        MessageBox.Show("Loi tai khoan, dang nhap khong thanh cong");

            //    }
            //    else
            //    {
            //        //MessageBox.Show("Dan nhap thanh cong, ten nguoi dang la: "+data.ToString());
            //        ClsCHHeThong.TenDangNhap = txbTenDN.Text;
            //        ClsCHHeThong.TenDayDu = data.ToString();
            //        frmMainForm frm = new frmMainForm(data.ToString());
            //        frm.Show();
            //        this.Hide();
            //    }
            //    #endregion
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ket noi lôi: " + ex.Message);
            //}
            //finally
            //{
            //    connect.Close();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
