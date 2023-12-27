#pragma once
class MenuLogic
{
public:
	int MenuHeader();
	int MainMenu();
	int ExpoMenu();
	double ExpoResults(double resultR500, double resultR300, double resultNPFs, double resultNPF);
	int FovMenu();
	double FovResults(double fovWidthAngle, double fovHeightAngle, double fovDiagonalAngle);
	int CamDBMenu();
	int DivByZero();
	int MenuReset();
};

