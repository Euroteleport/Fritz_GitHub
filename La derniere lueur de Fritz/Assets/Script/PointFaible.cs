using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointFaible : MonoBehaviour
{
    public GameObject objetDetruire;
     private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
