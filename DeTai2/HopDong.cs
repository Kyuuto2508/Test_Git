using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class HopDong
    {
        protected NguoiGiupViec nguoigiupviec;
        protected NguoiThue nguoithue;
        protected NguoiMoiGioi nguoimoigioi;
        protected long hoahong;
        protected DateTime ngaybatdau;
        protected int thoihan;

        public HopDong(NguoiGiupViec nguoigiupviec, NguoiThue nguoithue, NguoiMoiGioi nguoimoigioi, long hoahong,
            DateTime ngaybatdau, int thoihan)
        {
            this.nguoigiupviec = nguoigiupviec;
            this.nguoithue = nguoithue;
            this.nguoimoigioi = nguoimoigioi;
            this.hoahong = hoahong;
            this.ngaybatdau = ngaybatdau;
            this.thoihan = thoihan;
        }

        public NguoiGiupViec NguoiGiupViec
        {
            get { return this.nguoigiupviec;}
        }

        public NguoiThue NguoiThue
        {
            get { return this.nguoithue; }
        }

        public NguoiMoiGioi NguoiMoiGioi
        {
            get { return this.nguoimoigioi; }
        }

        public long HoaHong
        {
            get { return this.hoahong; }
        }

        public DateTime NgayBatDau
        {
            get { return this.ngaybatdau; }
        }

        public int ThoiHan
        {
            get { return this.thoihan; }
        }

        enum EThoaThuan
        {
            EThoaThuanThanhCong,
            EThoaThuanKhongThanhCong,
        }

        public int ThoaThuanGiaCa()
        {
            if (nguoigiupviec.GiaTien > nguoithue.GiaThue)
            {
                return (int)EThoaThuan.EThoaThuanKhongThanhCong;
            }
            else
                return (int)EThoaThuan.EThoaThuanThanhCong;
        }

        public void KetQuaThoaThuan()
        {
            int x = ThoaThuanGiaCa();
            if (x == (int)EThoaThuan.EThoaThuanKhongThanhCong)
            {
                Console.WriteLine("Hai bên thỏa thuận giá cả không thành công");
            }
            else
                Console.WriteLine("Hai bên thỏa thuận giá cả thành công");
        }

        public virtual void InDanhSach()
        {
                
        }

        enum EHopDong
        {
            EHetThoiHan,
            EConThoiHan,
        }

        public int KiemTraHopDong()
        {
            DateTime a = DateTime.Now;
            DateTime tam = ngaybatdau.AddMonths(thoihan);
            int c = DateTime.Compare(a, tam);
            if (c >= 0)
                return (int)EHopDong.EHetThoiHan;
            else
                return (int)EHopDong.EConThoiHan;
        }

        public void ThoiHanHopDong()
        {
            DateTime a = ngaybatdau.AddMonths(thoihan);
            Console.WriteLine("Ngày hết hạn hợp đồng:" + a.ToString("dd/MM/yyyy"));
            int x = KiemTraHopDong();
            if (x == (int)EHopDong.EConThoiHan)
            {
                Console.WriteLine("Hợp đồng còn thời hạn");
            }
            else
            {
                Console.WriteLine("Hợp đồng đã hết thời hạn");
            }
        }
    }
}
