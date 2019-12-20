using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class TacGia
    {
        private string m_MaTG;
        private string m_TenTG;
        public string matg
        {
            get { return m_MaTG; }
            set { m_MaTG = value; }
        }
        public string tentg
        {
            get { return m_TenTG; }
            set { m_TenTG = value; }
        }
        public TacGia(string matg, string tentg)
        {
            m_MaTG = matg;
            m_TenTG = tentg;
        }
        public TacGia()
        {
            m_MaTG = " ";
            m_TenTG = " ";
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ma Tac Gia : ");
            matg = Console.ReadLine();
            Console.WriteLine("Nhap Ten Tac Gia : ");
            tentg = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma Tac Gia : " + matg);
            Console.WriteLine("Ten Tac Gia : " + tentg);
        }
        
    }
}
