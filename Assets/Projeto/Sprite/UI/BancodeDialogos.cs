using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField] public struct Dialogos
{
    public string name;
    [TextArea(5,10)]
    public string text;
}

[CreateAssetMenu(fileName = "BancodeDialogos", menuName = "ScriptableObject/TalkScript", order = 1)]
public class BancodeDialogos : ScriptableObject
{
    public List<Dialogos> TalkScript;
}
