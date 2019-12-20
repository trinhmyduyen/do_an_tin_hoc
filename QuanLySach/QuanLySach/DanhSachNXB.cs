using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class DanhsachNXB
    {
        NhaXuatBan NXB = new NhaXuatBan();
        List<NhaXuatBan> dsNXB = new List<NhaXuatBan>();
        public void Them(NhaXuatBan a)
        {
            NXB.Nhap();
            dsNXB.Add(NXB);
        }
        public NhaXuatBan Tim(string manxb)
        {
            foreach (NhaXuatBan a in dsNXB)
            {
                if (a.manxb == manxb)
                {
                    a.Xuat();
                    return a;
                }
            }
            return null;
        }
        public int TimViTri(string manxb)
        {
            int vitri = 0;
            foreach (NhaXuatBan a in dsNXB)
            {
                if (a.manxb == manxb)
                {
                    vitri = int.Parse(a.manxb);
                }
            }
            return vitri;
        }
        public void CapNhat(NhaXuatBan a)
        {
            DanhsachNXB ds = new DanhsachNXB();
            Console.WriteLine("Nhap ma NhaXuatBan muon sua: ");
            string manxb = Console.ReadLine();

            int vitri = TimViTri(manxb);
            dsNXB.RemoveAt(vitri);
            Console.WriteLine("Nhap lai thong tin NhaXuatBan!");
            Them(a);

            ghiflie();
        }
        public void Xoa(NhaXuatBan a)
        {

            DanhsachNXB ds = new DanhsachNXB();
            Console.WriteLine("Nhap ma NhaXuatBan muon xoa: ");
            string manxb = Console.ReadLine();
            int vitri = TimViTri(manxb);
            dsNXB.RemoveAt(vitri);
            ghiflie();
        }
        public void docfile()
        {

            string[] allLines = File.ReadAllLines("NXB.txt");
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                NhaXuatBan NXB = new NhaXuatBan();
                string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length > 0)
                {
                    NXB.manxb = temp[0];
                    NXB.tennxb = temp[1];
                    NXB.ttlh = temp[2];

                    dsNXB.Add(NXB);
                }
                NXB.Xuat();
            }


        }
        public void ghiflie()
        {
            StreamWriter swt = new StreamWriter("NXB.txt", false, Encoding.UTF8);
            for (int i = 0; i < dsNXB.Count; i++)
            {
                NhaXuatBan NXB = new NhaXuatBan();
                NXB = dsNXB[i];
                swt.WriteLine(NXB.manxb + "\t" + NXB.tennxb + "\t" + NXB.ttlh);
            }
            swt.Close();

        }


    }
}


