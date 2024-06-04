public class FovManager : UnityEngine.MonoBehaviour
{
    [UnityEngine.SerializeField, UnityEngine.Header("Code References")]
    public Maths MATHS;

    [UnityEngine.SerializeField, UnityEngine.Header("Editor References")]
    public TMPro.TMP_InputField INPUTFIELD_WIDTH_FOV;
    public TMPro.TMP_InputField INPUTFIELD_HEIGHT_FOV;
    public TMPro.TMP_InputField INPUTFIELD_FL_FOV;

    public TMPro.TMP_Text WIDTH_OUT;
    public TMPro.TMP_Text HEIGHT_OUT;
    public TMPro.TMP_Text DIAGONAL_OUT;

    int fovFocalLength;
    float fovWidth;
    float fovHeight;

    private readonly string green = "<color=#33FF00>";
    private readonly string endColor = "</color>";

    public void StartCalculation()
    {
        GatherInputs();
    }

    void GatherInputs()
    {
        float.TryParse(INPUTFIELD_WIDTH_FOV.text, out fovWidth);
        float.TryParse(INPUTFIELD_HEIGHT_FOV.text, out fovHeight);
        int.TryParse(INPUTFIELD_FL_FOV.text, out fovFocalLength);

        SendToMaths(fovWidth, fovHeight, fovFocalLength);
    }

    void SendToMaths(double width, double height, int focalLength)
    {
        double resultWidth = MATHS.CalcFovWidth(width, focalLength);
        double resultHeight = MATHS.CalcFovHeight(height, focalLength);
        double resultDiagonal = MATHS.CalcFovDiagonal(width, height, focalLength);

        SendToOutput(resultWidth, resultHeight, resultDiagonal);
    }

    void SendToOutput(double rWidth, double rHeight, double rDiagonal)
    {
        WIDTH_OUT.text = "FoV along long edge: " + green + rWidth + endColor + "°";
        HEIGHT_OUT.text = "FoV along short edge: " + green + rHeight + endColor + "°";
        DIAGONAL_OUT.text = "FoV along diagonal: " + green + rDiagonal + endColor + "°";
    }
}
