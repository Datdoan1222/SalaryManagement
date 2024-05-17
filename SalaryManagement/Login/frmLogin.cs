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
            string connString = "Data Source=.;Initial Catalog=QuanLiTienLuong;Integrated Security=True";

            try
            {
                string sql = @"SELECT TaiKhoan.MaTaiKhoan, TaiKhoan.TenDangNhap, PhongBan.TenPhongBan, ChucVu.TenChucVu, NhanVien.TenNhanVien
                               FROM TaiKhoan
                               JOIN NhanVien ON TaiKhoan.MaTaiKhoan = NhanVien.MaTaiKhoan
                               JOIN PhongBan ON NhanVien.MaPhongBan = PhongBan.MaPhongBan
                               JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu
                               WHERE TaiKhoan.TenDangNhap = @Username AND TaiKhoan.MatKhau = @Password";

                using (SqlConnection connect = new SqlConnection(connString))
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        command.Parameters.AddWithValue("@Username", txbTenDN.Text);
                        command.Parameters.AddWithValue("@Password", txbPassWord.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("MaTaiKhoan"));
                                string tenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap"));
                                string tenPhongBan = reader.GetString(reader.GetOrdinal("TenPhongBan"));
                                string tenChucVu = reader.GetString(reader.GetOrdinal("TenChucVu"));
                                string tenDayDu = reader.GetString(reader.GetOrdinal("TenNhanVien"));


                                ClsCHHeThong.ID = id.ToString();
                                ClsCHHeThong.TenDangNhap = tenDangNhap;
                                ClsCHHeThong.PhongBan = tenPhongBan;
                                ClsCHHeThong.ChucVu = tenChucVu;
                                ClsCHHeThong.TenDayDu = tenDayDu;

                                frmMainForm frm = new frmMainForm(tenDangNhap);
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
