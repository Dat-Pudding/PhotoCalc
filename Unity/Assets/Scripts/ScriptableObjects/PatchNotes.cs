using UnityEngine;

[CreateAssetMenu(fileName = "PatchNotes", menuName = "ScriptableObjects/Libs/Patch Notes", order = 2)]
public class PatchNotes : ScriptableObject
{
    public string[] patchNotes;
}