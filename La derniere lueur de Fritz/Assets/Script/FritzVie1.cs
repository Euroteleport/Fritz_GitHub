using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

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
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
      if(!isInvicible)
      {
        currentHealth -= damage;
        barreDeVie.SetHealth(currentHealth);
        isInvicible = true;
        StartCoroutine(InvicibilityFlash());
        StartCoroutine(DelaisInvincible());
      }
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
