using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
        public class DanTocBUS
        {
            private static DanTocBUS instance;
            private BindingSource bindingSource = new BindingSource();

            private DanTocBUS() { }

            public static DanTocBUS Instance
            {
                get
                {
                    if (instance == null) instance = new DanTocBUS();
                    return instance;
                }
                private set => instance = value;
            }

            public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
            {

            object DanTocDAO = null;
            bindingSource.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
                bindingNavigator.BindingSource = bindingSource;
                dataGridViewX.DataSource = bindingSource;
            }

            public void HienThiComboBox(ComboBox comboBox)
            {
                comboBox.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
                comboBox.DisplayMember = "TenDanToc";
                comboBox.ValueMember = "MaDanToc";
            }

            public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
            {
                cmbColumn.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
                cmbColumn.DisplayMember = "TenDanToc";
                cmbColumn.ValueMember = "MaDanToc";
                cmbColumn.DataPropertyName = "MaDanToc";
                cmbColumn.HeaderText = "Dân tộc";
            }

            public void CapNhatDanToc(DataTable dataTable)
            {
                DanTocDAO.Instance.CapNhatDanToc(dataTable);
            }
        }
}
