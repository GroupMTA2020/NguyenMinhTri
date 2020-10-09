using QuanlyKhohang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.BUS
{
    class NhanVien_BUS
    {
        #region Control
        public DataGridView bangDuLieu { get; set; }
        public DataView dv { get; set; }
        #endregion
        public void ViewAll()
        {
            string sql = string.Format("select * from Nhanvien");
            DataTable dt = DataAccess.Query(sql);
            dv = new DataView(dt);
            bangDuLieu.DataSource = dt;
            bangDuLieu.Columns[0].HeaderText = "ID NHANVIEN";
            bangDuLieu.Columns[1].HeaderText = "Tên Nhân Viên";
            bangDuLieu.Columns[2].HeaderText = "Giới Tính";
            bangDuLieu.Columns[3].HeaderText = "Địa Chỉ";
            bangDuLieu.Columns[4].HeaderText = "Điện thoại";
            bangDuLieu.Columns[5].HeaderText = "Email";
        }
        public void timKiem(string tenkh, string diachi)
        {
            dv.RowFilter = "[TenNV] like '%" + tenkh + "%' and [Diachi] like '%" + diachi + "%'";
            bangDuLieu.DataSource = dv;
        }
        public void Add(string ten,string gioitinh, string diachi, string dienthoai, string email)
        {
            DataAccess.NonQuery("nhanvien_insert",
                new SqlParameter("@ten", ten),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@dienthoai", dienthoai),
                new SqlParameter("@email", email));
        }
        public void Update(int id, string ten, string gioitinh, string diachi, string dienthoai, string email)
        {
            DataAccess.NonQuery("nhanvien_update",
                new SqlParameter("@nvid", id),
                new SqlParameter("@ten", ten),
                new SqlParameter("@gioitinh", gioitinh),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@dienthoai", dienthoai),
                new SqlParameter("@email", email));
        }
        public int Delete(int id)
        {
            DataTable dt = DataAccess.Query("Nhanvien_delete",
                new SqlParameter("@nvid", id));
            int res = int.Parse(dt.Rows[0][0].ToString());
            return res;
        }
    }
}
