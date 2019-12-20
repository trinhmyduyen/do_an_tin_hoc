using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhSachTacGia
    {
        TacGia tacgia = new TacGia();
        List<TacGia> dstacgia = new List<TacGia>();
        public void Them(TacGia a)
        {
            tacgia.Nhap();
            dstacgia.Add(tacgia);
        }
        public TacGia Tim(string matg)
        {
            foreach (TacGia a in dstacgia)
            {
                if (a.matg == matg)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string matacgia)
        {
            int vitri = 0;
            foreach (TacGia a in dstacgia)
            {
                if (a.matg == matacgia)
                {
                    vitri = int.Parse(a.matg);
                }
            }
            return vitri;
        }
        public void CapNhat(TacGia a)
        {
            DanhSachTacGia ds = new DanhSachTacGia();
            Console.WriteLine("Nhap ma tac gia muon sua: ");
            string matg = Console.ReadLine();

            int vitri = TimViTri(matg);
            dstacgia.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin sach!");
            Them(a);

            ghiflie();
        }
        public void Xoa(TacGia a)
        {

            DanhSachTacGia ds = new DanhSachTacGia();
            Console.WriteLine("Nhap ma tac gia muon xoa: ");
            string matg = Console.ReadLine();
            int vitri = TimViTri(matg);
            dstacgia.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("TacGia.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                TacGia tacgia = new TacGia();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    tacgia.matg = temp[0];
                    tacgia.tentg = temp[1];
                    
                    dstacgia.Add(tacgia);
                }
                tacgia.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("TacGia.txt", false, Encoding.UTF8);
            for (int i = 0; i < dstacgia.Count; i++)
            {
                TacGia tacgia = new TacGia();
                tacgia = dstacgia[i];
                swt.WriteLine(tacgia.matg + "\t" + tacgia.tentg );
            }
            swt.Close();

        }


    }
}


