using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DeviceLib", menuName = "ScriptableObjects/Libs/DeviceLib", order = 2)]

public class DeviceLib : ScriptableObject
{
    public Dictionary<string, string> smartPhones = new()
    {
        { "Motorola edge 20 lite", "Android" },
        { "Samsung Galaxy S20 5G FE", "Android" },
        { "Samsung Galaxy A4", "Android" },
        { "Generic Phone", "Android" }
    };

    public Dictionary<string, string> tablets = new()
    {

    };

    public Dictionary<string, string> windowsVersions = new()
    {
        {"64-bit, 22H2, Home Edition", "Windows 10"}
    };

    public Dictionary<string, string> linuxVersions = new()
    {

    };

    public Dictionary<string, string> macOSVersions = new()
    {

    };

    public Dictionary<int, string> androidVersions = new()
    {
        { 12, "Android"}
    };

    public Dictionary<string, string> iOSVersions = new()
    {

    };
}