using QuanLiHocSinh.GUI;
using System;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public partial class fHome : Form
    {
        private const DockStyle fill = DockStyle.Fill;

        public fHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fHome fh = new fHome();
            fh.Show();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            fDiem fd = new fDiem();
            fd.TopLevel = false;
            panel3.Controls.Add(fd);
            fd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fd.Dock = DockStyle.Fill;
            fd.Show();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            fMonHoc fm = new fMonHoc();
            fm.TopLevel = false;
            panel3.Controls.Add(fm);
            fm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHanhKiem fk = new fHanhKiem();
            fk.TopLevel = false;
            panel3.Controls.Add(fk);
            fk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fk.Dock = DockStyle.Fill;
            fk.Show();
        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {
            fHocLuc fhl = new fHocLuc();
            fhl.TopLevel = false;
            panel3.Controls.Add(fhl);
            fhl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fhl.Dock = DockStyle.Fill;
            fhl.Show();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            fKetQua fkq = new fKetQua();
            fkq.TopLevel = false;
            panel3.Controls.Add(fkq);
            fkq.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fkq.Dock = DockStyle.Fill;
            fkq.Show();
        }

        private void btnHS_Click(object sender, EventArgs e)
        {
            fHocSinh fhs = new fHocSinh();
            fhs.TopLevel = false;
            panel3.Controls.Add(fhs);
            fhs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fhs.Dock = DockStyle.Fill;
            fhs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fGiaoVien fgv = new fGiaoVien();
            fgv.TopLevel = false;
            panel3.Controls.Add(fgv);
            fgv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fgv.Dock = DockStyle.Fill;
            fgv.Show();
        }
    }
}
