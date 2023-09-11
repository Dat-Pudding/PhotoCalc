#pragma once
class ExposureTimeMaths
{
public:
	double CalculateR500(double crop, double f);
	double CalculateR300(double crop, double f);
	double CalculateNPFsimple(double n, double p, double f);
	double CalculateNPFfull(double k, double n, char p, double f, double theta);
};

