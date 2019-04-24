using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh
{
    public partial class ManagerForm2 : Form
    {
        public ManagerForm2()
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
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nhanVienManagerForm = searchOpenedForm("NhanVienManagerForm");
            if (nhanVienManagerForm == null)
            {
                nhanVienManagerForm = new NhanVienManagerForm();
            }
            nhanVienManagerForm.MdiParent = this;
            nhanVienManagerForm.Show();
            nhanVienManagerForm.Activate();
        }

        private void nhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("NhomHangManagerForm");
            if (form == null)
            {
                form = new NhomHangManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = searchOpenedForm("HangHoaManagerForm");
            if (form == null)
            {
                form = new HangHoaManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void hàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = searchOpenedForm("HangNhapManagerForm");
            if (form == null)
            {
                form = new HangNhapManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void hàngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = searchOpenedForm("HangBanManagerForm");
            if (form == null)
            {
                form = new HangBanManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = searchOpenedForm("HoaDonNhapManagerForm");
            if (form == null)
            {
                form = new HoaDonNhapHangManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void hóaĐơnXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HoaDonXuatManagerForm");
            if (form == null)
            {
                form = new HoaDonXuatManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = searchOpenedForm("NhaCungCapManagerForm");
            if (form == null)
            {
                form = new NhaCungCapManagerForm();
            }
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }
    }
}
