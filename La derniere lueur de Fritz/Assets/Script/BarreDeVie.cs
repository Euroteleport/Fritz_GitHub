using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHeatlth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
  
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
