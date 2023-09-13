#include "ExposureTimeMaths.h"
#include "ConstantsLib.h"
#include <cmath>

double ExposureTimeMaths::CalculateR500(double npfInputs[], double expoResults)
{
    return 500 / (npfInputs[0] * npfInputs[4]);
}

double ExposureTimeMaths::CalculateR300(double npfInputs[])
{
    return 300 / (npfInputs[0] * npfInputs[4]);
}

double ExposureTimeMaths::CalculateNPFsimple(double npfInputs[])
{
    return (35 * n + 30 * npfInputs[2]) / npfInputs[4];
}

double ExposureTimeMaths::CalculateNPFfull(double npfInputs[])
{
    ConstantsLib constant;
    double pi = constant.Pi();
    return npfInputs[0] * ((16.856 * npfInputs[2] + 0.0997 * npfInputs[4] + 13.713 * npfInputs[3]) / (npfInputs[4] * cos(npfInputs[5] * (180 / pi))));
}
