using UnityEngine;

[System.Serializable]

public class DialogueLines
{
    public string speaker;
    [TextArea(3, 10)]
    public string text;
}