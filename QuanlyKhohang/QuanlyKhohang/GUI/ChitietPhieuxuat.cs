using QuanlyKhohang.BUS;
using QuanlyKhohang.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKhohang.GUI
{
    public partial class Chitietphieuxuat : Form
    {
        ChitietPhieuxuat_BUS ct = new ChitietPhieuxuat_BUS();

        public Chitietphieuxuat()
        {
            InitializeComponent();
            ct.sanPham = dataGridView1;
            ct.chiTiet = dataGridView2;
            ct.txtTotal = txtTongtien;
        }    
        private void Chitietphieuxuat_Load_1(object sender, EventArgs e)
        {
            ct.ViewAll(int.Parse(txtPXID1.Text));
            txtID.Focus();
        }

        public void GetValue1(string pxid)
        {
            txtPXID1.Text = pxid;
        }

        #region CellContentClick
        int trangThai = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trangThai = 0;
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSanpham.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btnXoa.Enabled = false;
            txtSoluong.Focus();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        #endregion

        #region ButtonHandle
        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
         
        }

        #endregion

        
    }
}
