using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI speakerText;
    public GameObject dialogueUI;

    private DialogueTrigger dialogueTrigger;
    private Queue<DialogueLines> lines;
    private bool inDialogue = false;

    public void Awake()
    {
        instance = this;
        lines = new Queue<DialogueLines>();
    }

    private void Start() 
    {
        dialogueTrigger = FindObjectOfType<DialogueTrigger>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Time.timeScale = 0;
        dialogueUI.SetActive(true);
        lines.Clear();

        foreach (DialogueLines line in dialogue.lines)
        {
            lines.Enqueue(line);
        }

        inDialogue = true;
    }

    public void DisplayNextLine()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return;
        }

        DialogueLines line = lines.Dequeue();
        dialogueText.text = line.text;
        speakerText.text = line.speaker;
    }

    void Update()
    {
        if (inDialogue == true && Input.GetKeyDown(KeyCode.E))
        {
            DisplayNextLine();
        }
    }

    void EndDialogue()
    {
        dialogueUI.SetActive(false);
        inDialogue = false;
        dialogueTrigger.IsInDialogue();
        Time.timeScale = 1;
    }
}