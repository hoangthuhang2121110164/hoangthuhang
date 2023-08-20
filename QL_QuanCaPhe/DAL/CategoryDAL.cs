using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QuanCaPhe.DTO;

namespace QL_QuanCaPhe.DAL
{
    internal class CategoryDAL
    {
        public static SqlConnection connection = GetSQLConnection.getConnection();


        public static List<string> layDanhSachTen()
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                List<string> list = new List<string>();

                SqlCommand command = new SqlCommand("select name from Category", connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read()) { 
                    list.Add(reader.GetString(0));  
                }
                return list;
            }
        }
        public static DataTable layDanhSach()
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                SqlCommand command = new SqlCommand("select * from Category", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void addCategory(Category category)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Category(name, img) " +
                    "values(@name, @img)", connection);

                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = category.name;
                command.Parameters.Add("@img", System.Data.SqlDbType.Image).Value = category.img;
                command.ExecuteNonQuery();
            }
        }

        public static void updateCategory(Category category)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Category set name = @name, img = @img " +
                    "where id = @id", connection);
                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = category.name;
                command.Parameters.Add("@img", System.Data.SqlDbType.Image).Value = category.img;
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = category.id;

                command.ExecuteNonQuery();
            }
        }

        public static void deleteCategory(int id)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete Category where id = " + id, connection);
                command.ExecuteNonQuery();
            }
        }

        public static int findIDByName(string name)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select id from Category where name = @name", connection);
                command.Parameters.AddWithValue("@name", name);  
                int id = Convert.ToInt32(command.ExecuteScalar());
                return id;
            }
        }

        public static string findNameByID(int id)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select name from Category where id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                string name = (string)command.ExecuteScalar();
                return name;
            }
        }
    }
}
