#include <iostream>
#include "MenuLogic.h"
#include "MathsCompendium.h"
#include "CameraDatabaseHandler.h"
#include <conio.h>
#include <dos.h>

using namespace std;

int main()
{
    MathsCompendium expoC;
    MathsCompendium fovC;

    int menuPoint = 0;
    int mainMenuInput = 0;

    // in this order: crop, k, n, p, f, theta
    double npfInputs[6] = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

    // in this order: f, w, h
    double fovInputs[3] = { 0.0, 0.0, 0.0 };

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
                    expoC.CalcExpo(npfInputs);
                    Menus.ExpoResults(expoC.expoResults[0], expoC.expoResults[1], expoC.expoResults[2], expoC.expoResults[3]);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;

            case 2:

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
                    fovC.CalcFoV(fovInputs);
                    Menus.FovResults(fovC.fovResults[0], fovC.fovResults[1], fovC.fovResults[2]);
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
 