using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
       public Dialogue dialogue;
       public bool isInRange;

    
    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
        }
    }
 
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    void TriggerDialogue()
    {
        dialogueManager.instance.StartDialogue(dialogue);
    }
}
