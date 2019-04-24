﻿namespace QuanLyThietBiMayTinh
{
    partial class NhanVienManagerForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grQuanLyNhanVien = new System.Windows.Forms.DataGridView();
            this.sMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnGT = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQuanLyNhanVien)).BeginInit();
            this.pnChucNang.SuspendLayout();
            this.pnGT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel.Controls.Add(this.btnPrint);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnSearchNV);
            this.panel.Controls.Add(this.btnDeleteNV);
            this.panel.Controls.Add(this.btnEditNV);
            this.panel.Controls.Add(this.btnAddNV);
            this.panel.Location = new System.Drawing.Point(12, 84);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(180, 577);
            this.panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.grQuanLyNhanVien);
            this.panel2.Location = new System.Drawing.Point(198, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 346);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(921, 506);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // grQuanLyNhanVien
            // 
            this.grQuanLyNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grQuanLyNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNhanVien,
            this.sTenNhanVien,
            this.bGioiTinh,
            this.dNgaySinh,
            this.sDiaChi,
            this.sSoDienThoai});
            this.grQuanLyNhanVien.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grQuanLyNhanVien.Location = new System.Drawing.Point(3, 3);
            this.grQuanLyNhanVien.Name = "grQuanLyNhanVien";
            this.grQuanLyNhanVien.RowTemplate.Height = 24;
            this.grQuanLyNhanVien.Size = new System.Drawing.Size(1046, 340);
            this.grQuanLyNhanVien.TabIndex = 0;
            // 
            // sMaNhanVien
            // 
            this.sMaNhanVien.DataPropertyName = "sMaNhanVien";
            this.sMaNhanVien.HeaderText = "Mã nhân viên";
            this.sMaNhanVien.Name = "sMaNhanVien";
            // 
            // sTenNhanVien
            // 
            this.sTenNhanVien.DataPropertyName = "sTenNhanVien";
            this.sTenNhanVien.HeaderText = "Họ tên";
            this.sTenNhanVien.Name = "sTenNhanVien";
            // 
            // bGioiTinh
            // 
            this.bGioiTinh.DataPropertyName = "bGioiTinh";
            this.bGioiTinh.HeaderText = "Giới tính (nam)";
            this.bGioiTinh.Name = "bGioiTinh";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày sinh";
            this.dNgaySinh.Name = "dNgaySinh";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.Name = "sDiaChi";
            // 
            // sSoDienThoai
            // 
            this.sSoDienThoai.DataPropertyName = "sSoDienThoai";
            this.sSoDienThoai.HeaderText = "Số điện thoại";
            this.sSoDienThoai.Name = "sSoDienThoai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnChucNang.Controls.Add(this.btnOK);
            this.pnChucNang.Controls.Add(this.pnGT);
            this.pnChucNang.Controls.Add(this.dateNgaySinh);
            this.pnChucNang.Controls.Add(this.lbNgaySinh);
            this.pnChucNang.Controls.Add(this.lbGioiTinh);
            this.pnChucNang.Controls.Add(this.txtSDT);
            this.pnChucNang.Controls.Add(this.txtDiaChi);
            this.pnChucNang.Controls.Add(this.txtHoTenNV);
            this.pnChucNang.Controls.Add(this.txtMaNV);
            this.pnChucNang.Controls.Add(this.label6);
            this.pnChucNang.Controls.Add(this.label5);
            this.pnChucNang.Controls.Add(this.label4);
            this.pnChucNang.Controls.Add(this.lbMaNhanVien);
            this.pnChucNang.Controls.Add(this.lbTitle);
            this.pnChucNang.Location = new System.Drawing.Point(198, 436);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1052, 225);
            this.pnChucNang.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(509, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(286, 42);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Chức năng";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnGT
            // 
            this.pnGT.Controls.Add(this.rbNu);
            this.pnGT.Controls.Add(this.rbNam);
            this.pnGT.Location = new System.Drawing.Point(604, 48);
            this.pnGT.Name = "pnGT";
            this.pnGT.Size = new System.Drawing.Size(191, 29);
            this.pnGT.TabIndex = 14;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(123, 7);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 12;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(6, 7);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 11;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(604, 97);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(191, 22);
            this.dateNgaySinh.TabIndex = 13;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(506, 102);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(71, 17);
            this.lbNgaySinh.TabIndex = 10;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(506, 57);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(60, 17);
            this.lbGioiTinh.TabIndex = 9;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(217, 163);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(217, 126);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(217, 84);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(245, 22);
            this.txtHoTenNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(217, 48);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(245, 22);
            this.txtMaNV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ và tên";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Location = new System.Drawing.Point(117, 53);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(93, 17);
            this.lbMaNhanVien.TabIndex = 1;
            this.lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(19, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(152, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 66);
            this.panel1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Image = global::QuanLyThietBiMayTinh.Properties.Resources.Printer_New;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(0, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnPrint.Size = new System.Drawing.Size(180, 100);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Image = global::QuanLyThietBiMayTinh.Properties.Resources.action_export;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBack.Size = new System.Drawing.Size(180, 100);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNV.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchNV.Image = global::QuanLyThietBiMayTinh.Properties.Resources.search;
            this.btnSearchNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNV.Location = new System.Drawing.Point(0, 293);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSearchNV.Size = new System.Drawing.Size(180, 100);
            this.btnSearchNV.TabIndex = 3;
            this.btnSearchNV.Text = "Search";
            this.btnSearchNV.UseVisualStyleBackColor = false;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNV.Image = global::QuanLyThietBiMayTinh.Properties.Resources.delete2;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(0, 197);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(180, 100);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.Transparent;
            this.btnEditNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNV.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditNV.Image = global::QuanLyThietBiMayTinh.Properties.Resources.edit;
            this.btnEditNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNV.Location = new System.Drawing.Point(0, 97);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEditNV.Size = new System.Drawing.Size(180, 100);
            this.btnEditNV.TabIndex = 1;
            this.btnEditNV.Text = "Edit";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNV.Image = global::QuanLyThietBiMayTinh.Properties.Resources.add_icon;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(0, 0);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAddNV.Size = new System.Drawing.Size(180, 100);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Add";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // NhanVienManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "NhanVienManagerForm";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVienManagerForm_Load);
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grQuanLyNhanVien)).EndInit();
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.pnGT.ResumeLayout(false);
            this.pnGT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoDienThoai;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView grQuanLyNhanVien;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnGT;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
    }
}