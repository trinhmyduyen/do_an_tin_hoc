using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Kho
    {
        private string _makho;
        private string _tenkho;
        private int _sonhap;
        private int _sonton;

        public string makho
        {
            get { return _makho; }
            set { _makho = value; }
        }
        public string tenkho
        {
            get { return _tenkho; }
            set { _tenkho = value; }
        }
        public int sonhap
        {
            get { return _sonhap; }
            set { _sonhap = value; }
        }
        public int soton
        {
            get { return _sonton; }
            set { _sonton = value; }
        }
        public Kho(string makho, string tenkho, int sonhap, int soton)
        {
            _makho = makho;
            _tenkho = tenkho;
            _sonhap = sonhap;
            _sonton = soton;
        }
        public Kho()
        {
            _makho = "";
            _tenkho = "";
            _sonhap = 0;
            _sonton = 0;

        }
        public void Nhap()
        {
            Console.WriteLine("Ma Kho: ");
            makho = Console.ReadLine();
            Console.WriteLine("Ten Kho: ");
            tenkho = Console.ReadLine();
            Console.WriteLine("So Luong Nhap:");
            sonhap = int.Parse(Console.ReadLine());
            Console.WriteLine("So Luong Ton Kho:");
            soton = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Mã Kho : " + makho);
            Console.WriteLine("Tên Kho:" + tenkho);
            Console.WriteLine("So Luong Nhap; " + sonhap);
            Console.WriteLine("So Luong Ton Kho:" + soton);
        }
        private List<Kho> dskho = new List<Kho>();
        public List<Kho> DanhsachKho
        {
            get { return dskho; }
        }
        public Kho tim(string makho)
        {
            foreach (Kho a in dskho)
            {
                if (a.makho == makho) return a;
            }
            return null;
        }
        public void them(Kho a)
        {
            dskho.Add(a);
        }
        public void xoa(string makho)
        {
            Kho a = tim(makho);
            if (a != null) dskho.Remove(a);
        }
        public void sua(Kho a)
        {
            Kho x = tim(a.makho);
            if (x != null)
            {
                x.tenkho = a.tenkho;
                x.sonhap = a.sonhap;
                x.soton = a.soton;

            }
        }
    }
}
