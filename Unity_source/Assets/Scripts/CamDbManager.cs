using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TMPro;
using Unity.VisualScripting;

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

    string dirPath;
    public string[] filePaths;

    private void Start()
    {
        dirPath = UnityEngine.Application.persistentDataPath + "/CamProfiles/";

        DirectoryCheck(dirPath);
    }

    public void RefreshDropdownList()
    {
        if (!System.IO.Directory.Exists(dirPath))
        {
            System.IO.DirectoryInfo dir = System.IO.Directory.CreateDirectory(UnityEngine.Application.persistentDataPath + "/CamProfiles/");
        }

        if (System.IO.Directory.Exists(dirPath))
        {
            List<string> refreshPaths = System.IO.Directory.GetFiles(dirPath, "*.camDB").ToList();
            fileSelector.ClearOptions();
            fileSelector.AddOptions(refreshPaths);
        }
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

    public bool GatherInputs()
    {
        if (camName.text.Length > 0)
        {
            DH.camNameToSave = camName.text;
            float.TryParse(cropFactor.text, out DH.cropFactorToSave);
            float.TryParse(pixelPitch.text, out DH.pixelPitchToSave);
            float.TryParse(sensorWidth.text, out DH.sensorWidthToSave);
            float.TryParse(sensorHeight.text, out DH.sensorHeightToSave);
            UnityEngine.Debug.Log("Inputs gathered successfully");
            return true;
        }
        else
        {
            UnityEngine.Debug.Log("Couldn't gather camName.txt - is it empty?");
            return false;
        }
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

    public void FileCheck(string dirPath)
    {
        filePaths = System.IO.Directory.GetFiles(dirPath, "*.camDB");

        for (int i = 0; i < filePaths.Length; ++i)
        {
            string newData  = filePaths[i];
            fileSelector.options.Add(new TMPro.TMP_Dropdown.OptionData(newData));
            DH.activeCamName = newData.TrimStart(dirPath);
            fileSelector.options[i].text = DH.activeCamName;
        }
        fileSelector.RefreshShownValue();
    }

    public void RefreshOnChange()
    {
        DH.activeCamName = fileSelector.options[fileSelector.value].text.TrimStart(dirPath);

        DH.camNameToLoad = dirPath + DH.activeCamName;
        fileSelector.captionText.text = DH.activeCamName;
        fileSelector.options[fileSelector.value].text = DH.activeCamName;
    }
}