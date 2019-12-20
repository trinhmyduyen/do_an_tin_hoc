using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class DanhSachKhachHang
    {
        KhachHang khach = new KhachHang();
        List<KhachHang> dskhach = new List<KhachHang>();
        public void Them(KhachHang a)
        {
            khach.Nhap();
            dskhach.Add(khach);
        }
        public KhachHang Tim(string masach)
        {
            foreach (KhachHang a in dskhach)
            {
                if (a.makh == masach)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string makh)
        {
            int vitri = 0;
            foreach (KhachHang a in dskhach)
            {
                if (a.makh == makh)
                {
                    vitri = int.Parse(a.makh);
                }
            }
            return vitri;
        }
        public void CapNhat(KhachHang a)
        {
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();

            int vitri = TimViTri(masach);
            dskhach.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin sach!");
            Them(a);

            ghiflie();
        }
        public void Xoa(KhachHang a)
        {

            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string manv = Console.ReadLine();
            int vitri = TimViTri(manv);
            dskhach.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("khachhang.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                KhachHang khach = new KhachHang();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    khach.makh = temp[0];
                    khach.tenkh = temp[1];
                    khach.gioitinh = temp[2];
                    khach.diachi = temp[3];
                    khach.sdt = temp[4];
                    dskhach.Add(khach);
                }
                khach.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("khachhang.txt", false, Encoding.UTF8);
            for (int i = 0; i < dskhach.Count; i++)
            {
                KhachHang khach = new KhachHang();
                khach = dskhach[i];
                swt.WriteLine(khach.makh + "\t" + khach.tenkh + "\t" + khach.gioitinh + "\t" + khach.diachi + "\t" + khach.sdt );
            }
            swt.Close();

        }

    }
}

