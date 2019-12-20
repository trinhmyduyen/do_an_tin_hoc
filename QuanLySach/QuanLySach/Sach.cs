using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Sach
    {
        private string m_masach;
        private string m_tensach;
        private string m_dsmatg;
        private string m_manxb;
        private double m_gia;
        private string m_dsmatl;

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
        public string dsmatg
        {
            get { return m_dsmatg; }
            set { m_dsmatg = value; }
        }
        public string manxb
        {
            get { return m_manxb; }
            set { m_manxb = value; }
        }
        public double gia
        {
            get { return m_gia; }
            set { m_gia = value; }
        }
        public string dsmatl
        {
            get { return m_dsmatl; }
            set { m_dsmatl = value; }
        }

        public Sach(string masach, string tensach, string dsmatg, string manxb, double gia, string dsmatl)
        {
            m_masach = masach;
            m_tensach = tensach;
            m_dsmatg = dsmatg;
            m_manxb = manxb;
            m_gia = gia;
            m_dsmatl = dsmatl;
        }

        public Sach()
        {
            m_masach = " ";
            m_tensach = " ";
            m_dsmatg = " ";
            m_manxb = " ";
            m_gia = 0;
            m_dsmatl = " ";
        }
        public void Nhap()
        {
            Console.Write("Ma sach: ");
            masach = Console.ReadLine();
            Console.Write("Ten sach: ");
            tensach = Console.ReadLine();
            Console.Write("Danh sach ma tac gia: ");
            dsmatg = Console.ReadLine();
            Console.Write("Ma ngay xuat ban:");
            manxb = Console.ReadLine();
            Console.Write("Gia:  ");
            gia = double.Parse(Console.ReadLine());
            Console.Write("Danh sach ma the loai: ");
            dsmatl = Console.ReadLine();
        }

        public void Xuat()
        {
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("MaSach:          " + masach);
            Console.WriteLine("TenSach:         " + tensach);
            Console.WriteLine("DSMaTacGia:      " + dsmatg);
            Console.WriteLine("MaNgayXuatBan:   " + manxb);
            Console.WriteLine("Gia:             " + gia);
            Console.WriteLine("DSMaTheLoai      " + dsmatl);
            
        }
    }
}
