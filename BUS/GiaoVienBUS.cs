using DAO;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private GiaoVienBUS() { }

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVienBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridView dataGridViewX,
            TextBox txtMaGiaoVien,
            TextBox txtTenGiaoVien,
            TextBox txtDiaChi,
            TextBox txtDienThoai,
            ComboBox cmbMonHoc)
        {
            bindingSource.DataSource = GiaoVienDAO.Instance.LayDanhSachGiaoVien();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            txtMaGiaoVien.DataBindings.Clear();
            txtMaGiaoVien.DataBindings.Add("Text", bindingSource, "MaGiaoVien");

            txtTenGiaoVien.DataBindings.Clear();
            txtTenGiaoVien.DataBindings.Add("Text", bindingSource, "TenGiaoVien");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai");

            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("SelectedValue", bindingSource, "MaMonHoc");
        }

        public void HienThiDgvCmbCol(object colMaGiaoVien)
        {
            throw new NotImplementedException();
        }

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = GiaoVienDAO.Instance.LayDanhSachGiaoVien();
            comboBox.DisplayMember = "TenGiaoVien";
            comboBox.ValueMember = "MaGiaoVien";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = GiaoVienDAO.Instance.LayDanhSachGiaoVien();
            cmbColumn.DisplayMember = "TenGiaoVien";
            cmbColumn.ValueMember = "MaGiaoVien";
            cmbColumn.DataPropertyName = "MaGiaoVien";
            cmbColumn.HeaderText = "Giáo viên";
        }

        public void CapNhatGiaoVien(DataTable dataTable)
        {
            GiaoVienDAO.Instance.CapNhatGiaoVien(dataTable);
        }

        public void ThemGiaoVien(GiaoVienDTO GiaoVien)
        {
            GiaoVienDAO.Instance.ThemGiaoVien(GiaoVien);
        }

        public void TimTheoMa(string maGiaoVien)
        {
            bindingSource.DataSource = GiaoVienDAO.Instance.TimTheoMa(maGiaoVien);
        }

        public void TimTheoTen(string tenGiaoVien)
        {
            bindingSource.DataSource = GiaoVienDAO.Instance.TimTheoTen(tenGiaoVien);
        }
    }
}
