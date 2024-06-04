using UnityEngine;
using UnityEngine.UI;

public class SideBarManagerMobile : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////
    // SBMROe - Referenced Objects (assign in Editor)
    //
    public Button ExpoTimeButton;
    public Button FieldOfViewButton;
    public Button flatButton_ON;
    public GameObject flatButton_OFF;
    public GameObject calcButton;
    public Button infoButton;
    public GameObject infoButtonContainer;
    public Button aboutButton;
    public GameObject aboutButtonContainer;
    public Button backButton;
    public GameObject backButtonContainer;

    public GameObject expoContainer_IN;
    public GameObject fovContainer_IN;
    public GameObject expoContainer_OUT;
    public GameObject fovContainer_OUT;
    public GameObject flatContainer;
    public GameObject infoPageContainer;
    public GameObject aboutPageContainer;
    public GameObject mainPageContainer;
    public GameObject bottomBarContainer;
    public GameObject calcTimeContainer;

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
        calcButton.SetActive(true);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(true);
        infoButtonContainer.SetActive(true);
        aboutButtonContainer.SetActive(false);
        calcTimeContainer.SetActive(true);
    }

    public void FovMenuSwitch()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(true);
        fovContainer_OUT.SetActive(true);
        flatContainer.SetActive(false);
        calcButton.SetActive(true);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(true);
        infoButtonContainer.SetActive(true);
        aboutButtonContainer.SetActive(false);
        calcTimeContainer.SetActive(true);

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
            calcButton.SetActive(false);
            infoPageContainer.SetActive(false);
            aboutPageContainer.SetActive(false);
            mainPageContainer.SetActive(true);
            bottomBarContainer.SetActive(false);
            infoButtonContainer.SetActive(true);
            aboutButtonContainer.SetActive(false);
            calcTimeContainer.SetActive(false);

            isON = false;
        }
        else
        {
            isON = true;
            expoContainer_IN.SetActive(false);
            expoContainer_OUT.SetActive(false);
            fovContainer_IN.SetActive(false);
            fovContainer_OUT.SetActive(false);
            flatContainer.SetActive(true);
            flatButton_OFF.SetActive(true);
            calcButton.SetActive(false);
            infoPageContainer.SetActive(false);
            aboutPageContainer.SetActive(false);
            mainPageContainer.SetActive(false);
            bottomBarContainer.SetActive(true);
            infoButtonContainer.SetActive(true);
            aboutButtonContainer.SetActive(false);
            calcTimeContainer.SetActive(false);

        }

    }

    public void InfoButton()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        flatContainer.SetActive(false);
        calcButton.SetActive(false);
        infoPageContainer.SetActive(true);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(false);
        infoButtonContainer.SetActive(false);
        aboutButtonContainer.SetActive(true);
        backButtonContainer.SetActive(true);
        calcTimeContainer.SetActive(false);

    }

    public void AboutPage()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        flatContainer.SetActive(false);
        calcButton.SetActive(false);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(true);
        mainPageContainer.SetActive(false);
        bottomBarContainer.SetActive(false);
        infoButtonContainer.SetActive(false);
        aboutButtonContainer.SetActive(false);
        backButtonContainer.SetActive(true);
        calcTimeContainer.SetActive(false);

    }

    public void BackOrMainPage()
    {
        expoContainer_IN.SetActive(false);
        expoContainer_OUT.SetActive(false);
        fovContainer_IN.SetActive(false);
        fovContainer_OUT.SetActive(false);
        flatContainer.SetActive(false);
        calcButton.SetActive(false);
        infoPageContainer.SetActive(false);
        aboutPageContainer.SetActive(false);
        mainPageContainer.SetActive(true);
        bottomBarContainer.SetActive(false);
        infoButtonContainer.SetActive(true);
        aboutButtonContainer.SetActive(false);
        backButtonContainer.SetActive(false);
        calcTimeContainer.SetActive(false);

    }
}