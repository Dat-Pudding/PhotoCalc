using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PatchNoteHandler : MonoBehaviour
{
    public TMP_Text patchNoteText;
    public PatchNotes patchNotes;

    private readonly string red = "<color=#FF3300>";
    static private readonly string green = "<color=#33FF00>";
    private readonly string orange = "<color=#FFBB00>";
    static private readonly string endColor = "</color>";

    private readonly string addedIcon = "[" + green + "+" + endColor + "]";

    void Start()
    {
        patchNotes.patchNotes.Initialize(); 
    }

    private void Update()
    {
        patchNoteText.text = addedIcon + " " + patchNotes.patchNotes[3] + "\n" + addedIcon + " " + patchNotes.patchNotes[2] + "\n" + addedIcon + " " + patchNotes.patchNotes[1] + "\n" + addedIcon + " " + patchNotes.patchNotes[0];

    }
}
