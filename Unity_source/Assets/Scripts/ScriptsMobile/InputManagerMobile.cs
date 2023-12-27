using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class InputManagerMobile : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // IMROe - Referenced Objects (assign in Editor)
    //
    public MathsMobile maths;
    public SideBarManagerMobile sideBarManager;
    public OutputManagerMobile outputManager;

    public TMP_InputField focalLengthInput;
    public TMP_InputField apertureInput;
    public TMP_InputField pixelPitchInput;
    public TMP_InputField decInput;
    public TMP_InputField cropInput;
    public TMP_Dropdown precisionChoice;

    public TMP_Text R500_OUT;
    public TMP_Text R300_OUT;
    public TMP_Text NPFs_OUT;
    public TMP_Text NPF_OUT;

    public TMP_InputField widthInput;
    public TMP_InputField heightInput;
    public TMP_InputField focalLengthFovInput;

    public TMP_Text FoV_W_OUT;
    public TMP_Text FoV_H_OUT;
    public TMP_Text FoV_D_OUT;

    public TMP_Text OutputTimeText;

    public Button calcButton;

    ///////////////////////////////////////////////////////////////////
    // IMROc - Referenced Objects (assign in Code)
    //

    ///////////////////////////////////////////////////////////////////
    // IMdec - Declarations
    //
    private readonly string red = "<color=#FF3300>";
    private readonly string green = "<color=#33FF00>";
    private readonly string orange = "<color=#FFBB00>";
    private readonly string endColor = "</color>";
    string width;
    string height;
    string focalLengthFov;

    string focalLength;
    string aperture;
    string pixelPitch;
    string declination;
    string crop;

    public float mathWidth;
    public float mathHeight;
    public float mathFocalLengthFov;

    public float mathFocalLength;
    public float mathAperture;
    public float mathPixelPitch;
    public double mathDeclination;
    public float mathCropFactor;
    public int k;

    public double R500result;
    public double R300result;
    public double NPFsResult;
    public double NPFresult;

    public double fovWidthResult;
    public double fovHeightResult;
    public double fovDiagonalResult;

    ///////////////////////////////////////////////////////////////////
    // IMP - Preparations
    //

    ///////////////////////////////////////////////////////////////////
    // IMWL - Workload
    //
    public void LookUpRecipe()
    {
        ExpoT_Recipe();
        FoV_Recipe();
    }

    public void CookForMaths()
    {
        float.TryParse(width, out float Wresult);
        float.TryParse(height, out float Hresult);
        float.TryParse(focalLengthFov, out float FLfovResult);

        float.TryParse(focalLength, out float FLresult);
        float.TryParse(aperture, out float APresult);
        float.TryParse(pixelPitch, out float PPresult);
        float.TryParse(declination, out float DECresult);
        float.TryParse(crop, out float CROPresult);

        mathWidth = Wresult;
        mathHeight = Hresult;
        mathFocalLengthFov = FLfovResult;

        mathFocalLength = FLresult;
        mathAperture = APresult;
        mathPixelPitch = PPresult;
        mathDeclination = DECresult * (Math.PI / 180);
        mathCropFactor = CROPresult;
    }

    public void GetFromMaths()
    {
        maths.CalcR500();
        maths.CalcR300();
        maths.CalcNPFs();
        maths.CalcNPF();

        maths.CalcFovWidth();
        maths.CalcFovHeight();
        maths.CalcFovDiagonal();
    }

    public void CheckDropdown()
    {
        outputManager.SetTimeStamp();
        k = precisionChoice.value + 1;
    }

    public void SendToText()
    {
        R500_OUT.text = "500-Rule: " + red + R500result + endColor + "s";
        R300_OUT.text = "300-Rule: " + red + R300result + endColor + "s";
        NPFs_OUT.text = "NPFs-Rule: " + red + NPFsResult + endColor + "s";
        NPF_OUT.text = "NPF-Rule: " + green + NPFresult + endColor + "s";

        FoV_W_OUT.text = "Along long side:  " + orange + fovWidthResult + endColor + "°";
        FoV_H_OUT.text = "Along short side: " + orange + fovHeightResult + endColor + "°";
        FoV_D_OUT.text = "Along diagonal:   " + orange + fovDiagonalResult + endColor + "°";
        outputManager.GetTimeDiff();
        OutputTimeText.text = "All operations took " + outputManager.usedTime + " seconds.";
    }

    public void ResetAllValues()
    {

    }

    public void ExpoT_Recipe()
    {
        focalLength = focalLengthInput.text;
        aperture = apertureInput.text;
        pixelPitch = pixelPitchInput.text;
        declination = decInput.text;
        crop = cropInput.text;
    }

    private void FoV_Recipe()
    {
        width = widthInput.text;
        height = heightInput.text;
        focalLengthFov = focalLengthFovInput.text;
    }
}