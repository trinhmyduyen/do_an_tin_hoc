using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhsachKho
    {
      Kho kho= new Kho();
        List<Kho> dskho = new List<Kho>();
        public void Them(Kho a)
        {
            kho.Nhap();
            dskho.Add(kho);
        }
        public Kho Tim(string makho)
        {
            foreach (Kho a in dskho)
            {
                if (a.makho == makho)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string makho)
        {
            int vitri = 0;
            foreach (Kho a in dskho)
            {
                if (a.makho == makho)
                {
                    vitri = int.Parse(a.makho);
                }
            }
            return vitri;
        }
        public void CapNhat(Kho a)
        {
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();

            int vitri = TimViTri(masach);
            dskho.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin sach!");
            Them(a);

            ghiflie();
        }
        public void Xoa(Kho a)
        {

            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string masach = Console.ReadLine();
            int vitri = TimViTri(masach);
            dskho.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("sach.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                Kho sach = new Kho();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    kho.makho = temp[0];
                    kho.tenkho = temp[1];
                    kho.sonhap = int .Parse (temp[2]);
                    kho.soton= int.Parse(temp[3]);

                    dskho.Add(kho);
                }
                sach.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("sach.txt", false, Encoding.UTF8);
            for (int i = 0; i < dskho.Count; i++)
            {
             Kho kho= new Kho();
                kho = dskho[i];
                swt.WriteLine(kho.makho + "\t" + kho.tenkho + "\t" + kho.sonhap+ "\t" + kho.soton );
            }
            swt.Close();

        }


    }
}


