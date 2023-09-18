using System;
using UnityEngine;


public class Maths : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // MROe - Referenced Objects (assign in Editor)
    //
    public InputManager inputManager;

    ///////////////////////////////////////////////////////////////////
    // MROc - Referenced Objects (assign in Code)
    //


    ///////////////////////////////////////////////////////////////////
    // Mdec - Declarations
    //


    ///////////////////////////////////////////////////////////////////
    // MWL - Workload
    //
    public void CalcR500()
    {
        inputManager.R500result = Math.Round(500 / (inputManager.mathFocalLength * inputManager.mathCropFactor), 3);

    }
    public void CalcR300()
    {
        inputManager.R300result = Math.Round(300 / (inputManager.mathFocalLength * inputManager.mathCropFactor), 3);
    }
    public void CalcNPFs()
    {
        inputManager.NPFsResult = Math.Round((35 * inputManager.mathAperture + 30 * inputManager.mathPixelPitch) / inputManager.mathFocalLength, 3);
    }
    public void CalcNPF()
    {
        inputManager.NPFresult = Math.Round(inputManager.k * ((16.856 * inputManager.mathAperture + 0.0997 * inputManager.mathFocalLength + 13.713 * inputManager.mathPixelPitch) / ((inputManager.mathFocalLength * (Math.Cos(inputManager.mathDeclination))))), 3);
    }

    public void CalcFovWidth()
    {
        inputManager.fovWidthResult = Math.Round((2 * Math.Atan(inputManager.mathWidth / (2 * inputManager.mathFocalLengthFov))) * (180 / Math.PI), 3);
    }
    public void CalcFovHeight()
    {
        inputManager.fovHeightResult = Math.Round((2 * Math.Atan(inputManager.mathHeight / (2 * inputManager.mathFocalLengthFov))) * (180 / Math.PI), 3);
    }
    public void CalcFovDiagonal()
    {
        double diagonal = Math.Sqrt(Math.Pow(inputManager.mathWidth, 2) + Math.Pow(inputManager.mathHeight, 2));
        inputManager.fovDiagonalResult = Math.Round((2 * Math.Atan(diagonal / (2 * inputManager.mathFocalLengthFov))) * (180 / Math.PI), 3);
    }
}
