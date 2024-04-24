using System;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    internal class fLopHoc
    {
        public bool TopLevel { get; internal set; }
        public DockStyle Dock { get; internal set; }
        public FormBorderStyle FormBorderStyle { get; internal set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}