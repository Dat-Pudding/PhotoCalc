#pragma once
class MenuLogic
{
public:
	int MenuHeader(); // contains version and author, displays both in a formatted way
	int MainMenu(); // displays the main menu entries
	int ExpoMenu(); // submenu for exposure length calculations, explains/displays how and what to enter
	int FovMenu(); // submenu for viewing angle calculations, explains/displays how and what to enter 
	int CamDBMenu(); // COMING SOON! will contain pages of camera/sensor data 

	double ExpoResults(double resultR500, double resultR300, double resultNPFs, double resultNPF); // displays the exposure length results fed in via overloads in main()
	double FovResults(double fovWidthAngle, double fovHeightAngle, double fovDiagonalAngle); // displays the viewing angle results fed in via overloads in main()

	int DivByZero(); // Error handling
	int MenuReset(); // for later implementation, will set the mainMenuInput in main() to 0
};

