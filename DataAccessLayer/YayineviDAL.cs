using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class YayineviDAL
    {
        private readonly string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public YayineviDAL()
        {
        }

        public bool YayineviEkle(string yayineviAdi, string telNo, string ePosta, string adres)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Yayinevi (YayineviAdi, TelNo, Eposta, Adres) VALUES (@YayineviAdi, @TelNo, @Eposta, @Adres)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YayineviAdi", yayineviAdi);
                command.Parameters.AddWithValue("@TelNo", telNo);
                command.Parameters.AddWithValue("@Eposta", ePosta);
                command.Parameters.AddWithValue("@Adres", adres);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool YayineviGuncelle(int id, string yayineviAdi, string telNo, string ePosta, string adres)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Yayinevi SET YayineviAdi = @YayineviAdi, TelNo = @TelNo, Adres = @Adres WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@AdiSoyadi", yayineviAdi);
                command.Parameters.AddWithValue("@Iletisim", telNo);
                command.Parameters.AddWithValue("@DogumTarihi", ePosta);
                command.Parameters.AddWithValue("@Biyografi", adres);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool YayineviSil(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Yayinevi WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public DataTable TumYayinevleriniGetiir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataRow YayinevleriniGetirById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            }
        }
        public DataTable YayineviAra(string aramaMetni)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Yayinevi WHERE YayineviAdi LIKE @AramaMetni OR YayineviAdi LIKE @AramaMetni";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
