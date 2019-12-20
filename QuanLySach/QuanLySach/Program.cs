using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySach
{
    public class Program
    {
        static void Main(string[] args)
        {
            

           

        menu:
            int chon, tt;
            Console.WriteLine(" ========================== MENU ============================ ");
            Console.WriteLine("0 - Thoat chuong trinh");
            Console.WriteLine("1 - Sach");
            Console.WriteLine("2 - Tac Gia");
            Console.WriteLine("3 - The Loai");
            Console.WriteLine("4 - Nha Xuat Ban");
            Console.WriteLine("5 - Hoa Don");
            Console.WriteLine("6 - Chi Tiet Hoa Don");
            Console.WriteLine("7 - Khach Hang");
            Console.WriteLine("8 - Kho");
            Console.WriteLine("9 - Nhan Vien");
            Console.WriteLine(" ============================================================ ");

            do
            {

                Console.Write("Chon Menu: ");
                chon=int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            Sach a = new Sach();
                            DanhsachSach danhsach = new DanhsachSach();
                            DanhsachSach n = new DanhsachSach();
                            List<Sach> saches = new List<Sach>();
                        menu1:
                            int sach;
                            Console.WriteLine(" ========================== MENU SACH ============================ ");
                            Console.WriteLine("0 - Thoat chuong trinh");
                            Console.WriteLine("1 - Nhap Sach");
                            Console.WriteLine("2 - Them Sach");
                            Console.WriteLine("3 - Ghi Sach");
                            Console.WriteLine("4 - Xoa Sach");
                            Console.WriteLine("5 - Doc Sach");
                            Console.WriteLine("6 - Tim Sach");
                            Console.WriteLine("7 - Cap Nhat Lai Sach");
                            Console.WriteLine(" ================================================================= ");

                            do
                            {

                                Console.Write("Chon thao tac: ");
                                sach = int.Parse(Console.ReadLine());
                                switch (sach)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            danhsach.Them(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 2:
                                        {
                                            danhsach.Them(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 3:
                                        {
                                            danhsach.ghiflie();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 4:
                                        {
                                            danhsach.Xoa(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 5:
                                        {
                                            danhsach.docfile();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Nhap ma sach muon tim: ");
                                            string masach = Console.ReadLine();
                                            danhsach.Tim(masach);

                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                    case 7:
                                        {
                                            danhsach.CapNhat(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu1;
                                            break;
                                        }
                                }
                                Console.WriteLine("-------------------------------------\n");
                            } while (sach != 0);
                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                            tt = int.Parse(Console.ReadLine());
                            if (tt == 1)
                                goto menu;
                            break;
                        }
                    case 2:
                        {
                            TacGia b = new TacGia();
                            TacGia b1 = new TacGia();
                            DanhSachTacGia danhsachtg = new DanhSachTacGia();
                            DanhSachTacGia b2 = new DanhSachTacGia();
                            List<TacGia> tacgias = new List<TacGia>();
                        menu2:
                            int tacgia;
                            Console.WriteLine(" ========================== MENU TAC GIA ============================ ");
                            Console.WriteLine("0 - Thoat chuong trinh");
                            Console.WriteLine("1 - Nhap tac gia");
                            Console.WriteLine("2 - Them tac gia");
                            Console.WriteLine("3 - Ghi tac gia");
                            Console.WriteLine("4 - Xoa tac gia");
                            Console.WriteLine("5 - Doc tac gia");
                            Console.WriteLine("6 - Tim tac gia");
                            Console.WriteLine("7 - Cap Nhat Lai tacgia");
                            Console.WriteLine(" ================================================================= ");

                            do
                            {

                                Console.Write("Chon thao tac: ");
                                tacgia = int.Parse(Console.ReadLine());
                                switch (tacgia)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            danhsachtg.Them(b);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                    case 2:
                                        {
                                            danhsachtg.Them(b);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                    case 3:
                                        {
                                            danhsachtg.ghiflie();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                    case 4:
                                        {
                                            danhsachtg.Xoa(b1);
                                            goto menu2;
                                        }
                                    case 5:
                                        {
                                            danhsachtg.docfile();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Nhap ma tac gia muon tim: ");
                                            string matacgia = Console.ReadLine();
                                            danhsachtg.Tim(matacgia);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                    case 7:
                                        {
                                            danhsachtg.CapNhat(b);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu2;
                                            break;
                                        }
                                }
                                Console.WriteLine("-------------------------------------\n");
                            } while (tacgia != 0);
                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                            tt = int.Parse(Console.ReadLine());
                            if (tt == 1)
                                goto menu;
                            break;
                        }
                    case 3:
                        {

                            TheLoai c = new TheLoai();
                            TheLoai c1 = new TheLoai();
                            DanhSachTheLoai danhsach = new DanhSachTheLoai();
                            DanhSachTheLoai c2 = new DanhSachTheLoai();
                            List<TheLoai> theloais = new List<TheLoai>();
                        menu3:
                            int theloai;
                            Console.WriteLine(" ========================== MENU THE LOAI============================ ");
                            Console.WriteLine("0 - Thoat chuong trinh");
                            Console.WriteLine("1 - Nhap the loai");
                            Console.WriteLine("2 - Them the loai");
                            Console.WriteLine("3 - Ghi the loai");
                            Console.WriteLine("4 - Xoa the loai");
                            Console.WriteLine("5 - Doc the loai");
                            Console.WriteLine("6 - Tim the loai");
                            Console.WriteLine("7 - Cap Nhat Lai the loai");
                            Console.WriteLine(" ================================================================= ");

                            do
                            {

                                Console.Write("Chon thao tac: ");
                                theloai = int.Parse(Console.ReadLine());
                                switch (theloai)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            danhsach.Them(c);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                    case 2:
                                        {
                                            danhsach.Them(c);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                    case 3:
                                        {
                                            danhsach.ghiflie();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                    case 4:
                                        {
                                            danhsach.Xoa(c1);
                                            goto menu3;
                                        }
                                    case 5:
                                        {
                                            danhsach.docfile();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Nhap ma the loai muon tim: ");
                                            string matl = Console.ReadLine();
                                            danhsach.Tim(matl);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                    case 7:
                                        {
                                            danhsach.CapNhat(c);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu3;
                                            break;
                                        }
                                }
                                Console.WriteLine("-------------------------------------\n");
                            } while (theloai != 0);
                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                            tt = int.Parse(Console.ReadLine());
                            if (tt == 1)
                                goto menu;
                            break;
                        }
                    case 4:
                        {

                            NhaXuatBan a = new NhaXuatBan();
                            NhaXuatBan p = new NhaXuatBan();
                            DanhsachNXB danhsach = new DanhsachNXB();
                            DanhsachNXB n = new DanhsachNXB();
                            List<NhaXuatBan> saches = new List<NhaXuatBan>();
                        menu4:
                            int NXB;
                            Console.WriteLine(" ===================== MENU NHA XUAT BAN ========================== ");
                            Console.WriteLine("0 - Thoat chuong trinh");
                            Console.WriteLine("1 - Nhap NhaXuatBan");
                            Console.WriteLine("2 - Them NhaXuatBan");
                            Console.WriteLine("3 - Ghi NhaXuatBan");
                            Console.WriteLine("4 - Xoa NhaXuatBan");
                            Console.WriteLine("5 - Doc NhaXuatBan");
                            Console.WriteLine("6 - Tim NhaXuatBan");
                            Console.WriteLine("7 - Cap Nhat Lai NhaXuatBan");
                            Console.WriteLine(" ================================================================= ");

                            do
                            {

                                Console.Write("Chon thao tac: ");
                                NXB = int.Parse(Console.ReadLine());
                                switch (NXB)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        {
                                            danhsach.Them(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                    case 2:
                                        {
                                            danhsach.Them(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                    case 3:
                                        {
                                            danhsach.ghiflie();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                    case 4:
                                        {
                                            danhsach.Xoa(p);
                                            goto menu4;
                                        }
                                    case 5:
                                        {
                                            danhsach.docfile();
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Nhap ma NhaXuatBan muon tim: ");
                                            string masach = Console.ReadLine();
                                            danhsach.Tim(masach);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                    case 7:
                                        {
                                            danhsach.CapNhat(a);
                                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                            tt = int.Parse(Console.ReadLine());
                                            if (tt == 1)
                                                goto menu4;
                                            break;
                                        }
                                }
                                Console.WriteLine("-------------------------------------\n");
                            } while (NXB != 0);
                            Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                            tt = int.Parse(Console.ReadLine());
                            if (tt == 1)
                                goto menu;
                            break;
                        }
                    case 5:
                        NhaXuatBan a = new NhaXuatBan();
                        NhaXuatBan p = new NhaXuatBan();
                        DanhsachNXB danhsach = new DanhsachNXB();
                        DanhsachNXB n = new DanhsachNXB();
                        List<NhaXuatBan> saches = new List<NhaXuatBan>();
                    menu4:
                        int NXB;
                        Console.WriteLine(" ===================== MENU NHA XUAT BAN ========================== ");
                        Console.WriteLine("0 - Thoat chuong trinh");
                        Console.WriteLine("1 - Nhap NhaXuatBan");
                        Console.WriteLine("2 - Them NhaXuatBan");
                        Console.WriteLine("3 - Ghi NhaXuatBan");
                        Console.WriteLine("4 - Xoa NhaXuatBan");
                        Console.WriteLine("5 - Doc NhaXuatBan");
                        Console.WriteLine("6 - Tim NhaXuatBan");
                        Console.WriteLine("7 - Cap Nhat Lai NhaXuatBan");
                        Console.WriteLine(" ================================================================= ");

                        do
                        {

                            Console.Write("Chon thao tac: ");
                            NXB = int.Parse(Console.ReadLine());
                            switch (NXB)
                            {
                                case 0:
                                    break;
                                case 1:
                                    {
                                        danhsach.Them(a);
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                                case 2:
                                    {
                                        danhsach.Them(a);
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                                case 3:
                                    {
                                        danhsach.ghiflie();
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                                case 4:
                                    {
                                        danhsach.Xoa(p);
                                        goto menu4;
                                    }
                                case 5:
                                    {
                                        danhsach.docfile();
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.WriteLine("Nhap ma NhaXuatBan muon tim: ");
                                        string masach = Console.ReadLine();
                                        danhsach.Tim(masach);
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                                case 7:
                                    {
                                        danhsach.CapNhat(a);
                                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                                        tt = int.Parse(Console.ReadLine());
                                        if (tt == 1)
                                            goto menu4;
                                        break;
                                    }
                            }
                            Console.WriteLine("-------------------------------------\n");
                        } while (NXB != 0);
                        Console.WriteLine("Ban co muon tiep tuc?(1: co, 2: khong)");
                        tt = int.Parse(Console.ReadLine());
                        if (tt == 1)
                            goto menu;
                        break;
                }
                Console.WriteLine("-------------------------------------\n");
            } while (chon != 0);
        }
    }
}
