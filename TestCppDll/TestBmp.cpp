#include "pch.h"

#include "TestBmp.h"
#include <iostream>
using namespace std;
#include <list>

DLLEXPORT int CreateBMP(const char* fileName, BmpInfo* bmpInfo)
{

	list<BmpInfo> bmpList;

	BmpInfo item1 = { "File1", 0x0003 };
	BmpInfo item2 = { "File2", 0x0002 };

	bmpList.push_back(item1);
	bmpList.push_back(item2);

	cout << "count in dll:" << bmpList.size();

	int num = bmpList.size();

	int cnt = 0;
	for (auto itr = bmpList.begin(); itr != bmpList.end(); ++itr) {
		bmpInfo[cnt++] = *itr;
	}

	return bmpList.size();
}

