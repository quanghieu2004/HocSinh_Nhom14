using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class KetQuaBUS
    {
        private static KetQuaBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private KetQuaBUS() { }

        public static KetQuaBUS Instance
        {
            get
            {
                if (instance == null) instance = new KetQuaBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = KetQuaDAO.Instance.LayDanhSachKetQua();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void CapNhatKetQua(DataTable dataTable)
        {
            KetQuaDAO.Instance.CapNhatKetQua(dataTable);
        }
    }
}
