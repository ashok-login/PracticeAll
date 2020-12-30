using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PracticeConsole
{
    public class ADONETTransactionDemo
    {
        public void Execute()
        {
            var objConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollPlusLocal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlTransaction objTransaction = null;
            try
            {
                objConn.Open();
                objTransaction = objConn.BeginTransaction();
                SqlCommand objCmd1 = new SqlCommand("UPDATE Account SET Amount = Amount + 10 WHERE AccountNo = 1001", objConn, objTransaction);
                SqlCommand objCmd2 = new SqlCommand("UPDATE Account SET Amount = Amount - 10 WHERE AccountNo = 1002", objConn, objTransaction);
                objCmd1.ExecuteNonQuery();
                //throw new Exception("Terrible error occurred");
                objCmd2.ExecuteNonQuery();
                objTransaction.Commit();
            }
            catch (Exception ex)
            {
                objTransaction.Rollback();
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                    objConn.Close();
            }
        }
    }
}
