using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    class DanhSachNhanVien
    {
        NhanVien nv = new NhanVien();
        List<NhanVien> dsnv = new List<NhanVien>();
        public void Them(NhanVien a)
        {
            nv.Nhap();
            dsnv.Add(nv);
        }
        public NhanVien Tim(string masach)
        {
            foreach (NhanVien a in dsnv)
            {
                if (a.manv == masach)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string manv)
        {
            int vitri = 0;
            foreach (NhanVien a in dsnv)
            {
                if (a.manv == manv)
                {
                    vitri = int.Parse(a.manv);
                }
            }
            return vitri;
        }
        public void CapNhat(NhanVien a)
        {
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();

            int vitri = TimViTri(masach);
            dsnv.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin sach!");
            Them(a);

            ghiflie();
        }
        public void Xoa(NhanVien a)
        {

            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string manv = Console.ReadLine();
            int vitri = TimViTri(manv);
            dsnv.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("nv.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                NhanVien nv = new NhanVien();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    nv.manv = temp[0];
                    nv.hoten = temp[1];
                    nv.ngayvaolam = DateTime.Parse(temp[2]);
                    nv.chucvu = temp[3];
                    nv.gioitinh = temp[4];
                    nv.diachi = temp[5];
                    nv.sdt = temp[6];
                    dsnv.Add(nv);
                }
                nv.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("nv.txt", false, Encoding.UTF8);
            for (int i = 0; i < dsnv.Count; i++)
            {
                NhanVien sach = new NhanVien();
                nv = dsnv[i];
                swt.WriteLine(nv + "\t" + nv.hoten  + "\t" + nv.ngayvaolam + "\t" + nv.chucvu + "\t" + nv.gioitinh + "\t" +nv.diachi+ "\t" +nv.sdt);
            }
            swt.Close();

        }

    }
}
