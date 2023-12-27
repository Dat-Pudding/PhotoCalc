#ifndef MATHSCOMPENDIUM_H
#define MATHSCOMPENDIUM_H

class MathsCompendium
{
public:

    // Declaring and defining constants in one go
    double fixedPi = 3.141592653589793;
    int r500const = 500;

/* Declaring the arrays and variables holding the Inputs and results */
    // Arrays
    double expoLresults[4];
    double FoVresults[3];

    // Variables for Calc_ExpoL()
    double cropFactor;
    double aperture;
    double expoFL;
    double pixelPitch;
    double declination;
    double precisionLevel;
    int rCustomValue;

    // Variables for Calc_FoV()
    double sensorWidth;
    double sensorHeight;
    double fovFL;

/* Calculation Functions within class - each returning the results as entries of their respective arrays */
    // Exposure Length calculations
    double Calc_ExpoL();

    // Viewing Angle calculations
    double Calc_FoV();
};

#endif // MATHSCOMPENDIUM_H
