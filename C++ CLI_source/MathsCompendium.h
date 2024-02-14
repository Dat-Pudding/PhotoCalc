#pragma once
class MathsCompendium
{
public:
	//////////////////////////////////////////////////////////////////////////////////
	// ARRAYS AND CONSTANTS	
	double fovResults[3] = { }; // in this order: width-wise, height-wise, diagonally
	double pi = 3.1415926535897932384626433832795028841971;

	//////////////////////////////////////////////////////////////////////////////////
	// EXPOSURE LENGHTS
	double CalculateR500(double npfInputs[], double expoResults);
	double CalculateR300(double npfInputs[], double expoResults[]);
	double CalculateNPFsimple(double npfInputs[], double expoResults[]);
	double CalculateNPFfull(double npfInputs[], double expoResults[]);


	//////////////////////////////////////////////////////////////////////////////////
	// FIELD OF VIEW
	double CalcFoV(double fovInputs[]);
};

