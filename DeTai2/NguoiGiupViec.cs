using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class NguoiGiupViec : ThanhVien
    {
        private List<string> nangluc;
        private List<string> danhgia;
        private List<string> lichsulamviec;
        private long giatien;

        public NguoiGiupViec(string hoten, string sdt, string diachi, long giatien) : base(hoten, sdt, diachi) 
        {
            this.nangluc = new List<string>();
            this.danhgia = new List<string>();
            this.lichsulamviec = new List<string>();
            this.giatien = giatien;
        }

        public long GiaTien
        {
            get { return this.giatien; }
        }

        public void ThemNangLuc(string nangluc)
        {
            this.nangluc.Add(nangluc);
        }

        public void ThemDanhGia(string danhgia)
        {
            this.danhgia.Add(danhgia);
        }

        public void ThemLichSuLamViec(string noilamviec, string mucluong)
        {
            string thongtinlichsu = $"{noilamviec} - Mức lương: {mucluong}";
            this.lichsulamviec.Add(thongtinlichsu);
        }

        public override void InDanhSach()
        {
            Console.WriteLine($"Tên người giúp việc: {HoTen}, Số điện thoại: {Sdt}, Địa chỉ: {DiaChi}");
        }
    }
}
