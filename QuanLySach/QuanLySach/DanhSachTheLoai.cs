using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhSachTheLoai
    {
        TheLoai theloai = new TheLoai();
        List<TheLoai> dstheloai = new List<TheLoai>();
        public void Them(TheLoai a)
        {
            theloai.Nhap();
            dstheloai.Add(theloai);
        }
        public TheLoai Tim(string matl)
        {
            foreach (TheLoai a in dstheloai)
            {
                if (a.matl == matl)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string matl)
        {
            int vitri = 0;
            foreach (TheLoai a in dstheloai)
            {
                if (a.matl == matl)
                {
                    vitri = int.Parse(a.matl);
                }
            }
            return vitri;
        }
        public void CapNhat(TheLoai a)
        {
            DanhSachTheLoai ds = new DanhSachTheLoai();
            Console.WriteLine("Nhap ma theloai muon sua: ");
            string matl = Console.ReadLine();

            int vitri = TimViTri(matl);
            dstheloai.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin theloai!");
            Them(a);

            ghiflie();
        }
        public void Xoa(TheLoai a)
        {

            DanhSachTheLoai ds = new DanhSachTheLoai();
            Console.WriteLine("Nhap ma theloai muon xoa: ");
            string matl = Console.ReadLine();
            int vitri = TimViTri(matl);
            dstheloai.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("theloai.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                TheLoai theloai = new TheLoai();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    theloai.matl = temp[0];
                    theloai.tentl = temp[1];
                    dstheloai.Add(theloai);
                }
                theloai.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("theloai.txt", false, Encoding.UTF8);
            for (int i = 0; i < dstheloai.Count; i++)
            {
                TheLoai theloai = new TheLoai();
                theloai = dstheloai[i];
                swt.WriteLine(theloai.matl + "\t" + theloai.tentl );
            }
            swt.Close();

        }


    }
}


