using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Reponsitories
{
    public class Database //tuong tac vs csdl
    {
        private SqlConnection connect = null;
        private SqlCommand command = null;
        private string connString = "Data Source=.;Initial Catalog=QLTL;Integrated Security=True";
        public Database()
        {
            try
            {
                connString = "Data Source=.;Initial Catalog=QLTL;Integrated Security=True";
                connect = new SqlConnection(connString);
                command = new SqlCommand();
                command.Connection = connect;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GetDataFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                SqlDataReader reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                error = "";
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public object GetValueFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                var data = command.ExecuteScalar();
                error = "";
                return data;
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
        public bool ProcessData(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
        {
            try
            {
                connect.Open();
                command.CommandText = sql;
                command.CommandType = commandtype;
                command.Parameters.Clear();
                if (paramlist != null)
                {
                    foreach (var paraitem in paramlist)
                    {
                        command.Parameters.Add(paraitem);
                    }
                }
                int row = command.ExecuteNonQuery();
                if (row == 0)
                {
                    error = "";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = "Ket noi lôi: " + ex.Message;
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
