#include <iostream>
#include <fstream>
#include <array>
#include <vector>
#include <conio.h>
using namespace std;

typedef int TYPEINFO;
struct NODE
{
	TYPEINFO data;
	NODE* left;
	NODE* right;
};
typedef NODE* NODEPTR;
typedef NODEPTR BST;

//Ham khoi tao cay
void Init(BST &r)
{
	r = NULL;
}

//Ham kiem tra rong
int Empty(BST r)
{
	if (r == NULL)
		return 1;
	else
		return 0;
}

//Ham tao node
NODEPTR CreateNode(TYPEINFO a)
{
	NODEPTR p = new NODE;
	p->data = a;
	p->left = NULL;
	p->right = NULL;
	return p;
}

//Ham chen them node
//void InsertNode(BST &r, TYPEINFO a)
//{
//	if (a < r->data)
//		Chen(r->left, a);
//	else
//		Chen(r->right, a);
//}

//Doc cay tu mot file van ban
void Read( BST &r)
{
	FILE *f;
	fopen_s(&f, "textcay.txt", "r");
	if (f == NULL)
	{
		cout << "\nFile rong!!!";
		fclose(f);
	}
	else 
	{
		fscanf_s(f, "%n", &r->data);

	}
	fclose(f);
}

//Ham chen them node
void Chen(BST &r, TYPEINFO a)
{
	if (r == NULL)
	{
		NODEPTR p = CreateNode(a);
		r = p;
	}
	else if (r->data == a)
		cout << "Gia tri can chen da co trong cay." << endl;
	else
	{
		if (a < r->data)
			Chen(r->left, a);
		else
			Chen(r->right, a);
	}
}

//Doc file, so luong phan tu khong biet truoc
void Load_1(BST &root)
{
	int *A;
	int n = 0;
	int number;
	FILE *f = fopen("textcay.txt", "r");

	// Dem so luong phan tu co trong file
	while (fscanf(f, "%d", &number) > 0)
	{
		n++;
	}
	// Cap phat bo nho cho mang A
	A = new int[n];

	// Quay tro lai file de doc du lieu vao mang A
	fseek(f, 0, SEEK_SET);
	for (int i = 0; i < n; i++)
		fscanf(f, "%d", &A[i]);

	// Xuat mang da doc
	for (int i = 0; i < n; i++)
		Chen(root, A[i]);
}

//Doc file bang Fstream (so luong phan tu bi gioi han)
void Load_fstream(BST &root)
{
	ifstream file;
	file.open("textcay.txt", ios::in);
	if (file.fail() == true)
	{
		cout << "\nDoc file bi loi!!!";
	}
	int arr[100];
	int dem = 0, i = 0;
	while (!file.eof())
	{
		file >> arr[i];
		i++;
		dem++;
	}
	cout << "\nTong so phan tu: " << dem << endl;
	for (int j = 0; j < dem; j++)
	{
		Chen(root, arr[j]);
	}
	file.close();
}

//Ham Duyet LNR
void DuyetLNR(BST r)
{
	if (r != NULL)
	{
		DuyetLNR(r->left);
		cout << r->data << "  ";
		DuyetLNR(r->right);
	}
}

//Ham Duyet NLR
void DuyetNLR(BST r)
{
	if (r != NULL)
	{
		cout << r->data << "  ";
		DuyetNLR(r->left);
		DuyetNLR(r->right);
	}
}

//Ham Duyet LRN
void DuyetLRN(BST r)
{
	if (r != NULL)
	{
		DuyetLRN(r->left);
		DuyetLRN(r->right);
		cout << r->data << "  ";
	}
}

//Ham tim kiem
NODEPTR SearchNode(BST r, TYPEINFO a)
{
	if (r == NULL)
	{
		return NULL;
	}
	NODEPTR p = r;
	while (p != NULL)
	{
		if (p->data < a)
		{
			p = p->right;
			cout << "\t->" << p->data;
		}
		else if (p->data > a)
		{
			p = p->left;
			cout << "\t->" << p->data;
		}
		else
			return p;
	}
	return NULL;
}

//Ham tinh chieu cao cay
//int Hight(BST r)
//{
//	if (r == NULL) return 0;
//	int hl = 1 + ChieuCao(r->left);
//	int hr = 1 + ChieuCao(r->right);
//	if (hl >= hr) return hl;
//	else return hr;
//}

void main()
{
	BST r;
	TYPEINFO a;
	
	Init(r);
	Load_1(r);
	//Load_fstream(r);

	cout << "\nDuyet LNR:";
	DuyetLNR(r);
	cout << "\nDuyet NLR:";
	DuyetNLR(r);
	cout << "\nDuyet LRN:";
	DuyetLRN(r);
	cout << "\nNhap node can tim: ";
	cin >> a;
	//cout << "\nDuong di toi node " << a << " : " << SearchNode(r, a);
	//cout << "\nChieu cao cay: " << Hight(r);

	cout << "\n";
	system("pause");
}