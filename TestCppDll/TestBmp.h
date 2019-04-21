#pragma once

#ifdef __cplusplus
#define DLLEXPORT extern "C" __declspec(dllexport)
#else
#define DLLEXPORT __declspec(dllexport)
#endif

#include <string>
using namespace std;



struct BmpInfo {

	char FileName[255];
	long long Offset;
};

DLLEXPORT int CreateBMP(const char* fileName, BmpInfo* bmpInfo);
DLLEXPORT int Test();

