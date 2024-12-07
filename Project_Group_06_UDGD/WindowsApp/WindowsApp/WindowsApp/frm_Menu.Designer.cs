﻿namespace WindowsApp
{
    partial class frm_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_khuyenmai = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_quydinh = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashBoard1 = new WindowsApp.AdminDashBoard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(-1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = " SHOE SALES MANAGEMENT SYSTEM";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1119, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(48, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.btn_khuyenmai);
            this.panel2.Controls.Add(this.btn_nhanvien);
            this.panel2.Controls.Add(this.btn_baocao);
            this.panel2.Controls.Add(this.btn_quydinh);
            this.panel2.Controls.Add(this.btn_dangxuat);
            this.panel2.Controls.Add(this.btn_khachhang);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 706);
            this.panel2.TabIndex = 1;
            // 
            // btn_khuyenmai
            // 
            this.btn_khuyenmai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_khuyenmai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_khuyenmai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khuyenmai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khuyenmai.ForeColor = System.Drawing.Color.White;
            this.btn_khuyenmai.Location = new System.Drawing.Point(6, 394);
            this.btn_khuyenmai.Name = "btn_khuyenmai";
            this.btn_khuyenmai.Size = new System.Drawing.Size(220, 40);
            this.btn_khuyenmai.TabIndex = 20;
            this.btn_khuyenmai.Text = "Khuyến Mãi";
            this.btn_khuyenmai.UseVisualStyleBackColor = true;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_nhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanvien.Location = new System.Drawing.Point(6, 348);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(220, 40);
            this.btn_nhanvien.TabIndex = 19;
            this.btn_nhanvien.Text = "Nhân Viên";
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_baocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_baocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baocao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocao.ForeColor = System.Drawing.Color.White;
            this.btn_baocao.Location = new System.Drawing.Point(121, 440);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(105, 40);
            this.btn_baocao.TabIndex = 18;
            this.btn_baocao.Text = "Báo Cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            // 
            // btn_quydinh
            // 
            this.btn_quydinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_quydinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_quydinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quydinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quydinh.ForeColor = System.Drawing.Color.White;
            this.btn_quydinh.Location = new System.Drawing.Point(6, 440);
            this.btn_quydinh.Name = "btn_quydinh";
            this.btn_quydinh.Size = new System.Drawing.Size(109, 40);
            this.btn_quydinh.TabIndex = 17;
            this.btn_quydinh.Text = "Quy Định";
            this.btn_quydinh.UseVisualStyleBackColor = true;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_dangxuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.White;
            this.btn_dangxuat.Location = new System.Drawing.Point(6, 637);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(220, 40);
            this.btn_dangxuat.TabIndex = 16;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_khachhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.ForeColor = System.Drawing.Color.White;
            this.btn_khachhang.Location = new System.Drawing.Point(6, 302);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(220, 40);
            this.btn_khachhang.TabIndex = 14;
            this.btn_khachhang.Text = "Khách Hàng";
            this.btn_khachhang.UseVisualStyleBackColor = true;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(6, 256);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(220, 40);
            this.btn_dashboard.TabIndex = 10;
            this.btn_dashboard.Text = "MENU Điều Khiển";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHOP GIÀY 06";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.press_break_pedal;
            this.pictureBox1.Location = new System.Drawing.Point(29, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashBoard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(229, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 706);
            this.panel3.TabIndex = 2;
            // 
            // adminDashBoard1
            // 
            this.adminDashBoard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashBoard1.Name = "adminDashBoard1";
            this.adminDashBoard1.Size = new System.Drawing.Size(950, 706);
            this.adminDashBoard1.TabIndex = 0;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 751);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.Text = "frm_Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_quydinh;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_khuyenmai;
        private AdminDashBoard adminDashBoard1;
    }
}