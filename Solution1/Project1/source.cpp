#include <Windows.h>
#include <ScrnSave.h>

#ifdef UNICODE
	#pragma comment(lib, "ScrnSavW.lib")
#else
	#pragma comment(lib, "ScrnSave.lib")
#endif

#pragma comment(lib,"ComCtl32.lib")

/*
    ��ũ�� ���̹��� �޽����� ó���ϴ� �޽��� ���ν��� 
    ������ WndProc�� �����ϸ� ���α׷��� ����� ���� 
    ��ũ�� ���̹� ���̺귯���� ���ø��� ������ ��üȭ���� ������ ��濡 �׻� �� �ɼ����� ���� �����츦 ����� 
    ���� �������� �޽��� ���ν����� �� �Լ��� �����Ѵ�.
    �� �Լ����� ó������ �ʴ� �޽����� DefScreenSaverProc�Լ��� �����Ͽ� ��ũ�� ���̹� ���̺귯���� ó�� 
*/
LRESULT WINAPI ScreenSaverProc(HWND hWnd, UINT iMessage, WPARAM wParam, LPARAM lParam)
{
    switch(iMessage){
    //case WM_CREATE:
    //    return 0;

    //case WM_PAINT:
    //    return 0;

	case WM_KEYDOWN:
		return 0;

	case WM_MOUSEMOVE:
		return 0;

	//case WM_DESTROY:
	//	return 0;
    }
    return DefScreenSaverProc(hWnd,iMessage,wParam,lParam);
}

/* 
    ���� ��ȭ������ �޽��� ó�� �Լ�. �Ϲ����� ��ȭ���� �޽��� ���ν����� ���� 
    ����ڷκ��� ���� ���¸� �Է¹޾� ��ӵ� ���(���� ������Ʈ��)�� �����ϴ� ���� 
*/
BOOL WINAPI ScreenSaverConfigureDialog(HWND hDlg, UINT iMessage, WPARAM wParam, LPARAM lParam)
{
    return TRUE;
}

/* 
    Ŀ���� ��Ʈ���� ����� �� ���. ���� TRUE�� �����ϸ� �ȴ�.* 
*/
BOOL WINAPI RegisterDialogClasses(HANDLE hInst)
{
    return TRUE;
}