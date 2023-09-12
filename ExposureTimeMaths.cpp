#include "ExposureTimeMaths.h"
#include "ConstantsLib.h"
#include <cmath>

double ExposureTimeMaths::CalculateR500(double crop, double f)
{
    return 500 / (crop * f);
}

double ExposureTimeMaths::CalculateR300(double crop, double f)
{
    return 300 / (crop * f);
}

double ExposureTimeMaths::CalculateNPFsimple(double n, double p, double f)
{
    return (35 * n + 30 * p) / f;
}

double ExposureTimeMaths::CalculateNPFfull(int k, double n, char p, double f, double theta)
{
    ConstantsLib constant;
    double pi = constant.Pi();
    return k * ((16.856 * n + 0.0997 * f + 13.713 * p) / (f * cos(theta * (180 / pi))));
}
