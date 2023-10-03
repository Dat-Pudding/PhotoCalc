using UnityEngine;
using TMPro;

public class VersionTextHandlerMobile : MonoBehaviour
{
    public TMP_Text versionText;
    public AppInfo appInfo;

    void Start()
    {
        versionText.text = appInfo.releaseBranchArray[appInfo.releaseBranch] + appInfo.releaseStateArray[appInfo.releaseState] + appInfo.appVersion;
    }
}