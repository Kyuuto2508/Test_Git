using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class HopDongNganHan : HopDong
    {
        private string loaidichvu;

        public HopDongNganHan(NguoiGiupViec nguoigiupviec, NguoiThue nguoithue, NguoiMoiGioi nguoimoigioi, long hoahong,
            DateTime ngaybatdau, int thoihan, string loaidichvu) : base(nguoigiupviec, nguoithue, nguoimoigioi, hoahong,
                ngaybatdau, thoihan)
        {
            this.loaidichvu = loaidichvu;
        }

        public override void InDanhSach()
        {
            Console.WriteLine($"Hợp đồng ngắn hạn: Người giúp việc: {nguoigiupviec.HoTen}, " +
                $"Người thuê: {nguoithue.HoTen}, " + $"Loại công việc: {loaidichvu}, " +
                $"Ngày bắt đầu làm việc {ngaybatdau.ToString("dd/MM/yyyy")}, Thời hạn {thoihan} tháng");
        }
    }
}
