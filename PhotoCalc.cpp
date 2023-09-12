#include <iostream>
#include "MenuLogic.h"
#include "ExposureTimeMaths.h"
#include "FieldOfViewMaths.h"
#include "CameraDatabaseHandler.h"
#include <conio.h>
#include <dos.h>

using namespace std;

int main()
{
    int menuPoint = 0;
    int mainMenuInput = 0;

    double crop = 1.0;
    int k = 0;
    double f = 0.0;
    double p = 0.0;
    double n = 0.0;
    double theta = 0.0;

    double resultR500 = 0.0;
    double resultR300 = 0.0;
    double resultNPFs = 0.0;
    double resultNPF = 0.0;
    
    double fl = 0.0;
    double w = 0.0;
    double h = 0.0;

    double fovWidthAngle = 0.0;
    double fovHeightAngle = 0.0;
    double fovDiagonalAngle = 0.0;

    while (menuPoint == 0)
    {
        MenuLogic Menus;
        Menus.MenuHeader();
        Menus.MainMenu();

        cin >> mainMenuInput;
        system("cls");
        switch (mainMenuInput)
        {
            case 0:
                main();
                break;

            case 1:
                ExposureTimeMaths expoC;
                Menus.MenuHeader();
                Menus.ExpoMenu();
                cin >> crop >> k >> n >> p >> f >> theta;

                if (f == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    resultR500 = expoC.CalculateR500(crop, f);
                    resultR300 = expoC.CalculateR300(crop, f);
                    resultNPFs = expoC.CalculateNPFsimple(n, p, f);
                    resultNPF = expoC.CalculateNPFfull(k, n, p, f, theta);
                    Menus.ExpoResults(resultR500, resultR300, resultNPFs, resultNPF);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;
                

            case 2:
                FieldOfViewMaths fovC;
                Menus.MenuHeader();
                Menus.FovMenu();

                cin >> fl >> w >> h;

                if (fl == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    fovWidthAngle = fovC.CalculateWidthFoV(fl, w);
                    fovHeightAngle = fovC.CalculateHeightFoV(fl, h);
                    fovDiagonalAngle = fovC.CalculateDiagonalFoV(fl, w, h);
                    Menus.FovResults(fovWidthAngle, fovHeightAngle, fovDiagonalAngle);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;

            case 3:
                CameraDatabaseHandler camDB;
                Menus.MenuHeader();
                cout << "Camera Test Database" << endl << endl;
                cout << "ERROR: Feature is not implemented yet\n";
                cout << "(Press any key to continue)";
                _getch();
                system("cls");
                mainMenuInput = 0;
                break;
                
            default:
                main();


        }
    }
    return 0;
}
/*
1.6 1 5.6 3.74 200 41   - can handle
1.6 1 5.6 3.74 0 0      - can handle
1.6 1 5.6 3.74          - messes up the number crunching with valid numbers for some reason
*/
 