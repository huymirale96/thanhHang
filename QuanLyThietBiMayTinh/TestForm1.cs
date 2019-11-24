using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyThietBiMayTinh
{
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {
            InitializeComponent();
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("test", cnn);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            ctrForTestForm report = new ctrForTestForm();
            report.SetDataSource(dt);
            //TestForm1 reportForm = new TestForm1();
           crystalReportViewer1.ReportSource = report;
            //reportForm.ShowDialog();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
