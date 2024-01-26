using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class NguoiThue : ThanhVien
    {
        private List<string> yeucau;
        private long giathue;
        private string chedothuong;
        private List<string> danhgia;
        private List<NguoiGiupViec> lichsuthue;

        public NguoiThue(string hoten, string sdt, string diachi, long giathue, string chedothuong) : base(hoten, sdt, diachi)
        {
            this.yeucau = new List<string>();
            this.giathue = giathue;
            this.chedothuong = chedothuong;
            this.danhgia = new List<string>();
            this.lichsuthue = new List<NguoiGiupViec>();
        }

        public long GiaThue
        {
            get { return this.giathue; }
        }

        public void ThemYeuCau(string yeucau)
        {
            this.yeucau.Add(yeucau);
        }

        public void ThemDanhGia(string danhgia)
        {
            this.danhgia.Add(danhgia);
        }

        public void ThemLichSuThue(NguoiGiupViec nguoigiupviec)
        {
            this.lichsuthue.Add(nguoigiupviec);
        }

        public override void InDanhSach()
        {
            Console.WriteLine($"Tên người thuê: {HoTen}, Số điện thoại: {Sdt}, Địa chỉ: {DiaChi}");
        }
    }
}
