using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FritzVie1 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BarreDeVie barreDeVie;
    
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

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        barreDeVie.SetHealth(currentHealth);
    }
}
