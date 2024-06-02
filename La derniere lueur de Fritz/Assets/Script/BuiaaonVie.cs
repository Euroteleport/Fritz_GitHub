using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BuiaaonVie : MonoBehaviour
{
    public float pointDeVie = 2;
    public GameObject spawnAme;

    public void degatSubi(float degats)
    { 
      pointDeVie -= (float)degats;
      Debug.Log("Point de vie" + pointDeVie);
      if(pointDeVie <= 0)
      {
        Morts();
      }
    }
    
    public void Morts()
    {
      Instantiate(spawnAme, transform.position, quaternion.identity);
      Destroy(transform.parent.gameObject);
    }

}
