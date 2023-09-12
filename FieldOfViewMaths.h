#pragma once
class FieldOfViewMaths
{
public:
	double CalculateWidthFoV(double fl, double w);
	double CalculateHeightFoV(double fl, double w);
	double CalculateDiagonalFoV(double fl, double w, double h);
};

