#include "MathsCompendium.h"
#include <cmath>

double MathsCompendium::CalcExpo(double npfInputs[])
{
    expoResults[0] = 500 / (npfInputs[0] * npfInputs[4]);
    expoResults[1] = 300 / (npfInputs[0] * npfInputs[4]);
    expoResults[2] = (35 * npfInputs[2] + 30 * npfInputs[3]) / npfInputs[4];
    expoResults[3] = npfInputs[1] * ((16.856 * npfInputs[2] + 0.0997 * npfInputs[4] + 13.713 * npfInputs[3]) / (npfInputs[4] * cos(npfInputs[5] * (pi / 180))));
    return expoResults[0], expoResults[1], expoResults[2], expoResults[3];
}

double MathsCompendium::CalcFoV(double fovInputs[])
{
    fovResults[0] = (2 * atan(fovInputs[1] / (2 * fovInputs[0]))) * (180 / pi);
    fovResults[1] = (2 * atan(fovInputs[2] / (2 * fovInputs[0]))) * (180 / pi);
    fovResults[2] = sqrt(fovInputs[1] * fovInputs[1] + fovInputs[2] * fovInputs[2]);
    return fovResults[0], fovResults[1], fovResults[2];
}