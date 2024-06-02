using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    public static float amePosseder;
    public static Inventaire instance;
    public Text compteAmeText;
    public static float bonusPourcentage = 0.15f;
    public float degatsTotaux;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("probleme !");
        }
       
        instance = this;
    }

     public void AjoutAmes(int count)
     {
        amePosseder += count;
        compteAmeText.text = amePosseder.ToString();
     }
    

    public static float CalculerBonusDegats(float degatsDeBase)
    {
        //Je créer mon bonus d'attaque en rapport avec mes ames
        float bonus = amePosseder * bonusPourcentage;
        //Je créer ma variable finale, qui additionne tout 
        float degatsTotaux = degatsDeBase + bonus;
        return degatsTotaux;
    }

}
