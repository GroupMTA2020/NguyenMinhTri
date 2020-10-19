using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using QuanlyKhohang.Model;
namespace QuanlyKhohang.GUI
{
    public partial class ThongKe : UserControl
    {
        private Model1 db = new Model1();
        public ThongKe()
        {
            InitializeComponent();
            LoadControl();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisableControl()
        {
            cbxchucvu.Enabled = false;
            cbxgioitinh.Enabled = false;
            comboNhapNam.Enabled = false;
            cbxgioitinh.Enabled = false;
            comboNhapNam.Enabled = false;
        }
        private void LoadControl()
        {

            cbxchucvu.DataSource = db.Nhacungcaps.ToList();
            cbxchucvu.ValueMember = "IDNCC";
            cbxchucvu.DisplayMember = "TenNCC";
            DisableControl();

        }
        private void ThongKeSPTheoNSX()
        {
            int id = (int)cbxchucvu.SelectedValue;
            var dbNV = db.Sanphams.Where(a => a.NCCID == id).ToList();
            dataGridView1.DataSource = dbNV;

        }
        private void ThongKePhieuNhapThang()
        {
            string id = (string)cbxgioitinh.SelectedItem;
            int s = Int32.Parse(id);
            var dbNV = db.Phieunhaps.Where(a => a.Ngaynhap.Month == s).ToList();
            dataGridView1.DataSource = dbNV;

        }
        private void ThongKePhieuNhapNam()
        {
            string id = (string)comboNhapNam.SelectedItem;
            int s = Int32.Parse(id);
            var dbNV = db.Phieunhaps.Where(a => a.Ngaynhap.Year == s).ToList();
            dataGridView1.DataSource = dbNV;

        }
        private void ThongKePhieuXuatThang()
        {
            string id = (string)comboNhapNam.SelectedItem;
            int s = Int32.Parse(id);
            var dbNV = db.Phieuxuats.Where(a => a.Ngayxuat.Month == s).ToList();
            dataGridView1.DataSource = dbNV;

        }
        private void ThongKePhieuXuatNam()
        {
            string id = (string)cbxgioitinh.SelectedItem;
            int s = Int32.Parse(id);
            var dbNV = db.Phieuxuats.Where(a => a.Ngayxuat.Year == s).ToList();
            dataGridView1.DataSource = dbNV;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radiothongkedotuoi.Checked)
            {
                combodotuoi.Enabled = true;
                ThongKePhieuXuatThang();
                return;
            }
            if (RadioThongKePhongBan.Checked)
            {
                cbxphongban.Enabled = true;
                ThongKePhieuXuatNam();
                return;
            }
            if (RadioThongkeNCC.Checked)
            {
                cbxchucvu.Enabled = true;
                ThongKeSPTheoNSX();
                return;
            }
            if (radioButton2.Checked)
            {
                comboNhapNam.Enabled = true;
                ThongKePhieuNhapNam();
                return;

            }
            if (RadioThongKeKhachHang.Checked)
            {
                cbxgioitinh.Enabled = true;
                ThongKePhieuNhapThang();
                return;
            }
            MessageBox.Show("Chưa có kiểu thống kê nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void RadioThongkeNCC_CheckedChanged_1(object sender, EventArgs e)
        {
            DisableControl();
            if (RadioThongkeNCC.Checked)
                cbxchucvu.Enabled = true;
        }

        private void RadioThongKePhongBan_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (RadioThongKePhongBan.Checked)
                cbxphongban.Enabled = true;
        }

        private void radiothongkedotuoi_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radiothongkedotuoi.Checked)
                combodotuoi.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radioButton2.Checked)
                comboNhapNam.Enabled = true;
        }

        private void RadioThongKeKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (RadioThongKeKhachHang.Checked)
                cbxgioitinh.Enabled = true;
        }
    }
}