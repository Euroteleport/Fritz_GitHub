using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    public static dialogueManager instance;
    public Text dialogueText; 
    private Queue<string> phrases;
    public Animator animator;
    
    public void Awake()
    {
        instance = this;
        phrases = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        phrases.Clear();
        
        foreach (string phrase in dialogue.phrases)
        {
            phrases.Enqueue(phrase);
        }
    
        PhraseSuivante();
    }
   public void PhraseSuivante()
   {
    if(phrases.Count == 0)
    {
        FinDialogue();
        return;
    }
   
       string phrase = phrases.Dequeue();  
       dialogueText.text = phrase; 
   }

     void FinDialogue()
     {
       animator.SetBool("isOpen", false);
     }
}
