using System.Text;
using System.Xml.Schema;

namespace ĐeTai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NguoiGiupViec nguoigiupviec = new NguoiGiupViec("Nguyễn Văn A", "0123456789", " Hà Nội", 8000000);
            NguoiGiupViec nguoigiupviec1 = new NguoiGiupViec("Nguyễn Văn M", "0678903214", " Bắc Ninh", 9000000);
            nguoigiupviec.ThemNangLuc("Chăm người già");
            nguoigiupviec.ThemDanhGia("Nấu ăn ngon");
            nguoigiupviec.ThemLichSuLamViec("Nhà A", "5 triệu/tháng");

            NguoiThue nguoithue = new NguoiThue("Nguyễn Văn B", "0987654321", "123 Đường ABC", 8000000, "chế độ thưởng Tết");
            nguoithue.ThemYeuCau("Nấu ăn ngon");
            nguoithue.ThemDanhGia("Làm việc tốt");
            nguoithue.ThemLichSuThue(nguoigiupviec);

            NguoiMoiGioi nguoimoigioi = new NguoiMoiGioi("Nguyễn Văn C", "0328456721", "Quảng Ngãi");
            DateTime ngaybatdau = new DateTime(2023, 07, 16);
            HopDong hopdong1 = new HopDong(nguoigiupviec, nguoithue, nguoimoigioi, 500000, ngaybatdau, 14);
            HopDong hopdong2 = new HopDong(nguoigiupviec1, nguoithue, nguoimoigioi, 500000, ngaybatdau, 3);

            List<ThanhVien> danhsach = new List<ThanhVien>
            {
                nguoigiupviec,
                nguoigiupviec1,
                nguoithue,
            };

            Console.WriteLine("Danh sách đối tượng:");
            foreach (ThanhVien x in danhsach)
            {
                x.InDanhSach();
            }

            List<HopDong> ds = new List<HopDong>
            {
                hopdong1,
                hopdong2,
            };

            List<HopDong> loaihopdong = new List<HopDong>();
            const int gioihan = 6;
            foreach (HopDong x in ds)
            {
                if (x.ThoiHan <= gioihan)
                {
                    HopDongNganHan hopdongnganhan = new HopDongNganHan(x.NguoiGiupViec, x.NguoiThue, x.NguoiMoiGioi, x.HoaHong, x.NgayBatDau, x.ThoiHan, "Dọn dẹp theo giờ");
                    loaihopdong.Add(hopdongnganhan);
                }
                else
                {
                    HopDongDaiHan hopdongdaihan = new HopDongDaiHan(x.NguoiGiupViec, x.NguoiThue, x.NguoiMoiGioi, x.HoaHong, x.NgayBatDau, x.ThoiHan, "Chăm người già");
                    loaihopdong.Add(hopdongdaihan);
                }
            }

            Console.WriteLine("Danh sách hợp đồng:");
            foreach(HopDong x in loaihopdong)
            {
                x.InDanhSach();
                x.KetQuaThoaThuan();
                int kq = x.ThoaThuanGiaCa();
                if (kq == (int)EThoaThuan.EThoaThuanKhongThanhCong)
                {
                    continue;
                }
                else
                {
                    x.ThoiHanHopDong();
                }
            }
            Console.ReadKey();
        }
        enum EThoaThuan
        {
            EThoaThuanThanhCong,
            EThoaThuanKhongThanhCong,
        }
    }
}