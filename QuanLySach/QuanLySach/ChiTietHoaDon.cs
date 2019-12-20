using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class ChiTietHoaDon
    {
        private string m_mahd;
        private string m_masach;
        private string m_tensach;
        private int m_soluong;
        private int m_gia;

        public string mahd
        {
            get { return m_mahd; }
            set { m_mahd = value; }
        }
        public string masach
        {
            get { return m_masach; }
            set { m_masach = value; }
        }
        public string tensach
        {
            get { return m_tensach; }
            set { m_tensach = value; }
        }
        public int soluong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }
        public int gia
        {
            get { return m_gia; }
            set { m_gia = value; }
        }

        public ChiTietHoaDon(string mahd, string masach, string tensach, int soluong, int gia)
        {
            m_mahd = mahd;
            m_masach = masach;
            m_tensach = tensach;
            m_gia = gia;
            m_soluong = soluong;
        }

        public ChiTietHoaDon()
        {
            mahd = " ";
            masach = " ";
            tensach = " ";
            gia = 0;
            soluong = 0;
        }
        public void Nhap()
        {
            Console.WriteLine("ma hoa don: ");
            mahd = Console.ReadLine();
            Console.WriteLine("ma sach : ");
            masach = Console.ReadLine();
            Console.WriteLine("ten sach: ");
            tensach = Console.ReadLine();
            Console.WriteLine("Gia : ");
            gia = int.Parse(Console.ReadLine());
            Console.WriteLine("So luong sach: ");
            soluong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Mahd:               " + mahd);
            Console.WriteLine("Masach:             " + masach);
            Console.WriteLine("ten sach:           " + tensach);
            Console.WriteLine("Gia:                " + gia);
            Console.WriteLine("So luong sach:      " + soluong);


        }
        private List<ChiTietHoaDon> dsct;
        public List<ChiTietHoaDon> DanhsachHoaDon
        {
            get { return dsct; }
        }

        public ChiTietHoaDon tim(string mahd)
        {
            foreach (ChiTietHoaDon a in dsct)
            {
                if (a.mahd == mahd) return a;
            }
            return null;
        }
        public void them(ChiTietHoaDon a)
        {
            dsct.Add(a);
        }
        public void xoa(string mshs)
        {
            ChiTietHoaDon a = tim(mshs);
            if (a != null) dsct.Remove(a);
        }
        public void sua(ChiTietHoaDon a)
        {
            ChiTietHoaDon x = tim(a.mahd);
            if (x != null)
            {
                x.mahd = a.mahd;
                x.masach = a.masach;
                x.tensach = a.tensach;
                x.gia = a.gia;
                x.soluong = a.soluong;
            }
        }

    }
}
