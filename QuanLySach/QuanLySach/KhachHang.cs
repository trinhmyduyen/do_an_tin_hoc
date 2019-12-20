using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class KhachHang
    {
        private string _makh;
        private string _tenkh;
        private string _diachi;
        private string _sdt;
        private string _gioitinh;

        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string tenkh
        {
            get { return _tenkh; }
            set { _tenkh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }

        }
        public string sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public KhachHang(string makh, string tenkh, string diachi, string sdt, string gioitinh)
        {
            _makh = makh;
            _tenkh = tenkh;
            _diachi = diachi;
            _sdt = sdt;
            _gioitinh = gioitinh;
        }
        public KhachHang()
        {

            _makh = "";
            _tenkh = "";
            _diachi = "";
            _sdt = "";
            _gioitinh = "";
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Thông tin Khach Hang:");
            Console.WriteLine("\nMa Khach Hang: ");
            makh = Console.ReadLine();
            Console.WriteLine("Ten Khach Hang: ");
            tenkh = Console.ReadLine();
            Console.WriteLine("Dia Chi: ");
            diachi = Console.ReadLine();
            Console.WriteLine("SDT: ");
            sdt = Console.ReadLine();
            Console.WriteLine("Gioi Tinh:");
            gioitinh = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("\nThông tin Khach Hang");
            Console.WriteLine("MaKH: " + makh);
            Console.WriteLine("TenKh:" + tenkh);
            Console.WriteLine("Dia Chi: " + diachi);
            Console.WriteLine("SDT:" + sdt);
            Console.WriteLine("Gioi Tinh:" + gioitinh);
        }
        public List<KhachHang> dskh = new List<KhachHang>();
        public List<KhachHang> DanhsachNhanVien
        {
            get { return dskh; }
        }
        public KhachHang tim(string makh)
        {
            foreach (KhachHang a in dskh)
            {
                if (a.makh == makh) return a;
            }
            return null;
        }
        public void them(KhachHang a)
        {
            dskh.Add(a);
        }
        public void xoa(string makh)
        {
            KhachHang a = tim(makh);
            if (a != null) dskh.Remove(a);
        }
        public void sua(KhachHang a)
        {
            KhachHang x = tim(a.makh);
            if (x != null)
            {
                Nhap();
                x.tenkh = a.tenkh;
                x.gioitinh = a.gioitinh;
                x.diachi = a.diachi;
                x.sdt = a.sdt;
            }
        }
    }
}
