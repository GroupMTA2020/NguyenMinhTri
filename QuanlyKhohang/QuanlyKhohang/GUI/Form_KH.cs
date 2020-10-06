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
    public partial class Form_KH : Form
    {
        public Form_KH()
        {
            InitializeComponent();
        }

        private void Form_KH_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        #region Push Information

        public delegate void GetData(string id, string name);

        public GetData Getmydata;
        private void btn_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        
    }
}
