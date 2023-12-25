using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        //Tạo Singleton: Đảm bảo chỉ có 1 TableDAO được tạo ra
        public static TableDAO Instance 
        {
            get 
            { 
                if (instance == null) 
                    instance = new TableDAO(); 
                return TableDAO.instance; 
            }
            private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 125;
        public static int TableHeight = 125;
        // Hàm tạo private để ngăn cản việc tạo thể hiện từ bên ngoài lớp.
        private TableDAO() { }
        public void SwtichTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        // Phương thức tải danh sách bàn từ cơ sở dữ liệu.
        public List<Table> LoadTableList()
        {
            //Tạo một danh sách để lưu trữ đối tượng Table
            List<Table> tableList = new List<Table>();
            //Thực hiện một truy vấn để lấy dữ liệu của các bàn từ cơ sở dữ liệu
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            // Duyệt qua các dòng kết quả và tạo các đối tượng Table.
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            //Trả về danh sách các đối tượng Table
            return tableList;
        }
        public List<Table> GetTableList()
        {
            List<Table> list = new List<Table>();
            string query = "SELECT * FROM dbo.TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }
            return list;
        }
        public Table GetTableByID(int id)
        {
            Table table = null;
            string query = "SELECT * FROM TableFood where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                table = new Table(item);
                return table;
            }
            return table;
        }
        public bool InsertTable(string name, string status)
        {
            string query = string.Format("INSERT dbo.TableFood (name, status) VALUES (N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int id, string name, string status)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}', status = N'{1}' WHERE id = {2}", name, status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            string query = string.Format("Delete dbo.TableFood where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
