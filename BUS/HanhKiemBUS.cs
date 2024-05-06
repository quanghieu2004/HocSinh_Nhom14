using System.Data;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class HanhKiemBUS
    {
        private static HanhKiemBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HanhKiemBUS() { }

        public static HanhKiemBUS Instance
        {
            get
            {
                if (instance == null) instance = new HanhKiemBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridView, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = HanhKiemDAO.Instance.LayDanhSachHanhKiem();
            bindingNavigator.BindingSource = bindingSource;
            dataGridView.DataSource = bindingSource;
        }

        public void CapNhatHanhKiem(DataTable dataTable)
        {
            HanhKiemDAO.Instance.CapNhatHanhKiem(dataTable);
        }
    }
}
