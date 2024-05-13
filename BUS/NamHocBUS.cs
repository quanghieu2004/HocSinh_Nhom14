using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class NamHocBUS
    {
        private static NamHocBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private NamHocBUS() { }

        public static NamHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new NamHocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            cmbColumn.DisplayMember = "TenNamHoc";
            cmbColumn.ValueMember = "MaNamHoc";
            cmbColumn.DataPropertyName = "MaNamHoc";
            cmbColumn.HeaderText = "Năm học";
        }

        public void CapNhatNamHoc(DataTable dataTable)
        {
            NamHocDAO.Instance.CapNhatNamHoc(dataTable);
        }
    }
}
