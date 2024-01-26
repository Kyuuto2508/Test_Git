using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class HopDongDaiHan : HopDong
    {
        private string loaicongviec;

        public HopDongDaiHan(NguoiGiupViec nguoigiupviec, NguoiThue nguoithue, NguoiMoiGioi nguoimoigioi, long hoahong, 
            DateTime ngaybatdau, int thoihan, string loaicongviec): base(nguoigiupviec, nguoithue, nguoimoigioi, hoahong,
                ngaybatdau, thoihan)
        {
            this.loaicongviec = loaicongviec;
        }

        public override void InDanhSach()
        {
            Console.WriteLine($"Hợp đồng dài hạn: Người giúp việc: {nguoigiupviec.HoTen}, " +
                $"Người thuê: {nguoithue.HoTen}, " +$"Loại công việc: {loaicongviec}, " +
                $"Ngày bắt đầu làm việc {ngaybatdau.ToString("dd/MM/yyyy")}, Thời hạn {thoihan} tháng");
        }
    }
}
