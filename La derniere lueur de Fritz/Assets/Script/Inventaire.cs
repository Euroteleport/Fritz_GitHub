using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    public int amePosseder;
    public static Inventaire instance;
    public Text compteAmeText;
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


}
