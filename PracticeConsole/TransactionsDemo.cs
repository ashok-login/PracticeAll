using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PracticeConsole
{
    public class TransactionsDemo
    {
        public void Execute()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollPlusLocal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection objConn = new SqlConnection(connectionString);
            objConn.Open();
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                SqlCommand objCmd = new SqlCommand("UPDATE Account set Amount -= 10 where AccountNo = 1001", objConn, objTran);
                objCmd.ExecuteNonQuery();
                //throw new Exception("Unexpected error occurred...");
                objCmd = new SqlCommand("UPDATE Account set Amount += 10 where AccountNo = 1002", objConn, objTran);
                objCmd.ExecuteNonQuery();
                objTran.Commit();
                Console.ReadKey();
            }
            catch (Exception)
            {
                objTran.Rollback();
                throw;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                    objConn.Close();
            }
        }
    }
}
