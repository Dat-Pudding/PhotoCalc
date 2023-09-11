#include <iostream>
#include "ExposureTimeMaths.h"

using namespace std;

int main()
{
    float menuPoint = 0.0;


    double crop = 1.0;
    double k = 0.0;
    double f = 0.0;
    double p = 0.0;
    double n = 0.0;
    double theta = 0.0;

    double resultR500 = 0.0;
    double resultR300 = 0.0;
    double resultNPFs = 0.0;
    double resultNPF = 0.0;
    string suffix = " seconds long lightframes\n";

    cout << "Photographer's Calculator v0.0.1" << endl << endl;
    //cout << "Choose:\n 1 - Exposure Times\n 2 - Angle of View\n 3 - Camera/Sensor Data\n";

    cout << "Exposure test Calculator" << endl << endl;
    cout << "Please enter your data in this format: crop k n p f theta\n" << endl;
    cout << "Explanation:\n     " << endl;
    cout << " crop          - Your sensor's crop factor e.g.: 1.6\n";
    cout << " k = 1/2/3     - Determines Precision (precise/normal/trailing)\n";
    cout << " n             - unitless, The lens' aperture\n";
    cout << " p             - Pixelpitch of the Sensor\n";
    cout << " f             - The lens' focal length in mm\n";
    cout << " theta         - Declination of the target in degrees (enter 0 if unknown)\n" << endl;

    ExposureTimeMaths c;
    while (true)
    {
        cin >> crop >> k >> n >> p >> f >> theta;

/*        if ()
        {

        } */

        if (f == 0)
        {
            cout << "Attempted division by 0!" << endl;
            continue;
        }
        else
        {
            resultR500 = c.CalculateR500(crop, f);
            resultR300 = c.CalculateR300(crop, f);
            resultNPFs = c.CalculateNPFsimple(n, p, f);
            resultNPF = c.CalculateNPFfull(k, n, p, f, theta);
        }

        cout << "\nAccording to the Rule of 500 you can take up to " << resultR500 << suffix;
        cout << "According to the Rule of 300 you can take up to " << resultR300 << suffix;
        cout << "According to the simplified NPF-Rule you can take up to " << resultNPFs << suffix;
        cout << "According to the full NPF-Rule you can take up to " << resultNPF << suffix;

        f = 0.0;
    }

    return 0;
}
/*
1.6 1 5.6 3.74 200 41   - can handle
1.6 1 5.6 3.74 0 0      - can handle
1.6 1 5.6 3.74          - messes up the number crunching with valid numbers for some reason
*/
 