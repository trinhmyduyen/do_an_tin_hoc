using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class TheLoai
    {
        private string m_MaTL;
        private string m_TenTL;
        public string matl
        {
            get { return m_MaTL; }
            set { m_MaTL = value; }
        }
        public string tentl
        {
            get { return m_TenTL; }
            set { m_TenTL = value; }
        }
        public TheLoai(string matl, string tentl)
        {
            m_MaTL = matl;
            m_TenTL = tentl;
        }
        public TheLoai()
        {
            m_MaTL = " ";
            m_TenTL = " ";
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ma The Loai : ");
            matl = Console.ReadLine();
            Console.WriteLine("Nhap Ten The Loai : ");
            tentl = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma The Loai : " + matl);
            Console.WriteLine("Ten The Loai : " + tentl);
        }

        public List<TheLoai> dstl = new List<TheLoai>();
        public void Them(TheLoai a)
        {
            dstl.Add(a);
            a.Nhap();
        }
        public void Xoa(TheLoai a)
        {
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string masach = Console.ReadLine();
            dstl.Remove(a);
        }
        public void CapNhat(TheLoai a)
        {
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();
            Console.WriteLine("Nhap lai thong tin sach!");
            Nhap();
            dstl.Add(a);
        }
        public TheLoai tim(string masach)
        {
            foreach (TheLoai a in dstl)
            {
                if (a.matl == masach) 
                {
                    a.Xuat();
                }
            }
            return null;
        }
    }
}
