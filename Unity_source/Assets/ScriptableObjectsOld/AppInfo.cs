using UnityEngine;

[CreateAssetMenu(fileName = "AppInfo", menuName = "ScriptableObjects/Libs/AppInfo", order = 2)]

public class AppInfo : ScriptableObject
{
    public string appName = "PhotoCalc";
    public string appVersion = "v0.2.5";
    public bool isPreRelease = true;
    public int releaseState = 1;
    public string[] releaseStateArray;
    public int releaseBranch = 0;
    public string[] releaseBranchArray;
    public string author = "Joshua Ostwald";
}