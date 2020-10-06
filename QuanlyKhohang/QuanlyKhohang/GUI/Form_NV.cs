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
    public partial class Form_NV : Form
    {
        public Form_NV()
        {
            InitializeComponent();
        }
        private void Form_NV_Load_1(object sender, EventArgs e)
        {
          
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        public delegate void GetData(string id, string name);
        public GetData Getmydata;
        private void btn_Click(object sender, EventArgs e)
        {
           
        }
          

        
    }
}
