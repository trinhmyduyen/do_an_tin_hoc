using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class HoaDon
    {
        private string m_mahd;
        private string m_manv;
        private string m_makh;
        private DateTime m_ngayxuat;
        private string m_thanhtoan;
        private int m_thanhtien;

        public string mahd
        {
            get { return m_mahd; }
            set { m_mahd = value; }
        }
        public string manv
        {
            get { return m_manv; }
            set { m_manv = value; }
        }
        public string makh
        {
            get { return m_makh; }
            set { m_makh = value; }
        }
        public DateTime ngayxuat
        {
            get { return m_ngayxuat; }
            set { m_ngayxuat = value; }
        }
        public string thanhtoan
        {
            get { return m_thanhtoan; }
            set { m_thanhtoan = value; }
        }
        public int thanhtien
        {
            get { return m_thanhtien; }
            set { m_thanhtien = value; }
        }

        public HoaDon(string mahd, string manv, string makh, DateTime ngayxuat, string thanhtoan, int thanhtien)
        {
            m_mahd = mahd;
            m_manv = manv;
            m_makh = makh;
            m_ngayxuat = ngayxuat;
            m_thanhtien = thanhtien;
            m_thanhtoan = thanhtoan;
        }

        public HoaDon()
        {
            m_mahd = " ";
            m_manv = " ";
            m_makh = " ";
            m_ngayxuat = DateTime.Now;
            m_thanhtoan = " ";
            m_thanhtien = 0;
        }
        public void Nhap()
        {
            Console.WriteLine("ma hoa don: ");
            mahd = Console.ReadLine();
            Console.WriteLine("ma khach hang: ");
            makh = Console.ReadLine();
            Console.WriteLine("ma nhhan vien: ");
            manv = Console.ReadLine();
            Console.WriteLine("ngay xuat hoa don:");
            ngayxuat = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Thanh toan: ");
            thanhtoan = Console.ReadLine();
            Console.WriteLine("thanh tien: ");
            thanhtien = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Mahd:               " + mahd);
            Console.WriteLine("MaNV:               " + manv);
            Console.WriteLine("Makh:               " + makh);
            Console.WriteLine("Ngay xuat hoa don   " + ngayxuat);
            Console.WriteLine("HInh thuc thanh toan" + thanhtoan);
            Console.WriteLine("Thanh tien          " + thanhtien);

        }
       
    }
}
