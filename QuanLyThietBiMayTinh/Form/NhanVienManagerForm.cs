using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh//
{
    public partial class NhanVienManagerForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sqlGetAllNhanVien = "sp_GettAllNhanVien";
        private string sqlAddNhanVien = "sp_AddNhanVien";
        private string sqlDeleteNhanVien = "sp_DeleteNhanVien";
        private string sqlEditNhanVien = "sp_EditNhanVien";


        public NhanVienManagerForm()
        {
            InitializeComponent();
        }

        private Form searchOpenedForm(String formName)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formName))
                {
                    return f;
                }
            }
            return null;
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            
            pnChucNang.Visible = true;
            btnOK.Text = "Thêm";
            lbTitle.Text = "Thêm nhân viên";

            lbGioiTinh.Enabled = true;
            lbNgaySinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            pnGT.Enabled = true;

            txtMaNV.Enabled = true;
            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;


        }

        public DataTable getAllNV()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlGetAllNhanVien, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblNhanVien");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
        }

        public void showAllNhanVien ()
        {
            DataTable dt = getAllNV();
            dt.Columns.Add("GT", typeof(String));
            foreach (DataRow row in dt.Rows)
            {
                //MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?",""+ row["bGioiTinh"].ToString(),MessageBoxButtons.OK);
                if (row["bGioiTinh"].ToString() == "True")

                {
                    row["GT"] = "Nam";
                }
                else
                {
                    row["GT"] = "Nu";
                }
            }
            dt.Columns.Remove("bGioiTinh");
            dataGridView1.DataSource = dt;
            grQuanLyNhanVien.AutoGenerateColumns = false;
            grQuanLyNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grQuanLyNhanVien.DataSource = dt;
        }

        private void NhanVienManagerForm_Load(object sender, EventArgs e)
        {
            showAllNhanVien();
            pnChucNang.Visible = false;
            rbNam.Checked = true;
            grQuanLyNhanVien.Visible = false;
        }

    

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            pnChucNang.Visible = false;
            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;

            DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
            DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
            string manv = row["sMaNhanVien"].ToString();

            DialogResult dr;
            dr = MessageBox.Show(string.Format("Bạn có muốn xóa {0} không ?", row["sTenNhanVien"].ToString()),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlDeleteNhanVien, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showAllNhanVien();
            }
            
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {

            pnChucNang.Visible = true;

            txtMaNV.Enabled = false;
            btnOK.Text = "Sửa";
            lbTitle.Text = "Sửa thông tin nhân viên";

            lbGioiTinh.Enabled = true;
            lbNgaySinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            pnGT.Enabled = true;

            DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
            DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
            txtMaNV.Text = row["sMaNhanVien"].ToString();
            txtDiaChi.Text= row["sDiaChi"].ToString();
            txtHoTenNV.Text= row["sTenNhanVien"].ToString();
            txtSDT.Text= row["sSoDienThoai"].ToString();

        }
      
        
    
        private void btnSearchNV_Click(object sender, EventArgs e)
        {

            pnChucNang.Visible = true;

            lbGioiTinh.Enabled = false;
            lbNgaySinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            pnGT.Enabled = false;
            txtMaNV.Enabled = true;
            lbTitle.Text = "Tìm kiếm";
            btnOK.Text= "Tìm kiếm";

            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int gt = 0;
            DateTime ngaySinh;

            switch (btnOK.Text)
            {
                case "Tìm kiếm":
                    string filter = "1=1";

                    if (txtMaNV.Text != string.Empty)
                    {
                        filter += string.Format(" AND sMaNhanVien LIKE '%{0}%'", txtMaNV.Text);
                    }
                    if (txtHoTenNV.Text != string.Empty)
                    {
                        filter += string.Format(" AND sTenNhanVien LIKE '%{0}%'", txtHoTenNV.Text);
                    }
                    if (txtDiaChi.Text != string.Empty)
                    {
                        filter += string.Format(" AND sDiaChi LIKE '%{0}%'", txtDiaChi.Text);
                    }
                    if (txtSDT.Text != string.Empty)
                    {
                        filter += string.Format(" AND sSoDienThoai LIKE '%{0}%'", txtSDT.Text);
                    }
                    hienNV(filter);
                    break;
                case "Sửa":
                    DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
                    DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
                    string manv = row["sMaNhanVien"].ToString();

                    if (rbNam.Checked == true)
                    {
                        gt = 1;
                    }
                    else gt = 0;

                    ngaySinh = dateNgaySinh.Value.Date;
                    NhanVienManagerForm f = new NhanVienManagerForm();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlEditNhanVien, conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sMaNV", manv);
                            cmd.Parameters.AddWithValue("@sTenNV", txtHoTenNV.Text);
                            cmd.Parameters.AddWithValue("@bGioiTinh", gt);
                            cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sSoDienThoai", txtSDT.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }////sdasđđay rồi
                    }

                    showAllNhanVien();
                    break;

                case "Thêm": //cau1
                             //if (txtMaNV.Text != "" && txtDiaChi.Text != "" && txtHoTenNV.Text != "" && txtSDT.Text != "") 
                             //{
                    if (rbNam.Checked == true)
                    {
                        gt = 1;
                    }
                    else gt = 0;

                    ngaySinh = dateNgaySinh.Value.Date;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlAddNhanVien, conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sMaNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@sTenNV", txtHoTenNV.Text);
                            cmd.Parameters.AddWithValue("@bGioiTinh", gt);
                            cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sSoDienThoai", txtSDT.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Thông Báo ?","Phải nhập đủ", MessageBoxButtons.OK);
                        //}
                        showAllNhanVien();
                        break;
                    }
            }
        }
        private void hienNV(string filter)
        {
           
            DataTable dt = getAllNV();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            grQuanLyNhanVien.AutoGenerateColumns = false;
            grQuanLyNhanVien.DataSource = dv;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnChucNang.Visible = false;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn trở về không ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = getAllNV();
            cau3_1 report = new cau3_1();
            report.SetDataSource(dt);
            ReportForm reportForm = new ReportForm();
            reportForm.rpt.ReportSource = report;
            reportForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void grQuanLyNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Giới Tính")
            {
                e.Value = (bool)e.Value ? "MY_TEXT_FOR_TRUE" : "MY_TEXT_FOR_FALSE";
                e.FormattingApplied = true;
            }
        }
    }
}
