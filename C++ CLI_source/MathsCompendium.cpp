#include "MathsCompendium.h"
#include <math.h>

void ExposureLength::CalcExpo()
{
	Output.R500 = constant.R500_NUM / (Input.cropFactor * Input.focalLength);
	Output.R300 = constant.R300_NUM / (Input.cropFactor * Input.focalLength);
	Output.NPFs = (constant.NPFs_APERTURE_MULT * Input.aperture + constant.NPFs_PIXELPITCH_MULT * Input.pixelPitch) / Input.focalLength;
	Output.NPF = Input.precision * ((constant.NPF_APERTURE_MULT * Input.aperture + constant.NPF_FOCAL_LENGTH_MULT * Input.focalLength + constant.NPF_PIXELPITCH_MULT * Input.pixelPitch) / (Input.focalLength * cos(Input.declinationTheta * constant.RAD_TO_DEG)));
}

void FieldOfView::CalcFov()
{
	Output.widthFov = 2 * atan(Input.sensorWidth / (2 * Input.focalLength) * (constant.HALF_CIRCLE_DEGREES / constant.PI));
	Output.heightFov = 2 * atan(Input.sensorWidth / (2 * Input.focalLength) * (constant.HALF_CIRCLE_DEGREES / constant.PI));
	Output.diagFov = sqrt(Input.sensorHeight * Input.sensorHeight + Input.sensorWidth * Input.sensorWidth);
};