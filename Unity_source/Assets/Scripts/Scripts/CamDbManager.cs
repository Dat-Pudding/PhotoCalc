public class CamDbManager : UnityEngine.MonoBehaviour
{
    [UnityEngine.SerializeField, UnityEngine.Header("Code References")]
    public ExpoManager EM;
    public FovManager FM;
    public DataHandler DH;

    [UnityEngine.SerializeField, UnityEngine.Header("Editor References")]
    public TMPro.TMP_InputField camName;
    public TMPro.TMP_InputField cropFactor;
    public TMPro.TMP_InputField pixelPitch;
    public TMPro.TMP_InputField sensorWidth;
    public TMPro.TMP_InputField sensorHeight;
    public TMPro.TMP_Dropdown fileSelector;

    public string[] filePaths;

    private void Start()
    {
        string dirPath = UnityEngine.Application.persistentDataPath + "/CamProfiles/";

        DirectoryCheck(dirPath);
    }

    public void SpreadLoadedData(string name, float cf, float pp, float width, float height)
    {
        if (name != null)
        {
            camName.text = name;
            cropFactor.text = cf.ToString();
            EM.INPUTSLIDER_CF_EXPO.value = cf;
            pixelPitch.text = pp.ToString();
            EM.INPUTFIELD_PP_EXPO.text = pp.ToString();
            sensorWidth.text = width.ToString();
            FM.INPUTFIELD_WIDTH_FOV.text = width.ToString();
            sensorHeight.text = height.ToString();
            FM.INPUTFIELD_HEIGHT_FOV.text = height.ToString();

            UnityEngine.Debug.Log("Data has been spread successfully");
        }

        else
        {
            UnityEngine.Debug.LogError("No loadable data found!");
        }
    }

    public void GatherInputs()
    {
        DH.camNameToSave = camName.text;
        float.TryParse(cropFactor.text, out DH.cropFactorToSave);
        float.TryParse(pixelPitch.text, out DH.pixelPitchToSave);
        float.TryParse(sensorWidth.text, out DH.sensorWidthToSave);
        float.TryParse(sensorHeight.text, out DH.sensorHeightToSave);

        UnityEngine.Debug.Log("Inputs gathered successfully");
    }

    void DirectoryCheck(string dirPath)
    {
        if (!System.IO.Directory.Exists(dirPath))
        {
            System.IO.DirectoryInfo dir = System.IO.Directory.CreateDirectory(UnityEngine.Application.persistentDataPath + "/CamProfiles/");
        }

        if (System.IO.Directory.Exists(dirPath))
        {
            FileCheck(dirPath);
        }

        else
        {
            UnityEngine.Debug.LogError("Something went wrong!");
        }
    }

    void FileCheck(string dirPath)
    {
        filePaths = System.IO.Directory.GetFiles(dirPath, "*camDB");

        for (int i = 0; i < filePaths.Length; ++i)
        {
            string newData  = filePaths[i];
            fileSelector.options.Add(new TMPro.TMP_Dropdown.OptionData(newData));
        }

        fileSelector.RefreshShownValue();
    }
}