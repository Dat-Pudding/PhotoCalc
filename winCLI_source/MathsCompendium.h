#pragma once

struct ConstCollection
{
	const int HALF_CIRCLE_DEGREES = 180;
	const int R500_NUM = 500;
	const int R300_NUM = 300;
	const int NPFs_APERTURE_MULT = 35;
	const int NPFs_PIXELPITCH_MULT = 30;
	const double NPF_APERTURE_MULT = 16.8560001;
	const double NPF_FOCAL_LENGTH_MULT = 0.0997001;
	const double NPF_PIXELPITCH_MULT = 13.7130001;
	const double PI = 3.141592653589793;
	const double RAD_TO_DEG = PI / HALF_CIRCLE_DEGREES;
};

class ExposureLength
{
public:
	struct inputs
	{
		double cropFactor, precision, aperture, pixelPitch, focalLength, declinationTheta;
	};

	struct outputs
	{
		double R500, R300, NPFs, NPF;
	};

	inputs Input;
	outputs Output;
	void CalcExpo();

private:
	ConstCollection constant;
};

class FieldOfView
{
public:
	struct inputs
	{
		double focalLength, sensorWidth, sensorHeight;
	};

	struct outputs
	{
		double widthFov, heightFov, diagFov;
	};

	inputs Input;
	outputs Output;

	void CalcFov();

private:
	ConstCollection constant;
};