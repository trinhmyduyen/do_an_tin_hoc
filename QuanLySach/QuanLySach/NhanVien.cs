using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
   public  class NhanVien
    {
        private string m_manv;
        private string m_hoten;
        private DateTime m_ngayvaolam;
        private string m_chucvu;
        private string m_gioitinh;
        private string m_diachi;
        private string m_sdt;

        public string manv
        {
            get { return m_manv; }
            set { m_manv = value; }
        }

        public string hoten
        {
            get { return m_hoten; }
            set { m_hoten = value; }
        }
        public DateTime ngayvaolam
        {
            get { return m_ngayvaolam; }
            set { m_ngayvaolam = value; }
        }
        public string chucvu
        {
            get { return m_chucvu; }
            set { m_chucvu = value; }
        }
        public string gioitinh
        {
            get { return m_gioitinh; }
            set { m_gioitinh = value; }
        }
        public string diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        public string sdt
        {
            get { return m_sdt; }
            set { m_sdt = value; }
        }

        public NhanVien(string manv, string hoten, DateTime ngayvaolam, string chucvu, string gioitinh, string diachi, string sdt)
        {
            m_manv = manv;
            m_gioitinh = gioitinh;
            m_diachi = diachi;
            m_chucvu = chucvu;
            m_ngayvaolam = ngayvaolam;
            m_sdt = sdt;
            m_hoten = hoten;
        }

        public NhanVien()
        {
            m_manv = " ";
            m_hoten = " ";
            m_ngayvaolam = DateTime.Now;
            m_chucvu = " ";
            m_gioitinh = " ";
            m_diachi = " ";
            m_sdt = " ";
        }
        private List<NhanVien> dsnv;
        public List<NhanVien> DanhsachNhanVien
        {
            get { return dsnv; }
        }

        public void ghiflie()
        {
            Console.WriteLine("Vi du minh hoa doc va ghi File trong C#");
            Console.WriteLine("---------------------------------");

            string[] names = new string[] { "Tran Van A", "Nguyen Minh B" };
            using (StreamWriter sw = new StreamWriter("textfile.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // doc va hien thi du lieu trong textfile.txt
            string line = "";
            using (StreamReader sr = new StreamReader("E:\\test.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();

        }
        public void docfile()
        {
            FileStream fs = new FileStream("E:\\test.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String giatri = rd.ReadToEnd();// ReadLine() chỉ đọc 1 dòng đầu thoy, ReadToEnd là đọc hết
            Console.WriteLine(giatri);
            rd.Close();
            Console.ReadLine();
        }
        public NhanVien tim(string manv)
        {
            foreach (NhanVien a in dsnv)
            {
                if (a.manv == manv) return a;
            }
            return null;
        }
        public void them(NhanVien a)
        {
            dsnv.Add(a);
        }
        public void xoa(string mshs)
        {
            NhanVien a = tim(mshs);
            if (a != null) dsnv.Remove(a);
        }
        public void sua(NhanVien a)
        {
            NhanVien x = tim(a.manv);
            if (x != null)
            {
                x.hoten = a.hoten;
                x.ngayvaolam = a.ngayvaolam;
                x.chucvu = a.chucvu;
                x.gioitinh = a.gioitinh;
                x.diachi = a.diachi;
                x.diachi = a.diachi;
            }
        }

        public void Nhap()
        {
            Console.WriteLine("manv: ");
            manv = Console.ReadLine();
            Console.WriteLine("hoten: ");
            hoten = Console.ReadLine();
            Console.WriteLine("ngayvaolam:");
            ngayvaolam = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("chucvu: ");
            chucvu = Console.ReadLine();
            Console.WriteLine("diachi: ");
            diachi = Console.ReadLine();
            Console.WriteLine("sdt: ");
            sdt = Console.ReadLine();
            Console.WriteLine("gioitinh: ");
            gioitinh = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("MaNV:          " + manv);
            Console.WriteLine("THoTenNV:      " + hoten);
            Console.WriteLine("Ngay Vao Lam:  " + ngayvaolam);
            Console.WriteLine("Chuc Vu:       " + chucvu);
            Console.WriteLine("Dia Chi:       " + diachi);
            Console.WriteLine("SDT:           " + sdt);
            Console.WriteLine("Gioi Tinh:     " + gioitinh);
        }
    }
}
