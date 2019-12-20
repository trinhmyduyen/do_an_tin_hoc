using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhsachSach
    {
        Sach sach = new Sach();
        List<Sach> dssach = new List<Sach>();
        public void Them(Sach a )
        { 
                sach.Nhap();
            dssach.Add(sach);
        }
        public Sach Tim(string masach)
        {
            foreach (Sach a in dssach)
            {
                if (a.masach == masach) 
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string masach)
        {
            int vitri = 0;
            foreach (Sach a in dssach)
            {
                if (a.masach == masach)
                {
                    vitri = int.Parse(a.masach);
                }
            }
            return vitri;
        }
        public void CapNhat(Sach a)
        {
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon sua: ");
            string masach = Console.ReadLine();
            
                int vitri = TimViTri(masach);
                dssach.RemoveAt(vitri);
                Console.WriteLine("Nhap lai thong tin sach!");
                Them(a);
            
            ghiflie();
        }
        public void Xoa(Sach a)
        {
            
            DanhsachSach ds = new DanhsachSach();
            Console.WriteLine("Nhap ma sach muon xoa: ");
            string masach = Console.ReadLine();
            int vitri = TimViTri(masach);
                dssach.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {
           
            string[] allLines = File.ReadAllLines("sach.txt");
            for(int i=0;i<allLines.Length;i++)
            {
                string line = allLines[i];
                Sach sach = new Sach();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if(temp.Length >0)
                {
                    sach.masach = temp[0];
                    sach.tensach = temp[1];
                    sach.dsmatg = temp[2];
                    sach.manxb = temp[3];
                    sach.gia = double.Parse(temp[4]);
                    sach.dsmatl = temp[5];
                    dssach.Add(sach);
                }
                sach.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("sach.txt", false, Encoding.UTF8);
            for(int i=0;i<dssach.Count;i++)
            {
                Sach sach = new Sach();
                sach = dssach[i];
                swt.WriteLine(sach.masach + "\t" + sach.tensach + "\t" + sach.dsmatg + "\t" + sach.manxb+ "\t"+ sach.gia+ "\t" + sach.dsmatl);
            }
            swt.Close();

        }

       
    }
}


