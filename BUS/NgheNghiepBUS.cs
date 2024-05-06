using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class NgheNghiepBUS
    {
        private static NgheNghiepBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private NgheNghiepBUS() { }

        public static NgheNghiepBUS Instance
        {
            get
            {
                if (instance == null) instance = new NgheNghiepBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridView, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            bindingNavigator.BindingSource = bindingSource;
            dataGridView.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            comboBox.DisplayMember = "TenNghe";
            comboBox.ValueMember = "MaNghe";
        }

        public void HienThiDgvCmbColCha(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNgheCha";
            cmbColumn.HeaderText = "Nghề nghiệp cha";
        }

        public void HienThiDgvCmbColMe(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNgheMe";
            cmbColumn.HeaderText = "Nghề nghiệp mẹ";
        }

        public void CapNhatNgheNghiep(DataTable dataTable)
        {
            NgheNghiepDAO.Instance.CapNhatNgheNghiep(dataTable);
        }
    }
}
