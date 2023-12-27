using UnityEngine;
using UnityEngine.UI;

public class SideBarManager : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // SBMROe - Referenced Objects (assign in Editor)
    //
    public Button ExpoTimeButton;
    public Button FieldOfViewButton;
    public Button infoButton;
    public Button aboutButton;
    public Button backButton;

    public GameObject expoContainer_IN;
    public GameObject fovContainer_IN;
    public GameObject expoContainer_OUT;
    public GameObject fovContainer_OUT;
    public GameObject infoPageContainer;
    public GameObject aboutPageContainer;
    public GameObject mainPageContainer;
    public GameObject bottomBarContainer;
    public GameObject infoButtonContainer;
    public GameObject aboutButtonContainer;
    public GameObject backButtonContainer;

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
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(true);
        backButtonContainer.SetActive(true);
    }

    public void FovMenuSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(true);
        fovContainer_OUT.SetActive(true);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(true);
        backButtonContainer.SetActive(true);
    }

    public void InfoButtonSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        infoPageContainer.SetActive(true);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(false);
        infoButtonContainer.SetActive(false);
        aboutButtonContainer.SetActive(true);
    }

    public void AboutPageSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(true);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(false);
        aboutButtonContainer.SetActive(false);
        backButtonContainer.SetActive(true);
    }

    public void BackOrMainPageSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(true);
        bottomBarContainer.SetActive(false);
        backButtonContainer.SetActive(false);
        aboutButtonContainer.SetActive(false);
        infoButtonContainer.SetActive(true);
    }
}