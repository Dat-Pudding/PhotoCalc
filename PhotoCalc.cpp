#include <iostream>
#include "ExposureTimeMaths.h"
#include "FieldOfViewMaths.h"
#include "CameraDatabaseHandler.h"

using namespace std;

int main()
{
    string version = "[Win64 CLI pre-alpha_v0.1.0]";
    int menuPoint = 0;
    int menuInput = 0;

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
    string suffix = " seconds long lightframes\n";
    
    double fl = 0.0;
    double w = 0.0;
    double h = 0.0;

    double fovWidthAngle = 0.0;
    double fovHeightAngle = 0.0;
    double fovDiagonalAngle = 0.0;

    cout << "Photographer's Calculator " << version << endl << endl;
    cout << "Choose:\n 1 - Exposure Times\n 2 - Angle of View\n 3 - Camera/Sensor Data\n";

    while (menuPoint == 0)
    {
        cin >> menuInput;

        switch (menuInput)
        {
            case 0:
                main();
                break;

            case 1:
                ExposureTimeMaths expoC;
                cout << "Exposure test Calculator\n\n";
                cout << "Please enter your data in this format: crop k n p f theta\n\n";
                cout << "Explanation:\n\n";
                cout << " crop          - Your sensor's crop factor e.g.: 1.6, unitless\n";
                cout << " k = 1/2/3     - Determines Precision (precise/normal/trailing), unitless\n";
                cout << " n             - The lens' aperture, unitless\n";
                cout << " p             - Pixelpitch of the Sensor in um\n";
                cout << " f             - The lens' focal length in mm\n";
                cout << " theta         - Declination of the target in degrees (enter 0 if unknown)\n\n";

                cin >> crop >> k >> n >> p >> f >> theta;

                if (f == 0)
                {
                    cout << "Attempted division by 0!\n";
                    cout << "Try again...\n";
                    continue;
                }
                else
                {
                    resultR500 = expoC.CalculateR500(crop, f);
                    resultR300 = expoC.CalculateR300(crop, f);
                    resultNPFs = expoC.CalculateNPFsimple(n, p, f);
                    resultNPF = expoC.CalculateNPFfull(k, n, p, f, theta);

                    cout << "\nAccording to the Rule of 500 you can take up to " << resultR500 << suffix;
                    cout << "According to the Rule of 300 you can take up to " << resultR300 << suffix;
                    cout << "According to the simplified NPF-Rule you can take up to " << resultNPFs << suffix;
                    cout << "According to the full NPF-Rule you can take up to " << resultNPF << suffix << "\n";
                    cout << "Input 1 for another Exposure Length Calculation; Input 2 for a FoV Calculation; Ctrl+C to quit\n";
                    menuInput = 0;
                }
                menuInput = 0;
                break;
                

            case 2:
                FieldOfViewMaths fovC;
                cout << "FoV test Calculator\n\n";
                cout << "Please enter your data in this format: fl w h \n\n";
                cout << "Explanation:\n\n";
                cout << " fl            - Your focal length in mm\n";
                cout << " w             - Your sensor's long edge length in mm\n";
                cout << " h             - Your sensor's short edge length in mm\n\n";

                cin >> fl >> w >> h;

                if (fl == 0)
                {
                    cout << "Attempted division by 0!\n";
                    cout << "Try again...\n";
                    continue;
                }
                else
                {
                    fovWidthAngle = fovC.CalculateWidthFoV(fl, w);
                    fovHeightAngle = fovC.CalculateHeightFoV(fl, h);
                    fovDiagonalAngle = fovC.CalculateDiagonalFoV(fl, w, h);

                    cout << "Your Angle of View along the long edge of your sensor is " << fovWidthAngle << " degrees\n";
                    cout << "Your Angle of View along the short edge of your sensor is " << fovHeightAngle << " degrees\n";
                    cout << "Your Angle of View along the diagonal of your sensor is " << fovDiagonalAngle << " degrees\n\n";
                    cout << "Input 1 for an Exposure Length Calculation; Input 2 for another FoV Calculation; Ctrl+C to quit\n";
                    menuInput = 0;
                }
                menuInput = 0;
                break;

           /* case 3:
                CameraDatabaseHandler camDB;
                cout << "Camera Test Database" << endl << endl;
                cout << "Currently not finished, please come back later...";
                menuInput = 0;
                break;
                */
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
 