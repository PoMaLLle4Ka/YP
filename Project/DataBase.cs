using System;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    internal class DataBase : IDisposable
    {
        private SqlConnection _connection;
        private bool _disposed = false;

        public DataBase(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, _connection);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteReader();
        }

        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                if (_connection != null)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
                _disposed = true;
            }
        }
    }
}
