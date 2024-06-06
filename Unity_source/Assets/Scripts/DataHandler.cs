using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class DataHandler : UnityEngine.MonoBehaviour
{
    [UnityEngine.SerializeField, Header("Code References")]
    public CamDbManager CDM;

    public string camNameToSave;
    public float cropFactorToSave;
    public float pixelPitchToSave;
    public float sensorWidthToSave;
    public float sensorHeightToSave;

    public string activeCamName;
    public string camNameToLoad;
    float cropFactorToLoad;
    float pixelPitchToLoad;
    float sensorWidthToLoad;
    float sensorHeightToLoad;

    public void SaveFile()
    {

        if (CDM.GatherInputs())
        {
            BinaryFormatter bf = new BinaryFormatter();

            System.IO.FileStream file = System.IO.File.Create(UnityEngine.Application.persistentDataPath + "/CamProfiles/" + camNameToSave + ".camDB");
            SavedData data = new SavedData();

            data.savedCamName = camNameToSave;
            data.saveCropFactor = cropFactorToSave;
            data.savedPixelPitch = pixelPitchToSave;
            data.savedSensorWidth = sensorWidthToSave;
            data.savedSensorHeight = sensorHeightToSave;

            bf.Serialize(file, data);
            file.Close();

            UnityEngine.Debug.Log("Data saved!");
        }
    }

    public void LoadFile()
    {
        UnityEngine.Debug.Log("Path chosen for loading is: " + camNameToLoad);

        if (System.IO.File.Exists(camNameToLoad))
        {
            BinaryFormatter bf = new BinaryFormatter();

            System.IO.FileStream file = System.IO.File.Open(camNameToLoad, System.IO.FileMode.Open);
            SavedData data = (SavedData)bf.Deserialize(file);
            file.Close();

            camNameToLoad = data.savedCamName;
            cropFactorToLoad = data.saveCropFactor;
            pixelPitchToLoad = data.savedPixelPitch;
            sensorWidthToLoad = data.savedSensorWidth;
            sensorHeightToLoad = data.savedSensorHeight;

            CDM.SpreadLoadedData(camNameToLoad, cropFactorToLoad, pixelPitchToLoad, sensorWidthToLoad, sensorHeightToLoad);

            UnityEngine.Debug.Log("Saved data loaded!");
        }
        else
        {
            UnityEngine.Debug.LogError("There is no saved data!");
        }
    }

    public void RemoveFile()
    {
        string deletePath = camNameToLoad;
        UnityEngine.Debug.Log("File to be removed is at: " + deletePath);

        if (System.IO.File.Exists(deletePath))
        {
            System.IO.File.Delete(deletePath);
            File.Delete(deletePath);

            UnityEngine.Debug.Log("File removed successfully.");
        }

        else
        {
            UnityEngine.Debug.Log("File could not be removed. Has it been moved or deleted?");
        }
    }
}

[System.Serializable]
class SavedData
{
    public string savedCamName;
    public float saveCropFactor;
    public float savedPixelPitch;
    public float savedSensorWidth;
    public float savedSensorHeight;
}