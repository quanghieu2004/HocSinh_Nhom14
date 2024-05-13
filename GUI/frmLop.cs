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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            KhoiLopBUS.Instance.HienThiComboBox(cmbKhoiLop);
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            GiaoVienBUS.Instance.HienThiComboBox(cmbGiaoVien);

            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoiLop);
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
            GiaoVienBUS.Instance.HienThiDgvCmbCol(colMaGiaoVien);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorLop.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["MaLop"] = "";
            dataRow["TenLop"] = "";
            dataRow["MaKhoiLop"] = "";
            dataRow["MaNamHoc"] = "";
            dataRow["SiSo"] = 0;
            dataRow["MaGiaoVien"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorLop.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaLop", "colTenLop", "colMaKhoiLop", "colMaNamHoc", "colMaGiaoVien" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvLop, colNames) &&
                KiemTraTruocKhiLuu.KiemTraSiSo(dgvLop, "colSiSo"))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorLop.BindingSource;
                LopBUS.Instance.CapNhatLop((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopHoc.Text) ||
                string.IsNullOrWhiteSpace(txtTenLopHoc.Text) ||
                cmbKhoiLop.SelectedValue == null ||
                cmbNamHoc.SelectedValue == null ||
                cmbGiaoVien.SelectedValue == null
                )
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else
            {
                LopDTO lop = new LopDTO(
                    txtMaLopHoc.Text,
                    txtTenLopHoc.Text,
                    cmbKhoiLop.SelectedValue.ToString(),
                    cmbNamHoc.SelectedValue.ToString(),
                    txtSiSo.Text,
                    cmbGiaoVien.SelectedValue.ToString()
                );
                LopBUS.Instance.ThemLop(lop);
            }
        }

        private void btnThemKhoiLop_Click(object sender, EventArgs e)
        {
            frmKhoiLop fkl = new frmKhoiLop();
            fkl.Show();
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            frmNamHoc fnh = new frmNamHoc();
            fnh.Show();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            frmGiaoVien fgv = new frmGiaoVien();
            fgv.Show();
        }
    }
}
