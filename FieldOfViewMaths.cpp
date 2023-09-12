#include "FieldOfViewMaths.h"
#include <cmath>

double FieldOfViewMaths::CalculateWidthFoV(double fl, double w)
{
	return ((2 * atan(w / (2 * fl))) * (180 / 3.14159265358979));
}

double FieldOfViewMaths::CalculateHeightFoV(double fl, double h)
{
	return ((2 * atan(h / (2 * fl))) * (180 / 3.14159265358979));
}

double FieldOfViewMaths::CalculateDiagonalFoV(double fl, double w, double h)
{
	double diagonal = sqrt((w * w + h * h));
	return ((2 * atan(diagonal / (2 * fl))) * (180 / 3.14159265358979));
}
