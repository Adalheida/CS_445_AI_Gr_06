namespace WindowsApp
{
    partial class frm_bills
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_chitiethd = new System.Windows.Forms.Button();
            this.groupService = new System.Windows.Forms.GroupBox();
            this.btn_cndonhang = new System.Windows.Forms.Button();
            this.txt_tratruoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_ngayxuathd = new System.Windows.Forms.DateTimePicker();
            this.txt_sdtkhach = new System.Windows.Forms.TextBox();
            this.txt_khachhang = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.txt_masanpham = new System.Windows.Forms.TextBox();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_dataorders = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.txt_conlai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupService.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dataorders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dong);
            this.groupBox2.Controls.Add(this.btn_chitiethd);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(10, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 83);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_dong.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.White;
            this.btn_dong.Location = new System.Drawing.Point(216, 28);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(186, 37);
            this.btn_dong.TabIndex = 38;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_chitiethd
            // 
            this.btn_chitiethd.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_chitiethd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_chitiethd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_chitiethd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_chitiethd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiethd.ForeColor = System.Drawing.Color.White;
            this.btn_chitiethd.Location = new System.Drawing.Point(6, 28);
            this.btn_chitiethd.Name = "btn_chitiethd";
            this.btn_chitiethd.Size = new System.Drawing.Size(204, 37);
            this.btn_chitiethd.TabIndex = 66;
            this.btn_chitiethd.Text = "Chi Tiết Hóa Đơn";
            this.btn_chitiethd.UseVisualStyleBackColor = false;
            this.btn_chitiethd.Click += new System.EventHandler(this.btn_chitiethd_Click);
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.txt_conlai);
            this.groupService.Controls.Add(this.label8);
            this.groupService.Controls.Add(this.btn_cndonhang);
            this.groupService.Controls.Add(this.txt_tratruoc);
            this.groupService.Controls.Add(this.label7);
            this.groupService.Controls.Add(this.date_ngayxuathd);
            this.groupService.Controls.Add(this.txt_sdtkhach);
            this.groupService.Controls.Add(this.txt_khachhang);
            this.groupService.Controls.Add(this.txt_thanhtien);
            this.groupService.Controls.Add(this.cb_trangthai);
            this.groupService.Controls.Add(this.txt_masanpham);
            this.groupService.Controls.Add(this.txt_manhanvien);
            this.groupService.Controls.Add(this.txt_mahoadon);
            this.groupService.Controls.Add(this.label3);
            this.groupService.Controls.Add(this.label2);
            this.groupService.Controls.Add(this.label1);
            this.groupService.Controls.Add(this.label4);
            this.groupService.Controls.Add(this.label16);
            this.groupService.Controls.Add(this.label15);
            this.groupService.Controls.Add(this.label13);
            this.groupService.Controls.Add(this.label20);
            this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupService.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupService.Location = new System.Drawing.Point(12, 57);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(406, 388);
            this.groupService.TabIndex = 62;
            this.groupService.TabStop = false;
            this.groupService.Text = "Thông tin hoá đơn";
            // 
            // btn_cndonhang
            // 
            this.btn_cndonhang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_cndonhang.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_cndonhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_cndonhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_cndonhang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cndonhang.ForeColor = System.Drawing.Color.White;
            this.btn_cndonhang.Location = new System.Drawing.Point(104, 324);
            this.btn_cndonhang.Name = "btn_cndonhang";
            this.btn_cndonhang.Size = new System.Drawing.Size(164, 37);
            this.btn_cndonhang.TabIndex = 70;
            this.btn_cndonhang.Text = "Xác nhận";
            this.btn_cndonhang.UseVisualStyleBackColor = false;
            this.btn_cndonhang.Click += new System.EventHandler(this.btn_cndonhang_Click);
            // 
            // txt_tratruoc
            // 
            this.txt_tratruoc.Location = new System.Drawing.Point(214, 218);
            this.txt_tratruoc.Name = "txt_tratruoc";
            this.txt_tratruoc.Size = new System.Drawing.Size(163, 29);
            this.txt_tratruoc.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(210, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Số Tiền Đã Trả Trước:";
            // 
            // date_ngayxuathd
            // 
            this.date_ngayxuathd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayxuathd.Location = new System.Drawing.Point(15, 218);
            this.date_ngayxuathd.Name = "date_ngayxuathd";
            this.date_ngayxuathd.Size = new System.Drawing.Size(163, 29);
            this.date_ngayxuathd.TabIndex = 79;
            // 
            // txt_sdtkhach
            // 
            this.txt_sdtkhach.Location = new System.Drawing.Point(214, 105);
            this.txt_sdtkhach.Name = "txt_sdtkhach";
            this.txt_sdtkhach.Size = new System.Drawing.Size(163, 29);
            this.txt_sdtkhach.TabIndex = 78;
            // 
            // txt_khachhang
            // 
            this.txt_khachhang.Location = new System.Drawing.Point(214, 48);
            this.txt_khachhang.Name = "txt_khachhang";
            this.txt_khachhang.Size = new System.Drawing.Size(163, 29);
            this.txt_khachhang.TabIndex = 77;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(215, 159);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(163, 29);
            this.txt_thanhtien.TabIndex = 76;
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(15, 276);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(164, 29);
            this.cb_trangthai.TabIndex = 74;
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(15, 159);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(163, 29);
            this.txt_masanpham.TabIndex = 72;
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(15, 105);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(163, 29);
            this.txt_manhanvien.TabIndex = 71;
            this.txt_manhanvien.Text = "Nhân viên 01";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(15, 48);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(163, 29);
            this.txt_mahoadon.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(210, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Thành tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(210, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(11, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Trạng Thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(11, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ngày Xuất Hóa Đơn:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SeaGreen;
            this.label16.Location = new System.Drawing.Point(11, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã hoá đơn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SeaGreen;
            this.label15.Location = new System.Drawing.Point(11, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Mã Nhân Viên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(210, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Tên Khách Hàng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SeaGreen;
            this.label20.Location = new System.Drawing.Point(11, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 20);
            this.label20.TabIndex = 58;
            this.label20.Text = "Mã Sản Phẩm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_capnhap);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(7, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 109);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(11, 62);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(271, 29);
            this.txt_timkiem.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Mã Hóa Đơn";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_timkiem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.Location = new System.Drawing.Point(288, 56);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(110, 37);
            this.btn_timkiem.TabIndex = 67;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_dataorders);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(424, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 564);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hoá Đơn";
            // 
            // grid_dataorders
            // 
            this.grid_dataorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dataorders.Location = new System.Drawing.Point(7, 182);
            this.grid_dataorders.Name = "grid_dataorders";
            this.grid_dataorders.Size = new System.Drawing.Size(762, 376);
            this.grid_dataorders.TabIndex = 30;
            this.grid_dataorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dataorders_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 37);
            this.label6.TabIndex = 65;
            this.label6.Text = "QUẢN LÝ HÓA ĐƠN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_capnhap
            // 
            this.btn_capnhap.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_capnhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_capnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_capnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_capnhap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhap.ForeColor = System.Drawing.Color.White;
            this.btn_capnhap.Location = new System.Drawing.Point(395, 56);
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.Size = new System.Drawing.Size(128, 37);
            this.btn_capnhap.TabIndex = 70;
            this.btn_capnhap.Text = "Cập Nhập";
            this.btn_capnhap.UseVisualStyleBackColor = false;
            this.btn_capnhap.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_conlai
            // 
            this.txt_conlai.Location = new System.Drawing.Point(215, 276);
            this.txt_conlai.Name = "txt_conlai";
            this.txt_conlai.Size = new System.Drawing.Size(163, 29);
            this.txt_conlai.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(210, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Số Tiền Còn lại Phải Trả:";
            // 
            // frm_bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_bills";
            this.Text = "0";
            this.Load += new System.EventHandler(this.frm_bills_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupService.ResumeLayout(false);
            this.groupService.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dataorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_dataorders;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_chitiethd;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.TextBox txt_masanpham;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tratruoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_ngayxuathd;
        private System.Windows.Forms.TextBox txt_sdtkhach;
        private System.Windows.Forms.TextBox txt_khachhang;
        private System.Windows.Forms.Button btn_capnhap;
        private System.Windows.Forms.Button btn_cndonhang;
        private System.Windows.Forms.TextBox txt_conlai;
        private System.Windows.Forms.Label label8;
    }
}