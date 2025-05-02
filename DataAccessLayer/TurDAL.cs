    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using EntityLayer;

    namespace DataAccessLayer
    {
        public class TurDAL
        {
            private string connectionString = "Kendi veri tabanınızı girin.(Ben MSSQL kullandım.)";

            public TurDAL()
            {

            }
    //MBB-01-BIL065-N\SQLEXPRESS

            public bool TurEkle(string turAdi, string aciklama)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Turler (TurAdi, Aciklama) VALUES (@TurAdi, @Aciklama)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TurAdi", turAdi);
                    command.Parameters.AddWithValue("@Aciklama", aciklama);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            public bool TurGuncelle(int id, string turAdi, string aciklama)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Turler SET TurAdi = @TurAdi, Aciklama = @Aciklama WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@TurAdi", turAdi);
                    command.Parameters.AddWithValue("@Aciklama", aciklama);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

            public DataTable TumTurleriGetir()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Turler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            public DataRow TurGetirById(int id)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Turler WHERE ID = @ID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
                }
            }
            public DataTable TurAra(string aramaMetni)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Turler WHERE TurAdi LIKE @AramaMetni OR Aciklama LIKE @AramaMetni";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

    }

