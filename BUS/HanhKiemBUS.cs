using DAO;
using System.Data;
using System.Windows.Forms;

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

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = HanhKiemDAO.Instance.LayDanhSachHanhKiem();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void CapNhatHanhKiem(DataTable dataTable)
        {
            HanhKiemDAO.Instance.CapNhatHanhKiem(dataTable);
        }
    }
}
