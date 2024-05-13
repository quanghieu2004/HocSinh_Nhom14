using System;

namespace DTO
{
    public class HocSinhDTO
    {
        private string maHocSinh;
        private string hoTen;
        bool gioiTinh;
        private string diaChi;
        private string maDanToc;
        private string maTonGiao;

        public HocSinhDTO() { }
        public HocSinhDTO(
            string maHocSinh,
            string hoTen,
            bool gioiTinh,
            string diaChi,
            string maDanToc,
            string maTonGiao)
        {
            this.maHocSinh = maHocSinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.maDanToc = maDanToc;
            this.maTonGiao = maTonGiao;
        }

        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaDanToc { get => maDanToc; set => maDanToc = value; }
        public string MaTonGiao { get => maTonGiao; set => maTonGiao = value; }
    }
}
