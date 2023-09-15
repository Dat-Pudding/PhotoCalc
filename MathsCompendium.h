#pragma once
class MathsCompendium
{
public:
	
	//////////////////////////////////////////////////////////////////////////////////
	// EXPOSURE LENGHTS
	double CalculateR500(double npfInputs[], double expoResults);
	double CalculateR300(double npfInputs[], double expoResults[]);
	double CalculateNPFsimple(double npfInputs[], double expoResults[]);

	//gotta ask Frédéric Michaud for a license to use his NPF formula (should I ever get to turn this into something real
	double CalculateNPFfull(double npfInputs[], double expoResults[]);


	//////////////////////////////////////////////////////////////////////////////////
	// FIELD OF VIEW
	double CalculateWidthFoV(double fovInputs[], double fovResults);
	double CalculateHeightFoV(double fovInputs[], double fovResults[]);
	double CalculateDiagonalFoV(double fovInputs[], double fovResults[]);
};

