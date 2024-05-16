using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplqcementEnnemi : MonoBehaviour
{
    public Transform[] patrolPoint;
    public float moveSpeed;
    public int patrolDest;
    public SpriteRenderer Visuel;

    
    void Update()
    {
       if(patrolDest == 0)
       {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoint[0].position, moveSpeed * Time.deltaTime);
        if(Vector2.Distance(transform.position, patrolPoint[0].position) < .2f)
        {
            patrolDest = 1;
            Visuel.flipX = !Visuel.flipX;
        }
       
       }
       
       if(patrolDest == 1)
       {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoint[1].position, moveSpeed * Time.deltaTime);
        if(Vector2.Distance(transform.position, patrolPoint[1].position) < .2f)
        {
            patrolDest = 0;
            Visuel.flipX = !Visuel.flipX;
        }
       }
    
    }  
     private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.transform.CompareTag("Player"))
      {
        FritzVie1 fritzVie = collision.transform.GetComponent<FritzVie1>();
        fritzVie.TakeDamage(20);
      }
    }


}
