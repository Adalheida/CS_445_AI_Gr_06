namespace WindowsApp
{
    partial class frm_search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_loaigiay = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tengiay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_mausac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_datasearch = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_dong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datasearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dong);
            this.groupBox1.Controls.Add(this.cb_loaigiay);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.txt_tengiay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_size);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_mausac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_brand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Tìm Kiếm";
            // 
            // cb_loaigiay
            // 
            this.cb_loaigiay.FormattingEnabled = true;
            this.cb_loaigiay.Location = new System.Drawing.Point(258, 58);
            this.cb_loaigiay.Name = "cb_loaigiay";
            this.cb_loaigiay.Size = new System.Drawing.Size(236, 33);
            this.cb_loaigiay.TabIndex = 38;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_them.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(388, 190);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 37);
            this.btn_them.TabIndex = 33;
            this.btn_them.Text = "Đặt Hàng";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_timkiem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.Location = new System.Drawing.Point(522, 190);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(130, 37);
            this.btn_timkiem.TabIndex = 34;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_tengiay
            // 
            this.txt_tengiay.Location = new System.Drawing.Point(11, 58);
            this.txt_tengiay.Name = "txt_tengiay";
            this.txt_tengiay.Size = new System.Drawing.Size(236, 33);
            this.txt_tengiay.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên Giày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(253, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Loại Giày";
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(258, 122);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(149, 33);
            this.cb_size.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(253, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Size";
            // 
            // cb_mausac
            // 
            this.cb_mausac.FormattingEnabled = true;
            this.cb_mausac.Location = new System.Drawing.Point(505, 57);
            this.cb_mausac.Name = "cb_mausac";
            this.cb_mausac.Size = new System.Drawing.Size(149, 33);
            this.cb_mausac.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(500, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Màu Sắc";
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(11, 122);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(236, 33);
            this.cb_brand.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "BRAND Giày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grid_datasearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 320);
            this.panel2.TabIndex = 20;
            // 
            // grid_datasearch
            // 
            this.grid_datasearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_datasearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_datasearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_datasearch.Location = new System.Drawing.Point(27, 51);
            this.grid_datasearch.Name = "grid_datasearch";
            this.grid_datasearch.RowHeadersVisible = false;
            this.grid_datasearch.Size = new System.Drawing.Size(744, 235);
            this.grid_datasearch.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(22, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "DATA PRODUCTS";
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_dong.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.White;
            this.btn_dong.Location = new System.Drawing.Point(658, 190);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(130, 37);
            this.btn_dong.TabIndex = 38;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click_1);
            // 
            // frm_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_search";
            this.Text = "frm_search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_datasearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_loaigiay;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tengiay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_mausac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_datasearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_dong;
    }
}