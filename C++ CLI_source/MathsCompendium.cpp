#include "MathsCompendium.h"
#include "ConstantsLib.h"
#include <cmath>


//////////////////////////////////////////////////////////////////////////////////
// EXPOSURE LENGHTS
double MathsCompendium::CalculateR500(double npfInputs[], double expoResults)
{
    return 500 / (npfInputs[0] * npfInputs[4]);
}

double MathsCompendium::CalculateR300(double npfInputs[], double expoResults[])
{
    return 300 / (npfInputs[0] * npfInputs[4]);
}

double MathsCompendium::CalculateNPFsimple(double npfInputs[], double expoResults[])
{
    return (35 * npfInputs[2] + 30 * npfInputs[3]) / npfInputs[4];
}

double MathsCompendium::CalculateNPFfull(double npfInputs[], double expoResults[])
{
    ConstantsLib constant;
    double pi = constant.Pi();
    return npfInputs[1] * ((16.856 * npfInputs[2] + 0.0997 * npfInputs[4] + 13.713 * npfInputs[3]) / (npfInputs[4] * cos(npfInputs[5] * (180 / pi))));
}


//////////////////////////////////////////////////////////////////////////////////
// FIELD OF VIEW
double MathsCompendium::CalcFoV(double fovInputs[])
{
    fovResults[0] = ((2 * atan(fovInputs[1] / (2 * fovInputs[0]))) * (180 / pi));
    fovResults[1] = ((2 * atan(fovInputs[2] / (2 * fovInputs[0]))) * (180 / pi));
    fovResults[2] = sqrt((fovInputs[1] * fovInputs[1] + fovInputs[2] * fovInputs[2]));

    return fovResults[0], fovResults[1], fovResults[2];
}