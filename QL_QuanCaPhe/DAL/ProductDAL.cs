using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAL
{
    internal class ProductDAL
    {
        public static SqlConnection connection = GetSQLConnection.getConnection();


        public static DataTable layDanhSach()
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                DataTable dataTable = new DataTable();

                SqlCommand command = new SqlCommand("select * from Product", connection);
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

                SqlCommand command = new SqlCommand("select p.id, p.name, p.quantity, p.price, p.description, c.name from Product p inner join Category c on c.id = p.categoryId", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void addProduct(Product product)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Product(name, quantity, price, description, categoryId, img) " +
                    "values(@name, @quantity, @price, @description, @categoryId, @img)", connection);

                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = product.name;
                command.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = product.quantity;
                command.Parameters.Add("@price", System.Data.SqlDbType.Float).Value = product.price;
                command.Parameters.Add("@description", System.Data.SqlDbType.NVarChar).Value = product.description;
                command.Parameters.Add("@categoryId", System.Data.SqlDbType.Int).Value = product.categoryId;
                command.Parameters.Add("@img", System.Data.SqlDbType.Image).Value = product.img;
                command.ExecuteNonQuery();
            }
        }

        public static void updateProduct(Product product)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Product set name = @name, quantity = @quantity, price = @price, description = @description, " +
                    "categoryId = @categoryId, img = @img " +
                    "where id = @id", connection);
                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = product.name;
                command.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = product.quantity;
                command.Parameters.Add("@price", System.Data.SqlDbType.Float).Value = product.price;
                command.Parameters.Add("@description", System.Data.SqlDbType.NVarChar).Value = product.description;
                command.Parameters.Add("@categoryId", System.Data.SqlDbType.Int).Value = product.categoryId;
                command.Parameters.Add("@img", System.Data.SqlDbType.Image).Value = product.img;
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = product.id;

                command.ExecuteNonQuery();
            }
        }

        public static void deleteProduct(int id)
        {
            using (var connection = GetSQLConnection.getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete Product where id = " + id, connection);
                command.ExecuteNonQuery();
            }
        }

        public static void xuatBaoCao()
        {
            baoCaoThongKeSanPham(" Sản Phẩm", layDanhSach2());
        }

        public static void baoCaoThongKeSanPham(string content, System.Data.DataTable dataTable)
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
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

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

                cl2.Value2 = "Tên sản phẩm";

                cl2.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Số lượng";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Giá sản phẩm";

                cl4.ColumnWidth = 14;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mô tả";

                cl5.ColumnWidth = 25;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Loại sản phẩm";

                cl6.ColumnWidth = 23.71;



                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

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
