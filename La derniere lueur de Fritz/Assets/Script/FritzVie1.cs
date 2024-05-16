using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FritzVie1 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isInvicible = false;
    public BarreDeVie barreDeVie;
    public SpriteRenderer visuel;
    public float tempsInvincible = 0.2f;
    
    void Start()
    {
        currentHealth = maxHealth;
        barreDeVie.SetMaxHeatlth(maxHealth);
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(100);
        }
    }

    public void TakeDamage(int damage)
    {
      if(!isInvicible)
      {
        currentHealth -= damage;
        barreDeVie.SetHealth(currentHealth);
       
        if(currentHealth <= 0)
        {
          Mort();
          return;
        }
        
        isInvicible = true;
        StartCoroutine(InvicibilityFlash());
        StartCoroutine(DelaisInvincible());
      }
    }

    public void Mort()
    {
      PlayerMovement.instance.enabled = false;
      //PlayerMovement.instance.animator.SetTrigger("Mort");
      PlayerMovement.instance.rb.bodyType = RigidbodyType2D.Kinematic;
      gameManager.instance.OnPlayerDeath();
    }

    public IEnumerator InvicibilityFlash()
    {
       while(isInvicible)
       {
         visuel.color = new Color(1f, 1f, 0f);
         yield return new WaitForSeconds(tempsInvincible);
         visuel.color = new Color(1f, 1f, 1f);
         yield return new WaitForSeconds(tempsInvincible);
       }
    }

      public IEnumerator DelaisInvincible()
      {
        yield return new WaitForSeconds(2f);
        isInvicible = false;
      }
}
