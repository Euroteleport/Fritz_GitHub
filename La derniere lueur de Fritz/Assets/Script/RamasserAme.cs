using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserAme : MonoBehaviour
{
    
   private void OnTriggerEnter2D(Collider2D collision) 
   {
     if(collision.CompareTag("Player"))
     {
        Inventaire.instance.AjoutAmes(1);
        Destroy(gameObject);
     }   
   }
}
