using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class attaqueFritz : MonoBehaviour
{
    public GameObject attaque;
    public SpriteRenderer spriteRenderer;
    public float dureeAttaque = 0.1f; 

    private bool isAttack = false; 
    private float tempsDebutAttaque = 1; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isAttack)
        {
            LancerAttaque();
        }

        if (isAttack && Time.time >= tempsDebutAttaque + dureeAttaque)
        {
            FinAttaque();
        }

         float orientation = spriteRenderer.flipX ? -1 : 1;

        
        if (orientation < 0) 
            attaque.transform.localScale = new Vector3(-1, 1, 1); 
        else 
        {
            attaque.transform.localScale = new Vector3(1, 1, 1); 
        }
    }

    void LancerAttaque()
    {
        attaque.SetActive(true);
        isAttack = true;
        tempsDebutAttaque = Time.time;
    }

    void FinAttaque()
    {
        attaque.SetActive(false);
        isAttack = false;
    }
}
