using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private QuyDinhBUS() { }
        public static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatQuyDinhDiemDat(int diemDat)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhDiemDat(diemDat);
        }

        public bool KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LayDoTuoiQuyDinh();

            int doTuoiMin = Convert.ToInt32(dataTable.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dataTable.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;
            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax) return true;
            else return false;
        }

        public bool KiemTraSiSo(int siSo)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LaySiSoQuyDinh();

            int siSoMin = Convert.ToInt32(dataTable.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dataTable.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax) return true;
            else return false;
        }

        public bool KiemTraDiem(string diem)
        {
            IList<string> gioiHanDiem = new List<string>();
            float nacDiemTrongGioiHan = 0;

            for (int i = 0; i <= 1010; i++)
            {
                gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                nacDiemTrongGioiHan += 0.01F;
                nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
            }

            if (gioiHanDiem.Contains(diem)) return true;
            else return false;
        }
    }
}
