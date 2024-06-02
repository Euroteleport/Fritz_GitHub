using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegatDeLanterne : MonoBehaviour
{
     public int degatsDeBase = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ennemi"))
        {
            BuiaaonVie ennemi = other.GetComponent<BuiaaonVie>();
            Debug.Log("Touché");
        // Si l'ennemi est trouvé, null = non trouvé 
            if (ennemi != null)
            {
                float degatsTotaux = Inventaire.CalculerBonusDegats(degatsDeBase);
                Debug.Log("degat toto =" + degatsTotaux);
                
                ennemi.degatSubi(degatsTotaux);
             
            }
        }
    }

}
