using BUS;
using DTO;
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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            DanTocBUS.Instance.HienThiComboBox(cmbDanToc);
            TonGiaoBUS.Instance.HienThiComboBox(cmbTonGiao);
            DanTocBUS.Instance.HienThiDgvCmbCol(colMaDanToc);
            TonGiaoBUS.Instance.HienThiDgvCmbCol(colMaTonGiao);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorHocSinh.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            string stt = Utilities.LaySTT(dgvHocSinh.Rows.Count + 1);
            dataRow["MaHocSinh"] = "HS" + stt;
            dataRow["HoTen"] = "";
            dataRow["GioiTinh"] = false;
            dataRow["DiaChi"] = "";
            dataRow["MaDanToc"] = "";
            dataRow["MaTonGiao"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorHocSinh.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = {
                "colMaHocSinh",
                "colHoTen",
                "colDiaChi",
                "colMaDanToc",
                "colMaTonGiao"
            };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHocSinh, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHocSinh.BindingSource;
                HocSinhBUS.Instance.CapNhatHocSinh((DataTable)bindingSource.DataSource);

                MessageBox.Show("Dữ liệu đã được lưu vào CSDL","Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc fdt = new frmDanToc();
            fdt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTonGiao ftg = new frmTonGiao();
            ftg.Show();
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (ckbGTinhNu.Checked) gioiTinh = true;

            if (string.IsNullOrWhiteSpace(txtMaHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtTenHocSinh.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) || 
                cmbDanToc.SelectedValue == null ||
                cmbTonGiao.SelectedValue == null)
                MessageBox.Show("Giá trị của các ô không được rỗng !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
        }
    }
}
