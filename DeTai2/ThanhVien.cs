using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ĐeTai2
{
    class ThanhVien
    {
        private string hoten;
        private string sdt;
        private string diachi;

        public ThanhVien(string hoten, string sdt, string diachi)
        {
            this.hoten = hoten;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public string HoTen
        {
            get { return this.hoten; }
        }

        public string Sdt
        {
            get { return this.sdt; }
        }

        public string DiaChi
        {
            get { return this.diachi; }
        }

        public virtual void InDanhSach()
        {

        }
    }
}
