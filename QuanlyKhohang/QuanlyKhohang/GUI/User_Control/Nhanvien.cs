using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlyKhohang.BUS;

namespace QuanlyKhohang.GUI.User_Control
{
    public partial class Nhanvien : UserControl
    {
        NhanVien_BUS nv = new NhanVien_BUS();
        public Nhanvien()
        {
            InitializeComponent();
            nv.bangDuLieu = dataGridView1;
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            nv.ViewAll();
        }
    }
}
