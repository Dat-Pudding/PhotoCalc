#pragma once
class MathsCompendium
{
public:
	double expoResults[4] = { 0.0, 0.0, 0.0, 0.0 }; // in this order: R500, R300, NPFs, NPF
	double fovResults[3] = { }; // in this order: width-wise, height-wise, diagonally
	double pi = 3.1415926535897932384626433832795028841971; // pi

	double CalcExpo(double npfInputs[]); // Calculates the Exposure length results from the inputs
	double CalcFoV(double fovInputs[]); // Calculates the viewing angle results from the inputs
};

