#pragma once
class ExposureTimeMaths
{
public:
	double CalculateR500(double npfInputs, double expoResults);
	double CalculateR300(double npfInputs);
	double CalculateNPFsimple(double npfInputs);
	double CalculateNPFfull(double npfInputs);
};

