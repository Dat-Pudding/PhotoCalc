#include <iostream>
#include "MenuLogic.h"
#include "CameraDatabaseHandler.h"
#include <conio.h>
#include <dos.h>
using namespace std;

int MenuLogic::MenuHeader()
{
	string version = "[Win64 CLI pre-alpha_v0.1.2]";
	string author = " by Joshua Ostwald";
	cout << "Photographer's Calculator " + version + author + "\n\n";
	return 0;
}

int MenuLogic::MainMenu()
{
    cout << "Choose:\n 1 - Exposure Times\n 2 - Angle of View\n 3 - Camera/Sensor Data\n";
	return 0;
}

int MenuLogic::ExpoMenu()
{
    cout << "Exposure Length test Calculator                 NPF-Rule (C)Frederic Michaud & Societe Atronomique du Havre (SAH)\n\n";
    cout << "Please enter your data in this format: crop k n p f theta\n\n";
    cout << "Explanation:\n\n";
    cout << " crop          - Your sensor's crop factor e.g.: 1.6, unitless\n";
    cout << " k = 1/2/3     - Determines Precision (precise/normal/trailing), unitless\n";
    cout << " n             - The lens' aperture, unitless\n";
    cout << " p             - Pixelpitch of the Sensor in um\n";
    cout << " f             - The lens' focal length in mm\n";
    cout << " theta         - Declination of the target in degrees (enter 0 if unknown)\n\n";
    return 0;
}

double MenuLogic::ExpoResults(double resultR500, double resultR300, double resultNPFs, double resultNPF)
{
    string suffix = " seconds long lightframes\n";
    cout << "\nAccording to the Rule of 500 you can take up to " << resultR500 << suffix;
    cout << "According to the Rule of 300 you can take up to " << resultR300 << suffix;
    cout << "According to the simplified NPF-Rule you can take up to " << resultNPFs << suffix;
    cout << "According to the full NPF-Rule you can take up to " << resultNPF << suffix << "\n\n";
    cout << "(Press any key to continue)";
    _getch();
    system("cls");
    return 0;
}

int MenuLogic::FovMenu()
{
    cout << "FoV test Calculator                       courtesy of Elmar Baumann\n\n";
    cout << "Please enter your data in this format: fl w h \n\n";
    cout << "Explanation:\n\n";
    cout << " fl            - Your focal length in mm\n";
    cout << " w             - Your sensor's long edge length in mm\n";
    cout << " h             - Your sensor's short edge length in mm\n\n";
    return 0;
}

double MenuLogic::FovResults(double fovWidthAngle, double fovHeightAngle, double fovDiagonalAngle)
{
    cout << "Your Angle of View along the long edge of your sensor is " << fovWidthAngle << " degrees\n";
    cout << "Your Angle of View along the short edge of your sensor is " << fovHeightAngle << " degrees\n";
    cout << "Your Angle of View along the diagonal of your sensor is " << fovDiagonalAngle << " degrees\n\n";
    cout << "(Press any key to continue)";
    _getch();
    system("cls");
    return 0.0;
}

int MenuLogic::CamDBMenu()
{
    cout << "Camera Test Database" << endl << endl;
    cout << "ERROR: Feature is not implemented yet\n";
    cout << "(Press any key to continue)";
    _getch();
    system("cls");
    return 0;
}

int MenuLogic::DivByZero()
{
    cout << "Attempted division by 0!\n";
    cout << "Try again...                                       (Press any key to continue)\n";
    _getch();
    system("cls");

    return 0;
}

int MenuLogic::MenuReset()
{
    return 0;
}
