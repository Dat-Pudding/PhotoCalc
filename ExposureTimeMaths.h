#pragma once
class ExposureTimeMaths
{
public:
	double CalculateR500(double npfInputs[], double expoResults[]);
	double CalculateR300(double npfInputs[], double expoResults[]);
	double CalculateNPFsimple(double npfInputs[], double expoResults[]);
	double CalculateNPFfull(double npfInputs[], double expoResults[]);
};

