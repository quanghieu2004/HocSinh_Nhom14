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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanToc fdt = new frmDanToc();
            fdt.MdiParent = this;
            fdt.Show();
        }

        private void tônGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTonGiao ftg = new frmTonGiao();
            ftg.MdiParent = this;
            ftg.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc fmh = new frmMonHoc();
            fmh.MdiParent = this;
            fmh.Show();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQua fkq = new frmKetQua();
            fkq.MdiParent = this;
            fkq.Show();
        }

        private void họcLựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocLuc fhl = new frmHocLuc();
            fhl.MdiParent = this;
            fhl.Show();
        }

        private void hạnhKiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHanhKiem fhk = new frmHanhKiem();
            fhk.MdiParent = this;
            fhk.Show();
        }

        private void họcKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocKy fkhy = new frmHocKy();
            fkhy.MdiParent = this;
            fkhy.Show();
        }

        private void nămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNamHoc fnh = new frmNamHoc();
            fnh.MdiParent = this;
            fnh.Show();
        }

        private void khốiLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoiLop fkl = new frmKhoiLop();
            fkl.MdiParent = this;
            fkl.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien fgv = new frmGiaoVien();
            fgv.MdiParent = this;
            fgv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocSinh fhs = new frmHocSinh();
            fhs.MdiParent = this;
            fhs.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop fl = new frmLop();
            fl.MdiParent = this;
            fl.Show();
        }
    }
}
