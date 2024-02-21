#pragma once
class MenuLogic
{
public:
	void MenuHeader(); // contains version and author, displays both in a formatted way
	void MainMenu(); // displays the main menu entries
	void ExpoMenu(); // submenu for exposure length calculations, explains/displays how and what to enter
	void FovMenu(); // submenu for viewing angle calculations, explains/displays how and what to enter
	void CamDBMenu(); // COMING SOON! will contain pages of camera/sensor data

	void ExpoResults(double resultR500, double resultR300, double resultNPFs, double resultNPF); // displays CalcExpo() results fed in via overloads in main()
	void FovResults(double fovWidthAngle, double fovHeightAngle, double fovDiagonalAngle); // displays the CalcFov() results fed in via overloads in main()

	void DivByZero(); // Error handling
	void MenuReset(); // for later implementation, will set the mainMenuInput in main() to 0
};

