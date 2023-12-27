#include "mathscompendium.h"
#include <cmath>

// Exposure Length Calculations
double MathsCompendium::Calc_ExpoL()
{
    // Rule of custom integer
    expoLresults[0] = round(r500const / (cropFactor * expoFL) * 1000) / 1000;
    // Rule of 500
    expoLresults[1] = round(rCustomValue / (cropFactor * expoFL) * 1000) / 1000;
    // Simplified NPF formula
    expoLresults[2] = round((35 * aperture + 30 * pixelPitch) / expoFL * 1000) / 1000;
    // NPF formula
    expoLresults[3] = round(precisionLevel * ((16.856 * aperture + 0.0997 * expoFL + 13.713 * pixelPitch) / (expoFL * cos(declination * (fixedPi / 180)))) * 1000) / 1000;

    return expoLresults[0] && expoLresults[1] && expoLresults[2] && expoLresults[3];
}

double MathsCompendium::Calc_FoV()
{
    // Field of View along the sensor's long edge
    FoVresults[0] = round(((2 * atan(sensorWidth / (2 * fovFL))) * (180 / fixedPi)) * 1000) / 1000;
    // Field of View along the sensor's short edge
    FoVresults[1] = round(((2 * atan(sensorHeight / (2 * fovFL))) * (180 / fixedPi)) * 1000) / 1000;
    // Field of View along the sensor's diagonal
    float diagonalLength;
    diagonalLength = sqrt(sensorWidth * sensorWidth + sensorHeight * sensorHeight);
    FoVresults[2] = round(((2 * atan(diagonalLength / (2 * fovFL))) * (180 / fixedPi)) * 1000) / 1000;

    return FoVresults[0] && FoVresults[1] && FoVresults[2];
}
