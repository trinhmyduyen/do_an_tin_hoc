#include <iostream>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <ctime>

using namespace std;

int** KhoiTaoMang(int **p, int dong, int cot)
{
	p = new int*[dong];
	for (int i = 0; i < dong; i++)
		p[i] = new int[cot];
	return p;
}

void GiaiPhongMang(int **p, int dong)
{
	for (int i = 0; i < dong; i++)
		delete[]p[i];
	delete[]p;
}

void NhapMang(int **p, int dong, int cot)
{
	for (int i = 0; i < dong; i++)
	{
		for (int j = 0; j < cot; j++)
		{
			cout << "a[" << i + 1 << "][" << j + 1 << "]= ";
			cin >> p[i][j];
		}
		//cout << endl;
	}
}

void XuatMang(int **p, int dong, int cot) 
{
	for (int i = 0; i < dong; i++) {
		for (int j = 0; j < cot; j++)
			cout << "\t" << p[i][j];
		cout << endl;
	}
	cout << endl;
}

void ThemDong(int **p, int dong, int cot)
{
	int k = 0;
	do
	{
		cout << "\nNhap dong muon them vao: ";
		cin >> k;
	} while (k <= 0 || k > dong + 1);
	//tạo mảng động để lưu kq
	int **p2 = NULL;
	int dong2 = ++dong;
	int cot2 = cot;
	p2 = KhoiTaoMang(p2, dong2, cot2);
	//tạo dòng mới để lưu kq dòng mới
	int **p3 = NULL;
	p3 = KhoiTaoMang(p3, 1, cot);
	for (int i = 0; i < dong2; i++) 
	{
		if (i == k-1)
			break;
		for (int j = 0; j < cot2; j++) 
		{
			p2[i][j] = p[i][j];
			//cout << "\t" << p[i][j];
		}
		//cout << endl;
	}
	cout << "\nNhap gia tri:\n";
	NhapMang(p3, 1, cot);
	//cout << p3[1][2];
	for (int j = 0; j < cot2; j++) 
	{
		p2[k-1][j] = p3[0][j];
		//cout << "\t" << p2[k-1][j];
	}
	for (int i = k; i < dong2; i++) 
	{
		int tam = i - 1;
		for (int j = 0; j < cot2; j++) 
		{
			p2[i][j] = p[tam][j];
			//cout << "\t" << p2[i][j];
		}
		//cout << "\n";
	}
	cout << "\nMang vua duoc them:\n";
	XuatMang(p2, dong2, cot2);
}

void XoaDong(int **p, int dong, int cot)
{
	int k = 0;
	do
	{
		cout << "\nNhap dong muon xoa vao: ";
		cin >> k;
	} while (k <= 0 || k > dong + 1);
	int **p2 = NULL;
	int dong2 = --dong;
	int cot2 = cot;
	p2 = KhoiTaoMang(p2, dong2, cot2);
	for (int i = 0; i < dong2; i++)
	{
		if (i == k - 1)
			break;
		for (int j = 0; j < cot2; j++)
			p2[i][j] = p[i][j];
	}
	for (int i = k-1; i < dong2; i++)
	{
		int tam = i + 1;
		for (int j = 0; j < cot2; j++)
			p2[i][j] = p[tam][j];
	}
	cout << "\nMang vua xoa:\n";
	XuatMang(p2, dong2, cot2);
}

void ThemPTuTrenDong(int **p, int dong, int cot)
{
	int k = 0;
	do
	{
		cout << "\nNhap dong muon them vao: ";
		cin >> k;
	} while (k <= 0 || k > dong + 1);
	int **p2 = NULL;
	int dong2 = dong;
	int cot2 = ++cot;
	p2 = KhoiTaoMang(p, dong, cot);
	for (int i = 0; i < dong; i++)
	{
		if (i == k - 1)
			break;
		for (int j = 0; j < cot; j++)
		{
			p2[i][j] = p[i][j];
			cout << "\t" << p2[i][j];
		}
	}
	int vt = 0;
	do
	{
		if (vt <= 0 || vt > cot + 1)
		{
			cout << "\nNhap vi tri muon them vao: ";
			cin >> vt;
		}
	} while (vt <= 0 || vt > cot2);
	int gt;
	cout << "\nNhap gia tri muon them: ";
	cin >> gt;
	for (int j = 0; j < cot2; j++)
	{
		if (j == vt - 1)
			p2[vt - 1][j] = gt;
		else p2[0][j] = p[0][j];
	}
	for (int i = k + 1; i < dong; i++)
		for (int j = 0; j < cot; j++)
			p2[i][j] = p[i][j];
	cout << "\nMang vua them:\n";
	XuatMang(p2, dong2, cot);
}

void XoaPTuTrenDong(int **p, int dong, int cot) 
{

}

bool TimKiem(int **a, int dong, int cot, int gt)
{
	for (int i = 0; i < dong; i++)
		for (int j = 0; j < cot; j++)
			if (a[i][j] == gt)
				return true;
	return false;
}

void TimVTDau(int **a, int dong, int cot)
{
	int gt;
	int v = 0, t = 0;
	cout << "\nNhap gia tri muon tim: ";
	cin >> gt;
	for (int i = 0; i < dong; i++)
		for (int j = 0; j < cot; j++)
			if (TimKiem(a, dong, cot, gt) == true)
			{
				v = i;
				t = j;
				cout << "\Gia tri " << gt << " co vi tri dau tien: a[" << v + 1 << "][" << t + 1 << "]\n";
				return;
			}
			else cout << "\nKhong co gia tri!";
}

void TimVTCuoi(int **a, int dong, int cot)
{
	int gt;
	int v = 0, t = 0;
	cout << "\nNhap gia tri muon tim: ";
	cin >> gt;
	for (int i = 0; i < dong; i++)
		for (int j = 0; j < cot; j++)
			if (TimKiem(a, dong, cot, gt) == true)
			{
				v = i;
				t = j;
				break;
			}
	if (v != 0 && t != 0)
		cout << "\Gia tri " << gt << " co vi tri cuoi cung: a[" << v + 1 << "][" << t + 1 << "]\n";
	else cout << "\nKhong co gia tri!";
}

void TimVTAll(int **a, int dong, int cot)
{
	int gt;
	cout << "\nNhap gia tri muon tim: ";
	cin >> gt;
	cout << "\Gia tri " << gt << " co vi tri:";
	for (int i = 0; i < dong; i++)
		for (int j = 0; j < cot; j++)
			if (a[i][j] == gt)
			{
				cout << "\ta[" << i + 1 << "," << j + 1 << "]";
			}
			else cout << "\nKhong co gia tri!";
	cout << endl;
}

void TaoMangXoanOc(int **a, int dong, int cot)
{
	int A[100];
	int dem = 0, trai = 0, tren = 0, phai = cot, duoi = dong, soluong = cot * dong;

	for (int i = 0; i < dong; i++)
		for (int j = 0; j < dong; j++)
		{
			A[dem] = a[i][j];
			dem++;
		}
	while (dem < soluong)
	{
		for (int i = trai; i < phai; i++)
			if (dem < soluong)
			{
				a[tren][i] = A[dem];
				dem++;
			}
		tren++;
		for (int i = tren; i < duoi; i++)
			if (dem < soluong)
			{
				a[i][phai - 1] = A[dem];
				dem++;
			}
		phai--;
		for (int i = phai - 1; i >= trai; i--)
			if (dem < soluong)
			{
				a[duoi - 1][i] = A[dem];
				dem++;
			}
		duoi--;
		for (int i = duoi - 1; i >= tren; i--)
			if (dem < soluong)
			{
				a[i][trai] = A[dem];
				dem++;
			}
		trai++;
	}
}

int main()
{
	cout << "==========================MENU=============================";
	cout << "\n0.Exit";
	cout << "\n1.Nhap mang";
	cout << "\n2.Xuat mang";
	cout << "\n3.Them dong trong mang";
	cout << "\n4.Xoa dong trong mang";
	cout << "\n5.Them phan tu tren 1 dong";
	cout << "\n6.Xoa phan tu ren 1 dong";
	cout << "\n7.Tim kiem dau tien vi tri cua gia tri";
	cout << "\n8.Tim kiem cuoi cung vi tri cua gia tri";
	cout << "\n9.Tim kiem vi tri cua gia tri";
	cout << "\n10.Xuat mang theo chieu xoan oc\n";
	cout << "===========================================================";

	nhap:

	int chon = 0;
	do
	{
			cout << "\nChon Menu: ";
			cin >> chon;
	} while (chon < 0 || chon > 10);

	int dong, cot;
	int **p = NULL;
	int tt;
	switch (chon)
	{
	case 1:
		dong = 0, cot = 0;
		do
		{
			if (dong <= 0)
			{
				cout << "\nNhap so dong: ";
				cin >> dong;
			}
			else if (cot <= 0)
			{
				cout << "\nNhap so cot: ";
				cin >> cot;
			}
		} while (dong <= 0 || cot <= 0);
		cout << "\nNhap Ma Tran:\n";
		p = KhoiTaoMang(p, dong, cot);
		NhapMang(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 2: 
		cout << "\nMa Tran vua nhap:\n";
		XuatMang(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 3:
		ThemDong(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 4:
		XoaDong(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 5:
		ThemPTuTrenDong(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 6:
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 7:
		TimVTDau(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 8:
		TimVTCuoi(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 9:
		TimVTAll(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 10:
		TaoMangXoanOc(p, dong, cot);
		cout << "\nXuat Ma Tran xoan oc:\n";
		XuatMang(p, dong, cot);
		cout << "\nBan co muon tiep tuc?(1 co, 2 khong): ";
		cin >> tt;
		if (tt == 1)
			goto nhap;
		break;
	case 0:
		cout << "\nThoat!!!\n";
		break;
	default: break;
	}
	
	
	system("pause");
	return 0;
}