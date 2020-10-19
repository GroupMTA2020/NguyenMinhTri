namespace QuanlyKhohang.GUI
{
    partial class ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combodotuoi = new System.Windows.Forms.ComboBox();
            this.cbxphongban = new System.Windows.Forms.ComboBox();
            this.cbxchucvu = new System.Windows.Forms.ComboBox();
            this.RadioThongkeNCC = new System.Windows.Forms.RadioButton();
            this.radiothongkedotuoi = new System.Windows.Forms.RadioButton();
            this.RadioThongKePhongBan = new System.Windows.Forms.RadioButton();
            this.cbxgioitinh = new System.Windows.Forms.ComboBox();
            this.comboNhapNam = new System.Windows.Forms.ComboBox();
            this.RadioThongKeKhachHang = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // combodotuoi
            // 
            this.combodotuoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodotuoi.FormattingEnabled = true;
            this.combodotuoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combodotuoi.Location = new System.Drawing.Point(275, 215);
            this.combodotuoi.Name = "combodotuoi";
            this.combodotuoi.Size = new System.Drawing.Size(269, 27);
            this.combodotuoi.TabIndex = 159;
            // 
            // cbxphongban
            // 
            this.cbxphongban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxphongban.FormattingEnabled = true;
            this.cbxphongban.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbxphongban.Location = new System.Drawing.Point(275, 174);
            this.cbxphongban.Name = "cbxphongban";
            this.cbxphongban.Size = new System.Drawing.Size(269, 27);
            this.cbxphongban.TabIndex = 154;
            // 
            // cbxchucvu
            // 
            this.cbxchucvu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxchucvu.FormattingEnabled = true;
            this.cbxchucvu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxchucvu.Location = new System.Drawing.Point(275, 87);
            this.cbxchucvu.Name = "cbxchucvu";
            this.cbxchucvu.Size = new System.Drawing.Size(269, 27);
            this.cbxchucvu.TabIndex = 153;
            // 
            // RadioThongkeNCC
            // 
            this.RadioThongkeNCC.AutoSize = true;
            this.RadioThongkeNCC.BackColor = System.Drawing.Color.Transparent;
            this.RadioThongkeNCC.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioThongkeNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RadioThongkeNCC.Location = new System.Drawing.Point(32, 90);
            this.RadioThongkeNCC.Margin = new System.Windows.Forms.Padding(2);
            this.RadioThongkeNCC.Name = "RadioThongkeNCC";
            this.RadioThongkeNCC.Size = new System.Drawing.Size(182, 20);
            this.RadioThongkeNCC.TabIndex = 147;
            this.RadioThongkeNCC.Text = "Thống kê sp theo NSX";
            this.RadioThongkeNCC.UseVisualStyleBackColor = false;
            this.RadioThongkeNCC.CheckedChanged += new System.EventHandler(this.RadioThongkeNCC_CheckedChanged_1);
            // 
            // radiothongkedotuoi
            // 
            this.radiothongkedotuoi.AutoSize = true;
            this.radiothongkedotuoi.BackColor = System.Drawing.Color.Transparent;
            this.radiothongkedotuoi.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiothongkedotuoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radiothongkedotuoi.Location = new System.Drawing.Point(32, 222);
            this.radiothongkedotuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiothongkedotuoi.Name = "radiothongkedotuoi";
            this.radiothongkedotuoi.Size = new System.Drawing.Size(173, 20);
            this.radiothongkedotuoi.TabIndex = 148;
            this.radiothongkedotuoi.Text = "Thống kê theo tháng";
            this.radiothongkedotuoi.UseVisualStyleBackColor = false;
            this.radiothongkedotuoi.CheckedChanged += new System.EventHandler(this.radiothongkedotuoi_CheckedChanged);
            // 
            // RadioThongKePhongBan
            // 
            this.RadioThongKePhongBan.AutoSize = true;
            this.RadioThongKePhongBan.BackColor = System.Drawing.Color.Transparent;
            this.RadioThongKePhongBan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioThongKePhongBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RadioThongKePhongBan.Location = new System.Drawing.Point(32, 181);
            this.RadioThongKePhongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioThongKePhongBan.Name = "RadioThongKePhongBan";
            this.RadioThongKePhongBan.Size = new System.Drawing.Size(162, 20);
            this.RadioThongKePhongBan.TabIndex = 146;
            this.RadioThongKePhongBan.Text = "Thống kê theo năm";
            this.RadioThongKePhongBan.UseVisualStyleBackColor = false;
            this.RadioThongKePhongBan.CheckedChanged += new System.EventHandler(this.RadioThongKePhongBan_CheckedChanged);
            // 
            // cbxgioitinh
            // 
            this.cbxgioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgioitinh.FormattingEnabled = true;
            this.cbxgioitinh.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxgioitinh.Location = new System.Drawing.Point(275, 358);
            this.cbxgioitinh.Name = "cbxgioitinh";
            this.cbxgioitinh.Size = new System.Drawing.Size(269, 27);
            this.cbxgioitinh.TabIndex = 163;
            // 
            // comboNhapNam
            // 
            this.comboNhapNam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNhapNam.FormattingEnabled = true;
            this.comboNhapNam.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboNhapNam.Location = new System.Drawing.Point(275, 317);
            this.comboNhapNam.Name = "comboNhapNam";
            this.comboNhapNam.Size = new System.Drawing.Size(269, 27);
            this.comboNhapNam.TabIndex = 162;
            // 
            // RadioThongKeKhachHang
            // 
            this.RadioThongKeKhachHang.AutoSize = true;
            this.RadioThongKeKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.RadioThongKeKhachHang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioThongKeKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RadioThongKeKhachHang.Location = new System.Drawing.Point(32, 365);
            this.RadioThongKeKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioThongKeKhachHang.Name = "RadioThongKeKhachHang";
            this.RadioThongKeKhachHang.Size = new System.Drawing.Size(173, 20);
            this.RadioThongKeKhachHang.TabIndex = 161;
            this.RadioThongKeKhachHang.Text = "Thống kê theo tháng";
            this.RadioThongKeKhachHang.UseVisualStyleBackColor = false;
            this.RadioThongKeKhachHang.CheckedChanged += new System.EventHandler(this.RadioThongKeKhachHang_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(32, 324);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(162, 20);
            this.radioButton2.TabIndex = 160;
            this.radioButton2.Text = "Thống kê theo năm";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(548, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 164;
            this.label1.Text = "Thống kê theo các mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(224, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 165;
            this.label2.Text = "Thống kê phiếu xuất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(224, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 166;
            this.label3.Text = "Thống kê phiếu nhập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 48);
            this.button1.TabIndex = 167;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxgioitinh);
            this.Controls.Add(this.comboNhapNam);
            this.Controls.Add(this.RadioThongKeKhachHang);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.combodotuoi);
            this.Controls.Add(this.cbxphongban);
            this.Controls.Add(this.cbxchucvu);
            this.Controls.Add(this.RadioThongkeNCC);
            this.Controls.Add(this.radiothongkedotuoi);
            this.Controls.Add(this.RadioThongKePhongBan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1189, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combodotuoi;
        private System.Windows.Forms.ComboBox cbxphongban;
        private System.Windows.Forms.ComboBox cbxchucvu;
        private System.Windows.Forms.RadioButton RadioThongkeNCC;
        private System.Windows.Forms.RadioButton radiothongkedotuoi;
        private System.Windows.Forms.RadioButton RadioThongKePhongBan;
        private System.Windows.Forms.ComboBox cbxgioitinh;
        private System.Windows.Forms.ComboBox comboNhapNam;
        private System.Windows.Forms.RadioButton RadioThongKeKhachHang;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
