using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhsachHoaDon
    {
        HoaDon hoadon = new HoaDon();
        List<HoaDon> dshoadon = new List<HoaDon>();
        public void Them(HoaDon a)
        {
            hoadon.Nhap();
            dshoadon.Add(hoadon);
        }
        public HoaDon Tim(string mahd)
        {
            foreach (HoaDon a in dshoadon)
            {
                if (a.mahd == mahd)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string mahd)
        {
            int vitri = 0;
            foreach (HoaDon a in dshoadon)
            {
                if (a.mahd == mahd)
                {
                    vitri = int.Parse(a.mahd);
                }
            }
            return vitri;
        }
        public void CapNhat(HoaDon a)
        {
            DanhsachHoaDon ds = new DanhsachHoaDon();
            Console.WriteLine("Nhap ma HoaDon muon sua: ");
            string mahd = Console.ReadLine();

            int vitri = TimViTri(mahd);
            dshoadon.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin HoaDon!");
            Them(a);

            ghiflie();
        }
        public void Xoa(HoaDon a)
        {

            DanhsachHoaDon ds = new DanhsachHoaDon();
            Console.WriteLine("Nhap ma HoaDon muon xoa: ");
            string mahd = Console.ReadLine();
            int vitri = TimViTri(mahd);
            dshoadon.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("hoadon.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                HoaDon hoadon = new HoaDon();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    hoadon.mahd = temp[0];
                    hoadon.manv = temp[1];
                    hoadon.makh = temp[2];
                    hoadon.ngayxuat = DateTime.Parse(temp[3]);
                    hoadon.thanhtoan= temp[4];
                    hoadon.thanhtien = int.Parse(temp[5]);
                    dshoadon.Add(hoadon);
                }
                hoadon.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("hoadon.txt", false, Encoding.UTF8);
            for (int i = 0; i < dshoadon.Count; i++)
            {
                HoaDon sach = new HoaDon();
                sach = dshoadon[i];
                swt.WriteLine(hoadon.mahd + "\t" + hoadon.manv + "\t" + hoadon.makh + "\t" + hoadon.ngayxuat + "\t" + hoadon.thanhtoan + "\t" + hoadon.thanhtien);
            }
            swt.Close();

        }


    }
}


