using UnityEngine;
using UnityEngine.UI;

public class SideBarManager : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // SBMROe - Referenced Objects (assign in Editor)
    //
    public Button ExpoTimeButton;
    public Button FieldOfViewButton;
    public Button flatButton_ON;
    public GameObject flatButton_OFF;
    public Button CamDB_Button;

    public GameObject expoContainer_IN;
    public GameObject fovContainer_IN;
    public GameObject expoContainer_OUT;
    public GameObject fovContainer_OUT;
    public GameObject flatContainer;
    public GameObject camDB_Container;

    public bool isON;

    ///////////////////////////////////////////////////////////////////
    // SBMROc - Referenced Objects (assign in Code)
    //


    ///////////////////////////////////////////////////////////////////
    // SBMdec - Declarations
    //


    ///////////////////////////////////////////////////////////////////
    // SBML - Sidebar Button Manager Logic
    //
    public void ExpoTMenuSwitch()
    {
        expoContainer_IN.SetActive(true);
        expoContainer_OUT.SetActive(true);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        flatContainer.SetActive(false);
        camDB_Container.SetActive(false);
    }

    public void FovMenuSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(true);
        fovContainer_OUT.SetActive(true);
        flatContainer.SetActive(false);
        camDB_Container.SetActive(false);
    }

    public void FlatSwitch()
    {
        if (isON == true)
        {
            expoContainer_IN.SetActive(false);
            expoContainer_OUT.SetActive(false);
            fovContainer_IN.SetActive(false);
            fovContainer_OUT.SetActive(false);
            flatContainer.SetActive(false);
            flatButton_OFF.SetActive(false);
            camDB_Container.SetActive(false);
            isON = false;
        }
        else
        {
            expoContainer_IN.SetActive(false);
            expoContainer_OUT.SetActive(false);
            fovContainer_IN.SetActive(false);
            fovContainer_OUT.SetActive(false);
            flatContainer.SetActive(true);
            flatButton_OFF.SetActive(true);
            camDB_Container.SetActive(false);
            isON = true;
        }

    }

    public void CamDB_MenuSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        flatContainer.SetActive(false);
        camDB_Container.SetActive(true);
    }
}