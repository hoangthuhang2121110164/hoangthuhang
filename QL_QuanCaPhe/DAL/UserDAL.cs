using Microsoft.VisualBasic.ApplicationServices;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAL
{
    internal class UserDAL
    {
        public static SqlConnection connection = GetSQLConnection.getConnection();


        public static DataTable layDanhSach()
        {
            using(var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                SqlCommand command = new SqlCommand("select * from Users", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable layDanhSach2()
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                SqlCommand command = new SqlCommand("select id, userId, firstName, lastName, email, tel, DOB, gender, userRole, username, password from Users", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void addUser(Users users)
        {
            try
            {
                using (var connection = GetSQLConnection.getConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into Users(userId, firstName, lastName, email, tel, DOB, gender, userRole, username, password, avatar) " +
                        "values(@userId, @firstName, @lastName, @email, @tel, @DOB, @gender, @userRole, @username, @password, @avatar)", connection);

                    command.Parameters.Add("@userId", System.Data.SqlDbType.NVarChar).Value = users.userID;
                    command.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = users.firstName;
                    command.Parameters.Add("@lastName", System.Data.SqlDbType.NVarChar).Value = users.lastName;
                    command.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = users.email;
                    command.Parameters.Add("@tel", System.Data.SqlDbType.VarChar).Value = users.tel;
                    command.Parameters.Add("@DOB", System.Data.SqlDbType.Date).Value = users.DOB;
                    command.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = users.gender;
                    command.Parameters.Add("@userRole", System.Data.SqlDbType.NVarChar).Value = users.userRole;
                    command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = users.username;
                    command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = users.password;
                    command.Parameters.Add("@avatar", System.Data.SqlDbType.Image).Value = users.avatar;
                    command.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void updateUser(Users users)
        {
            try
            {
                using (var connection = GetSQLConnection.getConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("update Users set userId = @userId, firstName = @firstName, lastName = @lastName, email = @email, " +
                        "tel = @tel, DOB = @DOB, gender = @gender, userRole = @userRole, username = @username, password = @password, avatar = @avatar " +
                        "where id = @id", connection);
                    command.Parameters.Add("@userId", System.Data.SqlDbType.NVarChar).Value = users.userID;
                    command.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = users.firstName;
                    command.Parameters.Add("@lastName", System.Data.SqlDbType.NVarChar).Value = users.lastName;
                    command.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = users.email;
                    command.Parameters.Add("@tel", System.Data.SqlDbType.VarChar).Value = users.tel;
                    command.Parameters.Add("@DOB", System.Data.SqlDbType.Date).Value = users.DOB;
                    command.Parameters.Add("@gender", System.Data.SqlDbType.Bit).Value = users.gender;
                    command.Parameters.Add("@userRole", System.Data.SqlDbType.NVarChar).Value = users.userRole;
                    command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = users.username;
                    command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = users.password;
                    command.Parameters.Add("@avatar", System.Data.SqlDbType.Image).Value = users.avatar;
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = users.id;

                    command.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void deleteUser(int id)
        {
           using(var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete Users where id = " + id, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void xuatBaoCao()
        {
            baoCaoThongKeNguoiDung(" Người dùng", layDanhSach2());
        }

        public static void baoCaoThongKeNguoiDung(string content, System.Data.DataTable dataTable)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            string sheetName = content;
            string title = "Quản Lý " + content;

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "ID";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã người dùng";

            cl2.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Họ";
            cl3.ColumnWidth = 30.29;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tên";

            cl4.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Email";

            cl5.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Điện thoại";

            cl6.ColumnWidth = 23.71;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Ngày sinh";

            cl7.ColumnWidth = 23.71;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Giới tính";

            cl8.ColumnWidth = 23.71;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Quyền";

            cl9.ColumnWidth = 23.71;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Tài khoản";

            cl10.ColumnWidth = 23.71;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Mật khẩu";

            cl11.ColumnWidth = 23.71;



            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            int size = dataTable.Columns.Count;

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col].ToString();
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
