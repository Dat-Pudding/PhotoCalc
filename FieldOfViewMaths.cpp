#include "FieldOfViewMaths.h"
#include "ConstantsLib.h"
#include <cmath>

double FieldOfViewMaths::CalculateWidthFoV(double fl, double w)
{
	ConstantsLib constant;
	double pi = constant.Pi();
	return ((2 * atan(w / (2 * fl))) * (180 / pi));
}

double FieldOfViewMaths::CalculateHeightFoV(double fl, double h)
{
	ConstantsLib constant;
	double pi = constant.Pi();
	return ((2 * atan(h / (2 * fl))) * (180 / pi));
}

double FieldOfViewMaths::CalculateDiagonalFoV(double fl, double w, double h)
{
	ConstantsLib constant;
	double pi = constant.Pi();
	double diagonal = sqrt((w * w + h * h));
	return ((2 * atan(diagonal / (2 * fl))) * (180 / pi));
}
