using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Responsitories
{
    public class TaiKhoanResponsitory
    {
        public bool XoaTaiKhoan(string tendangnhap,ref string ERROR)   //XXXXXXXXX
        {
            //Buớc 2: Xac đinh chuoi ket noi
            string connString = "Data Source=.;Initial Catalog=Learning_QLBH;Integrated Security=True";
            //Buoc 3: Tao doi tuong ket noi
            SqlConnection connect = null;
            try
            {
                //ket noi csdl
                connect = new SqlConnection(connString);
                connect.Open();
                //Xử lý truy van
                #region Xu ly du lieu
                string sql = "delete from taikhoan where tendangnhap like '" + tendangnhap + "'";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                //thuc thi lenh
                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    ERROR = "";           //XXXXXXXXX
                   return true;
                }
                else
                {
                    ERROR = "Khong tin thay tai khoan: " + tendangnhap + " Xoa khong thanh cong";         //XXXXXXXXX
                    return false;
                }

                #endregion
            }
            catch (Exception ex)
            {
                ERROR = "Ket noi lôi: " + ex.Message;         //XXXXXXXXX
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public DataTable HienThiDanhSachTaiKhoan(ref string ERROR)
        {
            //Buoc 1: xac định CSDL sẽ lam việc
            //Buớc 2: Xac đinh chuoi ket noi
            string connString = "Data Source=.;Initial Catalog=Learning_QLBH;Integrated Security=True";
            //Buoc 3: Tao doi tuong ket noi
            SqlConnection connect = null;
            try
            {
                //ket noi csdl
                connect = new SqlConnection(connString);
                connect.Open();
                //Xử lý truy van
                #region Xu ly du lieu
                string sql = " select tendaydu,tendangnhap, q.mota as maquyen, " +
                             "       case when tk.tinhtrang ='Y' then N'Còn sử dụng' else N'Đã xóa' end as tinhtrang" +
                             " from TaiKhoan tk inner join quyendangnhap q on tk.maquyen=q.maquyen" +
                             " where tk.tinhtrang='Y'";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                ERROR = "";
                return data;
                #endregion
            }
            catch (Exception ex)
            {
                ERROR = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
