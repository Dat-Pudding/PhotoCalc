#pragma once
class MenuLogic
{
public:
	// menu stuff
	int MenuHeader();
	int MainMenu();
	int ExpoMenu();
	int FovMenu();
	int CamDBMenu();

	// transfer to output line
	double ExpoResults(double resultR500, double resultR300, double resultNPFs, double resultNPF);
	double FovResults(double fovWidthAngle, double fovHeightAngle, double fovDiagonalAngle);

	// App-internal functions
	int DivByZero();
	int MenuReset();
};

