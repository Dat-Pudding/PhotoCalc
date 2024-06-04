public class SideBarManager : UnityEngine.MonoBehaviour
{
    [UnityEngine.SerializeField, UnityEngine.Header("Editor References")]
    public UnityEngine.GameObject CONTAINER_MAIN;
    public UnityEngine.GameObject CONTAINER_EXPO;
    public UnityEngine.GameObject CONTAINER_FOV;
    public UnityEngine.GameObject CONTAINER_FLAT;
    public UnityEngine.GameObject CONTAINER_ABOUT;
    public UnityEngine.GameObject CONTAINER_CAMDB;

    private bool FLAT_IS_ON;

    private void Update()
    {
        if (CONTAINER_FLAT.activeSelf)
        {
            FLAT_IS_ON = true;
        }
        if (!CONTAINER_FLAT.activeSelf)
        {
            FLAT_IS_ON = false;
        }
    }
    public void ExpoMenuSwitch()
    {
        CONTAINER_MAIN.SetActive(false);
        CONTAINER_EXPO.SetActive(true);
        CONTAINER_FOV.SetActive(false);
        CONTAINER_FLAT.SetActive(false);
        CONTAINER_ABOUT.SetActive(false);
        CONTAINER_CAMDB.SetActive(false);
    }

    public void FovMenuSwitch()
    {
        CONTAINER_MAIN.SetActive(false);
        CONTAINER_EXPO.SetActive(false);
        CONTAINER_FOV.SetActive(true);
        CONTAINER_FLAT.SetActive(false);
        CONTAINER_ABOUT.SetActive(false);
        CONTAINER_CAMDB.SetActive(false);
    }

    public void FlatSwitch()
    {
        if (FLAT_IS_ON)
        {
            CONTAINER_EXPO.SetActive(false);
            CONTAINER_FOV.SetActive(false);
            CONTAINER_FLAT.SetActive(false);
            CONTAINER_ABOUT.SetActive(false);
            CONTAINER_MAIN.SetActive(true);
            CONTAINER_CAMDB.SetActive(false);

        }
        else
        {
            CONTAINER_MAIN.SetActive(false);
            CONTAINER_EXPO.SetActive(false);
            CONTAINER_FOV.SetActive(false);
            CONTAINER_FLAT.SetActive(true);
            CONTAINER_ABOUT.SetActive(false);
            CONTAINER_CAMDB.SetActive(false);
        }
    }

    public void AboutPage()
    {
        CONTAINER_EXPO.SetActive(false);
        CONTAINER_FOV.SetActive(false);
        CONTAINER_FLAT.SetActive(false);
        CONTAINER_MAIN.SetActive(false);
        CONTAINER_ABOUT.SetActive(true);
        CONTAINER_CAMDB.SetActive(false);
    }

    public void CamDbPage()
    {
        CONTAINER_EXPO.SetActive(false);
        CONTAINER_FOV.SetActive(false);
        CONTAINER_FLAT.SetActive(false);
        CONTAINER_MAIN.SetActive(false);
        CONTAINER_ABOUT.SetActive(false);
        CONTAINER_CAMDB.SetActive(true);
    }

    public void BackOrMainPage()
    {
        CONTAINER_MAIN.SetActive(true);
        CONTAINER_EXPO.SetActive(false);
        CONTAINER_FOV.SetActive(false);
        CONTAINER_FLAT.SetActive(false);
        CONTAINER_ABOUT.SetActive(false);
        CONTAINER_CAMDB.SetActive(false);
    }
}