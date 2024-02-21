#include <iostream>
#include "MenuLogic.h"
#include "MathsCompendium.h"
#include "CameraDatabaseHandler.h"
#include <conio.h>
#include <dos.h>

using namespace std;

int main()
{
    ExposureLength expo;
    FieldOfView fov;

    int menuPoint = 0;
    int mainMenuInput = 0;

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


                cin >> expo.Input.cropFactor >> expo.Input.precision >> expo.Input.aperture >> expo.Input.pixelPitch >> expo.Input.focalLength >> expo.Input.declinationTheta;

                if (expo.Input.focalLength == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    expo.CalcExpo();
                    Menus.ExpoResults(expo.Output.R500, expo.Output.R300, expo.Output.NPFs, expo.Output.NPF);
                    mainMenuInput = 0;
                }
                mainMenuInput = 0;
                break;

            case 2:

                Menus.MenuHeader();
                Menus.FovMenu();

                cin >> fov.Input.focalLength >> fov.Input.sensorWidth >> fov.Input.sensorHeight;

                if (fov.Input.focalLength == 0)
                {
                    Menus.DivByZero();
                    continue;
                }
                else
                {
                    fov.CalcFov();
                    Menus.FovResults(fov.Output.widthFov, fov.Output.heightFov, fov.Output.diagFov);
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
