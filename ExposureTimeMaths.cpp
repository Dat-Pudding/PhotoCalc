#include "ExposureTimeMaths.h"
#include "ConstantsLib.h"
#include <cmath>

double ExposureTimeMaths::CalculateR500(double npfInputs[], double expoResults[])
{
    return 500 / (npfInputs[0] * npfInputs[4]);
}

double ExposureTimeMaths::CalculateR300(double npfInputs[], double expoResults[])
{
    return 300 / (npfInputs[0] * npfInputs[4]);
}

double ExposureTimeMaths::CalculateNPFsimple(double npfInputs[], double expoResults[])
{
    return (35 * npfInputs[2] + 30 * npfInputs[3]) / npfInputs[4];
}

double ExposureTimeMaths::CalculateNPFfull(double npfInputs[], double expoResults[])
{
    ConstantsLib constant;
    double pi = constant.Pi();

    //gotta ask Frédéric Michaud for a license to use his NPF formula (should I ever get to turn this into something real
    return npfInputs[1] * ((16.856 * npfInputs[2] + 0.0997 * npfInputs[4] + 13.713 * npfInputs[3]) / (npfInputs[4] * cos(npfInputs[5] * (180 / pi))));
}
