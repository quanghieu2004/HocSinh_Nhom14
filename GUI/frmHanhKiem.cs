using BUS;
using QuanLyHocSinh;
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
    public partial class frmHanhKiem : Form
    {
        public frmHanhKiem()
        {
            InitializeComponent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaHanhKiem", "colTenHanhKiem" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHanhKiem, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHanhKiem.BindingSource;
                HanhKiemBUS.Instance.CapNhatHanhKiem((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            HanhKiemBUS.Instance.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem);
        }
    }
}
