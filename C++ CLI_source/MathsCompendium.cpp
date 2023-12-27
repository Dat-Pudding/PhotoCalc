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
double MathsCompendium::CalculateWidthFoV(double fovInputs[], double fovResults)
{
    ConstantsLib constant;
    double pi = constant.Pi();
    return ((2 * atan(fovInputs[1] / (2 * fovInputs[0]))) * (180 / pi));
}

double MathsCompendium::CalculateHeightFoV(double fovInputs[], double fovResults[])
{
    ConstantsLib constant;
    double pi = constant.Pi();
    return ((2 * atan(fovInputs[2] / (2 * fovInputs[0]))) * (180 / pi));
}

double MathsCompendium::CalculateDiagonalFoV(double fovInputs[], double fovResults[])
{
    ConstantsLib constant;
    double pi = constant.Pi();
    double diagonal = sqrt((fovInputs[1] * fovInputs[1] + fovInputs[2] * fovInputs[2]));
    return ((2 * atan(diagonal / (2 * fovInputs[0]))) * (180 / pi));
}
