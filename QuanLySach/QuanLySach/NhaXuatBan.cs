using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class NhaXuatBan
    {

        private string m_MaNXB;
        private string m_TenNXB;
        private string m_TTLH;
        public string manxb
        {
            get { return m_MaNXB; }
            set { m_MaNXB = value; }
        }
        public string tennxb
        {
            get { return m_TenNXB; }
            set { m_TenNXB = value; }
        }
        public string ttlh
        {
            get { return m_TTLH; }
            set { m_TTLH = value; }
        }
        public NhaXuatBan(string manxb, string tennxb, string ttlh)
        {
            m_MaNXB = manxb;
            m_TenNXB = tennxb;
            m_TTLH = ttlh;
        }
        public NhaXuatBan()
        {
            m_MaNXB = " ";
            m_TenNXB = " ";
            m_TTLH = " ";
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ma Nha Xuat Ban : ");
            manxb = Console.ReadLine();
            Console.WriteLine("Nhap Ten Nha Xuat Ban : ");
            tennxb = Console.ReadLine();
            Console.WriteLine("Nhap Thong Tin Lien He: ");
            ttlh = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.WriteLine("Ma Nha Xuat Ban : " + manxb);
            Console.WriteLine("Ten Nha Xuat Ban : " + tennxb);
            Console.WriteLine("Thong Tin Lien He: " + ttlh);
        }

        public List<NhaXuatBan> dsnxb = new List<NhaXuatBan>();
        public void Them(NhaXuatBan a)
        {
            dsnxb.Add(a);
            a.Nhap();
        }
        public void Xoa(NhaXuatBan a)
        {
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string masach = Console.ReadLine();
            dsnxb.Remove(a);
        }
        public void CapNhat(NhaXuatBan a)
        {
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();
            Console.WriteLine("Nhap lai thong tin sach!");
            Nhap();
            dsnxb.Add(a);
        }
        public NhaXuatBan tim(string masach)
        {
            foreach (NhaXuatBan a in dsnxb)
            {
                if (a.manxb == manxb) 
                {
                    a.Xuat();
                }
            }
            return null;
        }
    }
}
