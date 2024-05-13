using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        String tentaikhoan = "hieu";
        String matkhau = "123456";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNHap_Click(object sender, EventArgs e)
        {
            if (kiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
            }
            
        }

        private bool kiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if(tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
    }
}
