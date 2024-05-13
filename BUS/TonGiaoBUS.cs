using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class TonGiaoBUS
    {
        private static TonGiaoBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private TonGiaoBUS() { }

        public static TonGiaoBUS Instance
        {
            get
            {
                if (instance == null) instance = new TonGiaoBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = TonGiaoDAO.Instance.LayDanhSachTonGiao();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = TonGiaoDAO.Instance.LayDanhSachTonGiao();
            comboBox.DisplayMember = "TenTonGiao";
            comboBox.ValueMember = "MaTonGiao";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = TonGiaoDAO.Instance.LayDanhSachTonGiao();
            cmbColumn.DisplayMember = "TenTonGiao";
            cmbColumn.ValueMember = "MaTonGiao";
            cmbColumn.DataPropertyName = "MaTonGiao";
            cmbColumn.HeaderText = "Tôn giáo";
        }

        public void CapNhatTonGiao(DataTable dataTable)
        {
            TonGiaoDAO.Instance.CapNhatTonGiao(dataTable);
        }
    }
}
