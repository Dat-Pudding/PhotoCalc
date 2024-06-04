using UnityEngine;

public class ExpoManager : UnityEngine.MonoBehaviour
{
    [UnityEngine.SerializeField, Header("Code References")]
    public Maths MATHS;
    public SideBarManager SBM;

    [UnityEngine.SerializeField, Header("Editor References")]
    public TMPro.TMP_InputField INPUTFIELD_FL_EXPO;
    public TMPro.TMP_InputField INPUTFIELD_AP_EXPO;
    public TMPro.TMP_InputField INPUTFIELD_PP_EXPO;

    public UnityEngine.UI.Slider INPUTSLIDER_DEC_EXPO;
    public TMPro.TMP_InputField DISPFIELD_DEC_EXPO;
    public UnityEngine.UI.Slider INPUTSLIDER_CF_EXPO;
    public TMPro.TMP_InputField DISPFIELD_CF_EXPO;
    public UnityEngine.UI.Slider INPUTSLIDER_PRECISION_EXPO;
    public TMPro.TMP_InputField DISPFIELD_PRECISION_EXPO;

    public TMPro.TMP_Text R500_OUT;
    public TMPro.TMP_Text R300_OUT;
    public TMPro.TMP_Text NPFS_OUT;
    public TMPro.TMP_Text NPF_OUT;

    int expoFocalLength;
    int expoPrecision;
    float expoAperture;
    float expoPixelPitch;
    double expoDeclination;
    float expoCrop;

    private readonly string red = "<color=#FF2200>";
    private readonly string green = "<color=#22FF00>";
    private readonly string orange = "<color=#FFAA00>";
    private readonly string endColor = "</color>";

    private readonly string pLevel_1 = "Pinpoint";
    private readonly string pLevel_2 = "Light Trailing";
    private readonly string pLevel_3 = "Strong Trailing";

    void Update()
    {
        if (SBM.CONTAINER_EXPO.activeSelf)
        {
            ParseInputDisplays();
        }
    }

    void ParseInputDisplays()
    {
        DISPFIELD_DEC_EXPO.text = System.Math.Round(INPUTSLIDER_DEC_EXPO.value, 1).ToString();
        DISPFIELD_CF_EXPO.text = System.Math.Round(INPUTSLIDER_CF_EXPO.value, 1).ToString();

        switch (INPUTSLIDER_PRECISION_EXPO.value)
        {
            case 1:
                DISPFIELD_PRECISION_EXPO.text = pLevel_1;
                return;
            case 2:
                DISPFIELD_PRECISION_EXPO.text = pLevel_2;
                return;
            case 3:
                DISPFIELD_PRECISION_EXPO.text = pLevel_3;
                return;
        }
    }

    public void StartCalculation()
    {
        GatherInputs();
    }

    void GatherInputs()
    {
        int.TryParse(INPUTFIELD_FL_EXPO.text, out expoFocalLength);
        float.TryParse(INPUTFIELD_AP_EXPO.text, out expoAperture);
        float.TryParse(INPUTFIELD_PP_EXPO.text, out expoPixelPitch);
        expoCrop = INPUTSLIDER_CF_EXPO.value;
        expoDeclination = System.Math.Round(INPUTSLIDER_DEC_EXPO.value, 1);
        expoPrecision = UnityEngine.Mathf.RoundToInt(INPUTSLIDER_PRECISION_EXPO.value);

        SendToMaths(expoFocalLength, expoAperture, expoPixelPitch, expoDeclination, expoCrop, expoPrecision);
    }

    void SendToMaths(int fl, float ap, float pp, double dec, float cf, int p)
    {
        double r500 = MATHS.CalcR500(fl, cf);
        double r300 = MATHS.CalcR300(fl, cf);
        double rNPFs = MATHS.CalcNPFs(fl, ap, pp);
        double rNPF = MATHS.CalcNPF(fl, ap, cf, pp, dec, p);

        SendToOutput(r300, r500, rNPFs, rNPF);
    }

    void SendToOutput(double r300, double r500, double npfs, double npf)
    {
        R500_OUT.text = "500-Rule: " + red + r500 + endColor + "s";
        R300_OUT.text = "300-Rule: " + orange + r300 + endColor + "s";
        NPFS_OUT.text = "NPFs-Rule: " + orange + npfs + endColor + "s";
        NPF_OUT.text = "NPF-Rule: " + green + npf + endColor + "s";
    }
}
