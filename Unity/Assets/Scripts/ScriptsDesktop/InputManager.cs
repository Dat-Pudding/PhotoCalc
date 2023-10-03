using UnityEngine;
using UnityEngine.UI;
using System;

public class InputManager : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // IMROe - Referenced Objects (assign in Editor)
    //
    public Maths maths;
    public SideBarManager sideBarManager;

    public TMPro.TMP_InputField focalLengthInput;
    public TMPro.TMP_InputField apertureInput;
    public TMPro.TMP_InputField pixelPitchInput;
    public TMPro.TMP_InputField decInput;
    public TMPro.TMP_InputField cropInput;
    public TMPro.TMP_Dropdown precisionChoice;

    public TMPro.TMP_Text R500_OUT;
    public TMPro.TMP_Text R300_OUT;
    public TMPro.TMP_Text NPFs_OUT;
    public TMPro.TMP_Text NPF_OUT;

    public TMPro.TMP_InputField widthInput;
    public TMPro.TMP_InputField heightInput;
    public TMPro.TMP_InputField focalLengthFovInput;

    public TMPro.TMP_Text FoV_W_OUT;
    public TMPro.TMP_Text FoV_H_OUT;
    public TMPro.TMP_Text FoV_D_OUT;



    public Button calcButton;

    ///////////////////////////////////////////////////////////////////
    // IMROc - Referenced Objects (assign in Code)
    //


    ///////////////////////////////////////////////////////////////////
    // IMdec - Declarations
    //
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
    private void Awake()
    {
        Screen.SetResolution(420, 630, false);
    }


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
        k = precisionChoice.value + 1;
    }

    public void SendToText()
    {
        R500_OUT.text = "500-Rule: " + R500result + "s";
        R300_OUT.text = "300-Rule: " + R300result + "s";
        NPFs_OUT.text = "NPFs-Rule: " + NPFsResult + "s";
        NPF_OUT.text = "NPF-Rule: " + NPFresult  + "s";

        FoV_W_OUT.text = "Along long side:  " + fovWidthResult + "°";
        FoV_H_OUT.text = "Along short side: " + fovHeightResult + "°";
        FoV_D_OUT.text = "Along diagonal:   " + fovDiagonalResult + "°";

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
