#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <iomanip>
#include <cstdlib>

using namespace std;

typedef int TYPEINFO;

struct NODE
{
	TYPEINFO data;
	NODE *link;
};
typedef NODE *NODEPTR;

//Khoi tao DSLK
void Init(NODEPTR &list)
{
	list = NULL;
}

//Kiem tra rong?
int Empty(NODEPTR list)
{
	return (list == NULL ? 1 : 0);
}

//Tao mot nut (phan tu)
NODEPTR TaoNODE(TYPEINFO x)
{
	NODEPTR p;
	p = new NODE;
	p->data = x;
	p->link = NULL;
	return p;
}

//Giai phong bo nho
void GiaiPhong(NODEPTR &list)
{
	NODEPTR p = list;
	while (p != NULL)
	{
		list = list->link;
		delete p;
		p = list;
	}
}

//Dem phan tu trong DSLK
int DemPT(NODEPTR list)
{
	int dem = 0;
	while (list != NULL)
	{
		dem++;
		list = list->link;
	}
	return dem;
}

//Them 1 phan tu vao dau DSLK
NODEPTR ThemDau(NODEPTR &list, TYPEINFO x)
{
	NODEPTR p = TaoNODE(x);
	if (list == NULL)
		list = p;
	else
	{
		p->link = list;
		list = p;
	}
	return p;
}

//Them 1 phan tu vao giua DSLK
NODEPTR ThemGiua(NODEPTR &list, TYPEINFO x, int vt)
{
	NODEPTR p = TaoNODE(x);
	int dem = DemPT(list);
	if (vt<1 || vt>dem)
		cout << "\nVi tri khong thoa!";
	else
		if (vt == 1)
			ThemDau(list, x);
		else
		{
			NODEPTR q = list;
			int dem = 1;
			while (dem != vt - 1 && p != NULL)
			{
				dem++;
				q = q->link;
			}
			p->link = q->link;
			q->link = p;
		}
	return p;
}
//Them 1 phan tu vao cuoi DSLK
NODEPTR ThemCuoi(NODEPTR &list, TYPEINFO x)
{
	NODEPTR p = TaoNODE(x);
	if (list == NULL)
		list = p;
	else
	{
		NODEPTR q = list;
		while (q->link != NULL)
			q = q->link;
		q->link = p;
	}
	return p;
}

void NhapDS(NODEPTR &list, int n)
{
	Init(list);
	int x;
	for (int i = 0; i < n; i++)
	{
		cout << "\nNhap x" << i + 1 << ": ";
		cin >> x;
		//ThemDau(list, x);
		ThemCuoi(list, x);
	}
}

void XuatDS(NODEPTR list)
{
	NODEPTR p = list;
	while (p != NULL)
	{
		cout << "\t" << p->data;
		p = p->link;
	}
	cout << endl;
}

//Tim phan tu co gia tri x
NODEPTR TimNODEX(NODEPTR &list, TYPEINFO x)
{
	NODEPTR p = list;
	while (p != NULL)
	{
		if (p->data == x)
			return p;
		p = p->link;
	}
	return NULL;
}

//Xoa 1 phan tu o dau DSLK
NODEPTR XoaDau(NODEPTR &list)
{
	NODEPTR p = list;
	if (p->link == NULL)
	{
		delete p;
		list = NULL;
	}
	else
	{
		p = list;
		list = p->link;
		delete p;
	}
	return p;
}

//Xoa phan tu co gia tri x
NODEPTR XoaGiua(NODEPTR &list, TYPEINFO x)
{
	NODEPTR p, q;
	if (TimNODEX(list, x) == NULL)
		cout << "\nKhong co gia tri can xoa!" << endl;
	else
		if (list->data == x)
			XoaDau(list);
		else
		{
			p = list;
			q = list;
			while (p != NULL && p->data != x)
			{
				q = p;
				p = p->link;
			}
			if (p->data != NULL && p->data == x)
			{
				q->link = p->link;
				delete p;
			}
		}
	return 0;
}

//Xoa 1 phan tu o cuoi DSLK
NODEPTR XoaCuoi(NODEPTR &list)
{
	NODEPTR p = list;
	if (p->link == NULL)
	{
		delete p;
		list = NULL;
	}
	else
	{
		while (p->link->link != NULL)
			p = p->link;
		p->link = NULL;
	}
	return p;
}

//Dao nguoc 2 node co gia tri chi dinh
void DaoNguocGiaTri(NODEPTR &list, int x, int y)
{
	if (TimNODEX(list, x) == NULL || TimNODEX(list, y) == NULL)
		cout << "\nGia tri khong hop le!" << endl;
	else
	{
		NODEPTR p = NULL;
		NODEPTR q = NULL;
		int tam;
		while (list != NULL)
		{
			if (TimNODEX(list, x) != NULL)
				p->data = x;
			else
				if (TimNODEX(list, y) != NULL)
					q->data = y;
			if (p != NULL && q != NULL)
			{
				tam = p->data;
				p->data = q->data;
				q->data = tam;
			}
			list = list->link;
		}
	}
	cout << "\nDSLK sau khi dao phan tu chi dinh: ";
	XuatDS(list);
}

//Dao nguoc 2 node co vi tri chi dinh
void DaoNguocViTri(NODEPTR &list, int x, int y)
{
	if (x > DemPT(list) || y > DemPT(list))
		cout << "\nVi tri khong hop le!" << endl;
	else
	{
		NODEPTR p = list;
		int dem = 0, tam, tam1, tam2;
		while (p != NULL)
		{
			dem++;
			if (dem == x)
			{
				tam1 = p->data;
			}
			else if (dem == y)
			{
				tam2 = p->data;
			}
			tam = tam1;
			tam1 = tam2;
			tam2 = tam;
			p = p->link;
		}
	}
	cout << "\nDSLK sau khi dao phan tu chi dinh: ";
	XuatDS(list);
}

int main()
{
	NODEPTR list;
	int  n;
	cout << "\nNhap so phan tu: ";
	cin >> n;
	Init(list);
	NhapDS(list, n);
	system("cls");

	cout << "\nDSLK vua nhap:";
	XuatDS(list);

	TYPEINFO x;
	//int vt;
	if (Empty(list))
		cout << "\nDanh sach rong!" << endl;
	else
	{
		cout << "\nNhap gia tri muon chen: ";
		cin >> x;
		ThemDau(list, x);
		cout << "\nDSLK sau khi chen dau: ";
		XuatDS(list);

		cout << "\nNhap gia tri muon chen: ";
		cin >> x;
		cout << "\nNhap vi tri muon chen: ";
		cin >> vt;
		ThemGiua(list, x, vt);
		cout << "\nDSLK sau khi chen giua: ";
		XuatDS(list);

		cout << "\nNhap gia tri muon chen: ";
		cin >> x;
		ThemCuoi(list, x);
		cout << "\nDSLK sau khi chen cuoi: ";
		XuatDS(list);

		XoaDau(list);
		cout << "\nDSLK sau khi xoa phan tu dau: ";
		XuatDS(list);

		cout << "\nNhap gia tri muon xoa: ";
		cin >> x;
		XoaGiua(list, x);
		cout << "\nDSLK sau khi xoa " << x << " : ";
		XuatDS(list);

		XoaCuoi(list);
		cout << "\nDSLK sau khi xoa phan tu cuoi: ";
		XuatDS(list);

		int a, b;
		cout << "\nNhap gia tri dau muon dao: ";
		cin >> a;
		cout << "\nNhap gia tri sau: ";
		cin >> b;
		DaoNguocGiaTri(list, a, b);

		cout << "\nNhap vi tri dau muon dao: ";
		cin >> a;
		cout << "\nNhap vi tri sau: ";
		cin >> b;
		DaoNguocViTri(list, a, b);
	}
	GiaiPhong(list);


	system("pause");
	return 0;
}