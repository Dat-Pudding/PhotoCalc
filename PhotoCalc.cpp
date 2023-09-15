#include <iostream>
#include "MenuLogic.h"
#include "MathsCompendium.h"
#include "CameraDatabaseHandler.h"
#include <conio.h>
#include <dos.h>

using namespace std;

int main()
{
    int menuPoint = 0;
    int mainMenuInput = 0;

    // in this order: crop, k, n, p, f, theta
    double npfInputs[6] = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

    // in this order: f, w, h
    double fovInputs[3] = { 0.0, 0.0, 0.0 };

    // in this order: R500, R300, NPFs, NPF
    double expoResults[4] = { 0.0, 0.0, 0.0, 0.0 };

    // in this order: width-wise, height-wise, diagonally
    double fovResults[3] = { 0.0, 0.0, 0.0 };
    
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
                MathsCompendium expoC;
                Menus.MenuHeader();
                Menus.ExpoMenu();
                cin >> npfInputs[0] >> npfInputs[1] >> npfInputs[2] >> npfInputs[3] >> npfInputs[4] >> npfInputs[5];

                if (npfInputs[4] == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    expoResults[0] = expoC.CalculateR500(npfInputs, expoResults[0]);
                    expoResults[1] = expoC.CalculateR300(npfInputs, expoResults);
                    expoResults[2] = expoC.CalculateNPFsimple(npfInputs, expoResults);
                    expoResults[3] = expoC.CalculateNPFfull(npfInputs, expoResults);
                    Menus.ExpoResults(expoResults[0], expoResults[1], expoResults[2], expoResults[3]);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;

            case 2:
                MathsCompendium fovC;
                Menus.MenuHeader();
                Menus.FovMenu();

                cin >> fovInputs[0] >> fovInputs[1] >> fovInputs[2];

                if (fovInputs[0] == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    fovWidthAngle = fovC.CalculateWidthFoV(fovInputs, fovResults[1]);
                    fovHeightAngle = fovC.CalculateHeightFoV(fovInputs, fovResults);
                    fovDiagonalAngle = fovC.CalculateDiagonalFoV(fovInputs, fovResults);
                    Menus.FovResults(fovWidthAngle, fovHeightAngle, fovDiagonalAngle);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;

            case 3:
                CameraDatabaseHandler camDB;
                Menus.MenuHeader();
                Menus.CamDBMenu();
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
 