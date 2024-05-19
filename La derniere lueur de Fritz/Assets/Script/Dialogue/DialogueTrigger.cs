using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private bool inRange = false;
    private bool inDialogue = false;
    [SerializeField] private GameObject logoTouche;

    
    void Update()
    {
        if(inRange == true && inDialogue == false && Input.GetKeyDown(KeyCode.E))
        {
            DialogueManager.instance.StartDialogue(dialogue);
            inDialogue = true;
        }
    }
 
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            logoTouche.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            logoTouche.SetActive(false);
            inRange = false;
        }
    }

    public void IsInDialogue()
    {
        inDialogue = false;
    }
}
