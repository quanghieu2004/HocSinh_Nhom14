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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            KetQuaBUS.Instance.HienThi(dgvKetQua, bindingNavigatorKetQua);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaKetQua", "colTenKetQua" };

            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvKetQua, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorKetQua.BindingSource;
                KetQuaBUS.Instance.CapNhatKetQua((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
