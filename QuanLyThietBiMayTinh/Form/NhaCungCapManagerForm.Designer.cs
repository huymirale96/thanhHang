namespace QuanLyThietBiMayTinh
{
    partial class NhaCungCapManagerForm
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
            this.pnFunction = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.sMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnFunction.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 54);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // pnFunction
            // 
            this.pnFunction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnFunction.Controls.Add(this.btnOK);
            this.pnFunction.Controls.Add(this.txtSDT);
            this.pnFunction.Controls.Add(this.txtDiaChi);
            this.pnFunction.Controls.Add(this.txtTen);
            this.pnFunction.Controls.Add(this.txtMa);
            this.pnFunction.Controls.Add(this.label6);
            this.pnFunction.Controls.Add(this.label5);
            this.pnFunction.Controls.Add(this.label4);
            this.pnFunction.Controls.Add(this.lbMaNhanVien);
            this.pnFunction.Controls.Add(this.lbTitle);
            this.pnFunction.Location = new System.Drawing.Point(148, 310);
            this.pnFunction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnFunction.Name = "pnFunction";
            this.pnFunction.Size = new System.Drawing.Size(789, 227);
            this.pnFunction.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(350, 169);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 34);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Chức năng";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(304, 127);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 20);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(304, 97);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(185, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(304, 63);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(185, 20);
            this.txtTen.TabIndex = 6;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(304, 33);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(185, 20);
            this.txtMa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên NCC";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Location = new System.Drawing.Point(229, 37);
            this.lbMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(47, 13);
            this.lbMaNhanVien.TabIndex = 1;
            this.lbMaNhanVien.Text = "Mã NCC";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(14, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(117, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Chức năng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.gridview);
            this.panel2.Location = new System.Drawing.Point(148, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 241);
            this.panel2.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(691, 411);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 19);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNhanVien,
            this.sTenNhanVien,
            this.sDiaChi,
            this.sSoDienThoai});
            this.gridview.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridview.Location = new System.Drawing.Point(2, 2);
            this.gridview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridview.Name = "gridview";
            this.gridview.RowTemplate.Height = 24;
            this.gridview.Size = new System.Drawing.Size(784, 236);
            this.gridview.TabIndex = 0;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            // 
            // sMaNhanVien
            // 
            this.sMaNhanVien.DataPropertyName = "sMaNCC";
            this.sMaNhanVien.HeaderText = "Mã NCC";
            this.sMaNhanVien.Name = "sMaNhanVien";
            // 
            // sTenNhanVien
            // 
            this.sTenNhanVien.DataPropertyName = "sTenNCC";
            this.sTenNhanVien.HeaderText = "Tên NCC";
            this.sTenNhanVien.Name = "sTenNhanVien";
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
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel.Controls.Add(this.btnPrint);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnSearchNV);
            this.panel.Controls.Add(this.btnDeleteNV);
            this.panel.Controls.Add(this.btnEditNV);
            this.panel.Controls.Add(this.btnAddNV);
            this.panel.Location = new System.Drawing.Point(9, 68);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(135, 469);
            this.panel.TabIndex = 6;
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
            this.btnPrint.Location = new System.Drawing.Point(0, 388);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnPrint.Size = new System.Drawing.Size(135, 81);
            this.btnPrint.TabIndex = 10;
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
            this.btnBack.Location = new System.Drawing.Point(0, 318);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnBack.Size = new System.Drawing.Size(135, 81);
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
            this.btnSearchNV.Location = new System.Drawing.Point(0, 242);
            this.btnSearchNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSearchNV.Size = new System.Drawing.Size(135, 81);
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
            this.btnDeleteNV.Location = new System.Drawing.Point(0, 160);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(135, 81);
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
            this.btnEditNV.Location = new System.Drawing.Point(0, 79);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnEditNV.Size = new System.Drawing.Size(135, 81);
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
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAddNV.Size = new System.Drawing.Size(135, 81);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Add";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // NhaCungCapManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnFunction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(964, 592);
            this.Name = "NhaCungCapManagerForm";
            this.Text = "NhaCungCapManagerForm";
            this.Load += new System.EventHandler(this.NhaCungCapManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnFunction.ResumeLayout(false);
            this.pnFunction.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnFunction;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoDienThoai;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnPrint;
    }
}