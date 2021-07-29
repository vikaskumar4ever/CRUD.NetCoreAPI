using System;
using System.Data.SqlClient;


namespace Employee.Connection
{
    public class SqlDBConnect : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=CBLLAP0418;Initial Catalog=sample;Integrated Security=True");
        }
    }
}
